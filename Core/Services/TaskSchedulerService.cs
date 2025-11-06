using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text.Json;
using Batchup.Core.Models;

namespace Batchup.Core.Services
{
    // Serviço que cria / remove tarefas via schtasks e mantém um arquivo JSON local como registro.
    public interface ITaskSchedulerService
    {
        List<TarefaAgendadaModel> ObterTarefasAgendadas();
        bool CriarTarefaDiaria(string nomeArquivo, string caminhoCompleto, string horario, out string taskName);
        bool RemoverTarefa(string taskName);
    }

    public class TaskSchedulerService : ITaskSchedulerService
    {
        private readonly string _storagePath;

        public TaskSchedulerService()
        {
            var appData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            var dir = Path.Combine(appData, "Batchup");
            if (!Directory.Exists(dir)) Directory.CreateDirectory(dir);
            _storagePath = Path.Combine(dir, "tasks.json");
        }

        public List<TarefaAgendadaModel> ObterTarefasAgendadas()
        {
            try
            {
                if (!File.Exists(_storagePath)) return new List<TarefaAgendadaModel>();
                var json = File.ReadAllText(_storagePath);
                var list = JsonSerializer.Deserialize<List<TarefaAgendadaModel>>(json);
                return list ?? new List<TarefaAgendadaModel>();
            }
            catch
            {
                return new List<TarefaAgendadaModel>();
            }
        }

        public bool CriarTarefaDiaria(string nomeArquivo, string caminhoCompleto, string horario, out string taskName)
        {
            taskName = null;
            try
            {
                // nome único e seguro
                var safe = MakeSafeTaskName(nomeArquivo);
                taskName = $"Batchup_{safe}_{DateTime.Now:yyyyMMddHHmmss}";

                // schtasks espera ST no formato HH:mm
                var st = horario;
                // Monta comando (nota: envolve o caminho entre aspas)
                var args = $"/Create /SC DAILY /TN \"{taskName}\" /TR \"\\\"{caminhoCompleto}\\\"\" /ST {st} /F";
                var ok = RunProcess("schtasks", args, out var stdout, out var stderr);
                if (!ok)
                    return false;

                // grava no storage local
                var tarefas = ObterTarefasAgendadas();
                tarefas.Add(new TarefaAgendadaModel
                {
                    NomeArquivo = nomeArquivo,
                    CaminhoCompleto = caminhoCompleto,
                    Horario = horario,
                    TaskName = taskName
                });
                SaveStorage(tarefas);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool RemoverTarefa(string taskName)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(taskName)) return false;
                var args = $"/Delete /TN \"{taskName}\" /F";
                var ok = RunProcess("schtasks", args, out var stdout, out var stderr);
                // remove do storage local mesmo que schtasks retorne erro (tentar manter coerência)
                var tarefas = ObterTarefasAgendadas();
                var remains = tarefas.Where(t => !string.Equals(t.TaskName, taskName, StringComparison.OrdinalIgnoreCase)).ToList();
                SaveStorage(remains);
                return ok;
            }
            catch
            {
                return false;
            }
        }

        private void SaveStorage(List<TarefaAgendadaModel> list)
        {
            try
            {
                var json = JsonSerializer.Serialize(list, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(_storagePath, json);
            }
            catch
            {
                // ignore
            }
        }

        private static bool RunProcess(string exe, string args, out string stdout, out string stderr)
        {
            stdout = "";
            stderr = "";
            try
            {
                var psi = new ProcessStartInfo
                {
                    FileName = exe,
                    Arguments = args,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };
                using var p = Process.Start(psi);
                if (p == null) return false;
                stdout = p.StandardOutput.ReadToEnd();
                stderr = p.StandardError.ReadToEnd();
                p.WaitForExit(5000);
                return p.ExitCode == 0;
            }
            catch
            {
                return false;
            }
        }

        private static string MakeSafeTaskName(string input)
        {
            foreach (var c in Path.GetInvalidFileNameChars())
                input = input.Replace(c, '_');
            input = input.Replace(' ', '_');
            return input;
        }
    }
}
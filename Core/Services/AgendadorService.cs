using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.Win32.TaskScheduler;


namespace Batchup.Core.Services
{
    public class AgendadorService
    {
        public List<(string Hora, string Arquivo)> SelecionaAgendadorBat()
        {
            var list = new List<(string, string)>();
            using (TaskService ts = new TaskService())
            {
                foreach (var task in ts.AllTasks)
                {
                    if (task.Definition.Actions.FirstOrDefault() is ExecAction action &&
                        action.Path.EndsWith(".bat", StringComparison.OrdinalIgnoreCase))
                    {
                        var time = task.Definition.Triggers.FirstOrDefault() as DailyTrigger;
                        if (time != null)
                            list.Add((time.StartBoundary.ToString("HH:mm"), Path.GetFileName(action.Path)));
                    }
                }
            }
            return list;
        }
        public void SalvarTarefa(string nome, string caminhoArquivo, DateTime hora)
        {
            using (TaskService ts = new TaskService())
            {
                TaskDefinition td = ts.NewTask();
                td.RegistrationInfo.Description = $"Auto Backup {caminhoArquivo}";
                td.Triggers.Add(new DailyTrigger { StartBoundary = hora });
                td.Actions.Add(new ExecAction(caminhoArquivo, null, null));
                ts.RootFolder.RegisterTaskDefinition(nome, td);
            }
        }
    }
}

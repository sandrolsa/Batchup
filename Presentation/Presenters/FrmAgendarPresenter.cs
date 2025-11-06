using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Batchup.Core.Models;
using Batchup.Core.Services;
using Batchup.Presentation.IViews;

namespace Batchup.Presentation.Presenters
{
    public class AgendarPresenter
    {
        private readonly IFrmAgendar _view;
        private readonly IFileService _fileService;
        private readonly ITaskSchedulerService _taskService;
        private List<ArquivoInfoModel> _arquivosTodos = new();
        private List<TarefaAgendadaModel> _tarefas = new();

        public AgendarPresenter(IFrmAgendar view, IFileService fileService = null, ITaskSchedulerService taskService = null)
        {
            _view = view;
            _fileService = fileService ?? new FileService();
            _taskService = taskService ?? new TaskSchedulerService();
        }

        public void Carregar(string diretorio)
        {
            try
            {
                _arquivosTodos = _fileService.ListarBat(diretorio);
                _tarefas = _taskService.ObterTarefasAgendadas();

                AtualizarViews();
            }
            catch (Exception ex)
            {
                _view.ShowMessage($"Erro ao carregar: {ex.Message}");
            }
        }

        private void AtualizarViews()
        {
            // Arquivos disponíveis = todos .bat que não estão na lista de tarefas (comparar por caminho completo)
            var agendadosPaths = _tarefas.Select(t => t.CaminhoCompleto).ToHashSet(StringComparer.OrdinalIgnoreCase);
            var disponiveis = _arquivosTodos.Where(a => !agendadosPaths.Contains(a.CaminhoCompleto)).ToList();

            _view.SetDisponiveis(disponiveis);
            _view.SetAgendados(_tarefas);
            _view.SetAddEnabled(false);
        }

        public void OnSelectionOrTimeChanged(string selectedFilePath, bool hasTime)
        {
            var enabled = !string.IsNullOrWhiteSpace(selectedFilePath) && hasTime;
            _view.SetAddEnabled(enabled);
        }

        public void AdicionarTarefa(string nomeArquivo, string caminhoCompleto, string horario)
        {
            if (string.IsNullOrWhiteSpace(nomeArquivo) || string.IsNullOrWhiteSpace(caminhoCompleto) || string.IsNullOrWhiteSpace(horario))
            {
                _view.ShowMessage("Arquivo e horário são necessários.");
                return;
            }

            if (_taskService.CriarTarefaDiaria(nomeArquivo, caminhoCompleto, horario, out var taskName))
            {
                // recarrega estado
                Carregar(Path.GetDirectoryName(caminhoCompleto) ?? string.Empty);
                _view.ShowMessage($"Agendado {nomeArquivo} às {horario}");
            }
            else
            {
                _view.ShowMessage($"Erro ao agendar {nomeArquivo}.");
            }
        }

        public void RemoverTarefa(string taskName)
        {
            if (string.IsNullOrWhiteSpace(taskName))
            {
                _view.ShowMessage("Nome da tarefa inválido.");
                return;
            }

            if (_taskService.RemoverTarefa(taskName))
            {
                // recarrega
                Carregar(_arquivosTodos.FirstOrDefault()?.CaminhoCompleto != null ? System.IO.Path.GetDirectoryName(_arquivosTodos.First().CaminhoCompleto) : string.Empty);
                _view.ShowMessage("Tarefa removida.");
            }
            else
            {
                _view.ShowMessage("Erro ao remover tarefa.");
            }
        }
    }
}
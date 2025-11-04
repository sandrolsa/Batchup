using System;
using System.IO;
using System.Linq;
using Batchup.Core.Models;
using System.Collections.Generic;
using Batchup.Core.Services;
using Batchup.Presentation.IViews;
using Batchup.Presentation.Views;
using System.Windows.Forms;

namespace Batchup.Presentation.Presenters
{
    public class FrmAgendarPresenter
    {
        private readonly IFrmAgendar _view;
        private readonly BatService _batService;
        private readonly AgendadorService _agendadorService;
        private readonly ConfigAgendadorModel _model;

        public FrmAgendarPresenter(IFrmAgendar view)
        {
            _view = view;
            _batService = new BatService();
            _agendadorService = new AgendadorService();
            _model = new ConfigAgendadorModel();
        }

        public void AddAgenda(string hora, string arquivo)
        {
            int count = _model.ArquivosAgendados.FindAll(a => a.Arquivo == arquivo).Count;
            if (count >= 4)
            {
                _view.ShowMessage($"O arquivo {arquivo} já possui 4 horários agendados!");
                return;
            }
        }

        public void Salvar()
        {
            foreach (var (hora, arquivo) in _model.ArquivosAgendados)
            {
                string path = Path.Combine(_model.CaminhoDiretorio, arquivo);
                _agendadorService.SalvarTarefa($"Backup_{arquivo}_{hora.Replace(":", "")}", path, DateTime.Today.Add(TimeSpan.Parse(hora)));
            }

            _view.ShowMessage("Tarefas salvas com sucesso!");
        }
    }
}

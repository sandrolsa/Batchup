using System;
using System.Linq;
using System.Windows.Forms;
using Batchup.Core.Models;
using Batchup.Core.Services;
using Batchup.Presentation.IViews;
using Batchup.Presentation.Views;
using Batchup.Utils.Helpers;

namespace Batchup.Presentation.Presenters
{
    public class FrmBackupPresenter
    {
        private readonly IFrmBackup _view;
        private readonly IBackupService _backupService;
        private readonly ConfigConexaoModel _configConexao;
        private readonly ConfigBackupModel _configBackup;

        // CORREÇÃO: Adiciona evento para navegação
        public event EventHandler NavigatedBack;
        public event EventHandler CloseToPrincipal;

        public FrmBackupPresenter(IFrmBackup view, IBackupService backupService, ConfigConexaoModel configConexao)
        {
            _view = view;
            _backupService = backupService;
            _configConexao = configConexao;
            _configBackup = new ConfigBackupModel();
            SubscribeToEvents();
        }

        private void SubscribeToEvents()
        {
            _view.VoltarClicked += OnVoltarClicked;
            _view.LocalBackupClicked += OnLocalBackupClicked;
            _view.LocalCopiaClicked += OnLocalCopiaClicked;
            _view.ConcluirClicked += OnConcluirClicked;
            _view.FecharClicked += OnFecharClicked;
        }

        private void OnVoltarClicked(object sender, EventArgs e)
        {
            // CORREÇÃO: Fecha este form e dispara evento para voltar
            _view.Close();
            NavigatedBack?.Invoke(this, EventArgs.Empty);
        }

        private void OnFecharClicked(object sender, EventArgs e)
        {
            // FECHAR: Mata este form e vai direto para o FrmPrincipal
            _view.Close();
            CloseToPrincipal?.Invoke(this, EventArgs.Empty); // DISPARA o evento
        }

        private void OnLocalBackupClicked(object sender, EventArgs e)
        {
            string pasta = FolderBrowserDialogHelper.SelecionarPasta(
                "Selecione a pasta para salvar o backup.",
                @"C:\Database\Backup\On"
            );

            if (!string.IsNullOrEmpty(pasta))
            {
                _view.LocalBackup = pasta;
            }
        }

        private void OnLocalCopiaClicked(object sender, EventArgs e)
        {
            string pasta = FolderBrowserDialogHelper.SelecionarPasta(
                "Selecione a pasta para salvar a cópia.",
                @"Rede"
            );

            if (!string.IsNullOrEmpty(pasta))
            {
                _view.LocalCopia = pasta;
            }
        }

        private async void OnConcluirClicked(object sender, EventArgs e)
        {
            UpdateConfigFromView();

            if (!_configBackup.IsValid())
            {
                _view.ShowMessage("Preencha todos os campos obrigatórios.", "Validação", MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var resultado = await _backupService.CriarBackupAsync(_configConexao, _configBackup);

                _view.ShowMessage(resultado.Message, "Backup",
                    resultado.Success ? MessageBoxIcon.Information : MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                _view.ShowMessage($"Erro inesperado: {ex.Message}", "Erro", MessageBoxIcon.Error);
            }
        }

        private void UpdateConfigFromView()
        {
            _configBackup.Empresa = _view.Empresa;
            _configBackup.Caixa = int.TryParse(_view.Caixa, out int caixa) ? caixa : 0;
            _configBackup.Dias = int.TryParse(_view.Dias, out int dias) ? dias : 0;
            _configBackup.LocalBackup = _view.LocalBackup;
            _configBackup.LocalCopia = _view.LocalCopia;
        }
    }
}
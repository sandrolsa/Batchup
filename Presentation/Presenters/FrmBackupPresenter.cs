using System;
using System.Windows.Forms;
using Batchup.Core.Models;
using Batchup.Core.Services;
using Batchup.Presentation.IViews;
using Batchup.Utils.Helpers;

namespace Batchup.Presentation.Presenters
{
    public class FrmBackupPresenter
    {
        // Referências a interfaces e models
        private readonly IFrmBackup _view;
        private readonly IBackupService _backupService;
        private readonly ConfigConexaoModel _configConexao;
        private readonly ConfigBackupModel _configBackup;

        // Eventos para fechar e voltar
        public event EventHandler NavigatedBack;
        public event EventHandler CloseToPrincipal;

        // Injeção das dependencias
        public FrmBackupPresenter(IFrmBackup view, IBackupService backupService, ConfigConexaoModel configConexao)
        {
            _view = view;
            _backupService = backupService;
            _configConexao = configConexao;
            _configBackup = new ConfigBackupModel();
            SubscribeToEvents();
        }

        // Assinatura de Eventos
        private void SubscribeToEvents()
        {
            _view.VoltarClicked += OnVoltarClicked;
            _view.LocalBackupClicked += OnLocalBackupClicked;
            _view.LocalCopiaClicked += OnLocalCopiaClicked;
            _view.ConcluirClicked += OnConcluirClicked;
            _view.FecharClicked += OnFecharClicked;
        }

        // Handlers
        private void OnVoltarClicked(object sender, EventArgs e)
        {
            // Esconde este form e dispara evento para voltar
            _view.Hide();
            NavigatedBack?.Invoke(this, EventArgs.Empty); // DISPARA o evento
        }

        private void OnFecharClicked(object sender, EventArgs e)
        {
            // Fecha este form e exibe o FrmPrincipal
            _view.Close();
            CloseToPrincipal?.Invoke(this, EventArgs.Empty); // DISPARA o evento
        }

        private void OnLocalBackupClicked(object sender, EventArgs e)
        {
            // Helper para chamada do Dialog
            string pasta = FolderBrowserDialogHelper.SelecionarPasta(
                "Selecione a pasta para salvar o backup.",
                @"C:\Database\Backup\On"
            );
            // Atualiza o dado na View (propriedade da interface IFrmBackup)
            if (!string.IsNullOrEmpty(pasta))
            {
                _view.LocalBackup = pasta;
            }
        }

        private void OnLocalCopiaClicked(object sender, EventArgs e)
        {
            // Helper para chamada do Dialog
            string pasta = FolderBrowserDialogHelper.SelecionarPasta(
                "Selecione a pasta para salvar a cópia.",
                @"Rede"
            );
            // Atualiza o dado na View (propriedade da interface IFrmBackup)
            if (!string.IsNullOrEmpty(pasta))
            {
                _view.LocalCopia = pasta;
            }
        }

        private async void OnConcluirClicked(object sender, EventArgs e)
        {
            // Sincroniza os dados da View para o Model de Configuração
            UpdateConfigFromView();
            // Valida os Dados do Model
            if (!_configBackup.IsValid())
            {
                _view.ShowMessage("Preencha todos os campos obrigatórios.", "Validação", MessageBoxIcon.Warning);
                return;
            }
            // Execução da Lógica de Negócios (assíncrona para não travar a UI)
            try
            {
                // Chama o Service para criar o backup com as configurações dos Models conexao e backup 
                var resultado = await _backupService.CriarBackupAsync(_configConexao, _configBackup);
                // Mensagem
                _view.ShowMessage(resultado.Message, "Backup",
                    resultado.Success ? MessageBoxIcon.Information : MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // Tratamento de erro
                _view.ShowMessage($"Erro inesperado: {ex.Message}", "Erro", MessageBoxIcon.Error);
            }
        }

        // Atualiza o Model com os dados da View, parsea Caixa e Dias para int
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
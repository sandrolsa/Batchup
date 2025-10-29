using System;
using System.IO;
using System.Windows.Forms;
using Batchup.Core.Models;
using Batchup.Core.Services;
using Batchup.Presentation.Views;
using Batchup.Presentation.IViews;
using Batchup.Utils.Helpers;

namespace Batchup.Presentation.Presenters
{
    public class FrmConexaoPresenter
    {
        private readonly IFrmConexao _view;
        private readonly TestarConexaoService _testarConexaoService;
        private readonly ConfigConexaoModel _config;
        private FrmBackup _frmBackup;
        private FrmBackupPresenter _frmBackupPresenter;

        public event EventHandler NavigatedBack;
        public event EventHandler CloseToPrincipal;

        public FrmConexaoPresenter(IFrmConexao view)
        {
            _view = view;
            _testarConexaoService = new TestarConexaoService();
            _config = new ConfigConexaoModel();
            SubscribeToEvents();
        }

        private void SubscribeToEvents()
        {
            _view.VoltarClicked += OnVoltarClicked;
            _view.DiretorioClicked += OnDiretorioClicked;
            _view.CarregarClicked += OnCarregarClicked;
            _view.AvancarClicked += OnAvancarClicked;
            _view.TestarClicked += OnTestarClicked;
            _view.FecharClicked += OnFecharClicked;
        }

        private void OnVoltarClicked(object sender, EventArgs e)
        {
            _view.Close();
            NavigatedBack?.Invoke(this, EventArgs.Empty); // Avisa que voltou
        }

        private void OnFecharClicked(object sender, EventArgs e)
        {
            // FECHAR: Mata TODOS os forms e vai direto para o FrmPrincipal
            // Fecha o FrmBackup se estiver aberto
            if (_frmBackup != null && !_frmBackup.IsDisposed)
            {
                _frmBackup.Close();
                _frmBackup.Dispose();
                _frmBackup = null;
            }

            _view.Close();
            CloseToPrincipal?.Invoke(this, EventArgs.Empty); // DISPARA o evento para mostrar o FrmPrincipal
        }

        private void OnDiretorioClicked(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog())
            {
                ofd.Title = "Selecione o arquivo DbMysql para leitura";
                ofd.InitialDirectory = @"C:\Checkout_On\";
                ofd.Filter = "Arquivos INI (*.ini)|*.ini|Todos os arquivos (*.*)|*.*";
                ofd.CheckFileExists = true;
                ofd.CheckPathExists = true;

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    _view.Diretorio = ofd.FileName;
                }
            }
        }

        private void OnCarregarClicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_view.Diretorio) || !File.Exists(_view.Diretorio))
            {
                _view.ShowMessage("Por favor, selecione um arquivo .ini primeiro",
                    "Aviso", MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var (servidor, porta, banco, usuario, senha) = ArquivoIniUtil.LerIni(_view.Diretorio);
                _view.Servidor = servidor;
                _view.Porta = porta;
                _view.Usuario = usuario;
                _view.Senha = senha;
                _view.Banco = banco;

                _view.ShowMessage("Dados carregados com sucesso!",
                    "Leitura Concluída", MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                _view.ShowMessage($"Erro ao ler o arquivo .ini: {ex.Message}",
                    "Erro", MessageBoxIcon.Error);
            }
        }

        private async void OnTestarClicked(object sender, EventArgs e)
        {
            UpdateConfigFromView();

            if (!_config.IsValid())
            {
                _view.ShowMessage("Por favor, preencha todos os campos obrigatórios.",
                    "Campos Obrigatórios", MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var resultado = await _testarConexaoService.TestConnectionAsync(_config);
                _view.ShowMessage(resultado.Message, "Teste de Conexão",
                    resultado.Success ? MessageBoxIcon.Information : MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                _view.ShowMessage($"Erro inesperado: {ex.Message}",
                    "Erro", MessageBoxIcon.Error);
            }
        }

        private void OnAvancarClicked(object sender, EventArgs e)
        {
            UpdateConfigFromView();

            if (!_config.IsValid())
            {
                _view.ShowMessage("Por favor, preencha todos os campos obrigatórios.", "Campos Obrigatórios", MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (_frmBackup == null || _frmBackup.IsDisposed)
                {
                    _frmBackup = new FrmBackup();
                    var backupService = new BackupService();
                    _frmBackupPresenter = new FrmBackupPresenter(_frmBackup, backupService, _config);

                    // Quando o FrmBackup quiser VOLTAR, mostra este form
                    _frmBackupPresenter.NavigatedBack += (s, args) => _view.Show();

                    // CORREÇÃO CRÍTICA: Quando o FrmBackup quiser FECHAR, vai direto para o principal
                    _frmBackupPresenter.CloseToPrincipal += (s, args) =>
                    {
                        // Fecha este form também e vai direto para o principal
                        _view.Close();
                        CloseToPrincipal?.Invoke(this, EventArgs.Empty); // PROPAGA o evento
                    };
                }

                _view.Hide();
                _frmBackup.Show();
            }
            catch (Exception ex)
            {
                _view.ShowMessage($"Erro ao avançar: {ex.Message}", "Erro", MessageBoxIcon.Error);
            }
        }

        private void UpdateConfigFromView()
        {
            _config.Servidor = _view.Servidor;
            _config.Porta = _view.Porta;
            _config.Usuario = _view.Usuario;
            _config.Senha = _view.Senha;
            _config.Banco = _view.Banco;
        }
    }
}
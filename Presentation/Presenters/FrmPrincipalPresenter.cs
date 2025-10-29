using System;
using System.Windows.Forms;
using Batchup.Core.Services;
using Batchup.Presentation.IViews;
using Batchup.Presentation.Views;

namespace Batchup.Presentation.Presenters
{
    public class FrmPrincipalPresenter
    {
        private readonly IFrmPrincipal _view;
        private FrmConexao _frmConexao;
        private FrmConexaoPresenter _frmConexaoPresenter;

        public FrmPrincipalPresenter(IFrmPrincipal view)
        {
            _view = view;
            SubscribeToEvents();
        }

        private void SubscribeToEvents()
        {
            _view.CriarBackupClicked += OnCriarBackupClicked;
            _view.AgendarBackupClicked += OnAgendarBackupClicked;
            _view.ExcluirBackupClicked += OnExcluirBackupClicked;
            _view.FecharClicked += OnFecharClicked;
        }

        private void OnCriarBackupClicked(object sender, EventArgs e)
        {
            if (_frmConexao == null || _frmConexao.IsDisposed)
            {
                _frmConexao = new FrmConexao();
                _frmConexaoPresenter = new FrmConexaoPresenter(_frmConexao);
                _frmConexaoPresenter.NavigatedBack += (s, args) => _view.ShowView();
                _frmConexaoPresenter.CloseToPrincipal += (s, args) =>
                {
                    _view.ShowView(); // GARANTE que o FrmPrincipal seja exibido
                };
            }

            _view.HideForm();
            _frmConexao.Show();
        }

        private void OnAgendarBackupClicked(object sender, EventArgs e)
        {
            _view.ShowMessage("Atenção!",
                     "Funcionalidade de agendamento em desenvolvimento",
                     MessageBoxIcon.Information);
        }

        private void OnExcluirBackupClicked(object sender, EventArgs e)
        {
            _view.ShowMessage("Atenção!",
                     "Funcionalidade de exclusão em desenvolvimento",
                     MessageBoxIcon.Information);
        }

        private void OnFecharClicked(object sender, EventArgs e)
        {
            Application.Exit(); // Fecha TODA a aplicação
        }
    }
}
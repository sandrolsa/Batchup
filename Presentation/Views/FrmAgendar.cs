using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Batchup.Core.Models;
using Batchup.Presentation.IViews;
using Batchup.Presentation.Presenters;
using static Batchup.Utils.Helpers.AddArqLista;

namespace Batchup.Presentation.Views
{
    public partial class FrmAgendar : Form, IFrmAgendar
    {
        private readonly FrmAgendarPresenter _presenter;

        public FrmAgendar()
        {
            InitializeComponent();
            _presenter = new FrmAgendarPresenter(this);
            _presenter.CarregarArquivos(); // Carrega automaticamente
        }

        public void LimparLista()
        {
            listDisponiveis.Items.Clear();
        }

        public void AddArqLista(List<ArquivoInfoModel> arquivos)
        {
            ListViewHelper.PreencherComArquivosBat(listDisponiveis, arquivos);
        }

        public void ShowMessage(string message)
        {
            MessageBox.Show(message, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Sua lógica original
        }
    }
}
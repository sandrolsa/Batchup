using System;
using System.Windows.Forms;
using System.Collections.Generic;
using Batchup.Presentation.IViews;
using Batchup.Presentation.Presenters;
using Org.BouncyCastle.Asn1.BC;
using System.Threading.Tasks;
using System.IO;

namespace Batchup.Presentation.Views
{
    public partial class FrmAgendar : Form, IFrmAgendar
    {
        private readonly FrmAgendarPresenter _presenter;
        public FrmAgendar()
        {
            InitializeComponent();
            _presenter = new FrmAgendarPresenter(this);
            CarregarArquivos();
        }

        public void CarregarArquivos()
        {
            string diretorio = @"C:\Database\Backup\ON\";

            if (!Directory.Exists(diretorio))
            {
                MessageBox.Show("Diretório não encontrado: " + diretorio);
                return;
            }

            listDisponiveis.Items.Clear();

            // Icones
            ImageList icons = new ImageList();
            icons.Images.Add("bat", Properties.Resources.bat);
            listDisponiveis.SmallImageList = icons;

            var arquivos = Directory.GetFiles(diretorio, "*.bat");

            foreach (var arquivo in arquivos)
            {
                string nomeArquivo = Path.GetFileNameWithoutExtension(arquivo);
                ListViewItem item = new ListViewItem(nomeArquivo, "bat")
                {
                    Tag = arquivo
                };
                listDisponiveis.Items.Add(item);
            }

            MessageBox.Show($"Foram encontrados {arquivos.Length} arquivos .bat");
        }

        public void ExibeAgendados(List<(string Hora, string Arquivo)> tarefas)
        {
            listAgendados.Items.Clear();
            if (tarefas == null) return;
            foreach (var t in tarefas)
                listAgendados.Items.Add($"{t.Hora} - {t.Arquivo}");
        }

        public void ShowMessage(string message) =>
            MessageBox.Show(message, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            //if (listArquivos.SelectedItem == null) return;
            //_presenter.AddAgenda(timePicker.Text, listArquivos.SelectedItem.ToString());
        }

        private void btnSave_Click(object sender, EventArgs e) => _presenter.Salvar();

    }
}

using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Batchup.Core.Models;
using Batchup.Presentation.IViews;
using Batchup.Presentation.Presenters;
using Batchup.Utils.Helpers;

namespace Batchup.Presentation.Views
{
    // Código-behind simplificado do Form (use junto com seu Designer existente)
    public partial class FrmAgendar : Form, IFrmAgendar
    {
        private readonly AgendarPresenter _presenter;
        private string _diretorioPadrao = @"C:\DATABASE\Backup\ON\"; // mantenha ou torne configurável

        public FrmAgendar()
        {
            InitializeComponent();

            // inicializa presenter
            _presenter = new AgendarPresenter(this);

            // eventos
            listDisponiveis.SelectedIndexChanged += ListDisponiveis_SelectedIndexChanged;
            timePicker.ValueChanged += TimePicker_ValueChanged;
            btnAdd.Click += BtnAdd_Click;
            listAgendados.DoubleClick += ListAgendados_DoubleClick;

            // estado inicial
            btnAdd.Enabled = false;

            // carregar
            _presenter.Carregar(_diretorioPadrao);
        }

        // IFrmAgendar impl.
        public void SetDisponiveis(List<ArquivoInfoModel> arquivos)
        {
            if (InvokeRequired) { Invoke(new Action(() => ListViewHelpers.PreencherDisponiveis(listDisponiveis, arquivos))); return; }
            ListViewHelpers.PreencherDisponiveis(listDisponiveis, arquivos);
        }

        public void SetAgendados(List<TarefaAgendadaModel> tarefas)
        {
            if (InvokeRequired) { Invoke(new Action(() => ListViewHelpers.PreencherAgendados(listAgendados, tarefas))); return; }
            ListViewHelpers.PreencherAgendados(listAgendados, tarefas);
        }

        public void SetAddEnabled(bool enabled)
        {
            if (InvokeRequired) { Invoke(new Action(() => btnAdd.Enabled = enabled)); return; }
            btnAdd.Enabled = enabled;
        }

        public void ShowMessage(string message)
        {
            if (InvokeRequired) { Invoke(new Action(() => MessageBox.Show(message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information))); return; }
            MessageBox.Show(message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // eventos da UI delegando ao presenter
        private void ListDisponiveis_SelectedIndexChanged(object sender, EventArgs e)
        {
            var hasSelection = listDisponiveis.SelectedItems.Count > 0;
            var selectedPath = hasSelection ? listDisponiveis.SelectedItems[0].Tag?.ToString() : null;
            _presenter.OnSelectionOrTimeChanged(selectedPath, true); // timePicker sempre tem um valor; presenter checa se válido
            // Use a checagem simples de não-nulo: presenter decide se habilita
            _presenter.OnSelectionOrTimeChanged(selectedPath, timePicker.Value != null);
        }

        private void TimePicker_ValueChanged(object sender, EventArgs e)
        {
            var hasSelection = listDisponiveis.SelectedItems.Count > 0;
            var selectedPath = hasSelection ? listDisponiveis.SelectedItems[0].Tag?.ToString() : null;
            _presenter.OnSelectionOrTimeChanged(selectedPath, true);
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (listDisponiveis.SelectedItems.Count == 0)
            {
                ShowMessage("Selecione um arquivo primeiro.");
                return;
            }

            var item = listDisponiveis.SelectedItems[0];
            var nome = item.Text;
            var path = item.Tag?.ToString();
            var horario = timePicker.Value.ToString("HH:mm");

            _presenter.AdicionarTarefa(nome, path, horario);
        }

        private void ListAgendados_DoubleClick(object sender, EventArgs e)
        {
            if (listAgendados.SelectedItems.Count == 0) return;
            var item = listAgendados.SelectedItems[0];
            var taskName = item.Tag?.ToString();
            var display = item.Text;
            if (string.IsNullOrWhiteSpace(taskName)) { ShowMessage("Não foi possível identificar a tarefa."); return; }
            if (MessageBox.Show($"Remover {display}?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _presenter.RemoverTarefa(taskName);
            }
        }
    }
}
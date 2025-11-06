using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Batchup.Core.Models;

namespace Batchup.Utils.Helpers
{
    public static class ListViewHelpers
    {
        public static void PreencherDisponiveis(ListView lv, List<ArquivoInfoModel> arquivos)
        {
            if (lv == null) return;
            lv.BeginUpdate();
            lv.Items.Clear();
            foreach (var a in arquivos)
            {
                var item = new ListViewItem(a.Nome) { Tag = a.CaminhoCompleto };
                lv.Items.Add(item);
            }
            lv.EndUpdate();
        }

        public static void PreencherAgendados(ListView lv, List<TarefaAgendadaModel> tarefas)
        {
            if (lv == null) return;
            lv.BeginUpdate();
            lv.Items.Clear();
            foreach (var t in tarefas)
            {
                var item = new ListViewItem($"{t.NomeArquivo} ({t.Horario})") { Tag = t.TaskName };
                lv.Items.Add(item);
            }
            lv.EndUpdate();
        }
    }
}
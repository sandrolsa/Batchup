//using System.Collections.Generic;
//using System.Windows.Forms;
//using Batchup.Core.Models;

//namespace Batchup.Utils.Helpers
//{
//    public static class ListViewAgendadosHelper
//    {
//        public static void PreencherListaAgendados(ListView listView, List<TarefaAgendadaModel> tarefas)
//        {
//            listView.BeginUpdate();

//            try
//            {
//                listView.Items.Clear();
//                ConfigurarColunas(listView);

//                foreach (var tarefa in tarefas)
//                {
//                    var item = new ListViewItem(tarefa.NomeArquivo);
//                    item.SubItems.Add(tarefa.Horario);
//                    item.SubItems.Add("Diária"); // Frequência fixa
//                    item.SubItems.Add(tarefa.Status);
//                    item.Tag = tarefa.NomeTarefaAgendador; // Guarda o nome da tarefa para remover

//                    listView.Items.Add(item);
//                }
//            }
//            finally
//            {
//                listView.EndUpdate();
//            }
//        }

//        private static void ConfigurarColunas(ListView listView)
//        {
//            if (listView.Columns.Count == 0)
//            {
//                listView.View = View.Details;
//                listView.Columns.Add("Arquivo", 200);
//                listView.Columns.Add("Horário", 100);
//                listView.Columns.Add("Frequência", 100);
//                listView.Columns.Add("Status", 80);
//            }
//        }

//        public static void LimparListaAgendados(ListView listView)
//        {
//            listView.Items.Clear();
//        }
//    }
//}
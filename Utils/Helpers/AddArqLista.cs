using System.Collections.Generic;
using System.Windows.Forms;
using Batchup.Core.Models;

namespace Batchup.Utils.Helpers
{
    public static class AddArqLista
    {
        public static class ListViewHelper
        {
            public static void ConfigurarListViewArquivosBat(ListView listView)
            {
                if (listView.SmallImageList == null)
                {
                    listView.SmallImageList = new ImageList();
                }

                if (!listView.SmallImageList.Images.ContainsKey("bat"))
                {
                    // Se estiver usando recursos, ajuste o namespace
                    listView.SmallImageList.Images.Add("bat", Properties.Resources.bat);
                    // Ou use um ícone padrão:
                    // listView.SmallImageList.Images.Add("bat", SystemIcons.Application);
                }
            }

            public static void PreencherComArquivosBat(ListView listView, List<ArquivoInfoModel> arquivos)
            {
                listView.BeginUpdate(); // Melhora performance
                listView.Items.Clear();

                ConfigurarListViewArquivosBat(listView);

                foreach (var arquivo in arquivos)
                {
                    var item = new ListViewItem(arquivo.Nome, "bat")
                    {
                        Tag = arquivo.CaminhoCompleto
                    };
                    listView.Items.Add(item);
                }

                listView.EndUpdate(); // Finaliza atualização
            }
        }
    }
}
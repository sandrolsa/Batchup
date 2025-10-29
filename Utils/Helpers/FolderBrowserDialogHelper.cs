using System;
using System.Windows.Forms;

namespace Batchup.Utils.Helpers
{
    public static class FolderBrowserDialogHelper
    {
        public static string SelecionarPasta(string descricao, string pastaInicial = "")
        {
            using (var dialog = new FolderBrowserDialog())
            {
                dialog.Description = descricao;
                dialog.SelectedPath = pastaInicial;
                dialog.ShowNewFolderButton = true;
                dialog.RootFolder = Environment.SpecialFolder.MyComputer;

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    // CORREÇÃO: Garante que termina com \
                    return dialog.SelectedPath.EndsWith("\\") ?
                           dialog.SelectedPath :
                           dialog.SelectedPath + "\\";
                }
            }
            return string.Empty;
        }
    }
}
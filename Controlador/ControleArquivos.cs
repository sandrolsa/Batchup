
using System;
using System.IO;
using System.Windows.Forms;

namespace Batchup.Controlador
{
    internal class ControleArquivos
    {
        public void CopiarArquivos(string destino)
        {
            if (!Directory.Exists(destino))
            {
                Directory.CreateDirectory(destino);
            }

            string pastaResources = Path.Combine(Application.StartupPath, "Resources");

            if (!Directory.Exists(pastaResources))
            {
                MessageBox.Show("Pasta Resources não encontrada!", "Erro",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string[] arquivos = { "mysqldump.exe", "7z.dll", "7z.exe", "7zx.dll" };

            foreach (string arquivo in arquivos)
            {
                string origem = Path.Combine(pastaResources, arquivo);
                string destinoArquivo = Path.Combine(destino, arquivo);

                if (File.Exists(origem))
                {
                    File.Copy(origem, destinoArquivo, true);
                    File.SetAttributes(destinoArquivo, FileAttributes.Hidden);
                }
                else
                {
                    MessageBox.Show($"Arquivo {arquivo} não encontrado na pasta Resources!", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}

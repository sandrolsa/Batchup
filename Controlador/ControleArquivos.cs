
using System;
using System.IO;

namespace Batchup.Controlador
{
    internal class ControleArquivos
    {
        public void CopiarArquivosRecursos(string destino)
        {
            string pastaResources = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources");

            if (!Directory.Exists(pastaResources))
            {
                Directory.CreateDirectory(pastaResources);
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
            }
        }
    }
}

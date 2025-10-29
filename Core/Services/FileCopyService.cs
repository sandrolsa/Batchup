using System;
using System.IO;
using System.Threading.Tasks;

namespace Batchup.Core.Services
{
    public class FileCopyService
    {
        public async Task CopiarArquivosParaDestinoAsync(string destino)
        {
            await Task.Run(() => CopiarArquivos(destino));
        }

        public void CopiarArquivos(string destino)
        {
            if (!Directory.Exists(destino))
            {
                Directory.CreateDirectory(destino);
            }

            string pastaResources = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources");

            if (!Directory.Exists(pastaResources))
            {
                throw new DirectoryNotFoundException("Pasta Resources não encontrada!");
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
                    // Log do arquivo não encontrado
                    System.Diagnostics.Debug.WriteLine($"Arquivo {arquivo} não encontrado na pasta Resources!");
                }
            }
        }
    }
}
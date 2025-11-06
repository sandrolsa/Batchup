using System.Collections.Generic;
using System.IO;
using System.Linq;
using Batchup.Core.Models;

namespace Batchup.Core.Services
{
    public class ListarArquivosService
    {
        public List<ArquivoInfoModel> CarregarArquivosBat(string diretorio)
        {
            var arquivos = new List<ArquivoInfoModel>();

            try
            {
                if (!Directory.Exists(diretorio))
                {
                    // Cria o diretório se não existir
                    Directory.CreateDirectory(diretorio);
                    return arquivos;
                }

                var arquivosEncontrados = Directory.GetFiles(diretorio, "*.bat");

                foreach (var arquivo in arquivosEncontrados)
                {
                    var nomeArquivo = Path.GetFileNameWithoutExtension(arquivo);

                    //arquivos.Add(new ArquivoInfoModel
                    //{
                    //    Nome = nomeArquivo,
                    //    CaminhoCompleto = arquivo,
                    //    Extensao = ".bat",
                    //    JaAgendado = false
                    //});
                }
            }
            catch (System.Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Erro ao carregar arquivos: {ex.Message}");
            }

            return arquivos;
        }
    }
}
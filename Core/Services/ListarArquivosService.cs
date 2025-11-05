using System.Collections.Generic;
using System.IO;
using Batchup.Core.Models;

namespace Batchup.Core.Services
{
    public class ListarArquivosService
    {
        public List<ArquivoInfoModel> CarregarArquivosBat(string diretorio)
        {
            var arquivos = new List<ArquivoInfoModel>();

            if (!Directory.Exists(diretorio))
                return arquivos;

            var arquivosEncontrados = Directory.GetFiles(diretorio, "*.bat");

            foreach (var arquivo in arquivosEncontrados)
            {
                arquivos.Add(new ArquivoInfoModel
                {
                    Nome = Path.GetFileNameWithoutExtension(arquivo),
                    CaminhoCompleto = arquivo,
                    Extensao = ".bat"
                });
            }

            return arquivos;
        }
    }
}
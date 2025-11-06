using System.Collections.Generic;
using System.IO;
using System.Linq;
using Batchup.Core.Models;

namespace Batchup.Core.Services
{
    // Serviço mínimo para listar .bat em um diretório
    public interface IFileService
    {
        List<ArquivoInfoModel> ListarBat(string diretorio);
    }

    public class FileService : IFileService
    {
        public List<ArquivoInfoModel> ListarBat(string diretorio)
        {
            var lista = new List<ArquivoInfoModel>();
            if (string.IsNullOrWhiteSpace(diretorio))
                return lista;
            try
            {
                if (!Directory.Exists(diretorio))
                    Directory.CreateDirectory(diretorio);

                var arquivos = Directory.GetFiles(diretorio, "*.bat");
                lista.AddRange(arquivos.Select(f => new ArquivoInfoModel
                {
                    CaminhoCompleto = f,
                    Nome = Path.GetFileNameWithoutExtension(f),
                    Extensao = ".bat"
                }));
            }
            catch
            {
                // swallow: view/presenter podem mostrar mensagem se necessário
            }
            return lista;
        }
    }
}
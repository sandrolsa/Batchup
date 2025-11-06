using System.Collections.Generic;
using System.IO;
using System.Linq;
using Batchup.Core.Models;

namespace Batchup.Core.Services
{
    public class ArquivoService
    {
        public List<ArquivoInfoModel> CarregarArquivosBat(string diretorio)
        {
            var arquivos = new List<ArquivoInfoModel>();

            if (!Directory.Exists(diretorio))
                return arquivos;

            return Directory.GetFiles(diretorio, "*.bat")
                .Select(arquivo => new ArquivoInfoModel
                {
                    Nome = Path.GetFileNameWithoutExtension(arquivo),
                    CaminhoCompleto = arquivo
                })
                .ToList();
        }

        public List<ArquivoInfoModel> FiltrarNaoAgendados(
            List<ArquivoInfoModel> todosArquivos,
            List<ArquivoInfoModel> arquivosAgendados)
        {
            var nomesAgendados = arquivosAgendados.Select(a => a.Nome).ToHashSet();
            return todosArquivos
                .Where(arquivo => !nomesAgendados.Contains(arquivo.Nome))
                .ToList();
        }
    }
}
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Batchup.Core.Services
{
    public class BatService
    {
        public List<string> SelecionaBat(string diretorio)
        {
            if (!Directory.Exists(diretorio))
                return new List<string>();

            return Directory.GetFiles(diretorio, "*.bat")
                .Select(Path.GetFileName)
                .ToList();
        }
    }
}

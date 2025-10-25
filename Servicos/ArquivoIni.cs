using System.IO;
using Batchup.Config;

namespace Batchup.Servicos
{
    public static class ArquivoIni
    {
        public static (string servidor, string porta, string banco, string usuario, string senha) LerIni(string caminho)
        {
            var linhas = File.ReadAllLines(caminho);
            string servidor = "", porta = "", banco = "", usuario = "", senha = "";

            foreach (var linha in linhas)
            {
                if (linha.StartsWith("S")) servidor = linha.Substring(1);
                if (linha.StartsWith("O")) porta = linha.Substring(1);
                if (linha.StartsWith("B")) banco = linha.Substring(1);
                if (linha.StartsWith("U")) usuario = linha.Substring(1);
                if (linha.StartsWith("P")) senha = linha.Substring(1);
            }
            return (servidor, porta, banco, usuario, senha);
        }
    }
    
}
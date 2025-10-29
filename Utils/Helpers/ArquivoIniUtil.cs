using System;
using System.IO;
using System.Collections.Generic;

namespace Batchup.Utils.Helpers
{
    public static class ArquivoIniUtil
    {
        public static (string servidor, string porta, string banco, string usuario, string senha) LerIni(string caminhoArquivo)
        {
            var valores = new Dictionary<string, string>();

            try
            {
                var linhas = File.ReadAllLines(caminhoArquivo);

                foreach (var linha in linhas)
                {
                    if (string.IsNullOrWhiteSpace(linha) || linha.Length < 2)
                        continue;

                    // A primeira letra é a chave, o resto é o valor
                    string chave = linha[0].ToString().ToUpper();
                    string valor = linha.Substring(1).Trim();

                    valores[chave] = valor;
                }

                // Mapeia as chaves do ini
                valores.TryGetValue("S", out string servidor);
                valores.TryGetValue("O", out string porta);
                valores.TryGetValue("B", out string banco);
                valores.TryGetValue("U", out string usuario);
                valores.TryGetValue("P", out string senha);

                return (
                    servidor ?? "",
                    porta ?? "3306",
                    banco ?? "",
                    usuario ?? "",
                    senha ?? ""
                );
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao ler arquivo INI: {ex.Message}", ex);
            }
        }
    }
}
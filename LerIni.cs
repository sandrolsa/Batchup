using System.Collections.Generic;
using System.IO;
using System.Text;

public class LerIni
{
    public Conexao LerArquivo (string caminhoArquivo)
    {
        var conexao = new conexao();
        var linhas = File.ReadAllLines (caminhoArquivo, Enconding.Default);
        var secao = "";

        foreach (var linha in linhas) 
        {
            var t
        return new Conexao
        {
            Servidor = "",
            Porta = "".
            Usuario = "",
            Banco = "",
            Senha = ""
        };
    }
}
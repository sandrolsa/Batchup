namespace Batchup.Config
{
    public class ConfigConexao
    {
        public string Servidor { get; set; }
        public string Porta { get; set; }
        public string Usuario { get; set; }
        public string Banco { get; set; }
        public string Senha { get; set; }

    public ConfigConexao() { }
        public ConfigConexao(string servidor, string porta, string usuario, string senha, string banco)
        {
            Servidor = servidor;
            Porta = porta;
            Usuario = usuario;
            Senha = senha;
            Banco = banco;
        }
    }
}

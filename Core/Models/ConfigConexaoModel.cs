namespace Batchup.Core.Models
{
    public class ConfigConexaoModel
    {
        public string Servidor { get; set; } = string.Empty;
        public string Porta { get; set; } = "3306";
        public string Usuario { get; set; } = string.Empty;
        public string Senha { get; set; } = string.Empty;
        public string Banco { get; set; } = string.Empty;

        public bool IsValid()
        {
            return !string.IsNullOrWhiteSpace(Servidor) &&
                   !string.IsNullOrWhiteSpace(Porta) &&
                   !string.IsNullOrWhiteSpace(Usuario) &&
                   !string.IsNullOrWhiteSpace(Banco);
        }
    }
}
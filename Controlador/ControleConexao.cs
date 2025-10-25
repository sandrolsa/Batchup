using System.IO;
using Batchup.Config;
using Batchup.Servicos;

namespace Batchup.Controlador
{
    public class ControleConexao
    {
        public ConfigConexao CriarManual (string servidor, int porta, string banco, string usuario, string senha)
        {
            return new ConfigConexao
            {
                Servidor = servidor,
                Porta = porta,
                Banco = banco,
                Usuario = usuario,
                Senha = senha
            };
        }
    }
}

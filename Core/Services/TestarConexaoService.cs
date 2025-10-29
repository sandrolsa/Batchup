using Batchup.Core.Models;
using System;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;

namespace Batchup.Core.Services
{
    public class TestarConexaoService : ITestarConexaoService
    {
        public async Task<ServiceResult> TestConnectionAsync(ConfigConexaoModel config)
        {
            if (config == null)
                return ServiceResult.Fail("Preencha os dados de conexão");

            if (!config.IsValid())
                return ServiceResult.Fail("Dados de conexão inválidos");

            string connectionString = BuildConnectionString(config);

            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    await connection.OpenAsync();

                    if (connection.State == System.Data.ConnectionState.Open)
                    {
                        return ServiceResult.Ok("Conexão bem-sucedida!");
                    }
                    else
                    {
                        return ServiceResult.Fail("Não foi possível abrir a conexão.");
                    }
                }
            }
            catch (MySqlException ex)
            {
                return HandleMySqlException(ex);
            }
            catch (Exception ex)
            {
                return ServiceResult.Fail($"Erro ao testar conexão: {ex.Message}");
            }
        }

        private string BuildConnectionString(ConfigConexaoModel config)
        {
            var builder = new MySqlConnectionStringBuilder
            {
                Server = config.Servidor,
                Port = uint.Parse(config.Porta),
                UserID = config.Usuario,
                Password = config.Senha,
                Database = config.Banco,
                ConnectionTimeout = 5,
                AllowUserVariables = true
            };

            return builder.ToString();
        }

        private ServiceResult HandleMySqlException(MySqlException ex)
        {
            switch (ex.Number)
            {
                case 0:
                    return ServiceResult.Fail("Não foi possível conectar ao servidor. Verifique se o servidor está ativo.");
                case 1042:
                    return ServiceResult.Fail("Não foi possível conectar ao servidor MySQL. Verifique o endereço e porta.");
                case 1045:
                    return ServiceResult.Fail("Acesso negado. Verifique usuário e senha.");
                case 1049:
                    return ServiceResult.Fail(ExtrairNomeBancoDadosErro(ex.Message));
                case 2003:
                    return ServiceResult.Fail("Não foi possível conectar ao servidor. Verifique se o MySQL está rodando.");
                default:
                    return ServiceResult.Fail($"Erro MySQL ({ex.Number}): {ex.Message}");
            }
        }

        private string ExtrairNomeBancoDadosErro(string mensagemErro)
        {
            try
            {
                if (mensagemErro.Contains("Unknown database"))
                {
                    // Divide a string e pega a parte após "Unknown database '"
                    string[] parts = mensagemErro.Split(new string[] { "Unknown database '" }, StringSplitOptions.None);
                    if (parts.Length > 1)
                    {
                        string databaseName = parts[1].Split('\'')[0];
                        return $"Banco de dados '{databaseName}' não encontrado.";
                    }
                }

                // Fallback: retorna a mensagem original se não conseguir extrair
                return $"Banco de dados não encontrado. Erro: {mensagemErro}";
            }
            catch (Exception)
            {
                // Em caso de erro na extração, retorna mensagem genérica
                return "Banco de dados não encontrado.";
            }
        }
    }
}
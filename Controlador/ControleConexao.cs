using System;
using Batchup.Config;
using MySql.Data.MySqlClient;


namespace Batchup.Controlador
{
    public class ControleConexao
    {
        public static string TestarConexao(ConfigConexao config)
        {
            string conexao = 
                $"Server={config.Servidor};Port={config.Porta};Database={config.Banco};" +
                $"User ID={config.Usuario};Password={config.Senha};" +
                $"SslMode=Disabled;AllowPublicKeyRetrieval=True;CharSet=utf8mb4;Pooling=False";

            // TESTE MALDITO
            // MessageBox.Show($"TESTE DE CONEXAO:\nServidor: {config.Servidor}\nSenha: {config.Senha}\nBanco: {config.Banco}\nUsuário: {config.Usuario}", "String de Conexão", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            try
            {
                MySqlConnection.ClearAllPools();
                using (var conn = new MySqlConnection(conexao))
                {
                    conn.Open();
                    if (conn.State == System.Data.ConnectionState.Open)
                    {
                        return "Conexão bem-sucedida!";
                    }
                    else
                    {
                        return "Não foi possível abrir a conexão.";
                    }
                }
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        return "Erro: Não foi possível conectar ao servidor MySql.";
                    case 1042:
                        return $"Erro: Não foi possível conectar ao servidor {config.Servidor}";
                    case 1045:
                        return "Erro: Usuário ou senha incorretos.";
                    case 1049:
                        string mensagem = ex.Message;
                        if (mensagem.Contains("Unknown database"))
                        {
                            try
                            {
                                // Divide a string e pega a parte após "Unknown database '"
                                string[] parts = mensagem.Split(new string[] { "Unknown database '" }, StringSplitOptions.None);
                                if (parts.Length > 1)
                                {
                                    string databaseName = parts[1].Split('\'')[0];
                                    return $"Banco de dados '{databaseName}' não encontrado.";
                                }
                            }
                            catch
                            {
                                // Se der erro na extração, retorna a mensagem padrão
                            }
                        }
                        return $"Erro Mysql ({ex.Number}): {ex.Message}";
                    default:
                        return $"Erro MySql ({ex.Number}): {ex.Message}";
                }
            }
            catch (Exception ex)
            {
                return $"Erro inesperado: {ex.Message}";
            }
        }
    }
}

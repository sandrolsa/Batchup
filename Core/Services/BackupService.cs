using System;
using System.IO;
using System.Threading.Tasks;
using Batchup.Core.Models;
using Batchup.Utils.Helpers;

namespace Batchup.Core.Services
{
    public class BackupService : IBackupService
    {
        private readonly BatchFileGenerator _batchGenerator;
        private readonly FileCopyService _fileCopyService;

        public BackupService()
        {
            _batchGenerator = new BatchFileGenerator();
            _fileCopyService = new FileCopyService();
        }

        // Construtor para injeção de dependência (opcional)
        public BackupService(BatchFileGenerator batchGenerator, FileCopyService fileCopyService)
        {
            _batchGenerator = batchGenerator;
            _fileCopyService = fileCopyService;
        }

        public async Task<ServiceResult> CriarBackupAsync(ConfigConexaoModel configConexao, ConfigBackupModel configBackup)
        {
            try
            {
                // Validações
                if (configConexao == null || !configConexao.IsValid())
                    return ServiceResult.Fail("Configuração de conexão inválida");

                if (configBackup == null || !configBackup.IsValid())
                    return ServiceResult.Fail("Configuração de backup inválida");

                // Cria o diretório se não existir
                if (!Directory.Exists(configBackup.LocalBackup))
                {
                    Directory.CreateDirectory(configBackup.LocalBackup);
                }

                // Cria o diretório BAT
                string pastaBat = Path.Combine(configBackup.LocalBackup, "BAT");
                if (!Directory.Exists(pastaBat))
                {
                    Directory.CreateDirectory(pastaBat);
                }

                // Cria o arquivo .bat usando a classe específica
                string destinoBat = Path.Combine(pastaBat, $"{configBackup.Empresa}.bat");
                _batchGenerator.CriarArquivoBat(configConexao, configBackup, destinoBat);

                // Copia os arquivos 7z e mysqldump
                await _fileCopyService.CopiarArquivosParaDestinoAsync(pastaBat);
                return ServiceResult.Ok($"Backup configurado com sucesso!\nArquivo .bat criado em: {destinoBat}");

            }
            catch (Exception ex)
            {
                return ServiceResult.Fail($"Erro ao criar backup: {ex.Message}");
            }
        }

        public async Task<ServiceResult> CopiarArquivosAsync(string diretorioOrigem, string diretorioDestino)
        {
            try
            {
                if (!Directory.Exists(diretorioOrigem))
                    return ServiceResult.Fail("Diretório de origem não encontrado");

                if (!Directory.Exists(diretorioDestino))
                    Directory.CreateDirectory(diretorioDestino);

                // Aqui você pode implementar a cópia entre diretórios se necessário
                await Task.Run(() => CopiarEntreDiretorios(diretorioOrigem, diretorioDestino));

                return ServiceResult.Ok("Arquivos copiados com sucesso!");
            }
            catch (Exception ex)
            {
                return ServiceResult.Fail($"Erro ao copiar arquivos: {ex.Message}");
            }
        }

        private void CopiarEntreDiretorios(string origem, string destino)
        {
            foreach (var arquivo in Directory.GetFiles(origem, "*.*", SearchOption.AllDirectories))
            {
                string destinoArquivo = arquivo.Replace(origem, destino);
                string diretorioDestino = Path.GetDirectoryName(destinoArquivo);

                if (!Directory.Exists(diretorioDestino))
                    Directory.CreateDirectory(diretorioDestino);

                File.Copy(arquivo, destinoArquivo, true);
            }
        }
    }
}
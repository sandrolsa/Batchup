using System.Threading.Tasks;
using Batchup.Core.Models;

namespace Batchup.Core.Services
{
    public interface IBackupService
    {
        Task<ServiceResult> CriarBackupAsync(ConfigConexaoModel configConexao, ConfigBackupModel configBackup);
        Task<ServiceResult> CopiarArquivosAsync(string diretorioOrigem, string diretorioDestino);
    }
}
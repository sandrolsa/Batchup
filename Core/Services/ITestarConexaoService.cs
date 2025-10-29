using System.Threading.Tasks;
using Batchup.Core.Models;

namespace Batchup.Core.Services
{
    public interface ITestarConexaoService
    {
        Task<ServiceResult> TestConnectionAsync(ConfigConexaoModel config);
    }
}
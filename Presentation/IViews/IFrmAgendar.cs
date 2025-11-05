using System.Collections.Generic;
using Batchup.Core.Models;

namespace Batchup.Presentation.IViews
{
    public interface IFrmAgendar
    {
        void LimparLista();
        void AddArqLista(List<ArquivoInfoModel> arquivos);
        void ShowMessage(string message);
    }
}
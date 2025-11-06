using System.Collections.Generic;
using Batchup.Core.Models;

namespace Batchup.Presentation.IViews
{
    public interface IFrmAgendar
    {
        void SetDisponiveis(List<ArquivoInfoModel> arquivos);
        void SetAgendados(List<TarefaAgendadaModel> tarefas);
        void SetAddEnabled(bool enabled);
        void ShowMessage(string message);
    }
}
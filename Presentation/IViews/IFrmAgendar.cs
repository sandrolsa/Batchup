using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batchup.Presentation.IViews
{
    public interface IFrmAgendar
    {
        //void ExibeBats(List<string> arquivos);
        void ExibeAgendados(List<(string Hora, string Arquivo)> tarefas);
        void ShowMessage(string message);
    }
}

using System;

namespace Batchup.Core.Models
{
    public class ArquivoInfoModel
    {
        public string Nome { get; set; }
        public string CaminhoCompleto { get; set; }
        public string Extensao { get; set; }
    }

    public class TarefaAgendadaModel
    {
        public string NomeArquivo { get; set; }
        public string CaminhoCompleto { get; set; }
        public string Horario { get; set; } // "HH:mm"
        public string TaskName { get; set; } // nome usado no schtasks e no storage
    }
}
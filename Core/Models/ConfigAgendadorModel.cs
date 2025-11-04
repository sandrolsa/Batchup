

using System.Collections.Generic;

namespace Batchup.Core.Models
{
    public class ConfigAgendadorModel
    {
        public string CaminhoDiretorio { get; set; } = string.Empty;
        public List<string> ArquivosDisponiveis { get; set; } = new();
        public List<(string Hora, string Arquivo)> ArquivosAgendados { get; set; } = new();
    }
}

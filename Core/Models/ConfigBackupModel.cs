namespace Batchup.Core.Models
{
    public class ConfigBackupModel
    {
        public string Empresa { get; set; } = string.Empty;
        public int Caixa { get; set; }
        public int Dias {  get; set; }
        public string LocalBackup { get; set; } = string.Empty;
        public string LocalCopia {  get; set; } = string.Empty;

        public bool IsValid()
        {
            return !string.IsNullOrWhiteSpace(Empresa) &&
                Caixa > 0 &&
                Dias > 0 &&
                !string.IsNullOrWhiteSpace(LocalBackup);
        }
    }
}

using Batchup.Core.Models;
using Batchup.Core.Services;
using Batchup.Presentation.IViews;
using System.Collections.Generic;

namespace Batchup.Presentation.Presenters
{
    public class FrmAgendarPresenter
    {
        private readonly IFrmAgendar _view;
        private readonly ListarArquivosService _arquivosService;

        public FrmAgendarPresenter(IFrmAgendar view)
        {
            _view = view;
            _arquivosService = new ListarArquivosService();
        }

        public void CarregarArquivos()
        {
            string diretorio = @"C:\DATABASE\Backup\ON\";
            var arquivos = _arquivosService.CarregarArquivosBat(diretorio);

            if (arquivos.Count == 0)
            {
                _view.ShowMessage("Arquivos ou diretórios não encontrados.");
                return;
            }

            _view.LimparLista();
            _view.AddArqLista(arquivos);
            _view.ShowMessage($"Foram encontrados {arquivos.Count} arquivos .bat");
        }
    }
}
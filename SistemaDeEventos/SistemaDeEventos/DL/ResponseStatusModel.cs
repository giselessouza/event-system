using SistemaDeEventos.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaDeEventos.DL
{
    public class ResponseStatusModel : UpdateStatusModel
    {
        public ResponseStatusModel(StatusEvento modeldb)
        {
            this.idEvento = modeldb.IdEventoStatus;
            this.NomeStatus = modeldb.NomeStatus;
        }
    }
}

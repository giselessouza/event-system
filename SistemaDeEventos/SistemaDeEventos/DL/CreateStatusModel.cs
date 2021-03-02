using SistemaDeEventos.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaDeEventos.DL
{
    public class CreateStatusModel
    {
        public int idEvento { get; set; }
        public string NomeStatus { get; set; }

        public virtual Evento IdEventoNavigation { get; set; }
    }
}

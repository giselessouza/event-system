using SistemaDeEventos.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaDeEventos.DL
{
    public class ResponseEventoModel : UpdateEventoModel
    {
        public ResponseEventoModel(Evento modeldb)
        {
            this.IdEvento = modeldb.IdEvento;
            this.Nome = modeldb.Nome;
            this.Descricao = modeldb.Descricao;
        }
        public int IdEvento { get; set; }

    }
}

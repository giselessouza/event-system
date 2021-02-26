using System;
using System.Collections.Generic;

#nullable disable

namespace SistemaDeEventos.DAL
{
    public partial class StatusEvento
    {
        public StatusEvento()
        {
            Eventos = new HashSet<Evento>();
        }

        public int IdEventoStatus { get; set; }
        public string NomeStatus { get; set; }

        public virtual ICollection<Evento> Eventos { get; set; }
    }
}

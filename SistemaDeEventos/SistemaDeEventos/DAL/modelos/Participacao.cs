using System;
using System.Collections.Generic;

#nullable disable

namespace SistemaDeEventos.DAL
{
    public partial class Participacao
    {
        public int IdParticipacao { get; set; }
        public int IdEvento { get; set; }
        public string LoginParticipante { get; set; }
        public bool FlagPresente { get; set; } = false;
        public int? Nota { get; set; }
        public string Comentario { get; set; }

        public virtual Evento IdEventoNavigation { get; set; }
    }
}

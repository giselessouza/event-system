using SistemaDeEventos.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaDeEventos.DL
{
    public class CreateParticipacaoModel
    {
        public int IdParticipacao { get; set; }
        public int IdEvento { get; set; }
        public string LoginParticipante { get; set; }
        public bool FlagPresente { get; set; }
        public int? Nota { get; set; }
        public string Comentario { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaDeEventos.DL
{
    public class UpdateParticipacaoModel 
    {
        public int IdEvento { get; set; }
        public string LoginParticipante { get; set; }
        public bool FlagPresente { get; set; }
        public int? Nota { get; set; }
        public string Comentario { get; set; }
    }
}

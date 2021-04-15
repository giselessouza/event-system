using SistemaDeEventos.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaDeEventos.DL
{
    public class ResponseUpdateParticipanteModel : UpdateParticipanteModel
    {
        public int? Nota { get; set; }
        public string Comentario { get; set; }

        public ResponseUpdateParticipanteModel(Participacao modeldb)
        {
            this.Nota = modeldb.Nota;
            this.Comentario = modeldb.Comentario;
        }

    }
}

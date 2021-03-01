using SistemaDeEventos.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaDeEventos.DL
{
    public class ResponseParticipacaoModel : UpdateParticipacaoModel
    {

        public ResponseParticipacaoModel(Participacao modeldb)
        {
            // this.IdEvento = modeldb.IdEvento;
            this.idParticipacao = modeldb.IdParticipacao;
            this.IdEvento = modeldb.IdEvento;
            this.LoginParticipante = modeldb.LoginParticipante;
            this.FlagPresente = modeldb.FlagPresente;
            this.Nota = modeldb.Nota;
            this.Comentario = modeldb.Comentario;
        }
        public int idParticipacao { get; set; }

    }
}

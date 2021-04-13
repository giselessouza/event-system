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
            this.IdParticipacao = modeldb.IdParticipacao;
            this.IdEvento = modeldb.IdEvento;
            this.LoginParticipante = modeldb.LoginParticipante;
            this.FlagPresente = modeldb.FlagPresente;
            this.Comentario = modeldb.Comentario;
            this.Nota = modeldb.Nota;
        }

    }
}

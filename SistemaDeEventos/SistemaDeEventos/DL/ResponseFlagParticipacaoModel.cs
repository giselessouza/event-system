using SistemaDeEventos.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaDeEventos.DL
{
    public class ResponseFlagParticipacaoModel : UpdateFlagParticipacaoModel
    {
        public bool FlagPresente { get; set; } = false;

        public ResponseFlagParticipacaoModel(Participacao modeldb)
        {
            this.FlagPresente = modeldb.FlagPresente;
        }
    }
}

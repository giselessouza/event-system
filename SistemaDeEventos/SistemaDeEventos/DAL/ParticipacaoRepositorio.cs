using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaDeEventos.DAL
{
    public class ParticipacaoRepositorio
    {

        public List<Participacao> Listar()
        {
            using (var db = new SistemaDeEventosContext())
            {
                return db.Participacoes.ToList();
            }
        }

        public Participacao CreateParticipante(Participacao model)
        {
            using (var db = new SistemaDeEventosContext())
            {
                db.Participacoes.Add(model);
                db.SaveChanges();
                return model;
            }
        }

        public Participacao EditParticipante(Participacao model)
        {
            return null;
        }

        public Evento GetParticipanteByEvento(Evento model)
        {
            return null;
        }

    }
}

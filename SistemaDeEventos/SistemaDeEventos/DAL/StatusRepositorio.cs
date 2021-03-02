using SistemaDeEventos.DAL;
using System.Collections.Generic;
using System.Linq;

namespace SistemaDeEventos.BLL
{

    public class StatusRepositorio
    {

        public List<StatusEvento> Listar()
        {
            using (var db = new SistemaDeEventosContext())
            {
                return db.StatusEventos.ToList();
            }
        }

        public StatusEvento CreateStatus(StatusEvento model)
        {
            using (var db = new SistemaDeEventosContext())
            {
                db.StatusEventos.Add(model);
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
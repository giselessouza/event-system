using Microsoft.EntityFrameworkCore;
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

        public List<Participacao> GetParticipanteByEvento(int idEvento)
        {
            using (var db = new SistemaDeEventosContext())
            {
                return db.Participacoes.Where(x => x.IdEvento == idEvento).ToList();
            }
        }

        public Participacao create(Participacao model)
        {
            using (var db = new SistemaDeEventosContext())
            {
                db.Participacoes.Add(model);
                db.SaveChanges();
                return model;
            }
        }

        public Participacao update(Participacao model)
        {
            using (var db = new SistemaDeEventosContext())
            {
                db.Entry(model).State = EntityState.Modified;

                db.SaveChanges();

                return model;
            }
        }

        public bool delete(Participacao model)
        {
            using (var db = new SistemaDeEventosContext())
            {
                db.Entry(model).State = EntityState.Deleted;

                db.SaveChanges();

                return true;
            }
        }

        public Participacao findById(int id)
        {
            using (var db = new SistemaDeEventosContext())
            {
                return db.Participacoes.Where(x => x.IdParticipacao == id).FirstOrDefault();
            }
        }

        public int IncricoesEvento(int id)
        {
            using (var db = new SistemaDeEventosContext())
            {
                var incricoes = db.Participacoes.Include(p => p.IdEventoNavigation)
                    .Where(p => p.IdEvento == id)
                    .Count();

                return incricoes;
            }
        }


        public int LimiteVagas(int id)
        {
            using (var db = new SistemaDeEventosContext())
            {
                var limite = db.Eventos.Where(e => e.IdEvento == id).Select(e => e.LimiteVagas).First();

                return limite;
            }
        }

    }
}

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaDeEventos.DAL
{
    public class EventoRepositorio
    {

        public List<Evento> Listar() 
        {
            using (var db = new SistemaDeEventosContext())
            {
                //assim se faz left join
                return db.Eventos.Include(x=>x.IdCategoriaEventoNavigation).Include(x=>x.IdEventoStatusNavigation).ToList();

            }
        }

        public Evento Inserir (Evento model)
        {
            using (var db = new SistemaDeEventosContext())
            {
                db.Eventos.Add(model);
                db.SaveChanges();
                return model;
            }
        }

        public Evento Atualizar (Evento model)
        {
            using (var db = new SistemaDeEventosContext())
            {
                db.Entry(model).State = EntityState.Modified;

                db.SaveChanges();

                return model;
            }
        }

        public Evento Obter(int id)
        {
            using (var db = new SistemaDeEventosContext())
            {
                return db.Eventos.Where(x => x.IdEvento == id).FirstOrDefault();

            }
        }

        public List<Evento> ListByCategoria(int categoria)
        {
            using (var db = new SistemaDeEventosContext())
            {
                db.Eventos.Include(x => x.IdCategoriaEventoNavigation).Include(x => x.IdEventoStatusNavigation).ToList();
                return db.Eventos.Where(x => x.IdCategoriaEvento == categoria).ToList();
            }
        }

        public List<Evento> ListByData(DateTime data)
        {
            using (var db = new SistemaDeEventosContext())
            {
                db.Eventos.Include(x => x.IdCategoriaEventoNavigation).Include(x => x.IdEventoStatusNavigation).ToList();
                return db.Eventos.Where(x => x.DataHoraInicio == data).ToList();
            }
        }
    }
}

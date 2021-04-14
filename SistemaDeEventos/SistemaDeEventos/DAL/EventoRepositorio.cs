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

                return db.Eventos.ToList();
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

        public Evento ListarCateg (int categoria)
        {
            using (var db = new SistemaDeEventosContext())
            {
                return db.Eventos.Where(x => x.IdCategoriaEvento == categoria).FirstOrDefault();
            }
        }

        public Evento ListarData(DateTime data)
        {
            using (var db = new SistemaDeEventosContext())
            {
                return db.Eventos.Where(x => x.DataHoraInicio == data).FirstOrDefault();
            }
        }
    }
}

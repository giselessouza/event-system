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
            return null;
        }

        public Evento Excluir (Evento model)
        {
            return null;
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

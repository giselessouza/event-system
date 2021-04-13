using Microsoft.EntityFrameworkCore;
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

        public StatusEvento Update(StatusEvento model)
        {
            using (var db = new SistemaDeEventosContext())
            {
                db.Entry(model).State = EntityState.Modified;

                db.SaveChanges();

                return model;
            }
        }

        public StatusEvento findById(int id)
        {
            using (var db = new SistemaDeEventosContext())
            {
                return db.StatusEventos.Where(x => x.IdEventoStatus == id).FirstOrDefault();
            }
        }

        public bool Excluir(StatusEvento model)
        {
            using (var db = new SistemaDeEventosContext())
            {
                db.Entry(model).State = EntityState.Deleted;

                db.SaveChanges();

                return true;
            }
        }

    }
}
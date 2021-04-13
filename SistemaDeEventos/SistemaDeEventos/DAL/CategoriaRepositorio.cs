using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaDeEventos.DAL
{
    public class CategoriaRepositorio
    {
        public List<CategoriaEvento> Listar()
        {
            using (var db = new SistemaDeEventosContext())
            {

                return db.CategoriaEventos.ToList();
            }
        }

        public CategoriaEvento create(CategoriaEvento model)
        {
            using (var db = new SistemaDeEventosContext())
            {
                db.CategoriaEventos.Add(model);
                db.SaveChanges();
                return model;
            }
        }

        public CategoriaEvento update(CategoriaEvento model)
        {
            using (var db = new SistemaDeEventosContext())
            {
                db.Entry(model).State = EntityState.Modified;

                db.SaveChanges();

                return model;
            }
        }

        public bool delete(CategoriaEvento model)
        {
            using (var db = new SistemaDeEventosContext())
            {
                db.Entry(model).State = EntityState.Deleted;

                db.SaveChanges();

                return true;
            }
        }

        public CategoriaEvento findById(int id)
        {
            using (var db = new SistemaDeEventosContext())
            {
                return db.CategoriaEventos.Where(x => x.IdCategoriaEvento == id).FirstOrDefault();
            }
        }

    }
}

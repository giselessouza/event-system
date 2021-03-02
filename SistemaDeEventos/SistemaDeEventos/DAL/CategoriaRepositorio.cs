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

    }
}

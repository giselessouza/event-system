using SistemaDeEventos.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaDeEventos.DL
{
    public class CreateCategoriaModel
    {
        public int IdCategoriaEvento { get; set; }
        public string NomeCategoria { get; set; }

        public virtual ICollection<Evento> Eventos { get; set; }
    }
}

using SistemaDeEventos.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaDeEventos.DL
{
    public class CreateCategoriaModel
    {
        public int IdCategoriaEvento { get; set; }

        [Required]
        public string NomeCategoria { get; set; }
        
    }
}

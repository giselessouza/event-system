using SistemaDeEventos.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaDeEventos.DL
{
    public class CreateStatusModel
    {
        public int idEvento { get; set; }

        [Required]
        public string NomeStatus { get; set; }

        
    }
}

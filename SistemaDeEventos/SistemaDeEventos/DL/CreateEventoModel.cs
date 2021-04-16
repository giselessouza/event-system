using SistemaDeEventos.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaDeEventos.DL
{
    public class CreateEventoModel
    {
        public int IdCategoriaEvento { get; set; }
        [Required]
        [StringLength(255)]
        public string Nome { get; set; }
        public DateTime DataHoraInicio { get; set; }
        public DateTime DataHoraFim { get; set; }
        public string Local { get; set; }
        public string Descricao { get; set; }
        public int LimiteVagas { get; set; }

    }
}

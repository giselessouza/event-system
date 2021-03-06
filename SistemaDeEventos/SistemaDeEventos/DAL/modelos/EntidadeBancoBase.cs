using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaDeEventos.DAL
{
	public abstract class EntidadeBancoBase
	{
		[Required]
		[StringLength(255)]
		public string UsuarioCriacao { get; set; }
		[Required]
		public DateTime DataCriacao { get; set; }

		[Required]
		public bool FlagExcluido { get; set; }
	}
}

using System;
using System.Collections.Generic;

#nullable disable

namespace SistemaDeEventos.DAL
{
    public partial class Evento
    {
        public Evento()
        {
            Participacaos = new HashSet<Participacao>();
        } 

        public int IdEvento { get; set; }
        public int IdEventoStatus { get; set; }
        public int IdCategoriaEvento { get; set; }
        public string Nome { get; set; }
        public DateTime DataHoraInicio { get; set; }
        public DateTime DataHoraFim { get; set; }
        public string Local { get; set; }
        public string Descricao { get; set; }
        public int LimiteVagas { get; set; }

        
        public virtual CategoriaEvento IdCategoriaEventoNavigation { get; set; }
        public virtual StatusEvento IdEventoStatusNavigation { get; set; }
        public virtual ICollection<Participacao> Participacaos { get; set; } 
    }
}

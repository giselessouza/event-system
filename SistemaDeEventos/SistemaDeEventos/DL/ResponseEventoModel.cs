using SistemaDeEventos.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaDeEventos.DL
{
    public class ResponseEventoModel 
    {
        public ResponseEventoModel(Evento modeldb)
        {
            this.IdEvento = modeldb.IdEvento;
            this.Nome = modeldb.Nome;
            this.Descricao = modeldb.Descricao;
            this.IdEventoStatus = modeldb.IdEventoStatus;
            this.IdCategoriaEvento = modeldb.IdCategoriaEvento;
            this.DataHoraInicio = modeldb.DataHoraInicio;
            this.DataHoraFim = modeldb.DataHoraFim;
            this.Local = modeldb.Local;
            this.LimiteVagas = modeldb.LimiteVagas;
            if(modeldb.IdCategoriaEventoNavigation != null)
            {
                this.CategoriaEvento = modeldb.IdCategoriaEventoNavigation.NomeCategoria;
            }
            if(modeldb.IdEventoStatusNavigation != null)
            {
                this.EventoStatus = modeldb.IdEventoStatusNavigation.NomeStatus;
            }
        }
        public int IdCategoriaEvento { get; set; }
        public string Nome { get; set; }
        public DateTime DataHoraInicio { get; set; }
        public DateTime DataHoraFim { get; set; }
        public string Local { get; set; }
        public string Descricao { get; set; }
        public int LimiteVagas { get; set; }
        public String EventoStatus { get; set; }
        public int IdEvento { get; set; }
        public String CategoriaEvento { get; set; }
        public int IdEventoStatus { get; set; }

    }
}

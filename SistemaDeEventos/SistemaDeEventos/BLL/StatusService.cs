using SistemaDeEventos.DAL;
using SistemaDeEventos.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaDeEventos.BLL
{
    public class StatusService
    {

        private readonly StatusRepositorio repositorio;

        public StatusService(StatusRepositorio repositorio)
        {
            this.repositorio = repositorio;
        }

        public List<ResponseStatusModel> Listar()
        {
            var NStatus = repositorio.Listar();
            var retorno = new List<ResponseStatusModel>();
            foreach (var NomeStatus in NStatus)
            {
                retorno.Add(new ResponseStatusModel(NomeStatus));
            }
            return retorno;
        }

        public Evento GetStatusEvento(int idEvento)
        {
            return null;
        }

        public ResponseStatusModel Criar(CreateStatusModel model)
        {
            var Status = new StatusEvento();
            Status.IdEventoStatus = model.idEvento;
            Status.NomeStatus = model.NomeStatus;

            return new ResponseStatusModel(Status);
        }

        public ResponseStatusModel Editar(int IdEventoStatus, UpdateStatusModel model)
        {
            return null;
        }
    }
}

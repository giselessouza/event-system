using SistemaDeEventos.BLL;
using SistemaDeEventos.DAL;
using SistemaDeEventos.DL;
using System.Collections.Generic;

namespace SistemaDeEventos.Controllers
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
            Status.NomeStatus = model.NomeStatus;

            repositorio.CreateStatus(Status);
            return new ResponseStatusModel(Status);
        }

        public UpdateStatusModel Editar(int id, UpdateStatusModel model)
        {
            var status = repositorio.findById(id);
            if (status == null)
                return null;
            status.NomeStatus = model.NomeStatus;

            repositorio.Update(status);
            return new ResponseStatusModel(status);
        }

        public bool Excluir(int id)
        {
            var status = repositorio.findById(id);
            if (status == null)
                return false;

            repositorio.Excluir(status);

            return true;
        }

    }
}

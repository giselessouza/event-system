using SistemaDeEventos.DAL;
using SistemaDeEventos.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaDeEventos.BLL
{
    public class ParticipacaoService
    {

        private readonly ParticipacaoRepositorio repositorio;

        public ParticipacaoService(ParticipacaoRepositorio repositorio)
        {
            this.repositorio = repositorio;
        }

        public List<ResponseParticipacaoModel> Listar()
        {
            var participantes = repositorio.Listar();
            var retorno = new List<ResponseParticipacaoModel>();
            foreach (var participante in participantes)
            {
                retorno.Add(new ResponseParticipacaoModel(participante));
            }
            return retorno;
        }

        public Evento GetParticipanteByEvento(int idEvento)
        {
            return null;
        }

        public ResponseParticipacaoModel Criar(CreateParticipacaoModel model)
        {
            var participante = new Participacao();
            participante.IdEvento = model.IdEvento;
            participante.LoginParticipante = model.LoginParticipante;
            participante.FlagPresente = model.FlagPresente;

            repositorio.CreateParticipante(participante);

            return new ResponseParticipacaoModel(participante);
        }

        public UpdateParticipacaoModel Editar(int idParticipante, UpdateParticipacaoModel model)
        {           
            return null;
        }
    }
}

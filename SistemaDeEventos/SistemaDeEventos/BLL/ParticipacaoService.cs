﻿using SistemaDeEventos.DAL;
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

        public List<ResponseParticipacaoModel> GetParticipanteByEvento(int idEvento)
        {
            var participantes = repositorio.GetParticipanteByEvento(idEvento);
            var retorno = new List<ResponseParticipacaoModel>();
            foreach (var item in participantes)
            {
                retorno.Add(new ResponseParticipacaoModel(item));
            }
            return retorno;
        }

        public ResponseParticipacaoModel Criar(CreateParticipacaoModel model)
        {
            var participante = new Participacao();
            participante.IdEvento = model.IdEvento;
            participante.LoginParticipante = model.LoginParticipante;

            repositorio.create(participante);

            return new ResponseParticipacaoModel(participante);
        }

        public UpdateParticipacaoModel Editar(int id, UpdateParticipacaoModel model)
        {
            var participante = repositorio.findById(id);
            if (participante == null)
                return null;
            participante.IdEvento = model.IdEvento;
            participante.LoginParticipante = model.LoginParticipante;
            participante.FlagPresente = model.FlagPresente;
            participante.Nota = model.Nota;
            participante.Comentario = model.Comentario;


            repositorio.update(participante);
            return new ResponseParticipacaoModel(participante);
        }

        public bool Excluir(int id)
        {
            var participacao = repositorio.findById(id);
            if (participacao == null)
                return false;

            repositorio.delete(participacao);

            return true;
        }
    }
}

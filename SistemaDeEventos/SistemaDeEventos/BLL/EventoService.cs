using Microsoft.EntityFrameworkCore;
using SistemaDeEventos.DAL;
using SistemaDeEventos.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaDeEventos.BLL
{
    public class EventoService
    {
        private readonly EventoRepositorio repositorio;

        public EventoService(EventoRepositorio repositorio)
        {
            this.repositorio = repositorio;
        }

        public ResponseEventoModel Criar(CreateEventoModel model)
        {
            var evento = new Evento();
            evento.Nome = model.Nome;
            evento.DataHoraInicio = model.DataHoraInicio;
            evento.DataHoraFim = model.DataHoraFim;
            evento.Local = model.Local;
            evento.Descricao = model.Descricao;
            evento.LimiteVagas = model.LimiteVagas;
            evento.IdCategoriaEvento = model.IdCategoriaEvento;
            //status padrão - aberto para inscrição (1)
            evento.IdEventoStatus = 1;
            repositorio.Inserir(evento);

            return new ResponseEventoModel(evento);
        }

        public List<ResponseEventoModel> Listar()
        {
            var eventos = repositorio.Listar();
            var retorno = new List<ResponseEventoModel>();
            foreach(var evento in eventos)
            {
                retorno.Add(new ResponseEventoModel(evento));
            }
            return retorno;
        }

        public List<ResponseEventoModel> ListByCategoria(int idCategoria)
          {
            var eventos = repositorio.ListByCategoria(idCategoria);

            var retorno = new List<ResponseEventoModel>();

            foreach (var item in eventos)
            {
                retorno.Add(new ResponseEventoModel(item));
            }

            return retorno;
        }
        public List<ResponseEventoModel> ListByData(DateTime data)
        {
            var tarefas = repositorio.ListByData(data);

            var retorno = new List<ResponseEventoModel>();

            foreach (var item in tarefas)
            {
                retorno.Add(new ResponseEventoModel(item));
            }

            return retorno;
        }

        public List<Evento> Obter(int id)
        {
            using (var db = new SistemaDeEventosContext())
            {
                var eventos = db.Eventos
     
                    .Where(e => e.IdEvento == id).ToList();

                return eventos;
            }
        }

        public ResponseEventoModel changeStatus(UpdateEventoModel model)
        {
            var changeStatus = repositorio.Obter(model.IdEvento);
            if (changeStatus == null)
                return null;
            changeStatus.IdEvento = model.IdEvento;
            changeStatus.IdEventoStatus = model.IdEventoStatus;
            repositorio.Atualizar(changeStatus);
            return new ResponseEventoModel(changeStatus);
        }

    }
}

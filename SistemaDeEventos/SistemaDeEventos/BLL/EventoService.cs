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
            evento.IdEventoStatus = model.IdEventoStatus;
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

        public List<Evento> Obter(int id)
        {
            using (var db = new SistemaDeEventosContext())
            {
                var eventos = db.Eventos
     
                    .Where(e => e.IdEvento == id).ToList();

                return eventos;
            }
        }

        /*  public List<ResponseEventoModel> ListarPorCateg()
          {
              var eventos = repositorio.ListarCateg();
              var retorno = new List<ResponseEventoModel>();
              foreach (var evento in eventos)
              {
                  retorno.Add(new ResponseEventoModel(evento));
              }
              return retorno;
          }

          public List<ResponseEventoModel> ListarData()
          {
              var eventos = repositorio.ListarData();
              var retorno = new List<ResponseEventoModel>();
              foreach (var evento in eventos)
              {
                  retorno.Add(new ResponseEventoModel(evento));
              }
              return retorno; 

          } */
    }
}

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
            evento.Descricao = model.Descricao;

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
    }
}

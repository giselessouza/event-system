using SistemaDeEventos.DAL;
using SistemaDeEventos.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaDeEventos.BLL
{
    public class CategoriaService
    {
        private readonly CategoriaRepositorio repositorio;

        public CategoriaService (CategoriaRepositorio repositorio)
        {
            this.repositorio = repositorio;
        }

        public List<ResponseCategoriaModel> Listar()
        {
            var categorias = repositorio.Listar();
            var retorno = new List<ResponseCategoriaModel>();
            foreach (var categoria in categorias)
            {
                retorno.Add(new ResponseCategoriaModel(categoria));
            }
            return retorno;
        }

    }
}

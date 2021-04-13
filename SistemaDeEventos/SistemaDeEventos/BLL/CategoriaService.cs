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

        public ResponseCategoriaModel Criar(CreateCategoriaModel model)
        {
            var categoria = new CategoriaEvento();
            categoria.NomeCategoria = model.NomeCategoria;

            repositorio.create(categoria);

            return new ResponseCategoriaModel(categoria);
        }

        public UpdateCategoriaModel Editar(int id, UpdateCategoriaModel model)
        {
            var categoria = repositorio.findById(id);
            if (categoria == null)
                return null;
            categoria.NomeCategoria = model.NomeCategoria;
            repositorio.update(categoria);
            return new ResponseCategoriaModel(categoria);
        }

        public bool Excluir(int id)
        {
            var categoria = repositorio.findById(id);
            if (categoria == null)
                return false;

            repositorio.delete(categoria);

            return true;
        }

    }
}

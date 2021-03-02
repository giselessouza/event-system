using SistemaDeEventos.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaDeEventos.DL
{
    public class ResponseCategoriaModel : UpdateCategoriaModel
    {
        public ResponseCategoriaModel(CategoriaEvento modeldb)
        {
            this.IdCategoriaEvento = modeldb.IdCategoriaEvento;
            this.NomeCategoria = modeldb.NomeCategoria;
            this.Eventos = modeldb.Eventos;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaDeEventos.BLL
{
    public class Validacao<T>
        where T : class
    {
        public Validacao()
        {

        }

        public Validacao(T valor)
        {
            ValorRetorno = valor;
            Sucesso = true;
        }

        public T ValorRetorno { get; set; }

        public Boolean Sucesso { get; set; } 

        public String MensagemErro { get; set; }

    }
}

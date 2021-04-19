using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaDeEventos.BLL;
using SistemaDeEventos.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaDeEventos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParticipacaoController : Controller
    {
        private readonly ParticipacaoService service;

        public ParticipacaoController(ParticipacaoService service)
        {
            this.service = service;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(service.Listar());
        }

        [HttpGet("/listParticipantByEvento/{idEvento}")]
        public IActionResult ListParticipacaoByEvento(int idEvento)
        {
            return Ok(service.GetParticipanteByEvento(idEvento));
        }

        [HttpPost]
        public ActionResult Create(CreateParticipacaoModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            else
            {
                var validacao = service.Criar(model);
                if (validacao.Sucesso)
                {
                    return Ok(validacao.ValorRetorno);
                }
                else return BadRequest(validacao.MensagemErro);
            }
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] UpdateParticipanteModel value) //atualizar participacao
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            else
            {
                var retorno = service.Editar(id, value);

                if (retorno == null)
                    return NotFound();
                else
                    return Ok(retorno);
            }
        }

      

    }
}

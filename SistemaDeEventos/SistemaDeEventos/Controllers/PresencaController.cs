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
    public class PresencaController : Controller
    {

        private readonly ParticipacaoService service;

        public PresencaController(ParticipacaoService service)
        {
            this.service = service;
        }

        [HttpPut("{idParticipante}")]
        public IActionResult Put(int idParticipante, [FromBody] UpdateFlagParticipacaoModel value) //atualizar presenca
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            else
            {
                var retorno = service.EditarPresenca(idParticipante, value);

                if (retorno == null)
                    return NotFound();
                else
                    return Ok(retorno);
            }
        }
    }
}

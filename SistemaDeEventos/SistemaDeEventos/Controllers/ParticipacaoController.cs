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

        [HttpPost]
        public ActionResult Create(CreateParticipacaoModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            else
                return Ok(service.Criar(model));
        }
        /*
        [HttpPut("{id}")]
        public IActionResult Edit(int id, UpdateParticipacaoModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            else
                return Ok(service.Editar(id, model)); 
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (service.Excluir(id))
                return Ok();
            else
                return NotFound();
        } */
    }
}

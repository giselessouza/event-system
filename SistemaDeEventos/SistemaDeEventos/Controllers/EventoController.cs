using Microsoft.AspNetCore.Mvc;
using SistemaDeEventos.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaDeEventos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class EventoController : Controller
    {
        private readonly EventoService svc;
        public EventoController(EventoService svc)
        {
            this.svc = svc;
        }
        // GET: api/<EventoController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(svc.Listar());
        }

        // GET api/<EventoController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(svc.Obter(id));
        }



        // POST api/<EventoController>
        [HttpPost]
        public IActionResult Post([FromBody] CreateEventoModel value)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            else
                return Ok(svc.Criar(value));
        }



        // PUT api/<EventoController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] UpdateEventoModel value)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            else
            {
                var retorno = svc.Editar(id, value);



                if (retorno == null)
                    return NotFound();
                else
                    return Ok(retorno);
            }



        }



        // DELETE api/<EventoController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (svc.Excluir(id))
                return Ok();
            else
                return NotFound();
        }
    }
}

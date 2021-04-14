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

    public class StatusController : Controller
    {
        private readonly StatusService service;
        public StatusController(StatusService service)
        {
            this.service = service;
        }

        // GET: api/<EventoController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(service.Listar());
        }

       [HttpPost]
        public ActionResult Create(CreateStatusModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            else
                return Ok(service.Criar(model));
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] UpdateStatusModel value)
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

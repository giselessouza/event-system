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

    public class EventoController : Controller
    {
        private readonly EventoService service;
        public EventoController(EventoService service)
        {
            this.service = service;
        }

        // GET: api/<EventoController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(service.Listar());
        }

        // GET: api/<EventosController>
        [HttpGet("/listByCategoria/{idCategoria}")]
        public IActionResult ListarCategoria(int idCategoria)
        {
            return Ok(service.ListByCategoria(idCategoria));
        }

        // GET: api/<EventosController>
        [HttpGet("/listByData/{data}")]
        public IActionResult ListarData(DateTime data)
        {
            return Ok(service.ListByData(data));
        }

        // GET api/<EventoController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(service.Obter(id));
        }
        


        // POST api/<EventoController>
        [HttpPost]
        public IActionResult Post([FromBody] CreateEventoModel value)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            else
                return Ok(service.Criar(value));
        }

        [HttpPut("/changeStatus")]
        public IActionResult Put([FromBody] UpdateEventoModel value)
        {
            {
                var result = service.changeStatus(value);

                if (result is null)
                    return BadRequest();
                else
                {
                    return Ok(result);
                }
            }

        }
      
    }
}

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
            return null;
        }

        [HttpPost]
        public IActionResult Post([FromBody] CreateEventoModel value)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            else
                return null;
        }


    }
}

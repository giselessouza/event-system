using Microsoft.AspNetCore.Mvc;
using SistemaDeEventos.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaDeEventos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriaController : Controller
    {
        private readonly CategoriaService service;
        public CategoriaController(CategoriaService service)
        {
            this.service = service;
        }
        // GET: api/<CategoriaController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(service.Listar());
        }
    }
}

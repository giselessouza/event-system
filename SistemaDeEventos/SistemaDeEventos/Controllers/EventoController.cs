﻿using Microsoft.AspNetCore.Mvc;
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
        public IActionResult Index()
        {
            return View(service.Listar());
        }

   /*     [HttpGet("{IdCategoriaEvento}")]
        public IActionResult Get(int IdCategoriaEvento)
        {
            return Ok(service.ListarPorCateg());
        }

        [HttpGet("{DataHoraInicio}")]
        public IActionResult Get(DateTime DataHoraInicio)
        {
            return Ok(service.ListarData());
        } */

        /*
        // GET api/<EventoController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(service.Obter(id));
        }
        */


        // POST api/<EventoController>
        [HttpPost]
        public IActionResult Post([FromBody] CreateEventoModel value)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            else
                return Ok(service.Criar(value));
        }


    /*
        // PUT api/<EventoController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] UpdateEventoModel value)
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

        // DELETE api/<EventoController>/5
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

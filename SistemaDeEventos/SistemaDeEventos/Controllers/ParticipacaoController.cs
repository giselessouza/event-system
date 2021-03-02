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

        // GET: ParticipacaoController
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(service.Listar());
        }

        /*
        // GET: ParticipacaoController/Details/5
        [HttpPost]
        public ActionResult GetParticipanteByEvento(int idEvento)
        {
            return Ok(service.GetParticipanteByEvento(idEvento));
        } */


        // POST: ParticipacaoController/Create
        [HttpPost]
        public ActionResult Create(CreateParticipacaoModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            else
                return Ok(service.Criar(model));
        }

      
        /*
        // POST: ParticipacaoController/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, UpdateParticipacaoModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            else
                return Ok(service.Editar(id, model)); 
        } */

    


    }
}

﻿using Microsoft.AspNetCore.Mvc;
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
        public IActionResult Index()
        {
            return View();
        }
    }
}
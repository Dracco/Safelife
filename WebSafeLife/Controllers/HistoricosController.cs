﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebSafeLife.Controllers
{
    public class HistoricosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Peso()
        {
            return View();
        }

        public IActionResult PressaoArterial()
        {
            return View();
        }

    }
}
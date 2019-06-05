using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ADOPTAAHORA.Models;

namespace ADOPTAAHORA.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Nosotros()
        {
            return View();
        }

        public IActionResult Mascotas()
        {
          //TODO: Implement Realistic Implementation
          return View();
        }

        public IActionResult PreguntasFrecuentes()
        {
          //TODO: Implement Realistic Implementation
          return View();
        }

    }
}

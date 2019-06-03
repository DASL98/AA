using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TrabajoFinalGD.Models;
using Microsoft.AspNetCore.Mvc;

namespace TrabajoFinalGD.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Principal()
        {
            return View();
        }


        public IActionResult Contacto()
        {
          return View();
        }

        [HttpPost]
        public IActionResult Contacto(string nombre, string apellido, string correo)
        {
            TempData["nombre"]=nombre;
            TempData["apellido"]=apellido;
            TempData["correo"]=correo;
          return RedirectToAction("ConfirmarEnvio");
        }

        public IActionResult ConfirmarEnvio()
        {
          //TODO: Implement Realistic Implementation
          return View();
        }
        
       public IActionResult Donaciones()
       {
         return View();
       }
    }
}

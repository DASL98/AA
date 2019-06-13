using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AA.Models;
using AA.Datos;

namespace AA.Controllers
{
    public class ComunidadController: Controller
    {
        private MascotaContext _context;

        public ComunidadController(MascotaContext context){
          _context = context;
        }


        public IActionResult Solicitud()
        {
          ViewBag.Solicitud = _context.Solicitud.ToList();
          return View();
        }

        [HttpPost]
        public IActionResult Solicitud(Solicitud s)
        {
          if(ModelState.IsValid){
              _context.Add(s);
              _context.SaveChanges();
              return RedirectToAction("ConfirmarSolicitud");
          }

          ViewBag.Solicitud = _context.Solicitud.ToList();
          return View(s);
        }

        public IActionResult ConfirmarSolicitud()
        {
          //TODO: Implement Realistic Implementation
          return View();
        }

        public IActionResult Ayuda()
        {
          //TODO: Implement Realistic Implementation
          return View();
        }
        
    }
}
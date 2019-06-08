using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AA.Models;
using AA.Datos;
using Microsoft.EntityFrameworkCore;

namespace AA.Controllers
{
    public class AdminController: Controller
    {

        //CONTEXTO REPETIDO
        private MascotaContext _context;

        public AdminController(MascotaContext context){
            this._context = context;
        }

        //FORMULARIO INGRESO MASCOTA
        public IActionResult RegistroMascota()
        {
           ViewBag.Tipos = _context.Tipos.ToList();
          return View();
        }

        [HttpPost]
        public IActionResult RegistroMascota(Mascota m)
        {
          if (ModelState.IsValid){
              _context.Add(m);
              _context.SaveChanges();

              return RedirectToAction("ConfirmarRegistro");
          }

          ViewBag.Tipos = _context.Tipos.ToList();

          return View(m);
        }

        public IActionResult ConfirmarRegistro()
        {
          //TODO: Implement Realistic Implementation
          return View();
        }

        public IActionResult IniciarSesion()
        {
          //TODO: Implement Realistic Implementation
          return View();
        }
    }
}
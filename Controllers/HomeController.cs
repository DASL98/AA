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
    public class HomeController : Controller
    {
        private MascotaContext _context; 

        public HomeController(MascotaContext c)
        {
            _context = c;
        }

        public IActionResult MascotasDisponibles(int tipomascota)
        {
            ViewBag.Tipos = _context.Tipos.ToList();

            var mascotas = _context.Mascotas.Include(x => x.Tipo).ToList();
            
            if (tipomascota != 0){
                mascotas = _context.Mascotas.Include(x => x.Tipo).Where(x => x.TipoId == tipomascota).ToList();
            }
            
            return View(mascotas);
        }


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult PreguntasFrecuentes()
        {
        //TODO: Implement Realistic Implementation
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

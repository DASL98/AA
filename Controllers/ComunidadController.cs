using Microsoft.AspNetCore.Mvc;
namespace ADOPTAAHORA.Controllers
{
    public class ComunidadController: Controller
    {
        public IActionResult Solicitud()
        {
          //TODO: Implement Realistic Implementation
          return View();
        }

        //public IActionResult Solicitud(string nombre, string apellido_paterno, string apellido_materno, int dni, int telefono, string correo, int id_mascota)
        //{
          //TODO: Implement Realistic Implementation
          //return RedirectToAction("ConfirmarSolicitud");
        //}

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
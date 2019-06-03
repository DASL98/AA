using Microsoft.AspNetCore.Mvc;
namespace TrabajoFinalGD.Controllers
{
    public class MascotaController: Controller
    {
         public IActionResult RegistroMascota()
      {
        //TODO: Implement Realistic Implementation
        return View();
      }
        [HttpPost]
        public IActionResult RegistroMascota(string nombre, double peso, int edad, string raza, string foto)
        {
            TempData["nombre"]=nombre;
            TempData["peso"]=peso;
            TempData["edad"]=edad;
            TempData["raza"]=raza;
            TempData["foto"]=foto;
          return RedirectToAction("ConfirmarRegistroMascota");
        }

        public IActionResult ConfirmarRegistroMascota()
        {
          //TODO: Implement Realistic Implementation
          return View();
        }

    }
}
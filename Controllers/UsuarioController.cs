using Microsoft.AspNetCore.Mvc;
namespace TrabajoFinalGD.Controllers

{
    public class UsuarioController: Controller
    {
      public IActionResult Registro()
      {
        //TODO: Implement Realistic Implementation
        return View();
      }
        [HttpPost]
        public IActionResult Registro(string nombre, string apellido, string contraseña)
        {
            TempData["nombre"]=nombre;
            TempData["apellido"]=apellido;
            TempData["correo"]=correo;
          return RedirectToAction("ConfirmarRegistro");
        }

        public IActionResult ConfirmarRegistro()
        {
          //TODO: Implement Realistic Implementation
          return View();
        }

    }
}
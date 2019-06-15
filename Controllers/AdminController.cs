using System.Linq;
using Microsoft.AspNetCore.Mvc;
using AA.Models;
using AA.ViewModels;
using AA.Datos;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;

namespace AA.Controllers
{
    public class AdminController: Controller
    {
        private MascotaContext _context;
        private UserManager<IdentityUser> _userManager;
        private SignInManager<IdentityUser> _signInManager;

        public AdminController(
          MascotaContext context, 
          UserManager<IdentityUser> um, 
          SignInManager<IdentityUser> sim){
            this._context = context;
            _userManager = um;
            _signInManager = sim;
        }

        public IActionResult Login()
        {
          //TODO: Implement Realistic Implementation
          return View();
        }

       [HttpPost]
        public IActionResult Login(LoginViewModel vm) {
            if (ModelState.IsValid) {
                var resultado = _signInManager.PasswordSignInAsync(vm.Usuario, vm.Password, false, false);
            
                if (resultado.Result.Succeeded) {
                    return RedirectToAction("index", "home");
                }
                else {
                    ModelState.AddModelError("", "Usuario o contraseña incorrectos");
                }
            }

            return View(vm);
        }


        public IActionResult Registro() {
            return View();
        }

        [HttpPost]
        public IActionResult Registro(RegistroViewModel vm) {
            if (ModelState.IsValid) {
                var user = new IdentityUser();
                user.UserName = vm.Usuario;
                user.Email = vm.Email;

                var resultado = _userManager.CreateAsync(user, vm.Password);

                if (resultado.Result == IdentityResult.Success) {
                    return RedirectToAction("index", "home");
                }
                else {
                    foreach (var error in resultado.Result.Errors) {
                        ModelState.AddModelError("", error.Description);
                    }
                }
            }
            
            return View(vm);
        }

        public IActionResult Logout()
        {
          _signInManager.SignOutAsync();
          return RedirectToAction("index","home");
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

        public IActionResult ChangePassword(ChangePasswordViewModel vm) {
            if (ModelState.IsValid) {
                var user = _userManager.FindByNameAsync(User.Identity.Name).Result;
                var resultado = _userManager.ChangePasswordAsync(user, vm.PasswordActual, vm.PasswordNuevo);

                if (resultado.Result == IdentityResult.Success) {
                    return RedirectToAction("index", "home");
                }
                else {
                    foreach (var error in resultado.Result.Errors) {
                        ModelState.AddModelError("", error.Description);
                    }
                }
               
            }
            
            return View(vm);
        }
        
        public IActionResult ConfirmarRegistro()
        {
          //TODO: Implement Realistic Implementation
          return View();
        }


         public IActionResult Actualizar(int Id)
        {
            var m = _context.Mascotas.FirstOrDefault(x => x.Id == Id);

            if (m == null) {
                return NotFound();
            }

            return View(m);
        }

        [HttpPost]
        public IActionResult Actualizar(Mascota m)
        {
                var mascota = _context.Mascotas.Find(m.Id);

                mascota.NombreMascota = m.NombreMascota;
                mascota.Peso = m.Peso;
                mascota.Foto = m.Foto;
                mascota.Edad = m.Edad;

                _context.SaveChanges();

                return RedirectToAction("Listar");
   

            //return View(m);
        }

        public IActionResult Listar()
        {
            var mascotas = _context.Mascotas.ToList();

            return View(mascotas);
        }


        public IActionResult VerSolicitudes()
        {
          var solicitud = _context.Solicitud.OrderByDescending(x => x.id).ToList();
          ViewBag.solicitud = solicitud;
          return View();
        }
         public IActionResult Borrar(int id)
        {
            var p = _context.Mascotas.FirstOrDefault(x => x.Id == id);

            if (p != null) {
                _context.Mascotas.Remove(p);
                _context.SaveChanges();
            }

            return RedirectToAction("Listar");
        }

        public IActionResult BorrarSolicitud(int id)
        {
            var s = _context.Solicitud.FirstOrDefault(x => x.id == id);

            if (s != null) {
                _context.Solicitud.Remove(s);
                _context.SaveChanges();
            }

            return RedirectToAction("VerSolicitudes");
        }
    }
}
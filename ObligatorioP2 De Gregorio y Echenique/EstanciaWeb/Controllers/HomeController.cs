using EstanciaWeb.Models;
using Microsoft.AspNetCore.Mvc;
using ObligatorioP2_De_Gregorio_y_Echenique;
using System.Diagnostics;

namespace EstanciaWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private Sistema miSistema = Sistema.Instancia;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        //Métodos para login
        public IActionResult Login()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult IniciarSesion(string email, string contrasenia)
        {
            try
            {
                Empleado buscado = miSistema.BuscarEmpleado(email, contrasenia);
                if (buscado != null)
                {
                    HttpContext.Session.SetString("emailUsuario", email);
                    if (buscado is Peon)
                    {

                        HttpContext.Session.SetString("rol", "Peon");
                        return RedirectToAction("ObtenerDatos", "Peon");
                    }
                    else if (buscado is Capataz)
                    {
                        HttpContext.Session.SetString("rol", "Capataz");
                        return RedirectToAction("RegistrarBovino", "Animal");
                    }
                }
                else
                {
                    TempData["Mensaje"] = "Datos incorrectos";
                    ViewBag.Mensaje = "Datos incorrectos";
                }
                return RedirectToAction("Login");
            }
            catch (Exception ex)
            {
                ViewBag.Mensaje = ex.Message;
                return View();
            }

        }

        //Métodos para registrarse
        public IActionResult Registrarse()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Registrarse(string email, string contrasenia, string nombre, bool ResideEnEstancia)
        {
            try
            {
                Peon peonBuscado = miSistema.BuscarPeon(email);
                if (peonBuscado == null)
                {
                    Peon peonNuevo = new Peon(email, contrasenia, nombre, DateTime.Now, ResideEnEstancia);
                    peonNuevo.Validar();
                    miSistema.Empleados.Add(peonNuevo);
                    TempData["Mensaje"] = "Usuario registrado";
                    return RedirectToAction("Login");
                }
                else
                {
                    ViewBag.Mensaje = "Ya existe un usuario registrado con este email";
                    return View();
                }
            }
            catch (Exception ex)
            {
                ViewBag.Mensaje = ex.Message;
                return View();
            }
        }
        //Método para logout
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }

    }
}
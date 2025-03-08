using Microsoft.AspNetCore.Mvc;
using ObligatorioP2_De_Gregorio_y_Echenique;

namespace EstanciaWeb.Controllers
{
    public class AnimalController : Controller
    {
        private Sistema miSistema = Sistema.Instancia;
        public IActionResult Index()
        {
            return View();
        }
        //Métodos para registrar bovino
        public IActionResult RegistrarBovino()
        {
            if (HttpContext.Session.GetString("rol") != null &&
                HttpContext.Session.GetString("rol") == ("Capataz"))
            {
                return View(new Bovino());
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        [HttpPost]
        public IActionResult RegistrarBovino(Bovino nuevoBovino)
        {
            try
            {
                if (HttpContext.Session.GetString("rol") != null &&
                HttpContext.Session.GetString("rol") == ("Capataz"))
                {
                    nuevoBovino.Validar();
                    miSistema.AltaBovino(nuevoBovino);
                    ViewBag.Mensaje = "El bovino se agregó correctamente";
                    return View(nuevoBovino);
                }
                else
                {
                    return RedirectToAction("Index", "Home");
                }

            }
            catch (Exception ex)
            {
                ViewBag.Mensaje = ex.Message;
            }
            return View();
        }
    }
}

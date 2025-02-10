using Microsoft.AspNetCore.Mvc;
using ObligatorioP2_De_Gregorio_y_Echenique;

namespace EstanciaWeb.Controllers
{
    public class PotreroController : Controller
    {

        private Sistema miSistema = Sistema.Instancia;
        public IActionResult Index()
        {
            return View();
        }

        //Métodos para asignar un animal libre a un potrero
        public IActionResult AsignarAnimalPotrero()
        {
            if (HttpContext.Session.GetString("rol") != null &&
                HttpContext.Session.GetString("rol") == ("Capataz"))
            {
                return View();
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }

        }
        [HttpPost]
        public IActionResult AsignarAnimalPotrero(string caravana, int id)
        {
            ViewBag.Potreros = miSistema.Potreros;
            try
            {
                if (HttpContext.Session.GetString("rol") != null &&
                HttpContext.Session.GetString("rol") == ("Capataz"))
                {
                    if (caravana != null && id >= 0)
                    {
                        bool animalEsLibre = true;
                        Animal animalAsignado = miSistema.BuscarAnimal(caravana);
                        Potrero potreroAsignar = miSistema.BuscarPotrero(id);
                        if (animalAsignado != null && potreroAsignar != null)
                        {
                            foreach (Potrero potrero in miSistema.Potreros)
                            {
                                if (potrero.Animales.Contains(animalAsignado))
                                {
                                    animalEsLibre = false;
                                    break;
                                }
                            }
                            if (animalEsLibre)
                            {
                                miSistema.AsignarAnimalPotrero(id, caravana);
                                ViewBag.Mensaje = "El animal se asignó al potrero correctamente";
                            }
                            else
                            {
                                ViewBag.Mensaje = "El animal ya tiene un potrero asignado";
                            }
                        }
                        else if (animalAsignado != null && potreroAsignar == null)
                        {
                            ViewBag.Mensaje = "El potrero no existe";
                        }
                        else if (animalAsignado == null && potreroAsignar != null)
                        {
                            ViewBag.Mensaje = "El animal no existe";
                        }
                    }
                    else
                    {
                        ViewBag.Mensaje = "Los datos no son correctos";
                    }
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

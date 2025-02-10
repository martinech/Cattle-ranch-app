using Microsoft.AspNetCore.Mvc;
using ObligatorioP2_De_Gregorio_y_Echenique;

namespace EstanciaWeb.Controllers
{
    public class RegistroVacunacionController : Controller
    {
        private Sistema miSistema = Sistema.Instancia;
        public IActionResult Index()
        {
            return View();
        }

        //Métodos para dar de alta un registro de vacunación
        public IActionResult RegistrarVacunacion()
        {
            if (HttpContext.Session.GetString("rol") != null &&
                HttpContext.Session.GetString("rol") == ("Peon"))
            {
                ViewBag.Vacunas = miSistema.Vacunas;
                return View(new RegistroVacunacion());
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        [HttpPost]
        public IActionResult RegistrarVacunacion(RegistroVacunacion registro, string animal, string nombre)
        {
            ViewBag.RegistroVacunacion = miSistema.RegistroVacunaciones;
            ViewBag.Vacunas = miSistema.Vacunas;
            try
            {
                if (HttpContext.Session.GetString("rol") != null &&
                HttpContext.Session.GetString("rol") == ("Peon"))
                {
                    if (animal != null)
                    {
                        Animal animalBuscado = miSistema.BuscarAnimal(animal);
                        Vacuna vacBuscada = miSistema.BuscarVacuna(nombre);
                        if (registro.Fecha != DateTime.MinValue)
                        {
                            if (animalBuscado != null)
                            {
                                RegistroVacunacion nuevoRegistro = new RegistroVacunacion(animal, vacBuscada, registro.Fecha);
                                nuevoRegistro.ValidarEdad(animalBuscado.FechaNac);
                                nuevoRegistro.Validar();
                                miSistema.AltaRegistro(nuevoRegistro);
                                ViewBag.Mensaje = "El registro se agregó correctamente";
                                return View(new RegistroVacunacion());

                            }
                            else
                            {
                                ViewBag.Mensaje = "El animal no existe";
                            }
                        }
                        else
                        {
                            ViewBag.Mensaje = "Ingrese una fecha de vacunación";
                        }

                    }
                    else
                    {
                        ViewBag.Mensaje = "Ingrese una caravana";
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
            return View(registro);
        }

    }
}

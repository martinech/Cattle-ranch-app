using Microsoft.AspNetCore.Mvc;
using ObligatorioP2_De_Gregorio_y_Echenique;

namespace EstanciaWeb.Controllers
{
    public class CapatazController : Controller
    {

        private Sistema miSistema = Sistema.Instancia;

        

        //Método para obtener una lista de todos los peones
        public IActionResult ObtenerPeones()
        {
            try
            {
                if (HttpContext.Session.GetString("rol") != null &&
                HttpContext.Session.GetString("rol") == ("Capataz"))
                {
                    List<Empleado> peones = new List<Empleado>();
                    foreach (Empleado empleado in miSistema.Empleados)
                    {
                        if (empleado is Peon)
                        {
                            peones.Add(empleado);
                        }
                    }
                    return View(peones);
                }
                else
                {
                    return RedirectToAction("Index", "Home");
                }
            }
            catch (Exception ex)
            {
                ViewBag.Mensaje = ex.Message;
                return View();
            }
        }
        //Método para obtener el detalle de las tareas de los peones
        public IActionResult ObtenerTareas(string email)
        {
            try
            {
                if (HttpContext.Session.GetString("rol") != null &&
                HttpContext.Session.GetString("rol") == ("Capataz"))
                {
                    List<Tarea> tareasOrdenadas = miSistema.DevolverTareasOrdenadas(email);
                    if (tareasOrdenadas == null || tareasOrdenadas.Count() == 0)
                    {
                        ViewBag.Mensaje = "No existen tareas para este peón";
                    }

                    return View(tareasOrdenadas);
                }
                else
                {
                    return RedirectToAction("Index", "Home");
                }

            }
            catch (Exception ex)
            {
                return View();
            }

        }

        //Métodos para asginar tareas a un peon
        public IActionResult AsignarTareaPeon()
        {
            if (HttpContext.Session.GetString("rol") != null &&
                HttpContext.Session.GetString("rol") == ("Capataz"))
            {
                ViewBag.Empleados = miSistema.Empleados;
                return View(new Tarea());
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }

        }

        [HttpPost]
        public IActionResult AsignarTareaPeon(Tarea tarea, string email)
        {
            ViewBag.Empleados = miSistema.Empleados;
            try
            {
                if (HttpContext.Session.GetString("rol") != null &&
                HttpContext.Session.GetString("rol") == ("Capataz"))
                {
                    if (tarea != null && email != null)
                    {
                        Peon peonBuscado = miSistema.BuscarPeon(email);
                        if (peonBuscado != null)
                        {
                            tarea.Validar();
                            miSistema.AltaTarea(email, tarea);
                            TempData["Mensaje"] = "La tarea se asignó correctamente";
                            return RedirectToAction("ObtenerPeones");

                        }
                        else
                        {
                            ViewBag.Mensaje = "Los datos del peon no son correctos";
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

        //Método para obtener potreros
        public IActionResult ObtenerPotreros()
        {
            try
            {
                if (HttpContext.Session.GetString("rol") != null &&
                HttpContext.Session.GetString("rol") == ("Capataz"))
                {
                    List<Potrero> potrerosOrdenados = miSistema.DevolverPotrerosOrdenados();
                    foreach (Potrero potrero in potrerosOrdenados)
                    {
                        potrero.ObtenerPrecioVentaPotrero();
                    }
                    if (potrerosOrdenados == null || potrerosOrdenados.Count() == 0)
                    {
                        ViewBag.Mensaje = "No hay potreros asignados";
                    }
                    return View(potrerosOrdenados);
                }
                else
                {
                    return RedirectToAction("Index", "Home");
                }

            }
            catch (Exception ex)
            {
                ViewBag.Mensaje = ex.Message;
                return View();
            }
        }

        //Métodos para obtener animales de un tipo y con mayor peso al dado
        public IActionResult ObtenerAnimalesDeTipoMayorPeso()
        {
            try
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
            catch (Exception ex)
            {
                ViewBag.Mensaje = ex.Message;
                return View();
            }

        }

        [HttpPost]
        public IActionResult ObtenerAnimalesDeTipoMayorPeso(string tipo, decimal peso)
        {
            try
            {
                if (HttpContext.Session.GetString("rol") != null &&
                HttpContext.Session.GetString("rol") == ("Capataz"))
                {
                    if (tipo != null && peso > 0)
                    {
                        List<Animal> animalesFiltrados = miSistema.AnimalesDeTipoMayorPeso(tipo, peso);
                        return View(animalesFiltrados);
                    }
                    else
                    {
                        ViewBag.Mensaje = "Datos incorrectos";
                        return View();
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
                return View();
            }
        }

        

        
        
    }
}


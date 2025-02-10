using Microsoft.AspNetCore.Mvc;
using ObligatorioP2_De_Gregorio_y_Echenique;

namespace EstanciaWeb.Controllers
{
    public class TareaController : Controller
    {
        private Sistema miSistema = Sistema.Instancia;

        //Métodos para completar una tarea
        public IActionResult Edit(int id)
        {
            try
            {
                if (HttpContext.Session.GetString("rol") != null &&
                HttpContext.Session.GetString("rol") == ("Peon"))
                {
                    Peon peon = miSistema.ObtenerPeonPorTareaId(id);
                    if (peon != null)
                    {
                        foreach (Tarea tarea in peon.Tareas)
                        {
                            if (tarea.Id == id)
                            {
                                return View(tarea);
                            }
                        }
                    }
                }
                else
                {
                    return RedirectToAction("Index", "Home");
                }
                
            }

            catch (Exception ex)
            {
                ViewBag.Mensaje = "Error en los datos";
            }
            return View(new Tarea());
        }
        [HttpPost]
        public IActionResult Edit(Tarea tarea, int id, string comentario)
        {
            try
            {
                if (HttpContext.Session.GetString("rol") != null &&
                HttpContext.Session.GetString("rol") == ("Peon"))
                {
                    Peon peonAsociado = null;
                    Tarea tareaBuscada = null;
                    foreach (Empleado empleado in miSistema.Empleados)
                    {
                        if (empleado is Peon peon)
                        {
                            foreach (Tarea t in peon.Tareas)
                            {
                                if (t.Id == id)
                                {
                                    peonAsociado = peon;
                                    tareaBuscada = t;
                                    break;
                                }
                            }
                        }
                        if (tareaBuscada != null) break;
                    }
                    if (string.IsNullOrEmpty(comentario))
                    {
                        TempData["Mensaje"] = "El comentario de cierre es obligatorio";
                        return RedirectToAction("ObtenerTareasIncompletas","Peon");
                    }

                    if (peonAsociado != null && tareaBuscada != null && !string.IsNullOrEmpty(comentario))
                    {
                        miSistema.ModificarTarea(tarea, tareaBuscada, comentario);
                        TempData["Mensaje"] = "Tarea completada";
                        return RedirectToAction("ObtenerTareasIncompletas", "Peon");
                    }
                    else
                    {
                        TempData["Mensaje"] = "La tarea buscada no existe o no hay un peón asociado a esa tarea";
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
            return View("Edit");
        }

    }
}
using Microsoft.AspNetCore.Mvc;
using LogicaObligatorioP2_De_gregorio_y_Echenique;
using ObligatorioP2_De_Gregorio_y_Echenique;
using System.Drawing;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages.Manage;

namespace EstanciaWeb.Controllers
{

    public class PeonController : Controller
    {
        private Sistema miSistema = Sistema.Instancia;
        
        //Método para obtener datos
        public IActionResult ObtenerDatos()
        {
            List<Empleado> empleados = new List<Empleado>();
            Peon peonBuscado = miSistema.BuscarPeon(HttpContext.Session.GetString("emailUsuario"));
            try
            {
                if (HttpContext.Session.GetString("rol") != null &&
                HttpContext.Session.GetString("rol") == ("Peon"))
                {
                    if (peonBuscado != null)
                    {
                        empleados.Add(peonBuscado);
                    }
                    return View(empleados);
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
            return View(empleados);
        }

        
        //Método para obtener una lista de todas las tareas por completar
        public IActionResult ObtenerTareasIncompletas()
        {   
            try
            {
                if (HttpContext.Session.GetString("rol") != null &&
                HttpContext.Session.GetString("rol") == ("Peon"))
                {
                    List<Tarea> tareasOrdenadas = miSistema.DevolverTareasOrdenadas(HttpContext.Session.GetString("emailUsuario"));
                    List<Tarea> tareasIncompletas = new List<Tarea>();
                    foreach (Tarea tarea in tareasOrdenadas)
                    {
                        if (!tarea.FueCompletada)
                        {
                            tareasIncompletas.Add(tarea);
                        }
                    }
                    if (tareasIncompletas.Count == 0)
                    {
                        ViewBag.Mensaje = "No hay tareas por completar";
                        return View();
                    }

                    return View(tareasIncompletas);
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

       
        
    }
}

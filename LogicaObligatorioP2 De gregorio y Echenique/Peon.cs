using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObligatorioP2_De_Gregorio_y_Echenique
{
    public class Peon : Empleado
    {
        private bool _resideEnEstancia;
        private List<Tarea> _tareasAsignadas = new List<Tarea>();

        public List<Tarea> Tareas
        {
            get { return _tareasAsignadas; }
        }

        public bool ResideEnEstancia
        {
            get { return _resideEnEstancia; }
            set {  _resideEnEstancia = value;}
        }

        public Peon(string email, string contrasenia, string nombre, DateTime fechaIngreso, bool resideEnEstancia)
            :base( email, contrasenia, nombre, fechaIngreso)
        {
            _resideEnEstancia = resideEnEstancia;
        }

        public void AsignarTarea(Tarea nuevaTarea)
        {
            _tareasAsignadas.Add(nuevaTarea);
        }

        public override string ToString()
        {

            return base.ToString() + _resideEnEstancia.ToString();
        }

    }
}

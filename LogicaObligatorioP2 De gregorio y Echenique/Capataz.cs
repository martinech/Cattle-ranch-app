using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace ObligatorioP2_De_Gregorio_y_Echenique
{
    public class Capataz : Empleado
    {
        private int _empleado;

        public Capataz(string email, string contrasenia, string nombre, DateTime fechaIngreso, int empleado)
            :base(email, contrasenia, nombre, fechaIngreso)
        {
            _empleado = empleado;
        }

        public override string ToString()
        {

            return base.ToString() + _empleado.ToString();
        }

        public void Validar()
        {
            if (_empleado < 0)
            {
                throw new Exception("Los empleados a cargo son incorrectos");
            }
        }
    }
}

using LogicaObligatorioP2_De_gregorio_y_Echenique.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObligatorioP2_De_Gregorio_y_Echenique
{
    public abstract class Empleado :IValidable,IEquatable<Empleado>
    {
        private string _email;
        private string _contrasenia;
        private string _nombre;
        private DateTime _fechaIngreso;

        public string Email 
        {
            get { return _email; }
        }
        public string Nombre
        {
            get { return _nombre; }
        }
        public DateTime Fecha
        {
            get { return _fechaIngreso; }
        }
        public string Contrasenia
        {
            get { return _contrasenia; }
        }

        public Empleado(string email, string contrasenia, string nombre, DateTime fechaIngreso)
        {
            _email = email;
            _contrasenia = contrasenia;
            _nombre = nombre;
            _fechaIngreso = fechaIngreso;
        }

        public bool Equals(Empleado? empleado)  
        {
            return _email == empleado._email &&
                _fechaIngreso == empleado._fechaIngreso;

        }
                

        public void Validar()
        {
            if (string.IsNullOrEmpty(_email))
            {
                throw new Exception("Debe ingresar un email");
            }
            if (_contrasenia.Length < 8)
            {
                throw new Exception("La contraseña no puede tener menos de 8 caracteres");
            }
            if (string.IsNullOrEmpty(_nombre))
            {
                throw new Exception("Debe ingresar un nombre");
            }
            if (_fechaIngreso == DateTime.MinValue)
            {
                throw new Exception("La fecha ingresada no es correcta");
            }

        }
        public override string ToString()
        {
            return _email + " - " + _contrasenia + " - " + _fechaIngreso;
        }
    }
}

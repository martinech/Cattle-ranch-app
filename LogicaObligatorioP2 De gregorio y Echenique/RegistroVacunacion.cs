using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObligatorioP2_De_Gregorio_y_Echenique
{
    public class RegistroVacunacion : IEquatable<RegistroVacunacion>
    {
        private string _animal;
        private Vacuna _vacuna;
        private DateTime _fechaVacunacion;
        private DateTime _fechaVencimiento;
        public DateTime Fecha
        {
            get { return _fechaVacunacion; }
            set { _fechaVacunacion = value; }
        }
        public string Animal
        {
            get { return _animal; }
            set { _animal = value; }
        }

        public Vacuna Vacuna
        {
            get { return _vacuna; }
            set { _vacuna = value; }
        }

        public DateTime FechaVencimiento
        {
            get { return _fechaVencimiento; }
            set { _fechaVencimiento = _fechaVacunacion.AddYears(1); }
        }
        public RegistroVacunacion(string animal, Vacuna vacuna, DateTime fechaVacunacion)
        {
            _animal = animal;
            _vacuna = vacuna;
            _fechaVacunacion = fechaVacunacion;
            _fechaVencimiento = fechaVacunacion.AddYears(1);
        }
        public RegistroVacunacion()
        {

        }

        public override string ToString()
        {
            return _animal + " - " + _vacuna + " - " + _fechaVacunacion + " - " + _fechaVencimiento;
        }
        public void ValidarEdad(DateTime fechaNacimiento)
        {
            TimeSpan ageDifference = this.Fecha - fechaNacimiento;
            if (ageDifference.TotalDays < 90)
            {
                throw new Exception("El animal debe tener al menos 3 meses para vacunarse.");
            }
        }

        public void Validar()
        {
            if (string.IsNullOrEmpty(_animal))
            {
                throw new Exception("La caravana es obligatoria");
            }
            if (_vacuna == null)
            {
                throw new Exception("La vacuna es obligatoria");
            }
            if (_fechaVacunacion == DateTime.MinValue)
            {
                throw new Exception("La fecha de vacunación es obligatoria");
            }
            if (_fechaVencimiento == DateTime.MinValue)
            {
                throw new Exception("La fecha de vencimiento es obligatoria");
            }
        }

        public bool Equals(RegistroVacunacion? registro)
        {
            return _vacuna == registro._vacuna &&
                _fechaVacunacion == registro._fechaVacunacion;
        }
    }
}

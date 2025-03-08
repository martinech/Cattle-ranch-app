using LogicaObligatorioP2_De_gregorio_y_Echenique.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObligatorioP2_De_Gregorio_y_Echenique
{
    public class Bovino:Animal,IValidable
    {
        private string _tipoAlimentacion;
        private static decimal _precioPorKilo = 130;

        public Bovino(string caravana, string sexo, string raza, DateTime fechaNacimiento, decimal costoAdquisicion, decimal costoAlimentacion,
            decimal pesoActual, bool hibrido, string tipoAlimentacion)
            :base(caravana, sexo, raza, fechaNacimiento, costoAdquisicion, costoAlimentacion, pesoActual, hibrido)
        {
            _tipoAlimentacion = tipoAlimentacion;
        }

        public Bovino() : base()
        {

        }
        public decimal PrecioPorKilo
        {
            get { return _precioPorKilo; }
            set { _precioPorKilo = value; }
        }
        public string TipoAlimentacion
        {
            get { return _tipoAlimentacion; }
            set { _tipoAlimentacion = value; }
        }

        public override decimal CalcularPrecioVenta()
        {
            decimal costoCrianza = CalcularCostoCrianza();
            decimal precioVenta = PrecioPorKilo * PesoActual - costoCrianza;

            if (TipoAlimentacion.ToLower() == "grano")
            {
                precioVenta *= 1.3m;
            }
            if (Sexo.ToLower() == "hembra")
            {
                precioVenta *= 1.1m;
            }

            return precioVenta;
        }

        public new void Validar()
        {
            base.Validar();
            if (_tipoAlimentacion.ToLower() != "grano" && _tipoAlimentacion.ToLower() != "pastura")
            {
                throw new Exception("El tipo de alimentación debe ser 'Grano' o 'Pastura'");
            }
        }
    
        public override string ToString()
        {
            return "Bovino";
        }
    }
}

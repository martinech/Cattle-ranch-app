    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObligatorioP2_De_Gregorio_y_Echenique
{
    public class Ovino : Animal
    {
        private decimal _pesoLanaEstimado;
        private static decimal _precioLanaPorKilo = 87;
        private static decimal _precioPorKilo = 115;

        public Ovino(string caravana, string sexo, string raza, DateTime fechaNacimiento, decimal costoAdquisicion, decimal costoAlimentacion,
            decimal pesoActual, bool hibrido, decimal pesoLanaEstimado)
            : base(caravana, sexo, raza, fechaNacimiento, costoAdquisicion, costoAlimentacion, pesoActual, hibrido)
        {
            _pesoLanaEstimado = pesoLanaEstimado;
        }

        public Ovino() : base()
        {

        }

        public decimal PrecioLanaPorKilo
        {
            get { return _precioLanaPorKilo; }
        }
        public decimal PesoLanaEstimado
        {
            get { return _pesoLanaEstimado; }
        }
        public decimal PrecioPorKilo
        {
            get { return _precioPorKilo; }
        }

        public override decimal CalcularPrecioVenta()
        {
            decimal costoCrianza = CalcularCostoCrianza();
            decimal precioVenta = PesoLanaEstimado * PrecioLanaPorKilo + PrecioPorKilo * PesoActual - costoCrianza;

            if (Hibrido)
            {
                precioVenta *= 0.95m;
            }

            return precioVenta;
        }


        public override string ToString()
        {
            return "Ovino";
        }

        public void Validar()
        {
            if (_pesoLanaEstimado <= 0)
            {
                throw new Exception("El peso de lana no es correcto");
            }
        }
    }
}
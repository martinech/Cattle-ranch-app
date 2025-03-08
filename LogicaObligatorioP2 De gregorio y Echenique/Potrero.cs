using LogicaObligatorioP2_De_gregorio_y_Echenique.Interfaces;
using System.Security.Cryptography;

namespace ObligatorioP2_De_Gregorio_y_Echenique
{
    public class Potrero : IValidable, IEquatable<Potrero>, IComparable<Potrero>
    {
        private int _idPotrero;
        private static int s_UltId;
        private string _descripcion;
        private double _cantidadHectareas;
        private int _capacidadMaxima;
        private decimal _precioVenta;
        private List<Animal> _animales = new List<Animal>();

        public List<Animal> Animales
        {
            get { return _animales; }
        }

        public int CantidadAnimales
        {
            get { return _animales.Count; }
        }

        public int Id
        {
            get { return _idPotrero; }
        }

        public double Hectareas
        {
            get { return _cantidadHectareas; }
        }

        public int Capacidad
        {
            get { return _capacidadMaxima; }
        }

        public string Descripcion
        {
            get { return _descripcion; }
        }
        public decimal PrecioVenta
        {
            get { return _precioVenta; }
        }

        public Potrero(string descripcion, double cantidadHectareas, int capacidadMaxima)
        {
            _idPotrero = s_UltId++;
            _descripcion = descripcion;
            _cantidadHectareas = cantidadHectareas;
            _capacidadMaxima = capacidadMaxima;
        }

        public override string ToString()
        {
            return _idPotrero + " - " + _descripcion + " - " + _cantidadHectareas + " - " + _capacidadMaxima;
        }

        public void Validar()
        {
            if (string.IsNullOrEmpty(_descripcion))
            {
                throw new Exception("La descripción es obligatoria");
            }
            if (_cantidadHectareas < 0)
            {
                throw new Exception("La cantidad de hectáreas no puede ser menor a 0");
            }
            if (_capacidadMaxima < 0)
            {
                throw new Exception("La capacidad máxima no puede ser menor a 0");
            }
        }

        public bool Equals(Potrero potrero)
        {
            return _idPotrero.Equals(potrero._idPotrero);
        }

        public int CompareTo(Potrero? other)
        {
            int comparacion = _capacidadMaxima.CompareTo(other._capacidadMaxima);
            if (comparacion == 0)
            {
                comparacion = -1*_animales.Count().CompareTo(other._animales.Count());
            }
            return comparacion;
        }
        public void ObtenerPrecioVentaPotrero()
        {
            decimal precioVentaPotrero = 0;
            foreach (Animal animal in _animales)
            {
                precioVentaPotrero += animal.CalcularPrecioVenta();
            }
            _precioVenta = precioVentaPotrero;
        }

    }
}

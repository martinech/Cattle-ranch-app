using LogicaObligatorioP2_De_gregorio_y_Echenique.Interfaces;

namespace ObligatorioP2_De_Gregorio_y_Echenique
{
    public abstract class Animal : IValidable, IEquatable<Animal>
    {
        private string _caravana;
        private string _sexo;
        private string _raza;
        private DateTime _fechaNacimiento;
        private decimal _costoAdquisicion;
        private decimal _costoAlimentacion;
        private decimal _pesoActual;
        private bool _hibrido;
        private List<RegistroVacunacion> _registrosVacunaciones = new List<RegistroVacunacion>();

        public string Caravana
        {
            get { return _caravana; }
            set {  _caravana = value; }
        }
        public List<RegistroVacunacion> RegistroVacunaciones
        {
            get { return _registrosVacunaciones; }
            set { _registrosVacunaciones = value; }
        }
        public DateTime FechaNac
        {
            get { return _fechaNacimiento; }
            set { _fechaNacimiento = value; }
        }
        public string Sexo
        {
            get { return _sexo; }
            set { _sexo = value; }
        }
        public string Raza
        {
            get { return _raza; }
            set { _raza = value; }
        }
        public decimal PesoActual
        {
            get { return _pesoActual; }
            set { _pesoActual = value; }
        }
        public bool Hibrido
        {
            get { return (_hibrido); }
            set { _hibrido = value; }
        }
        public decimal CostoAdquisicion
        {
            get { return _costoAdquisicion; }
            set { _costoAdquisicion = value; }
        }
        public decimal CostoAlimentacion
        {
            get { return _costoAlimentacion; }
            set { _costoAlimentacion = value; }
        }

        public Animal(string caravana, string sexo, string raza, DateTime fechaNacimiento, decimal costoAdquisicion, decimal costoAlimentacion, decimal pesoActual, bool hibrido)
        {
            _caravana = caravana;
            _sexo = sexo;
            _raza = raza;
            _fechaNacimiento = fechaNacimiento;
            _costoAdquisicion = costoAdquisicion;
            _costoAlimentacion = costoAlimentacion;
            _pesoActual = pesoActual;
            _hibrido = hibrido;
        }

        public Animal()
        {

        }

        public abstract decimal CalcularPrecioVenta();

        public decimal CalcularCostoCrianza()
        {
            decimal costoCrianza = 0;
            decimal costoAdquisicion = _costoAdquisicion;
            decimal costoAlimentacion = _costoAlimentacion;
            decimal costoVacunas = RegistroVacunaciones.Count * 200;
            costoCrianza = costoAdquisicion + costoAlimentacion + costoVacunas;
            return costoCrianza;
        }

        public override string ToString()
        {
            return _caravana + " - " + _sexo + " - " + _raza + " - " + _pesoActual;
        }
        public void Validar()
        {
            if (string.IsNullOrEmpty(_caravana))
            {
                throw new Exception("La caravana es obligatoria");
            }
            if (_caravana.Length != 8)
            {
                throw new Exception("La caravana debe tener 8 caracteres");
            }
            if (string.IsNullOrEmpty(_sexo))
            {
                throw new Exception("El sexo es obligatorio");
            }
            if (string.IsNullOrEmpty(_raza))
            {
                throw new Exception("La raza es obligatoria");
            }
            if (_costoAdquisicion <= 0)
            {
                throw new Exception("El costo de adquisición debe ser mayor a 0");
            }
            if (_costoAlimentacion <= 0)
            {
                throw new Exception("El costo de alimentación debe ser mayor a 0");
            }
            if (_pesoActual <= 0)
            {
                throw new Exception("El peso actual debe ser mayor a 0");
            }
            if (_fechaNacimiento == DateTime.MinValue)
            {
                throw new Exception("La fecha ingresada no es correcta");
            }
        }

        public bool Equals(Animal? animal)
        {
            return _caravana == animal._caravana;
        }
    }
}

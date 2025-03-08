namespace ObligatorioP2_De_Gregorio_y_Echenique
{
    public class Vacuna :  IEquatable<Vacuna>
    {
        private string _nombre;
        private string _descripcion;
        private string _patogeno;



        public Vacuna(string nombre, string descripcion, string patogeno)
        {
            _nombre = nombre;
            _descripcion = descripcion;
            _patogeno = patogeno;
        }

        public Vacuna()
        {

        }

        public string Descripcion
        {
            get { return _descripcion; }
        }

        public string Nombre
        {
            get { return _nombre; }
        }

        public override string ToString()
        {

            return _nombre + " - " + _descripcion + " - " + _patogeno;
        }

        internal void Validar()
        {
            if (string.IsNullOrEmpty(_nombre))
            {
                throw new Exception("El nombre es obligatorio");
            }
            if (string.IsNullOrEmpty(_descripcion))
            {
                throw new Exception("El nombre es obligatorio");
            }
            if (string.IsNullOrEmpty(_patogeno))
            {
                throw new Exception("El patogeno es obligatorio");
            }
        }

        public bool Equals(Vacuna? vacuna)
        {
            return _nombre == vacuna._nombre &&
                _descripcion == vacuna._descripcion &&
                _patogeno == vacuna._patogeno;
        }
    }
}

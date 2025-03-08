using LogicaObligatorioP2_De_gregorio_y_Echenique.Interfaces;

namespace ObligatorioP2_De_Gregorio_y_Echenique
{
    public class Tarea : IValidable, IEquatable<Tarea>, IComparable<Tarea>
    {

        private int _id;
        private static int s_UltId;
        private string _descripcion;
        private DateTime _fechaPactada;
        private bool _completada;
        private DateTime _fechaCierre;
        private string _comentario;


        public Tarea(string descripcion, DateTime fechaPactada, bool completada, DateTime fechaCierre, string comentario)
        {
            _id = s_UltId++;
            _descripcion = descripcion;
            _fechaPactada = fechaPactada;
            _completada = completada;
            _fechaCierre = fechaCierre;
            _comentario = comentario;
        }

        public Tarea()
        {
            _id = s_UltId++;
        }

        public int Id
        {
            get { return _id; }
        }
        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }
        public DateTime FechaPactada
        {
            get { return _fechaPactada; }
            set { _fechaPactada = value; }
        }
        public bool FueCompletada
        {
            get { return _completada; }
            set {  _completada = value; }
        }
        public DateTime FechaCierre
        {
            get { return _fechaCierre; }
            set { _fechaCierre = value; }
        }
        public string Comentario
        {
            get { return _comentario; }
            set { _comentario = value; }
        }


        public void Validar()
        {
            if (string.IsNullOrEmpty(_descripcion))
            {
                throw new Exception("La descripción es obligatoria");
            }
            if (_fechaPactada == DateTime.MinValue)
            {
                throw new Exception("La fecha pactada es obligatoria");
            }
            if (string.IsNullOrEmpty(_comentario))
            {
                throw new Exception("El comentario es obligatorio");
            }
        }


        public bool Equals(Tarea tarea)
        {
            return _id.Equals(tarea._id);
        }

        public int CompareTo(Tarea? other)
        {
            return this._fechaPactada.CompareTo(other._fechaPactada);
        }
    }
}
namespace Obligatorio.Clases.Animales
{
    public class Mascota : IMascota
    {
        private string _cedula;
        private string _nombre;
        private string _raza;

        public Mascota(string nombre, string raza, string cedula)
        {
            _nombre = nombre;
            _raza = raza;
            _cedula = cedula;
        }

        public string Nombre
        {
            get => _nombre;
            set => _nombre = value;
        }

        public string Raza
        {
            get => _raza;
            set => _raza = value;
        }

        public string Cedula
        {
            get => _cedula;
            set => _cedula = value;
        }


        public virtual string getEspecie()
        {
            return "";
        }

        public string getCedula()
        {
            return _cedula;
        }

        public string getNombre()
        {
            return _nombre;
        }

        public string getRaza()
        {
            return _raza;
        }
    }
}
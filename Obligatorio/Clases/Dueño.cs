using System.Collections.Generic;

namespace Obligatorio.Clases
{
    public class Dueño
    {
        private string _cedula;
        private string _nombre;
        private List<Mascota> _mascotas;
        public Dueño(string cedula, string nombre)
        {
            _cedula = cedula;
            _nombre = nombre;
            _mascotas = new List<Mascota>();
        }

        public string Cedula
        {
            get => _cedula;
            set => _cedula = value;
        }

        public string Nombre
        {
            get => _nombre;
            set => _nombre = value;
        }

        public List<Mascota> Mascotas
        {
            get => _mascotas;
            set => _mascotas = value;
        }
    }
}
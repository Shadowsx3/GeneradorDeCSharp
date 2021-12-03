using System.Collections.Generic;
using Obligatorio.Clases.Animales;

namespace Obligatorio.Clases
{
    public class Dueño
    {
        private string _cedula;
        private string _nombre;
        private List<IMascota> _mascotas;
        public Dueño(string cedula, string nombre)
        {
            _cedula = cedula;
            _nombre = nombre;
            _mascotas = new List<IMascota>();
        }

        public void AgregarMascotas(List<IMascota> masc)
        {
            foreach (var a in masc)
            {
                _mascotas.Add(a);
            }
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

        public List<IMascota> Mascotas
        {
            get => _mascotas;
            set => _mascotas = value;
        }
    }
}
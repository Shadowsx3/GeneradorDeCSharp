using System.Collections.Generic;

namespace Obligatorio.Clases
{
    public class Funcionario
    {
        private List<string> _funciones;
        private string _nombre;
        private string _cedula;

        public Funcionario( string nombre, string cedula)
        {
            _funciones = new List<string>();
            _nombre = nombre;
            _cedula = cedula;
        }

        public List<string> Funciones
        {
            get => _funciones;
            set => _funciones = value;
        }

        public string Nombre
        {
            get => _nombre;
            set => _nombre = value;
        }

        public string Cedula
        {
            get => _cedula;
            set => _cedula = value;
        }
    }
}
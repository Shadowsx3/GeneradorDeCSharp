using System;

namespace Taller_Mecanico
{
    public class Cliente
    {
        private int _cedula;
        private string _nombre;
        private string _apellido;

        public int Cedula
        {
            get => _cedula;
            set => _cedula = value;
        }

        public string Nombre
        {
            get => _nombre;
            set => _nombre = value;
        }

        public string Apellido
        {
            get => _apellido;
            set => _apellido = value;
        }

        public Cliente(int cedula, string nombre, string apellido)
        {
            _cedula = cedula;
            _nombre = nombre;
            _apellido = apellido;
        }

        public override string ToString()
        {
            return $"Cedula:\n\t{_cedula}\nNombre:\n\t{_nombre}\nApellido\n\t{_apellido}";
        }
    }
}
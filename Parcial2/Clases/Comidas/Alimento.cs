using System;

namespace Parcial2.Clases
{
    public class Alimento : IAlimento
    {
        private string _nombre;
        private string _tipo;

        public virtual void Inspeccionar()
        {
            Console.WriteLine("Estas inspeccionando un alimento generico");
        }
        public Alimento(string nombre, string tipo)
        {
            _nombre = nombre;
            _tipo = tipo;
        }

        public string Nombre
        {
            get => _nombre;
            set => _nombre = value;
        }

        public string Tipo
        {
            get => _tipo;
            set => _tipo = value;
        }

        string IAlimento.Tipo()
        {
            return Tipo;
        }

        string IAlimento.Nombre()
        {
            return Nombre;
        }
    }
}
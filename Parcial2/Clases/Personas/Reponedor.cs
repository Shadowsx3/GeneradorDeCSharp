using System;

namespace Parcial2.Clases
{
    public class Reponedor : IPersona
    {
        private string _nombre;

        public Reponedor(string nombre)
        {
            _nombre = nombre;
        }
        public void AgregarAlimento(IAlimento a)
        {
            Tienda.GetInstance().AgregarAlimento(a);
        }

        public string Nombre
        {
            get => _nombre;
            set => _nombre = value;
        }

        public void Avisar(IAlimento alimento, string accion)
        {
            switch (accion)
            {
                case TiposAcciones.Removido:
                    Console.WriteLine($"Reponedor {Nombre}) *siente la necesidad de reponer {alimento.Nombre()}*");
                    break;
            }
        }

        public string GetNombre()
        {
            return Nombre;
        }
    }
}
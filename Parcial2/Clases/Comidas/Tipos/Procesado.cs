using System;

namespace Parcial2.Clases.Tipos
{
    public class Procesado : Alimento
    {
        public Procesado(string nombre) : base(nombre, TiposAlimentos.Procesado)
        {
        }
        public override void Inspeccionar()
        {
            Console.WriteLine("Nonono, mu mal, esto no es sano");
        }
    }
}
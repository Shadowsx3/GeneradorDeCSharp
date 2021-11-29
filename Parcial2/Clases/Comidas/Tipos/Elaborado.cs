using System;

namespace Parcial2.Clases.Tipos
{
    public class Elaborado:Alimento
    {
        public Elaborado(string nombre) : base(nombre, TiposAlimentos.Elaborado)
        {
        }
        public override void Inspeccionar()
        {
            Console.WriteLine("Es elaborado, como todo(?");
        }
    }
}
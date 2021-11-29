using System;
using System.Runtime.CompilerServices;

namespace Parcial2.Clases.Tipos
{
    public class Organico:Alimento
    {
        public Organico(string nombre) : base(nombre, TiposAlimentos.Organico)
        {
        }

        public override void Inspeccionar()
        {
            Console.WriteLine("Es organico, mira que lindo");
        }
    }
}
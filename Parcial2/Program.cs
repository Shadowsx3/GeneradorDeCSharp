using System.Collections.Generic;
using Parcial2.Clases;

namespace Parcial2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var cf = new ClientFactory();
            var ff = new FoodFactory();
            
            var c1 = cf.FabricarCliente("Juan", TiposClientes.Elaborado);
            var c2 = cf.FabricarCliente("Pedro", TiposClientes.Organico);
            var c3 = cf.FabricarCliente("Nose", TiposClientes.NoCome);
            var c4 = cf.FabricarCliente("Na", TiposClientes.SinDrama);
            var c5 = cf.FabricarCliente("Sise", TiposClientes.USA);
            var r1 = new Reponedor("Jacinto");
            var r2 = new Reponedor("Juana");
            Tienda.GetInstance().Personas = new List<IPersona>() {c1, c2, c3, c4, c5, r1, r2};

            var frutilla = ff.FabricarAlimento(TiposAlimentos.Organico, "Frutilla");
            var agua = ff.FabricarAlimento(TiposAlimentos.Organico, "Agua");
            var chorizo = ff.FabricarAlimento(TiposAlimentos.Elaborado, "Chorizos");
            var panchos = ff.FabricarAlimento(TiposAlimentos.Elaborado, "Panchos");
            var nose = ff.FabricarAlimento(TiposAlimentos.Procesado, "cosas");
            
            r1.AgregarAlimento(frutilla);
            r1.AgregarAlimento(agua);
            r1.AgregarAlimento(chorizo);
            r1.AgregarAlimento(chorizo);
            r1.AgregarAlimento(nose);
            
            c2.RemoverAlimento("Frutilla");
            c4.RemoverAlimento("Agua");
            r2.AgregarAlimento(panchos);
            c4.RemoverAlimento("Panchos");
            r2.AgregarAlimento(chorizo);
            c4.RemoverAlimento("Chorizos");
            r2.AgregarAlimento(chorizo);
            c4.RemoverAlimento("Helicoptero");
        }
    }
}
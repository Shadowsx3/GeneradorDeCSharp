using System.Collections.Generic;
using PracticoNoObligatorio.Clases;

namespace PracticoNoObligatorio
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            
            Cliente c = new Cliente("Pedro");
            Cliente c1 = new Cliente("Pedrozo");
            Desarrollador d = new Desarrollador("Juan");
            Desarrollador d1 = new Desarrollador("Juanito");
            Administador a = new Administador("Pablo");
            Administador a1 = new Administador("Pablozo");
            List<IPersona> personas = new List<IPersona>(){c, c1, d, d1, a, a1};
            SystemManager.Personas = personas;
            //Ahora se añade una nueva tarea
            Tarea t = new Tarea(c, "Bailar");
            Tarea t2 = new Tarea(c1, "Cantar");
            c.AñadirTarea(t);
            c1.AñadirTarea(t2);
            a.CambiarEstado(t,true);
            a1.CambiarEstado(t2,false);
            d.TomarTarea(t);
            d.RealizarTarea(t);
        }
    }
}
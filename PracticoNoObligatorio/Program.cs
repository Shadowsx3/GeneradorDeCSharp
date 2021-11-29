using System.Collections.Generic;
using PracticoNoObligatorio.Clases;

namespace PracticoNoObligatorio
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            PeopleFormer pf = new PeopleFormer();
            var c = (Cliente)pf.MakeOne("Cliente", "Pedro");
            var c1 = (Cliente)pf.MakeOne("Cliente", "Pedrozo");
            var d = (Desarrollador)pf.MakeOne("Desarrollador", "Juan");
            var d1 = (Desarrollador)pf.MakeOne("Desarrollador", "Juanito");
            var a = (Administador)pf.MakeOne("Administrador","Pablo");
            var a1 = (Administador)pf.MakeOne("Administrador","Pablozo");
            var personas = new List<IPersona>(){c, c1, d, d1, a, a1};
            SystemManager.GetInstance().Personas = personas;
            //Ahora se añade una nueva tarea
            var t = new Tarea(c, "Bailar");
            var t2 = new Tarea(c1, "Cantar");
            c.AñadirTarea(t);
            c1.AñadirTarea(t2);
            a.CambiarEstado(t,true);
            a1.CambiarEstado(t2,false);
            d.TomarTarea(t);
            d.RealizarTarea(t);
        }
    }
}
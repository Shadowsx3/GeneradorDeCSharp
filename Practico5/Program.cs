using System.Collections.Generic;
using PracticoNoObligatorio.Clases.Managers;
using PracticoNoObligatorio.Clases.Persona;
using PracticoNoObligatorio.Clases.Tareas;

namespace PracticoNoObligatorio
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var pf = new PeopleFormer();
            var c = (Cliente)pf.MakeOne(TiposPersonas.Cliente, "Pedro");
            var c1 = (Cliente)pf.MakeOne(TiposPersonas.Cliente, "Pedrozo");
            var d = (Desarrollador)pf.MakeOne(TiposPersonas.Desarrollador, "Juan");
            var d1 = (Desarrollador)pf.MakeOne(TiposPersonas.Desarrollador, "Juanito");
            var a = (Administador)pf.MakeOne(TiposPersonas.Administador,"Pablo");
            var a1 = (Administador)pf.MakeOne(TiposPersonas.Administador,"Pablozo");
            var personas = new List<IPersona>(){c, c1, d, d1, a, a1};
            SystemManager.GetInstance().AddLPersona(personas);
            //Ahora se añade una nueva tarea
            var t = new Tarea(c, "Bailar");
            var t2 = new Tarea(c1, "Cantar");
            c.AñadirTarea(t);
            c1.AñadirTarea(t2);
            a.CambiarEstado(0,true);
            a1.CambiarEstado(1,false);
            d.TomarTarea(0);
            d.RealizarTarea(0);
        }
    }
}
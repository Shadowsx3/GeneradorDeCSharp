using System;
using PracticoNoObligatorio.Clases.Managers;
using PracticoNoObligatorio.Clases.Tareas;

namespace PracticoNoObligatorio.Clases.Persona
{
    public class Administador: Persona
    {
        public Administador(string nombre)
        {
            _recibe = new[] {TiposAcciones.Nueva, TiposAcciones.Finalizada};
            _nombre = nombre;
        }

        public void CambiarEstado(int num, bool estado)
        {
            var t = SystemManager.GetInstance().GetTarea(num);
            if (t != null)
            {
                CambiarEstado(t, estado);
            }
        }
        public void CambiarEstado(Tarea t, bool estado)
        {
            Console.WriteLine($"El administrador {Nombre} ha {(estado ? "aprobado": "rechazado")} la tarea {t.Actividad}");
            SystemManager.GetInstance().CambiarAprobacion(t, estado);
        }
        public override string Tipo()
        {
            return TiposPersonas.Administador;
        }
    }
}
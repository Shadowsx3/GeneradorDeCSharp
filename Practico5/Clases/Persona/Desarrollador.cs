using PracticoNoObligatorio.Clases.Managers;
using PracticoNoObligatorio.Clases.Tareas;

namespace PracticoNoObligatorio.Clases.Persona
{
    public class Desarrollador : Persona,  ITrabajador
    {
        public Desarrollador(string nombre)
        {
            _recibe = new[] {TiposAcciones.Aprobada};
            _nombre = nombre;
        }
        public void RealizarTarea(int num)
        {
            var t = SystemManager.GetInstance().GetTarea(num);
            if (t != null)
            {
                RealizarTarea(t);
            }
        }
        public void TomarTarea(int num)
        {
            var t = SystemManager.GetInstance().GetTarea(num);
            if (t != null)
            {
                TomarTarea(t);
            }
        }
        public void RealizarTarea(Tarea tarea)
        {
            SystemManager.GetInstance().RealizarTarea(tarea);
        }
        public void TomarTarea(Tarea tarea)
        {
            SystemManager.GetInstance().AceptarTarea(tarea, this);
        }
        public override string Tipo()
        {
            return TiposPersonas.Desarrollador;
        }
    }
}
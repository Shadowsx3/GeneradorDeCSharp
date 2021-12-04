using PracticoNoObligatorio.Clases.Persona;

namespace PracticoNoObligatorio.Clases.Managers
{
    public interface ISystemManager
    {
        void AgregarTarea(Tareas.Tarea tarea);
        void RealizarTarea(Tareas.Tarea tarea);
        void AceptarTarea(Tareas.Tarea tarea, Desarrollador desarrollador);
        void CambiarAprobacion(Tareas.Tarea tarea, bool aprobada);
    }
}
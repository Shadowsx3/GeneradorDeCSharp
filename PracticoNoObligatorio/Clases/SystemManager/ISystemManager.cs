namespace PracticoNoObligatorio.Clases
{
    public interface ISystemManager
    {
        void Notificar(Tarea id, string accion);
        void AgregarTarea(Tarea t);
        void RealizarTarea(Tarea tarea);
        void AceptarTarea(Tarea tarea, Desarrollador desarrollador);
        void CambiarAprobacion(Tarea tarea, bool aprobada);
    }
}
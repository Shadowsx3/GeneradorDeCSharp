using PracticoNoObligatorio.Clases.Tareas;

namespace PracticoNoObligatorio.Clases.Persona
{
    public interface ITrabajador
    {
        void RealizarTarea(Tarea tarea);
        void TomarTarea(Tarea tarea);
    }
}
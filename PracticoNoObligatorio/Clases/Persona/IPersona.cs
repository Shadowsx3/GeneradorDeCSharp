namespace PracticoNoObligatorio.Clases.Persona
{
    public interface IPersona
    {
            void Update(Tareas.Tarea tarea, string accion);
            string Tipo();
    }
}
namespace PracticoNoObligatorio.Clases
{
    public class Desarrollador : Persona,  ITrabajador
    {
        public Desarrollador(string nombre)
        {
            _recibe = new string[] {"tarea aprobada"};
            _tipo = "Desarrollador";
            _nombre = nombre;
        }

        public void RealizarTarea(Tarea tarea)
        {
            SystemManager.GetInstance().RealizarTarea(tarea);
        }
        public void TomarTarea(Tarea tarea)
        {
            SystemManager.GetInstance().AceptarTarea(tarea, this);
        }
    }
}
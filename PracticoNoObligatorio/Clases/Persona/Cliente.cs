namespace PracticoNoObligatorio.Clases
{
    public class Cliente: Persona
    {
        public Cliente(string nombre)
        {
            _recibe = new string[] {"tarea no aprobada", "tarea finalizada"};
            _tipo = "Cliente";
            _nombre = nombre;
        }

        public override void Update(Tarea tarea, string accion)
        {
            if (tarea.SugeridaPor == this)
            {
                base.Update(tarea, accion);
            }
        }

        public void AñadirTarea(Tarea t)
        {
            SystemManager.AgregarTarea(t);
        }
    }
}
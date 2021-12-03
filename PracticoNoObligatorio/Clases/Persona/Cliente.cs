using PracticoNoObligatorio.Clases.Managers;

namespace PracticoNoObligatorio.Clases.Persona
{
    public class Cliente: Persona
    {
        public Cliente(string nombre)
        {
            _recibe = new string[] {TiposAcciones.Aprobada, TiposAcciones.Finalizada};
            _nombre = nombre;
        }

        public override void Update(Tareas.Tarea tarea, string accion)
        {
            if (tarea.SugeridaPor == this)
            {
                base.Update(tarea, accion);
            }
        }

        public void AñadirTarea(Tareas.Tarea t)
        {
            SystemManager.GetInstance().AgregarTarea(t);
        }
        public override string Tipo()
        {
            return TiposPersonas.Cliente;
        }
    }
}
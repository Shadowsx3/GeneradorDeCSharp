using PracticoNoObligatorio.Clases.Persona;

namespace PracticoNoObligatorio.Clases.Tareas
{
    public class Tarea : ITarea
    {
        public Tarea(Cliente sugeridaPor, string actividad)
        {
            SugeridaPor = sugeridaPor;
            Actividad = actividad;
            Aprobada = false;
            Realizada = false;
        }

        public Cliente SugeridaPor { get; set; }

        public Desarrollador Encargado { get; set; }

        public bool Aprobada { get; set; }

        public bool Realizada { get; set; }

        public string Actividad { get; set; }

        public void CambiarEstado(bool estado)
        {
            throw new System.NotImplementedException();
        }

        public void Encargar(ITrabajador trabajador)
        {
            throw new System.NotImplementedException();
        }

        public void Realizar()
        {
            throw new System.NotImplementedException();
        }
    }
}
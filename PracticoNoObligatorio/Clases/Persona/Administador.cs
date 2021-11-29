namespace PracticoNoObligatorio.Clases
{
    public class Administador: Persona
    {
        public Administador(string nombre)
        {
            _recibe = new string[] {"nueva tarea", "tarea finalizada"};
            _tipo = "Administador";
            _nombre = nombre;
        }

        public void CambiarEstado(Tarea t, bool estado)
        {
            SystemManager.GetInstance().CambiarAprobacion(t, estado);
        }
    }
}
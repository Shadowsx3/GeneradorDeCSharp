using PracticoNoObligatorio.Clases.Persona;

namespace PracticoNoObligatorio.Clases.Tareas
{
    public interface ITarea
    {
        void CambiarEstado(bool estado);
        void Encargar(ITrabajador trabajador);
        void Realizar();
    }
}
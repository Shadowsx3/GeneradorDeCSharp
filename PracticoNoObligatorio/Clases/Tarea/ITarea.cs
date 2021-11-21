namespace PracticoNoObligatorio.Clases
{
    public interface ITarea
    {
        void CambiarEstado(bool estado);
        void Encargar(ITrabajador trabajador);
        void Realizar();
    }
}
namespace Obligatorio.Clases.Animales
{
    public class Rata : Mascota
    {
        public Rata(string nombre, string raza, string cedula) : base(nombre, raza, cedula)
        {
        }
        public override string getEspecie()
        {
            return TiposMascotas.Rata;
        }
    }
}
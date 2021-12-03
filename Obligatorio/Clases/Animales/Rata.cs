namespace Obligatorio.Clases.Animales
{
    public class Rata : Mascota
    {
        public Rata(string nombre, string raza) : base(nombre, raza)
        {
        }
        public override string getEspecie()
        {
            return TiposMascotas.Perro;
        }
    }
}
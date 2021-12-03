namespace Obligatorio.Clases.Animales
{
    public class Perro : Mascota
    {
        public override string getEspecie()
        {
            return TiposMascotas.Perro;
        }

        public Perro(string nombre, string raza) : base(nombre, raza)
        {
        }
    }
}
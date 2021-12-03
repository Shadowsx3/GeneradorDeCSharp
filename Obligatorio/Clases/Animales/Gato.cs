namespace Obligatorio.Clases.Animales
{
    public class Gato : Mascota
    {
        public Gato(string nombre, string raza) : base(nombre, raza)
        {
        }
        public override string getEspecie()
        {
            return TiposMascotas.Gato;
        }
    }
}
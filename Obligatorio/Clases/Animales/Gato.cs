namespace Obligatorio.Clases.Animales
{
    public class Gato : Mascota
    {
        public Gato(string nombre, string raza, string cedula) : base(nombre, raza, cedula)
        {
        }
        public override string getEspecie()
        {
            return TiposMascotas.Gato;
        }
    }
}
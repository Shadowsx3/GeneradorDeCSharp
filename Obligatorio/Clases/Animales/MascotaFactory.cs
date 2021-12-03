namespace Obligatorio.Clases.Animales
{
    public static class MascotaFactory
    {
        private static int lastid = 0;
        public static IMascota CreateMascota(string especie, string nombre, string raza)
        {
            IMascota mascota = null;
            switch (especie)
            {
                case TiposMascotas.Gato:
                    mascota = new Gato(nombre, raza, lastid.ToString());
                    break;
                case TiposMascotas.Perro:
                    mascota = new Perro(nombre, raza, lastid.ToString());
                    break;
                case TiposMascotas.Rata:
                    mascota = new Rata(nombre, raza, lastid.ToString());
                    break;
                default:
                    lastid -= 1;
                    break;
            }

            lastid += 1;
            return mascota;
        }
    }
}
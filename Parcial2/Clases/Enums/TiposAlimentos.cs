using System.Collections.Generic;

namespace Parcial2.Clases
{
    //Funciona como un enum, facil de acceder desde cualquier lugar y lo suficientemente open closed para poder 
    //considerarlo valido, agregar un tipo is just agregarlo aqui
    public static class TiposAlimentos
    {
        public const string Procesado = "Procesado";
        public const string Organico = "Organico";
        public const string Elaborado = "Elaborado";
    }
}
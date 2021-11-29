using Parcial2.Clases.Tipos;

namespace Parcial2.Clases
{
    public class FoodFactory
    {
        public IAlimento FabricarAlimento(string Tipo, string Nombre)
        {
            IAlimento alimento;
            switch (Tipo)
            {
                case TiposAlimentos.Procesado:
                    alimento = new Procesado(Nombre);
                    break;
                case TiposAlimentos.Organico:
                    alimento = new Organico(Nombre);
                    break;
                case TiposAlimentos.Elaborado:
                    alimento = new Elaborado(Nombre);
                    break;
                default:
                    alimento = null;
                    break;
            }
            return alimento;
        }
    }
}
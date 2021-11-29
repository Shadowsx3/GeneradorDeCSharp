using System.Collections.Generic;

namespace Parcial2.Clases
{
    public interface ICliente : IPersona
    {
        List<string> Gustos();
        void RemoverAlimento(string nombre);
    }
}
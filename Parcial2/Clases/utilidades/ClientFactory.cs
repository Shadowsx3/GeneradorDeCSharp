using System.Collections.Generic;

namespace Parcial2.Clases
{
    public class ClientFactory
    {
        public ICliente FabricarCliente(string Nombre, string Gustos)
        {
            ICliente cliente;
            switch (Gustos)
            {
                case TiposClientes.Procesado:
                    cliente = new Cliente(Nombre, new List<string>(){TiposAlimentos.Procesado});
                    break;
                case TiposClientes.Organico:
                    cliente = new Cliente(Nombre, new List<string>(){TiposAlimentos.Organico});
                    break;
                case TiposClientes.Elaborado:
                    cliente = new Cliente(Nombre, new List<string>(){TiposAlimentos.Elaborado});
                    break;
                case TiposClientes.NoCome:
                    cliente = new Cliente(Nombre, new List<string>());
                    break;
                case TiposClientes.SinDrama:
                    cliente = new Cliente(Nombre, new List<string>(){TiposAlimentos.Elaborado, TiposAlimentos.Organico, TiposAlimentos.Procesado});
                    break;
                case TiposClientes.USA:
                    cliente = new Cliente(Nombre, new List<string>(){TiposAlimentos.Procesado, TiposAlimentos.Elaborado});
                    break;
                default:
                    cliente = null;
                    break;
            }
            return cliente;
        }
    }
}
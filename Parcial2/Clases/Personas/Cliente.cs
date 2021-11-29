using System;
using System.Collections.Generic;

namespace Parcial2.Clases
{
    public class Cliente : ICliente
    {
        private string _nombre;
        private List<string> _gustos;

        public void RemoverAlimento(string nombre)
        {
            Console.WriteLine($"Cliente {Nombre}) Okey, compremos un poco de {nombre}");
            Tienda.GetInstance().EliminarAlimento(nombre, Nombre);
        }

        public Cliente(string nombre, List<string> gustos)
        {
            _nombre = nombre;
            _gustos = gustos;
        }

        public string Nombre
        {
            get => _nombre;
            set => _nombre = value;
        }

        public List<string> Gustos
        {
            get => _gustos;
            set => _gustos = value;
        }

        public void Avisar(IAlimento alimento, string accion)
        {
            if (!_gustos.Contains(alimento.Tipo())) return;
            switch (accion)
            {
                case TiposAcciones.Agregado:
                    Console.WriteLine($"Cliente {Nombre}) *Sabe que hay {alimento.Nombre()} porque le gusta {alimento.Tipo()}*");
                    break;
                case TiposAcciones.Removido:
                    Console.WriteLine($"Cliente {Nombre}) *Sabe que compraron {alimento.Nombre()}* T-T");
                    break;
            }
        }

        List<string> ICliente.Gustos()
        {
            return _gustos;
        }
        public string GetNombre()
        {
            return Nombre;
        }
    }
}
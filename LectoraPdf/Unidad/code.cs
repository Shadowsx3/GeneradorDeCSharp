using System;
using System.Collections.Generic;
using System.Text;

namespace Oficina
{
    public class Usuario
    {
        private string _cedula;
        private string _nombre;
        private string _contraseña;
        private string _tipo;
        private List<Objeto> _inventario = new List<Objeto>();
        private int _puntos;

        public Usuario(string cedula, string nombre, string contraseña, string tipo)
        {
            _cedula = cedula;
            _nombre = nombre;
            _contraseña = contraseña;
            _tipo = tipo;
            _puntos = 0;
        }

        public int Puntos
        {
            get => _puntos;
            set => _puntos = value;
        }

        public void AddItem(Objeto o)
        {
            Inventario.Add(o);
        }
        public void ConsumeItem(Objeto o)
        {
            for (int i = 0; i < Inventario.Count; i++)
            {
                if (o.Id == Inventario[i].Id)
                {
                    Inventario[i].Consumido = true;
                }
            }
        }
        public List<Objeto> Inventario
        {
            get => _inventario;
            set => _inventario = value;
        }
        public string Tipo
        {
            get => _tipo;
            set => _tipo = value;
        }

        public string Contraseña
        {
            get => _contraseña;
            set => _contraseña = value;
        }

        public string Cedula
        {
            get => _cedula;
            set => _cedula = value;
        }

        public string Nombre
        {
            get => _nombre;
            set => _nombre = value;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Oficina
{
    public class Objeto
    {
        private int _id;
        private string _cedula;
        private string _nombre;
        private int _puntos;
        private bool _consumido;
        private string _comprador;
        public bool Consumido
        {
            get => _consumido;
            set => _consumido = value;
        }
        public string Comprador
        {
            get => _comprador;
            set => _comprador = value;
        }
    public Objeto(int id, string cedula, string nombre, int puntos)
        {
            _id = id;
            _cedula = cedula;
            _nombre = nombre;
            _puntos = puntos;
            _consumido = false;
            _comprador = "";
        }

        public int Id
        {
            get => _id;
            set => _id = value;
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

        public int Puntos
        {
            get => _puntos;
            set => _puntos = value;
        }
    }
}

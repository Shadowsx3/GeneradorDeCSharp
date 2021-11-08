using System;
using System.Collections.Generic;
using System.Text;

namespace Oficina
{
    public class Tarea
    {
        private int _id;
        private string _nombre;
        private int _puntos;
        private string _completedBy = "";

        public string CompletedBy
        {
            get => _completedBy;
            set => _completedBy = value;
        }

        public int Id
        {
            get => _id;
            set => _id = value;
        }

        public Tarea(int id, string nombre, int puntos)
        {
            _id = id;
            _nombre = nombre;
            _puntos = puntos;
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

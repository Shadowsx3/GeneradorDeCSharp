using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MalesCubos_BienesRaices.Clases
{
    public class Habitacion
    {
        private int _idHabitacion;
        private string _nombre;
        private float _dimensiones;

        public Habitacion(int idHabitacion, string nombre, float dimensiones)
        {
            _idHabitacion = idHabitacion;
            _nombre = nombre;
            _dimensiones = dimensiones;
        }

        public int IdHabitacion
        {
            get => _idHabitacion;
            set => _idHabitacion = value;
        }

        public string Nombre
        {
            get => _nombre;
            set => _nombre = value;
        }

        public float Dimensiones
        {
            get => _dimensiones;
            set => _dimensiones = value;
        }
    }
}

using System;

namespace Taller_Mecanico
{
    public class Vehiculo
    {
        private string _matricula;
        private string _modelo;
        private string _marca;
        private int _año;
        protected DateTime _ultimo_mantenimiento;
        protected DateTime _proximo_mantenimiento;
        private int _cedula = 0;
        private string _color;
        
        public DateTime UltimoMantenimiento1
        {
            get => _ultimo_mantenimiento;
            set => _ultimo_mantenimiento = value;
        }

        public DateTime ProximoMantenimiento1
        {
            get => _proximo_mantenimiento;
            set => _proximo_mantenimiento = value;
        }

        public string Matricula
        {
            get => _matricula;
            set => _matricula = value;
        }

        public string Modelo
        {
            get => _modelo;
            set => _modelo = value;
        }

        public string Marca
        {
            get => _marca;
            set => _marca = value;
        }

        public int Año
        {
            get => _año;
            set => _año = value;
        }

        public virtual DateTime UltimoMantenimiento
        {
            get => _ultimo_mantenimiento;
            set
            {
                _ultimo_mantenimiento = value; 
                _proximo_mantenimiento = value.AddMonths(5);
            }
        }

        public Vehiculo(string matricula, string modelo, string marca, int año)
        {
            _matricula = matricula;
            _modelo = modelo;
            _marca = marca;
            _año = año;
        }

        public DateTime ProximoMantenimiento
        {
            get => _proximo_mantenimiento;
            set => _proximo_mantenimiento = value;
        }

        public int Cedula
        {
            get => _cedula;
            set => _cedula = value;
        }

        public Vehiculo(string matricula, string modelo, string marca, int año, DateTime ultimoMantenimiento, DateTime proximoMantenimiento, int cedula)
        {
            _matricula = matricula;
            _modelo = modelo;
            _marca = marca;
            _año = año;
            _ultimo_mantenimiento = ultimoMantenimiento;
            _proximo_mantenimiento = proximoMantenimiento;
            _cedula = cedula;
        }

        public Vehiculo(string matricula, string modelo, string marca, int año, DateTime ultimoMantenimiento, DateTime proximoMantenimiento)
        {
            _matricula = matricula;
            _modelo = modelo;
            _marca = marca;
            _año = año;
            _ultimo_mantenimiento = ultimoMantenimiento;
            _proximo_mantenimiento = proximoMantenimiento;
        }

        public string Color
        {
            get => _color;
            set => _color = value;
        }

        public Vehiculo(string matricula, string modelo, string marca, int año, DateTime ultimoMantenimiento, DateTime proximoMantenimiento, int cedula, string color)
        {
            _matricula = matricula;
            _modelo = modelo;
            _marca = marca;
            _año = año;
            _ultimo_mantenimiento = ultimoMantenimiento;
            _proximo_mantenimiento = proximoMantenimiento;
            _cedula = cedula;
            _color = color;
        }

        public Vehiculo(string matricula, string modelo, string marca, int año, DateTime ultimoMantenimiento, DateTime proximoMantenimiento, string color)
        {
            _matricula = matricula;
            _modelo = modelo;
            _marca = marca;
            _año = año;
            _ultimo_mantenimiento = ultimoMantenimiento;
            _proximo_mantenimiento = proximoMantenimiento;
            _color = color;
        }

        public override string ToString()
        {
            return $"{nameof(_matricula)}: {_matricula}, {nameof(_modelo)}: {_modelo}, {nameof(_marca)}: {_marca}, {nameof(_año)}: {_año}, {nameof(_ultimo_mantenimiento)}: {_ultimo_mantenimiento}, {nameof(_proximo_mantenimiento)}: {_proximo_mantenimiento}, {nameof(_cedula)}: {_cedula}, {nameof(_color)}: {_color}, {nameof(UltimoMantenimiento1)}: {UltimoMantenimiento1}, {nameof(ProximoMantenimiento1)}: {ProximoMantenimiento1}, {nameof(Matricula)}: {Matricula}, {nameof(Modelo)}: {Modelo}, {nameof(Marca)}: {Marca}, {nameof(Año)}: {Año}, {nameof(UltimoMantenimiento)}: {UltimoMantenimiento}, {nameof(ProximoMantenimiento)}: {ProximoMantenimiento}, {nameof(Cedula)}: {Cedula}, {nameof(Color)}: {Color}";
        }
    }
}
using System;

namespace Taller_Mecanico
{
    public class VehiculoAntiguo : Vehiculo
    {
        public VehiculoAntiguo(string matricula, string modelo, string marca, int año, DateTime ultimoMantenimiento, DateTime proximoMantenimiento, int cedula) : base(matricula, modelo, marca, año, ultimoMantenimiento, proximoMantenimiento, cedula)
        {
        }

        public VehiculoAntiguo(string matricula, string modelo, string marca, int año, DateTime ultimoMantenimiento,
            DateTime proximoMantenimiento) : base(matricula, modelo, marca, año, ultimoMantenimiento,
            proximoMantenimiento)
        {
        }

        public override DateTime UltimoMantenimiento
        {
            get => _ultimo_mantenimiento;
            set
            {
                _ultimo_mantenimiento = value;
                _proximo_mantenimiento = value.AddMonths(2);
            }
        }
    }
}
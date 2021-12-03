using System;

namespace Obligatorio.Clases.Agenda
{
    public class Tratamiento : Consulta
    {
        

        public override string getTipo()
        {
            return TiposConsultas.Tratamiento;
        }

        public Tratamiento(int costo, string descripcion, DateTime fecha, string cedulaFuncionario, string cedulaMascotra, string cedulaDueño, bool pagada = false) : base(costo, descripcion, fecha, cedulaFuncionario, cedulaMascotra, cedulaDueño, pagada)
        {
        }
    }
}
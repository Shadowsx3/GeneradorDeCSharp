using System;

namespace Obligatorio.Clases.Agenda
{
    public class Intervencion : Consulta
    {
        
        public override string getTipo()
        {
            return TiposConsultas.Intervencion;
        }

        public Intervencion(int costo, string descripcion, DateTime fecha, string cedulaFuncionario, string cedulaMascotra, string cedulaDueño, bool pagada = false) : base(costo, descripcion, fecha, cedulaFuncionario, cedulaMascotra, cedulaDueño, pagada)
        {
        }
    }
}
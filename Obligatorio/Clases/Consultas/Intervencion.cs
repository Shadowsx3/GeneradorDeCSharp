using System;

namespace Obligatorio.Clases.Consultas
{
    public class Intervencion : Consulta
    {
        public Intervencion(int costo, string descripcion, DateTime fecha, int cedulaFuncionario, bool pagada = false) : base(costo, descripcion, fecha, cedulaFuncionario, pagada)
        {
        }
        public override string getTipo()
        {
            return TiposConsultas.Intervencion;
        }
    }
}
using System;

namespace Obligatorio.Clases.Consultas
{
    public class Consultas : Consulta
    {
        public Consultas(int costo, string descripcion, DateTime fecha, int cedulaFuncionario, bool pagada = false) : base(costo, descripcion, fecha, cedulaFuncionario, pagada)
        {
        }
        public override string getTipo()
        {
            return TiposConsultas.Consulta;
        }
    }
}
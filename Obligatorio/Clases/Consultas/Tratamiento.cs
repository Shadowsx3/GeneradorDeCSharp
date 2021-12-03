using System;

namespace Obligatorio.Clases.Consultas
{
    public class Tratamiento : Consulta
    {
        public Tratamiento(int costo, string descripcion, DateTime fecha, int cedulaFuncionario, bool pagada = false) : base(costo, descripcion, fecha, cedulaFuncionario, pagada)
        {
        }

        public override string getTipo()
        {
            return TiposConsultas.Tratamiento;
        }
        
    }
}
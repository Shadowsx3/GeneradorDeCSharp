namespace Obligatorio.Clases.Empleados
{
    public static class TiposFuncionarios
    {
        public const string Tratamiento = "Tratamiento";
        public const string Intervencion = "Intervencion";
        public const string Consulta = "Consulta";
        public const string Todo = "Todo";
        public const string Nada = "Nada";

        public static readonly string[] Todos = new[]
        {
            TiposFuncionarios.Consulta,
            TiposFuncionarios.Intervencion,
            TiposFuncionarios.Tratamiento
        };
    }
}
namespace Obligatorio.Clases.Agenda
{
    public static class TiposConsultas
    {
        public const string Tratamiento = "Tratamiento";
        public const string Intervencion = "Intervencion";
        public const string Consulta = "Consulta";
        public static readonly string[] Todos = new[]
        {
            Consulta,
            Intervencion,
            Tratamiento
        };
    }
}
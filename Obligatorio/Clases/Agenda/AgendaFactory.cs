using System;
using System.Linq;
using Obligatorio.Clases.Animales;

namespace Obligatorio.Clases.Agenda
{
    public static class AgendaFactory
    {
        public static IConsulta AgendarConsulta(Dueño d, IMascota m, string tipo, DateTime fecha, string funcionario)
        {
            IConsulta consulta = null;
            try
            {
                switch (m.getEspecie())
                {
                    case TiposMascotas.Gato:
                        switch (tipo)
                        {
                            case TiposConsultas.Consulta:
                                consulta = new Consulta(1000, "Consulta generica para gatos", fecha, funcionario,
                                    m.getCedula(), d.Cedula);
                                break;
                            case TiposConsultas.Intervencion:
                                consulta = new Consulta(3000, "Consulta tratamiento para gatos", fecha, funcionario,
                                    m.getCedula(), d.Cedula);
                                break;
                            case TiposConsultas.Tratamiento:
                                consulta = new Consulta(4000, "Consulta de intervencion", fecha, funcionario,
                                    m.getCedula(), d.Cedula);
                                break;
                        }
                        break;
                    case TiposMascotas.Perro:
                        switch (tipo)
                        {
                            case TiposConsultas.Consulta:
                                consulta = new Consulta(1000, "Consulta generica para perros", fecha, funcionario,
                                    m.getCedula(), d.Cedula);
                                break;
                            case TiposConsultas.Intervencion:
                                consulta = new Consulta(3000, "Consulta tratamiento para perritos", fecha, funcionario,
                                    m.getCedula(), d.Cedula);
                                break;
                            case TiposConsultas.Tratamiento:
                                consulta = new Consulta(4000, "Consulta de intervencion", fecha, funcionario,
                                    m.getCedula(), d.Cedula);
                                break;
                        }
                        break;
                    case TiposMascotas.Rata:
                        switch (tipo)
                        {
                            case TiposConsultas.Consulta:
                                consulta = new Consulta(1000, "Consulta generica para ratitas", fecha, funcionario,
                                    m.getCedula(), d.Cedula);
                                break;
                            case TiposConsultas.Intervencion:
                                consulta = new Consulta(3000, "Consulta tratamiento para ratotas", fecha, funcionario,
                                    m.getCedula(), d.Cedula);
                                break;
                            case TiposConsultas.Tratamiento:
                                consulta = new Consulta(4000, "Consulta de intervencion ratificada", fecha, funcionario,
                                    m.getCedula(), d.Cedula);
                                break;
                        }
                        break;
                }
            }
            catch
            {
                Console.WriteLine("Mascota no encontrada");
            }
            return consulta;
        }
    }
}
using System.Collections.Generic;
using Obligatorio.Clases.Agenda;
using Obligatorio.Clases.Animales;

namespace Obligatorio.Clases.Empleados
{
    public static class FuncionarioFactory
    {
        private static int lastid = 0;
        public static Funcionario CreateFuncionario(string tipo, string nombre)
        {
            Funcionario fun = null;
            switch (tipo)
            {
                case TiposFuncionarios.Consulta:
                    fun = new Funcionario(nombre, lastid.ToString(), new List<string>(){TiposConsultas.Consulta});
                    break;
                case TiposFuncionarios.Intervencion:
                    fun = new Funcionario(nombre, lastid.ToString(), new List<string>(){TiposConsultas.Intervencion});
                    break;
                case TiposFuncionarios.Tratamiento:
                    fun = new Funcionario(nombre, lastid.ToString(), new List<string>(){TiposConsultas.Tratamiento});
                    break;
                case TiposFuncionarios.Nada:
                    fun = new Funcionario(nombre, lastid.ToString(), new List<string>());
                    break;
                case TiposFuncionarios.Todo:
                    fun = new Funcionario(nombre, lastid.ToString(), new List<string>(){TiposConsultas.Consulta,TiposConsultas.Intervencion,TiposConsultas.Tratamiento});
                    break;
                default:
                    lastid -= 1;
                    break;
            }
            lastid += 1;
            return fun;
        }
    }
}
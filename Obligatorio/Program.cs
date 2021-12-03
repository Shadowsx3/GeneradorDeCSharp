using System;
using System.Collections.Generic;
using System.Linq;
using Obligatorio.Clases;
using Obligatorio.Clases.Agenda;
using Obligatorio.Clases.Animales;
using Obligatorio.Clases.Empleados;
using Obligatorio.Clases.Patrones;

namespace Obligatorio
{
    internal class Program
    {
        private static string[] _opciones = new[] {
            "Listar funcionarios",
            "Listar dueños",
            "Listar mascotas del dueño",
            "Seleccionar funcionario",
            "Seleccionar dueño",
            "Seleccionar mascota",
            "Listar consultas del funcionario",
            "Buscar funcionarios por especialidad",
            "Listar deudas de un dueño",
            "Listar deudas de la mascota",
            "Agendar consulta",
            "Pagar consulta"
        };
        private static string cedulaFuncionario = "1";
        private static string cedulaDueño = "1";
        private static string cedulaMascota = "1";
        public static void Main(string[] args)
        {
            #region "Inicio"
            List<IMascota> lm = new List<IMascota>()
            {
                MascotaFactory.CreateMascota(TiposMascotas.Gato, "Juan", "IDK"),
                MascotaFactory.CreateMascota(TiposMascotas.Perro, "Jan", "IDK"),
                MascotaFactory.CreateMascota(TiposMascotas.Rata, "Jun", "IDK")
            };
            List<IMascota> lm2 = new List<IMascota>(){
                MascotaFactory.CreateMascota(TiposMascotas.Gato,"Pancho","IDK"),
                MascotaFactory.CreateMascota(TiposMascotas.Gato,"Titi","IDK"),
                MascotaFactory.CreateMascota(TiposMascotas.Rata,"Lola","IDK")
            };
            Dueño d = new Dueño("1", "Pedro");
            d.AgregarMascotas(lm);
            Dueño d1 = new Dueño("2", "Pedro1");
            d1.AgregarMascotas(lm2);
            Administrador.GetInstance().Dueños = new List<Dueño>() {d, d1};
            Funcionario f = FuncionarioFactory.CreateFuncionario(TiposFuncionarios.Todo,"LOLO");
            Funcionario f1 = FuncionarioFactory.CreateFuncionario(TiposFuncionarios.Consulta,"LOLa");
            Administrador.GetInstance().Funcionarios = new List<Funcionario>() {f, f1};
            #endregion
            Console.WriteLine("Welcome a la veterinaria vet");
            while (true)
            {
                try
                {
                    Console.WriteLine(
                        $"Funcionario: {cedulaFuncionario} - Dueño: {cedulaDueño} - Mascota: {cedulaMascota}");
                    Console.WriteLine("Que desea hacer?");
                    for (int i = 0; i < _opciones.Length; i++)
                    {
                        Console.WriteLine($"{i}){_opciones[i]}");
                    }

                    string opcion = Console.ReadLine();
                    string cedula;
                    switch (opcion)
                    {
                        case "0":
                            Administrador.GetInstance().MostrarFuncionarios();
                            break;
                        case "1":
                            Administrador.GetInstance().MostrarDueños();
                            break;
                        case "2":
                            if (cedulaDueño == "")
                            {
                                Console.WriteLine("Seleccione un dueño primero");
                                break;
                            }

                            Administrador.GetInstance().MostrarMascotas(cedulaDueño);
                            break;
                        case "3":
                            Console.WriteLine("Ingrese la cedula del funcionario");
                            cedula = Console.ReadLine();
                            try
                            {
                                cedulaFuncionario = Administrador.GetInstance().Funcionarios
                                    .First(x => x.Cedula == cedula)
                                    .Cedula;
                            }
                            catch
                            {
                                Console.WriteLine("Cedula no encontrada");
                            }

                            break;
                        case "4":
                            Console.WriteLine("Ingrese la cedula del dueño");
                            cedula = Console.ReadLine();
                            try
                            {
                                cedulaDueño = Administrador.GetInstance().Dueños.First(x => x.Cedula == cedula)
                                    .Cedula;
                            }
                            catch
                            {
                                Console.WriteLine("Cedula no encontrada");
                            }

                            break;
                        case "5":
                            if (cedulaDueño == "")
                            {
                                Console.WriteLine("Seleccione un dueño primero");
                                break;
                            }

                            Console.WriteLine("Ingrese la cedula de la mascota");
                            cedula = Console.ReadLine();
                            try
                            {
                                cedulaMascota = Administrador.GetInstance()
                                    .Dueños
                                    .First(x => x.Cedula == cedulaDueño)
                                    .Mascotas.First(x => x.getCedula() == cedula)
                                    .getCedula();
                            }
                            catch
                            {
                                Console.WriteLine("Cedula no encontrada");
                            }

                            break;
                        case "6":
                            if (cedulaFuncionario == "")
                            {
                                Console.WriteLine("Seleccione un funcionario primero");
                                break;
                            }

                            Administrador.GetInstance().MostrarConsultas(cedulaFuncionario);
                            break;
                        case "7":
                            Console.WriteLine("Que tipo de funcion busca?");
                            for (int i = 0; i < TiposFuncionarios.Todos.Length; i++)
                            {
                                Console.WriteLine($"{i}){TiposFuncionarios.Todos[i]}");
                            }

                            if (!Int32.TryParse(Console.ReadLine(), out var opciones))
                            {
                                Console.WriteLine("La entrada no es valida");
                                break;
                            }

                            Administrador.GetInstance().BuscarFuncionario(TiposFuncionarios.Todos[opciones]);
                            break;
                        case "8":
                            if (cedulaDueño == "")
                            {
                                Console.WriteLine("Seleccione un dueño primero");
                                break;
                            }

                            Administrador.GetInstance().DeudasDueño(cedulaDueño);
                            break;
                        case "9":
                            if (cedulaMascota == "")
                            {
                                Console.WriteLine("Seleccione una mascota primero");
                                break;
                            }

                            Administrador.GetInstance().DeudasMascota(cedulaMascota);
                            break;
                        case "10":
                            if (cedulaMascota == "" || cedulaDueño == "" || cedulaFuncionario == "")
                            {
                                Console.WriteLine("Seleccione las cedulas primero");
                                break;
                            }

                            Console.WriteLine("Ingrese la fecha en formado dia/mes/año");
                            DateTime fecha = DateTime.Parse(Console.ReadLine());
                            Console.WriteLine("Que tipo de funcion de consulta es?");
                            for (var i = 0; i < TiposConsultas.Todos.Length; i++)
                            {
                                Console.WriteLine($"{i}){TiposConsultas.Todos[i]}");
                            }

                            if (!int.TryParse(Console.ReadLine(), out var op))
                            {
                                Console.WriteLine("La entrada no es valida");
                                break;
                            }

                            string tipo = TiposConsultas.Todos[op];
                            Console.WriteLine("Cuantas consultas son?");
                            int.TryParse(Console.ReadLine(), out var cantidad);
                            Console.WriteLine("Cada cuantos dias?");
                            int.TryParse(Console.ReadLine(), out var cantidadDias);
                            TimeSpan ts = new TimeSpan(cantidadDias, 0, 0, 0);
                            Administrador.GetInstance().AgendarConsultas(cedulaDueño, cedulaMascota, tipo,
                                cedulaFuncionario, cantidad, fecha, ts);
                            break;
                        case "11":
                            if (cedulaDueño == "")
                            {
                                Console.WriteLine("Seleccione un dueño primero");
                                break;
                            }

                            Console.WriteLine("Ingrese el numero de la consulta");
                            int.TryParse(Console.ReadLine(), out var numeroConsulta);
                            Administrador.GetInstance().PagarConsulta(numeroConsulta, cedulaDueño);
                            break;
                        default:
                            Console.WriteLine("Opcion no encontrada");
                            break;
                    }

                    Console.WriteLine("Enter para continuar");
                    Console.ReadLine();
                }
                catch
                {
                    Console.WriteLine("Error con el dato ingresado");
                }
            }
        }
    }
}
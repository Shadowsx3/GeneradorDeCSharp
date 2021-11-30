using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Taller_Mecanico
{
    class Program
    {
        static string linea = "----------------------------------------------";
        public static void print(string cadena)
        {
            Console.WriteLine(cadena);
        }
        public static string input(string Pregunta)
        {
            print(Pregunta);
            return Console.ReadLine();
        }

        public static string key(string opciones, bool limpiar = false)
        {
            if (limpiar)
            {
                Console.Clear();
            }

            print(opciones);
            print("Presione la opcion que desea usar");
            return $"{Console.ReadKey(true).KeyChar}";
        }

        public static bool ListarCliente(int cedula, List<Cliente> Clientes)
        {
            foreach (Cliente c in Clientes)
            {
                if (c.Cedula == cedula)
                {
                    print(c.ToString());
                    return true;
                }
            }
            print("No se encontró el cliente");
            return false;
        }

        public static void ListarVehiculosC(int cedula, List<Cliente> Clientes, List<Vehiculo> Vehiculos)
        {
            if (ListarCliente(cedula, Clientes))
            {
                foreach (Vehiculo v in Vehiculos)
                {
                    if (v.Cedula == cedula)
                    {
                        print(v.ToString());
                    }
                }
            }
        }
        public static void ListarClientes(List<Cliente> Clientes)
        {
            foreach (Cliente c in Clientes)
            {
                print(linea);
                print(c.ToString());
                print(linea);
            }
        }
        public static void ListarVehiculos(List<Vehiculo> Vehiculos)
        {
            foreach (Vehiculo v in Vehiculos)
            {
                print(linea);
                print(v.ToString());
                print(linea);
            }
        }
        public static void IngresarCliente(List<Cliente> Clientes)
        {
            try
            {
                int cedula = 0;
                while (cedula == 0)
                {
                    cedula = Convert.ToInt32(input("Ingrese su cedula"));
                    foreach (Cliente c in Clientes)
                    {
                        if (cedula == c.Cedula)
                        {
                            cedula = 0;
                            print("La cedula ingresada ya está usada");
                            break;
                        }
                    }
                }

                string nombre = input("Ingrese su nombre");
                string apellido = input("Ingrese su apellido");
                Clientes.Add(new Cliente(cedula, nombre, apellido));
            }
            catch (Exception ex)
            {
                input("Dato erroneo, presione enter para continuar");
                IngresarCliente(Clientes);
            }

        }
        public static void IngresarVehiculo(List<Vehiculo> Vehiculos)
        {
            try
            {
                string matricula = "";
                while (matricula == "")
                {
                    matricula = (input("Ingrese la matricula"));
                    foreach (Vehiculo v in Vehiculos)
                    {
                        if (matricula == v.Matricula)
                        {
                            matricula = "";
                            print("La matricula ingresada ya está usada");
                            break;
                        }
                    }
                }
                string modelo = input("Ingrese el modelo");
                string marca = input("Ingrese la marca");
                int año = Convert.ToInt32(input("Ingrese el año del vehiculo"));
                Vehiculos.Add(new Vehiculo(matricula, modelo, marca, año));
            }
            catch (Exception ex)
            {
                input("Dato erroneo, presione enter para continuar");
                IngresarVehiculo(Vehiculos);
            }

        }

        public static void AsociarVehiculo(int cedula, string matricula, List<Cliente> Clientes, List<Vehiculo> Vehiculos)
        {
            bool continuar = false;
            foreach (Cliente c in Clientes)
            {
                if (c.Cedula == cedula)
                {
                    continuar = true;
                    break;
                }
            }
            if (continuar)
            {
                foreach (Vehiculo v in Vehiculos)
                {
                    if (v.Matricula == matricula)
                    {
                        v.Cedula = cedula;
                        print("Asociado correctamente");
                        return;
                    }
                }
                print("Error, matricula no encontrada");
            }
            else
            {
                print("No se encontró el cliente");
            }
        }

        public static void ModificarMantenimiento(string matricula,List<Vehiculo> Vehiculos)
        {
            try
            {
                foreach (Vehiculo v in Vehiculos)
                {
                        if (v.Matricula == matricula)
                        {
                            DateTime fecha =
                                Convert.ToDateTime(input("Ingrese la fecha del mantenimiento en formato dia/mes/año"));
                            v.UltimoMantenimiento = fecha;
                            //En la clase vehiculo se hara sola la asignacion del proximo matenimiento
                            return;
                        }
                }
                print("Matricula no encontrada");
            }
            catch
            {   
                print("Error al ingresar");
                ModificarMantenimiento(matricula, Vehiculos);
            }
        }
        static void Main(string[] args)
        {
            List<Cliente> Clientes = new List<Cliente>();
            List<Vehiculo> Vehiculos = new List<Vehiculo>();
            print("Bienvenido al sistema de gestion del taller");
            int cliente = 0;
            string clientei = "";
            string vehiculo = "";
            string vehiculoi = "";
            while (true)
            {
                string tecla = key($"Cliente seleccionado: {clientei} - Vehiculo seleccionado: {vehiculoi}\n" +
                                   "a-Ingresar Cliente\n" +
                                   "b-Ingresar Vehiculo\n" +
                                   "c-Listar Clientes\n" +
                                   "d-Listar Vehiculos\n" +
                                   "e-Seleccionar Cliente\n" +
                                   "f-Seleccionar Vehiculo\n" +
                                   "g-Mostrar vehiculos del cliente\n" +
                                   "h-Asociar vehiculo a cliente\n" +
                                   "i-Actualizar mantenimiento");
                switch (tecla)
                {
                    case "a":
                        IngresarCliente(Clientes);
                        break;
                    case "b":
                        IngresarVehiculo(Vehiculos);
                        break;
                    case "c":
                        ListarClientes(Clientes);
                        break;
                    case "d":
                        ListarVehiculos(Vehiculos);
                        break;
                    case "e":
                        try
                        {
                            int cedula = Convert.ToInt32(input("Ingrese la cedula del cliente"));
                            foreach (Cliente c in Clientes)
                            {
                                if (c.Cedula == cedula)
                                {
                                    cliente = cedula;
                                    clientei = $"{c.Nombre} {c.Apellido}";
                                    break;
                                }
                            }

                            if (cliente == 0)
                            {
                                print("Cedula no registrada aun");
                            }
                        }
                        catch (Exception en)
                        {
                            print("Cedula incorrecta");
                        }

                        break;
                    case "f":
                        try
                        {
                            string matricula = input("Ingrese la matricula del vehiculo");
                            foreach (Vehiculo v in Vehiculos)
                            {
                                if (v.Matricula == matricula)
                                {
                                    vehiculo = matricula;
                                    vehiculoi = $"Matricula:{v.Matricula} {v.Marca} {v.Modelo}";
                                    break;
                                }
                            }

                            if (vehiculo == "")
                            {
                                print("Matricula no registrada aun");
                            }
                        }
                        catch (Exception en)
                        {
                            print("Matricula incorrecta");
                        }

                        break;
                    case "g":
                        if (cliente == 0)
                        {
                            print("Seleccione un cliente");
                        }
                        else
                        {
                            ListarVehiculosC(cliente, Clientes, Vehiculos);
                        }

                        break;
                    case "h":
                        if (cliente == 0)
                        {
                            print("Seleccione un cliente");
                        }
                        else
                        {
                            if (vehiculo == "")
                            {
                                print("Seleccione un vehiculo");
                            }
                            else
                            {
                                AsociarVehiculo(cliente, vehiculo, Clientes, Vehiculos);
                            }
                        }

                        break;
                    case "i":
                        ModificarMantenimiento(vehiculo, Vehiculos);
                        break;
                }

                input("Presione enter para continuar");
            }
        }
    }
}

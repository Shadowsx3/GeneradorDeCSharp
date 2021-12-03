using System;
using System.Collections.Generic;
using System.Linq;
using Obligatorio.Clases.Agenda;
using Obligatorio.Clases.Animales;
using Obligatorio.Clases.Empleados;

namespace Obligatorio.Clases.Patrones
{
    public sealed class Administrador
    {
        private Administrador()
        {
            _funcionarios = new List<Funcionario>();
            _dueños = new List<Dueño>();
            _consultas = new List<IConsulta>();
        }
        private static Administrador _instance;
        public static Administrador GetInstance()
        {
            return _instance ?? (_instance = new Administrador());
        }
        
        private AgendaFactory _af = new AgendaFactory();
        private List<Funcionario> _funcionarios;
        private List<Dueño> _dueños;
        private List<IConsulta> _consultas;

        public List<IConsulta> Consultas
        {
            get => _consultas;
            set => _consultas = value;
        }

        public List<Funcionario> Funcionarios
        {
            get => _funcionarios;
            set => _funcionarios = value;
        }

        public List<Dueño> Dueños
        {
            get => _dueños;
            set => _dueños = value;
        }

        public void ImprimirConsultasD(string cedulaDueño)
        {
            Console.WriteLine($"Funcionario: {_dueños.First(x => x.Cedula == cedulaDueño).Nombre}");
            foreach (var c in _consultas.Where(x => x.CedulaDueño() == cedulaDueño))
            {
                Console.WriteLine($"\tConsulta: {c.Descripcion()}");
                Console.WriteLine($"\t\tDueño de mascota: {_dueños.First(x => x.Cedula == c.CedulaDueño()).Nombre}");
                Console.WriteLine($"\t\tNombre de la mascota: {_dueños.First(x => x.Cedula == c.CedulaDueño()).Mascotas.First(x => x.getCedula() == c.CedulaMascotra()).getNombre()}");
                Console.WriteLine($"\t\tFecha: {c.Fecha()}");
                Console.WriteLine($"\t\tCosto: {c.Costo()}");
                Console.WriteLine($"\t\tPagada: {c.Pagada()}");
            }
        }
        public void PagarConsulta(int idConsulta, string cedulaDueño)
        {
            List<IConsulta> c = _consultas.Where(x => x.CedulaDueño() == cedulaDueño).ToList();
            if (c.Count < idConsulta)
            {
                Console.WriteLine("No existe esa consulta");
                return;
            }

            var pagada = _consultas.First(x => x == c[idConsulta]).Pagada();
            _consultas.First(x => x == c[idConsulta]).setPagada(true);
        }
        public void AgendarConsultas(string cedulaDueño, string cedulaMascota, string tipo, string cedulaFuncionario, int cantidad, DateTime fechaInicial, TimeSpan tiempoEntreConsultas)
        {
            try
            {
                Dueño d = _dueños.First(x => x.Cedula == cedulaDueño);
                IMascota m = d.Mascotas.First(x => x.getCedula() == cedulaMascota);
                Funcionario f = _funcionarios.First(x => x.Cedula == cedulaFuncionario);
                if (!f.Funciones.Contains(tipo))
                {
                    Console.WriteLine("El funcionario no esta capacitado para esta tarea");
                    return;
                }
                DateTime fecha = fechaInicial;
                for (var i = 0; i < cantidad; i++)
                {
                    _consultas.Add(_af.AgendarConsulta(d, m, tipo, fecha, f.Cedula ));
                    fecha = fecha.Add(tiempoEntreConsultas);
                }
            }
            catch
            {
                Console.WriteLine("Cedulas no encontradas");
            }
        }
        public void MostrarFuncionarios()
        {
            foreach (var f in _funcionarios)
            {
                Console.WriteLine($"Funcionario: {f.Nombre} - Cedula: {f.Cedula}");
                Console.WriteLine($"\tFunciones:");
                foreach (var fun in f.Funciones)
                {
                    Console.WriteLine($"\t-{fun}");
                }
            }
        }
        public void MostrarDueños()
        {
            foreach (var f in _dueños)
            {
                Console.WriteLine($"Dueño: {f.Nombre} - Cedula: {f.Cedula}");
            }
        }
        
        public void MostrarMascotas(string cedulaDueño)
        {
            Dueño d = _dueños.Find(x => x.Cedula == cedulaDueño);
            Console.WriteLine($"Mascotas:");
            foreach (var fun in d.Mascotas)
            {
                Console.WriteLine($"\t-{fun.getNombre()} - Especie: {fun.getEspecie()} - Cedula: {fun.getCedula()}");
            }
        }
        public void MostrarConsultas(string cedulaFun)
        {
            Console.WriteLine($"Funcionario: {_funcionarios.First(x => x.Cedula == cedulaFun).Nombre}");
            foreach (var c in _consultas.Where(x => x.CedulaFuncionario() == cedulaFun))
            {
                Console.WriteLine($"\tConsulta: {c.Descripcion()}");
                Console.WriteLine($"\t\tDueño de mascota: {_dueños.First(x => x.Cedula == c.CedulaDueño()).Nombre}");
                Console.WriteLine($"\t\tNombre de la mascota: {_dueños.First(x => x.Cedula == c.CedulaDueño()).Mascotas.First(x => x.getCedula() == c.CedulaMascotra()).getNombre()}");
                Console.WriteLine($"\t\tFecha: {c.Fecha()}");
                Console.WriteLine($"\t\tCosto: {c.Costo()}");
                Console.WriteLine($"\t\tPagada: {c.Pagada()}");
            }
        }
        public void BuscarFuncionario(string especialidad)
        {
            foreach (var c in _funcionarios.Where(x => x.Funciones.Contains(especialidad)))
            {
                Console.WriteLine($"Funcionario: {c.Nombre}");
            }
        }
        public void DeudasDueño(string cedulaDueño)
        {
            var dueño = _dueños.First(x => x.Cedula == cedulaDueño);
            foreach (var m in _consultas.Where(x => x.CedulaDueño() == cedulaDueño))
            {
                if (m.Pagada())
                {
                    continue;
                }
                Console.WriteLine($"Consulta: {m.Descripcion()}");
                Console.WriteLine($"\tCosto: {m.Costo()}");
                Console.WriteLine($"\tNombre mascota: {dueño.Mascotas.First(x => x.getCedula() == m.CedulaMascotra()).getNombre()}");
            }
        }
        public void DeudasMascota(string cedulaMascota)
        {
            foreach (var m in _consultas.Where(x => x.CedulaMascotra() == cedulaMascota))
            {
                if (m.Pagada())
                {
                    continue;
                }
                Console.WriteLine($"Consulta: {m.Descripcion()}");
                Console.WriteLine($"\tCosto: {m.Costo()}");
                
            }
        }
    }
}
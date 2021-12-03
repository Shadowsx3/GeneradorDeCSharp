using System;
using System.Collections.Generic;
using System.Linq;
using Obligatorio.Clases.Consultas;

namespace Obligatorio.Clases.Patrones
{
    public sealed class Administrador
    {
        private Administrador()
        {
        }
        private static Administrador _instance;
        public Administrador getInstance()
        {
            if (_instance == null)
            {
                _instance = new Administrador();
            }
            return _instance;
        }

        private List<Funcionario> _funcionarios;
        private List<Dueño> _dueños;
        private List<Consulta> _consultas;

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


        public void MostrarFuncionarios()
        {
            foreach (var f in _funcionarios)
            {
                Console.WriteLine($"Funcionario: {f.Nombre} - Cedula: {f.Cedula}");
                Console.WriteLine($"Funciones:");
                foreach (var fun in f.Funciones)
                {
                    Console.WriteLine($"\t-{fun}");
                }
            }
        }
        public void MostrarConsultas(string _cedulaFun)
        {
            Console.WriteLine($"Funcionario: {_funcionarios.First(x => x.Cedula == _cedulaFun).Nombre}");
            foreach (var c in _consultas.Where(x => x.CedulaFuncionario == _cedulaFun))
            {
                Console.WriteLine($"Consulta: {c.Descripcion}");
                Console.WriteLine($"Dueño de mascota: {_dueños.First(x => x.Cedula == c.CedulaDueño).Nombre}");
                Console.WriteLine($"Nombre de la mascota: {_dueños.First(x => x.Cedula == c.CedulaDueño).Mascotas.First(x => x.Cedula == c.CedulaMascotra).Nombre}");
                Console.WriteLine($"Fecha: {c.Fecha}");
                Console.WriteLine($"Costo: {c.Costo}");
            }
        }
        public void BuscarFuncionario(string especialidad)
        {
            foreach (var c in _funcionarios.Where(x => x.Funciones.Contains(especialidad)))
            {
                Console.WriteLine($"Funcionario: {c.Nombre}");
            }
        }
        public void BuscarMascotasDueño(string cedulaDueño)
        {
            var dueño = _dueños.First(x => x.Cedula == cedulaDueño);
            foreach (var m in dueño.Mascotas)
            {
                Console.WriteLine($"Nombre: {m.Nombre}");
                Console.WriteLine($"Especie: {m.getEspecie()}");
                Console.WriteLine($"Raza: {m.Raza}");
            }
        }
        public void DeudasDueño(string cedulaDueño)
        {
            var dueño = _dueños.First(x => x.Cedula == cedulaDueño);
            foreach (var m in _consultas.Where(x => x.CedulaDueño == cedulaDueño))
            {
                if (m.Pagada)
                {
                    continue;
                }
                Console.WriteLine($"Costo: {m.Costo}");
                Console.WriteLine($"Nombre mascota: {dueño.Mascotas.First(x => x.Cedula == m.CedulaMascotra).Nombre}");
            }
        }
    }
}
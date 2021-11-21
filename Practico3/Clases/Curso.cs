using System;
using System.Collections.Generic;

namespace Practico3.Clases
{
    class Curso
    {
        private Docente _titular;
        private WebAsignatura _web;
        private List<Alumno> _listAlumnos;

        public Curso(Docente titular, WebAsignatura web, List<Alumno> listAlumnos)
        {
            _titular = titular;
            _web = web;
            _listAlumnos = listAlumnos;
        }

        public Docente Titular
        {
            get => _titular;
            set => _titular = value;
        }

        public WebAsignatura Web => _web;

        public List<Alumno> ListAlumnos 
        { 
            get => _listAlumnos;
            set => _listAlumnos = value;
        }
        public void ListarPersonas(){
            Console.WriteLine("Alumnos:");
            foreach(Alumno a in _listAlumnos){
                Console.WriteLine(a.apellido);
            }
            Console.WriteLine("Docente:");
            Console.WriteLine(_titular.apellido);
        }

        public void AgregarTarea(Tarea t, Docente d)
        {
            if (d == _titular)
            {
                _web.AgregarTarea(t);
            }
            else
            {
                Console.WriteLine("Solo el docente titular puede hacer eso");
            }
        }
        public Tarea CopiarTarea(int id)
        {
            return _web.CopiarTarea(id);
        }
        public void RealizarTarea(int id, Tarea t)
        { 
            _web.RealizarTarea(id, t);
        }

        public void ListarTareas()
        {
            _web.ListarTareas(_listAlumnos);
        }
    }
}
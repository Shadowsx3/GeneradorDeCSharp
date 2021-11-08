using System;
using System.Collections.Generic;

namespace Practico3.Clases
{
    class Curso
    {
        private Docente _titular;
        private WebAsignatura _web;
        private List<Alumno> _listAlumnos;

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
    }
}
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
    }
}
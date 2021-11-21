
using System.Collections;
using System;
using System.Collections.Generic;
namespace Practico3.Clases
{
    public class Tarea
    {
        private string _nombre;
        private string _idTarea;
        private string _contenido;
        private List<string> _respuestas;
        private List<string> _respuestasCorrectas;
        public string nombre => _nombre;
        public string idTarea => _idTarea;
        public string contenido => _contenido;
        public List<string> respuestas 
        { 
            get => _respuestas;
            set => _respuestas = value;
        }

        public Tarea(string nombre, string idTarea, string contenido, List<string> respuestasCorrectas)
        {
            _nombre = nombre;
            _idTarea = idTarea;
            _contenido = contenido;
            _respuestasCorrectas = respuestasCorrectas;
        }

        public List<string> respuestasCorrectas => _respuestasCorrectas;
    }
}
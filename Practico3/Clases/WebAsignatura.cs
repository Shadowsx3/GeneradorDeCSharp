using System;
using System.Collections.Generic;

namespace Practico3.Clases
{
    class WebAsignatura
    {
        private List<Tarea> _ListTareas = new List<Tarea>();
        public List<Tarea> getTareas => _ListTareas;

        private Dictionary<int, List<Tarea>> _tareasRealizadas = new Dictionary<int, List<Tarea>>();
        //Debe existir un método que permita al Docente agregar una Tarea a la lista de 
        // + El metodo está abajo
        //Tareas de WebAsignatura con las respuestas correctas.
        //Las respuestas están en la clase tareas -> se agrega con las "respuestas correctas"
        public void AgregarTarea(Tarea t){
            _ListTareas.Add(t);
        }

        public void ListarTareas(List<Alumno> lista)
        {
            foreach (KeyValuePair<int, List<Tarea>> entry in _tareasRealizadas)
            {
                Console.WriteLine("Tareas de:");
                lista[entry.Key].Presentarse();
                foreach (var t in entry.Value)
                {
                    Console.WriteLine("Nombre de la tarea:");
                    Console.WriteLine(t.nombre);
                }
            }
        }
        public Tarea CopiarTarea(int N){
            return _ListTareas[N];
        }

        public void RealizarTarea(int Alumno, Tarea tarea)
        {
            List<Tarea> tareas = new List<Tarea>();
            if (_tareasRealizadas.TryGetValue(Alumno, out tareas))
            {
                tareas.Add(tarea);
                _tareasRealizadas[Alumno] = tareas;
            }
            else
            {
                tareas = new List<Tarea> {tarea};
                _tareasRealizadas.Add(Alumno, tareas);
            }
        }
    }
}
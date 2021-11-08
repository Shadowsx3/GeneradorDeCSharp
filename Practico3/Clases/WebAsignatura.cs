using System.Collections.Generic;

namespace Practico3.Clases
{
    class WebAsignatura
    {
        private List<Tarea> _ListTareas;
        public List<Tarea> getTareas => _ListTareas;
        //Debe existir un método que permita al Docente agregar una Tarea a la lista de 
        // + El metodo está abajo
        //Tareas de WebAsignatura con las respuestas correctas.
        //Las respuestas están en la clase tareas -> se agrega con las "respuestas correctas"
        public void AgregarTarea(Tarea t){
            _ListTareas.Add(t);
        }
        public Tarea CopiarTarea(int N, List<string> Respuestas){
            Tarea n = _ListTareas[N];
            n.respuestas = Respuestas;
            return n;
        }
    }
}
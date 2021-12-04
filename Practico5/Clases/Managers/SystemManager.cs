using System;
using System.Collections.Generic;
using System.Linq;
using PracticoNoObligatorio.Clases.Persona;
using PracticoNoObligatorio.Clases.Tareas;

namespace PracticoNoObligatorio.Clases.Managers
{
    public sealed class SystemManager : ISystemManager
    {
        private static SystemManager _instance;
        private List<Tarea> _tareas;
        private List<IPersona> _personas;

        public List<Tarea> Tareas
        {
            get => _tareas;
            set => _tareas = value;
        }

        public List<IPersona> Personas
        {
            get => _personas;
            set => _personas = value;
        }

        public void AddPersona(IPersona persona)
        {
            _personas.Add(persona);
        }

        private SystemManager()
        {
            _tareas = new List<Tarea>();
            _personas = new List<IPersona>();
        }

        public static SystemManager GetInstance()
        {
            return _instance ?? (_instance = new SystemManager());
        }

        private void Notificar(Tarea tarea, string accion)
        {
            foreach (var p in _personas)
            {
              p.Update(tarea, accion);
            }
        }

        public void AgregarTarea(Tarea t)
        {
            try{
                Notificar(t, TiposAcciones.Nueva);
                _tareas.Add(t);
            }
            catch
            {
                Console.WriteLine("Ha ocurrido un error agregar la tarea");
            }
        }

        public void AddLPersona(List<IPersona> personas)
        {
            foreach (var p in personas)
            {
                _personas.Add(p);
            }
        }

        public Tarea GetTarea(int n)
        {
            try
            {
                return _tareas.Count < n ? throw new NumException() : _tareas[n];
            }
            catch (NumException e)
            {
                Console.WriteLine("Error con el index");
            }
            catch
            {
                Console.WriteLine("Error desconocido");
            }

            return null;
        }
        public void RealizarTarea(Tareas.Tarea tarea)
        {
            try{
                foreach (var t in _tareas.Where(t => t == tarea))
                {
                    t.Realizada = true;
                    Notificar(t, TiposAcciones.Finalizada);
                    break;
                }
            }
            catch
            {
                Console.WriteLine("Ha ocurrido un error realizando la tarea");
            }
        }

        public void AceptarTarea(Tarea tarea, Desarrollador desarrollador)
        {
            try
            {
                foreach (var t in _tareas.Where(t => t == tarea))
                {
                    t.Encargado = desarrollador;
                    break;
                }
            }
            catch
            {
                Console.WriteLine("Ha ocurrido un error aceptando la tarea");
            }
        }

        public void CambiarAprobacion(Tarea tarea, bool aprobada)
        {
            try
            {
                foreach (var t in _tareas.Where(t => t == tarea))
                {
                    t.Aprobada = aprobada;
                    Notificar(t, aprobada ? TiposAcciones.Aprobada : TiposAcciones.Rechazada);
                    break;
                }
            }
            catch
            {
                Console.WriteLine("Ha ocurrido un error aprobando la tarea");
            }
        }
    }
}
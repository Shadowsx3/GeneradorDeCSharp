using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticoNoObligatorio.Clases
{
    public class SystemManager : ISystemManager
    {
        private static SystemManager _instance;
        private static List<Tarea> _tareas = new List<Tarea>();
        private static List<IPersona> _personas = new List<IPersona>();

        public static List<Tarea> Tareas
        {
            get => _tareas;
            set => _tareas = value;
        }

        public static List<IPersona> Personas
        {
            get => _personas;
            set => _personas = value;
        }

        public void AddPersona(IPersona persona)
        {
            _personas.Add(persona);
        }
        private SystemManager(){}

        public SystemManager GetInstance()
        {
            if (_instance == null)
            {
                _instance = new SystemManager();
            }
            return _instance;
        }

        private static void Notificar(Tarea t, string accion)
        {
            foreach (var p in _personas)
            {
                p.Update(t, accion);
            }
        }

        void ISystemManager.AgregarTarea(Tarea t)
        {
            AgregarTarea(t);
        }

        void ISystemManager.Notificar(Tarea id, string accion)
        {
            Notificar(id, accion);
        }

        public static void AgregarTarea(Tarea t)
        {
            try{
                Notificar(t, "nueva tarea");
                _tareas.Add(t);
            }
            catch
            {
                Console.WriteLine("Ha ocurrido un error agregar la tarea");
            }
        }

        void ISystemManager.RealizarTarea(Tarea tarea)
        {
            RealizarTarea(tarea);
        }

        void ISystemManager.AceptarTarea(Tarea tarea, Desarrollador desarrollador)
        {
            AceptarTarea(tarea, desarrollador);
        }

        void ISystemManager.CambiarAprobacion(Tarea tarea, bool aprobada)
        {
            CambiarAprobacion(tarea, aprobada);
        }

        public static void RealizarTarea(Tarea tarea)
        {
            try{
                foreach (var t in _tareas.Where(t => t == tarea))
                {
                    t.Realizada = true;
                    Notificar(t, "tarea finalizada");
                    break;
                }
            }
            catch
            {
                Console.WriteLine("Ha ocurrido un error realizando la tarea");
            }
        }

        public static void AceptarTarea(Tarea tarea, Desarrollador desarrollador)
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

        public static void CambiarAprobacion(Tarea tarea, bool aprobada)
        {
            try
            {
                foreach (var t in _tareas.Where(t => t == tarea))
                {
                    t.Aprobada = aprobada;
                    Notificar(t, aprobada ? "tarea aprobada" : "tarea no aprobada");
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
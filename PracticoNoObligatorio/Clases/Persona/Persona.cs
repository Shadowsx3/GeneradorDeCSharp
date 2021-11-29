using System;
using System.Linq;

namespace PracticoNoObligatorio.Clases
{
    public class Persona: IPersona
    {
        protected string _nombre = "";
        protected string _tipo = "";
        protected string[] _recibe = Array.Empty<string>();

        public string Nombre
        {
            get => _nombre;
            set => _nombre = value;
        }

        public string Tipo1
        {
            get => _tipo;
            set => _tipo = value;
        }

        public string[] Recibe
        {
            get => _recibe;
            set => _recibe = value;
        }

        public virtual void Update(Tarea tarea, string accion)
        {
            if (_recibe.Contains(accion))
            {
                Reaccion(accion, tarea);
            }
        }

        private void Reaccion(string accion, Tarea t)
        {
            Console.WriteLine($"El {Tipo()} llamado {_nombre} ha recibido la alerta de {accion} para {t.Actividad}");
        }
        public string Tipo()
        {
            return _tipo;
        }
    }
}
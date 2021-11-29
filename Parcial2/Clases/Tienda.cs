using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading;

namespace Parcial2.Clases
{
    public class Tienda
    {
        private Tienda()
        {
            _alimentos = new List<IAlimento>();
            _personas = new List<IPersona>();
        }
        private static Tienda _instance;
        private List<IPersona> _personas;
        private List<IAlimento> _alimentos;
        public static Tienda GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Tienda();
            }
            return _instance;
        }

        public List<IPersona> Personas
        {
            get => _personas;
            set => _personas = value;
        }

        public List<IAlimento> Alimentos
        {
            get => _alimentos;
            set => _alimentos = value;
        }

        private void Notificar(IAlimento a, string accion)
        {
            foreach (var c in _personas)
            {
                c.Avisar(a, accion);
            }
        }
        public void AgregarAlimento(IAlimento a)
        {
            Console.WriteLine($"-Se agregó {a.Nombre()}-");
            _alimentos.Add(a);
            Notificar(a, TiposAcciones.Agregado);
        }
        public void EliminarAlimento(string nombre)
        {
            try
            {
                if (_alimentos.Count == 0)
                {
                    throw new VoidException();
                }
                List<IAlimento> copia = new List<IAlimento>(_alimentos);
                IAlimento a = _alimentos.First(x => x.Nombre() == nombre);
                Console.WriteLine($"-Se compró {a.Nombre()}-");
                Notificar(a, TiposAcciones.Removido);
                _alimentos.Remove(a);
            }
            catch (VoidException e)
            {
                Console.WriteLine("La lista esta vaciaaaaaa");
            }
            
        }
    }
}
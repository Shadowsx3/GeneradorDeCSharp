using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestor_gimnasio.clase
{
    class Cliente
    {
        #region "Clase"
        private int _idSocio;
        private string _nombre;
        private string _apellido;
        private float _peso;
        private float _altura;
        private bool _deuda;
        private string _ultimoEjercicio;

        public string UltimoEjercicio
        {
            get => _ultimoEjercicio;
            set => _ultimoEjercicio = value;
        }
        private List<Cuota> _cuotas = new List<Cuota>();

        public List<Cuota> Cuotas
        {
            get => _cuotas;
            set => _cuotas = value;
        }

        public int IdSocio
        {
            get => _idSocio;
            set => _idSocio = value;
        }

        public string Nombre
        {
            get => _nombre;
            set => _nombre = value;
        }

        public string Apellido
        {
            get => _apellido;
            set => _apellido = value;
        }

        public float Peso
        {
            get => _peso;
            set => _peso = value;
        }

        public float Altura
        {
            get => _altura;
            set => _altura = value;
        }

        public bool Deuda
        {
            get => _deuda;
            set => _deuda = value;
        }

        public Cliente(int xidSocio, string xnombre, string xapellido, float xpeso, float xaltura)
        {
            IdSocio = xidSocio;
            Nombre = xnombre;
            Apellido = xapellido;
            Peso = xpeso;
            Altura = xaltura;
            Deuda = false;
        }
        #endregion
        #region "Funciones"
        
        public void PagarCuota(DateTime fecha)
        {
            foreach (Cuota c in Cuotas)
            {
                if (c.Fecha.Month == fecha.Month && c.Fecha.Year == fecha.Year)
                {
                    c.Pendiente = false;
                }
            }
        }
        public void AddCuota(DateTime fecha, int Monto)
        {
            Cuota cu = new Cuota
            {
                Monto = Monto,
                Pendiente = true,
                Fecha = fecha
            };
            foreach (Cuota c in Cuotas)
            {
                if (c.Fecha.Month == fecha.Month && c.Fecha.Year == fecha.Year)
                {
                    c.Pendiente = true;
                    c.Monto = Monto;
                    return;
                }
            }
            Cuotas.Add(cu);
        }

        public float Imc()
        {
            return Peso / (Altura * Altura);
        }

        public void CambiarPeso(float nuevoPeso)
        {
            Peso = nuevoPeso;
        }

        public void Ejercitarse(string nombreEjercicio)
        {
            UltimoEjercicio = nombreEjercicio;
        }
        #endregion
    }
}

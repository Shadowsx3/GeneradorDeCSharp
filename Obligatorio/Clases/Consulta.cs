using System;
using Obligatorio.Clases.Consultas;

namespace Obligatorio.Clases
{
    public class Consulta : IConsulta
    {
        private int _costo;
        private string _descripcion;
        private DateTime _fecha;
        private bool _pagada;
        private string _cedulaFuncionario;
        private string _cedulaDueño;
        private string _cedulaMascotra;


        public Consulta( int costo, string descripcion, DateTime fecha, string cedulaFuncionario, string cedulaMascotra, string cedulaDueño, bool pagada = false)
        {
            _costo = costo;
            _descripcion = descripcion;
            _fecha = fecha;
            _pagada = pagada;
            _cedulaFuncionario = cedulaFuncionario;
            _cedulaMascotra = cedulaMascotra;
            _cedulaDueño = cedulaDueño;
        }

        public int Costo
        {
            get => _costo;
            set => _costo = value;
        }

        public string Descripcion
        {
            get => _descripcion;
            set => _descripcion = value;
        }

        public DateTime Fecha
        {
            get => _fecha;
            set => _fecha = value;
        }

        public bool Pagada
        {
            get => _pagada;
            set => _pagada = value;
        }

        public string IdFuncionario
        {
            get => _cedulaFuncionario;
            set => _cedulaFuncionario = value;
        }

        public string CedulaFuncionario
        {
            get => _cedulaFuncionario;
            set => _cedulaFuncionario = value;
        }

        public string CedulaDueño
        {
            get => _cedulaDueño;
            set => _cedulaDueño = value;
        }

        public string CedulaMascotra
        {
            get => _cedulaMascotra;
            set => _cedulaMascotra = value;
        }

        public virtual string getTipo()
        {
            return "";
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MalesCubos_BienesRaices.Clases
{
    public class Propiedad
    {
    private int _idPropiedad;
    private string _direccion;
    private string _nombre;
    private bool _comprada;
    private bool _alquilada;
    private bool _dcompra;
    private bool _dalquiler;
    private bool _activo;
    public bool Activo
        {
        get => _activo;
        set => _activo = value;
    }
        public int IdPropiedad
    {
        get => _idPropiedad;
        set => _idPropiedad = value;
    }

    public string Direccion
    {
        get => _direccion;
        set => _direccion = value;
    }
    public string Nombre
    {
        get => _nombre;
        set => _nombre = value;
    }

        public bool Comprada
    {
        get => _comprada;
        set => _comprada = value;
    }

    public bool Alquilada
    {
        get => _alquilada;
        set => _alquilada = value;
    }

    public bool Dcompra
    {
        get => _dcompra;
        set => _dcompra = value;
    }

    public bool Dalquiler
    {
        get => _dalquiler;
        set => _dalquiler = value;
    }

    public Propiedad(int idPropiedad, string direccion, string nombre, bool comprada = false, bool alquilada = false, bool dcompra = true, bool dalquiler = true)
    {
        _idPropiedad = idPropiedad;
        _nombre = nombre;
        _direccion = direccion;
        _comprada = comprada;
        _alquilada = alquilada;
        _dcompra = dcompra;
        _dalquiler = dalquiler;
        _activo = true;
    }
    }
}

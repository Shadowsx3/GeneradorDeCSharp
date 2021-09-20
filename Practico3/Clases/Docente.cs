using System;

namespace Practico3.Clases
{
    public class Docente : Persona
    {
        private uint _idDocente;
        public uint idDocente { get => _idDocente; set => _idDocente = value; }
        new public void Presentarse(){
            Console.WriteLine($"Ocupacion: Docente, El nombre es: {this.nombre}, el apellido es: {this.apellido}");
        }
        public Docente(string xNombre, string xApellido, string xDocumento, uint xIdDocente):base(xNombre, xApellido, xDocumento) {
            this.idDocente = xIdDocente;
        }
    }
}
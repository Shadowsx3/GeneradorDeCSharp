using System;

namespace Practico3.Clases
{
    //Hereda de la clase persona, todas sus funciones, variables ... para ahorrar codigo y facilitar la implementacion
    public class Docente : Persona
    {
        private uint _idDocente;
        public uint idDocente { get => _idDocente; set => _idDocente = value; }
        //Se sobreescribe la funcion presentarse de la clase padre
        public override void Presentarse(){
            Console.WriteLine($"Ocupacion: Docente, El nombre es: {this.nombre}, el apellido es: {this.apellido}");
        }
        public Docente(string xNombre, string xApellido, string xDocumento, uint xIdDocente):base(xNombre, xApellido, xDocumento) {
            this.idDocente = xIdDocente;
        }
    }
}
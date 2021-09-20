using System;

namespace Practico3.Clases
{
    public class Alumno : Persona
    {
        private int _idAlumno;
        public int idAlumno { get => _idAlumno; set => _idAlumno = value; }
        new public void Presentarse(){
        
            Console.WriteLine($"Ocupacion: Alumno, El nombre es: {this.nombre}, el apellido es: {this.apellido}");
        }
        public Alumno(string xNombre, string xApellido, string xDocumento, int xIdAlumno) :base(xNombre, xApellido, xDocumento){
            this.idAlumno = xIdAlumno;
        }
    }
}
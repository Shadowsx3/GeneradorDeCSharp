using System;
using System.Collections;
using System.Collections.Generic;

namespace Practico3.Clases
{
    interface IPersona{
        void Presentarse();
    }
    public class Persona : IPersona
    {
        private string _nombre;
        public string nombre { get => _nombre; set => _nombre = value; }
        private string _apellido;
        public string apellido {get => _apellido; set => _apellido = value;}
        private string _documento;
        public string documento { get => _documento; set => _documento = value; }
        public Persona(string xNombre = "", string xApellido = ""){
            this.nombre = xNombre;
            this.apellido = xApellido;
        }
        public Persona(string xNombre, string xApellido, string xDocumento){
            this.nombre = xNombre;
            this.apellido = xApellido;
            this.documento = xDocumento;
        }
        public override string ToString(){
            return $"El nombre es: {this.nombre}, el apellido es: {this.apellido}";
        }
        public void Presentarse(){
            Console.WriteLine($"Mi nombre es {nombre}");
        }
    }
}
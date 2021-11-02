using System;
using System.Collections;
using System.Collections.Generic;

namespace Practico3.Clases
{
    //Interface, es algo que nos indica que debe tener luego la clase que la implemente
    interface IPersona{
        //La funcion que se debe usar en Persona
        void Presentarse();
    }
    //Una clase, seria la definición o planos de un objeto
    public class Persona : IPersona
    {
        //Se declarará las variables seguidas de sus getters and setters
        private string _nombre;
        public string nombre { get => _nombre; set => _nombre = value; }
        private string _apellido;
        public string apellido {get => _apellido; set => _apellido = value;}
        private string _documento;
        public string documento { get => _documento; set => _documento = value; }
        //Constructor de la clase, incializa las variables a un estado cuando se crea un nuevo objeto
        public Persona(string xNombre = "", string xApellido = ""){
            this.nombre = xNombre;
            this.apellido = xApellido;
        }
        //Constructor con 3 argumentos que incluye la incializacion de el documento, se adopta esto
        // para que el codigo esté cerrado a modificiaciones y abierto a extensiones
        public Persona(string xNombre, string xApellido, string xDocumento){
            this.nombre = xNombre;
            this.apellido = xApellido;
            this.documento = xDocumento;
        }
        //Funcion .ToString del objeto sobreescrita
        public override string ToString(){
            return $"El nombre es: {this.nombre}, el apellido es: {this.apellido}";
        }
        //Funcion que presenta a la persona que no retorna
        public virtual void Presentarse(){
            Console.WriteLine($"Mi nombre es {nombre}");
        }
    }
}
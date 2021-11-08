using System.Collections;
using System;
using System.Collections.Generic;
using Practico3.Clases;

namespace Practico3
{
    class Program
    {
        static string AskThing(string Indicacion){
            Console.WriteLine(Indicacion);
            return Console.ReadLine();
        }
        //Parte 1
        static void Main(string[] args)
        {
            List<Persona> personas = new List<Persona>();
            Console.WriteLine("Bienvenido");
            for(int i = 0; i<3; i++){
                Console.WriteLine("Nuevo ingreso\n");
                string nombre = AskThing("Ingrese su nombre");
                string apellido = AskThing("Ingrese su apellido");
                Persona persona1 = new Persona(nombre, apellido);
                if (i != 0){
                    string documento = AskThing("Ingrese su documento");
                    persona1 = new Persona(nombre, apellido, documento);
                }
                personas.Add(persona1);
                persona1.Presentarse();
            }
            Docente profesor = new Docente("Juan", "Pedro", "4534", 4234324);
            profesor.Presentarse();
            Alumno alumno = new Alumno("Pedro", "Pedro", "45345", 4234325);
            alumno.Presentarse();
        }
    }
}

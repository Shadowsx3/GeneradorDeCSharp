using System;

namespace Test
{
    class Persona {
        private string nombre;
        public string apellido;
        public Persona(string xNombre, string xApellido) {
            this.nombre = xNombre;
            this.apellido = xApellido;
            }
        public string getNombre() {
            return this.nombre;
            }
        public string getApellido() {
            return this.apellido;
            }
        public void setNombre (string xNombre) {
            this.nombre = xNombre;
            }
        public void setApellido (string xApellido) {
            this.apellido = xApellido;
            }
        }
    class Docente : Persona{
        private int idDocente;
        public Docente (string xNombre, string xApellido, int xIdDocente) : base(xNombre, xApellido) {
            this.idDocente = xIdDocente;
            }
        public int getIdDocente() {
            return this.idDocente;
            }
        }
    class Program
    {
        static void Main(string[] args)
        {
            //CASO 1 // Persona objPersona = new Persona(“Baruch”, “Spinoza”);
            Persona objPersona = new Persona("Baruch", "Spinoza");
            
            //CASO 2 // objPersona.getNombre();
            objPersona.getNombre();
            
            //CASO 3 // objPersona.getIdDocente();
            //Removido ya que persona no tiene un id doncente
            
            //CASO 4 // Docente objDocente = new Persona(“Georg”, “Hegel”);
            Persona objDocente = new Docente("Georg", "Hegel",3);
            
            //CASO 5 // Persona objDocente2 = new Docente(“Immanuel”, “Kant”,1);
            Docente objDocente2 = new Docente("Immanuel", "Kant",1);
            
            //CASO 6 // objDocente2.getApellido();
            objDocente2.getApellido();
            
            //CASO 7 // objDocente2.getIdDocente();
            objDocente2.getIdDocente();
            
            //CASO 8 // objDocente2.nombre = “Emanuel”;
            objDocente2.setNombre("Emanuel");
            
            //CASO 9 // objDocente2.apellido = “Kant”;
            objDocente2.setApellido("Kant");
            
            //CASO 10 // objPersona.setNombre(“Baruj”);
            objPersona.setNombre("Baruj");
            
            //CASO 11 // objPersona.setApellido(“Espinosa”);
            objPersona.setApellido("Espinosa");
        }
    }
}

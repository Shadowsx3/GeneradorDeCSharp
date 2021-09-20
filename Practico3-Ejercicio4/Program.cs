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
            Persona objPersona = new Persona("Baruch", "Spinoza");
            objPersona.getNombre();
            Persona objDocente = new Docente("Georg", "Hegel",3);
            Docente objDocente2 = new Docente("Immanuel", "Kant",1);
            objDocente2.getApellido();
            objDocente2.getIdDocente();
            objDocente2.setNombre("Emanuel");
            objDocente2.setApellido("Kant");
            objPersona.setNombre("Baruj");
            objPersona.setApellido("Espinosa");
        }
    }
}

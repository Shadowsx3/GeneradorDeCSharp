using System;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;
namespace Musica
{
    class Program
    {
        public static void Menu(List<Banda> banda){
            ConsoleKeyInfo op;

            do
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[A]Agregar banda");
                Console.WriteLine("[E]Eliminar banda");
                Console.WriteLine("[D]Datos de una banda");
                Console.WriteLine("[V]Ver bandas");
                Console.WriteLine("[B]Buscar banda");
                Console.WriteLine("[G]Guardar bandas");
                Console.WriteLine("[Esc]Salir");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Seleccione opcion...");
                op = Console.ReadKey(true);
                switch (op.Key)
                {
                    case ConsoleKey.A:
                        Genericos.IngresoBanda(banda);
                        break;
                    case ConsoleKey.E:
                        Genericos.BorrarIndiceBanda(banda);
                        break;
                    case ConsoleKey.B:
                        MenuBuscar(banda);
                        break;
                    case ConsoleKey.G:
                        Genericos.GuardarDatosBanda(banda);
                        break;
                    case ConsoleKey.V:
                        Genericos.ImprimirBanda(banda);
                        break;
                    case ConsoleKey.D:
                        MenuBanda(banda);
                        break;
                }
                Console.WriteLine("Presione una tecla para continuar");
                Console.ReadKey(true);
            } while (op.Key != ConsoleKey.Escape);
        }
        public static void MenuBuscar(List<Banda> banda){
            ConsoleKeyInfo op;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("[N]Nombre");
            Console.WriteLine("[G]Genero");
            Console.WriteLine("[Esc]Salir");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Seleccione por que parametro quiere buscar...");
            op = Console.ReadKey(true);
            switch (op.Key)
                {
                    case ConsoleKey.N:
                        Genericos.TieneNombre(banda);
                        break;
                    case ConsoleKey.G:
                        Genericos.TieneGenero(banda);
                        break;
                }
        }
        public static void MenuBanda(List<Banda> banda){
            Banda seleccion = Genericos.SeleccionarBanda(banda);
            if (seleccion == null){ return;}
            ConsoleKeyInfo op;
            do
            {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("[I]Informacion de la banda");
            Console.WriteLine("[L]Listar canciones");
            Console.WriteLine("[A]Eliminar album");
            Console.WriteLine("[C]Eliminar cancion");
            Console.WriteLine("[E]Cambiar estado de integrante");
            Console.WriteLine("[Esc]Salir");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Seleccione por que parametro quiere buscar...");
            op = Console.ReadKey(true);
            switch (op.Key)
                {
                    case ConsoleKey.I:
                        Console.WriteLine(seleccion);
                        break;
                    case ConsoleKey.L:
                        Genericos.ListarCanciones(seleccion);
                        break;
                    case ConsoleKey.A:
                        Genericos.BorrarIndiceAlbum(seleccion.Albumes);
                        break;
                    case ConsoleKey.C:
                        Genericos.BorrarIndiceCancion(seleccion.Albumes);
                        break;
                    case ConsoleKey.E:
                        Genericos.CambiarEstado(seleccion);
                        break;
                }
            } while (op.Key != ConsoleKey.Escape);
        }

        static void Main(string[] args)
        {   

            List<Banda> banda = Genericos.CargarDatosBanda();
            Menu(banda);
            Genericos.GuardarDatosBanda(banda);
        }
    }
}

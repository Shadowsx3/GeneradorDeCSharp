using System;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;
namespace Musica
{
    class Genericos{
        static int SolicitarInt(string mensaje){
		Console.WriteLine(mensaje);
		string entrada = Console.ReadLine();
		try{
			return Int32.Parse(entrada);
		}catch{
			Console.WriteLine("Dato erroneo");
			return SolicitarInt(mensaje);}
		}
        public static string SolicitarString(string mensaje){
		Console.WriteLine(mensaje);
		string entrada = Console.ReadLine();
		return entrada;
		}
		public static bool SolicitarBool(string mensaje){
		Console.WriteLine(mensaje);
		string entrada = Console.ReadLine();
		try{
			return bool.Parse(entrada);
		}catch{
			Console.WriteLine("Dato erroneo");
			return SolicitarBool(mensaje);}
		}
		public static DateTime SolicitarDatetime(string mensaje){
		Console.WriteLine(mensaje);
		string entrada = Console.ReadLine();
		try{
			return Convert.ToDateTime(entrada);
		}catch{
			Console.WriteLine("Dato erroneo");
			return SolicitarDatetime(mensaje);}
		}
		public static float SolicitarFloat(string mensaje){
		Console.WriteLine(mensaje);
		string entrada = Console.ReadLine();
		try{
			return float.Parse(entrada);
		}catch{
			Console.WriteLine("Dato erroneo");
			return SolicitarFloat(mensaje);}
		}
		public static void AddPersonaes(List<Persona> personas){
			string j = "";
			while (j == ""){
				IngresoPersona(personas);
				j = SolicitarString("Presione enter para continuar agregando");
				}
		}
		public static void GuardarDatosPersona(List <Persona> persona){
			string fileName = "BaseDeDatosPersona.json";
			string jsonString = JsonSerializer.Serialize(persona);
			File.WriteAllTextAsync(fileName, jsonString);}
		public static List<Persona> CargarDatosPersona(){
			string fileName = "BaseDeDatosPersona.json";
			string jsonString = File.ReadAllText(fileName);
			List <Persona> persona = JsonSerializer.Deserialize<List<Persona>>(jsonString);
			return persona;}
		public static void BorrarIndicePersona(List <Persona> persona){
			int id = SolicitarInt("Ingrese un id\n");
			try{
				int j = 0;
				foreach(Persona P in persona){
					if (P.Id == id){
						persona.RemoveAt(j);
					}
				j += 1;
				}
			}catch{
				Console.WriteLine("Id erroneo");
			}}
		#region "FiltroPersona"
		public static void ImprimirPersona(List <Persona> persona){
			int j = 0;
			foreach(Persona P in persona){
				Console.WriteLine($"Persona Nro {j}");
				Console.WriteLine(P);
				j += 1;
			}
		}

		public static void ImprimirPersona(List <Persona> persona, int id){
			try{
				foreach(Persona P in persona){
					if (P.Id == id){
						Console.WriteLine(persona[id]);
					}
				}
			}catch{
				Console.WriteLine("Id erroneo");
			}
		}

		public static void EditarNombrePersona(List <Persona> persona, int id){
			try{
				foreach(Persona P in persona){
					if (P.Id == id){
						Console.WriteLine("Actual");
						Console.WriteLine(P);
						SetNombre(P);
					}
				}
			}catch{
				Console.WriteLine("Id erroneo");
			}}
		public static void SetNombre(Persona persona){
			persona.Nombre = SolicitarString("Ingrese el nombre\n");
		}
		public static List<Persona> TieneNombre(List <Persona> persona){
			string valor = SolicitarString("Ingrese un valor");
			bool imprimir = true;
			List<Persona> PERSONA = new List<Persona>();
			foreach(Persona P in persona){
				if (P.Nombre == valor){
					PERSONA.Add(P);
				}
			}
			if (imprimir){
				ImprimirPersona(PERSONA);
			}
			return PERSONA;
		}
		public static void EditarApellidoPersona(List <Persona> persona, int id){
			try{
				foreach(Persona P in persona){
					if (P.Id == id){
						Console.WriteLine("Actual");
						Console.WriteLine(P);
						SetApellido(P);
					}
				}
			}catch{
				Console.WriteLine("Id erroneo");
			}}
		public static void SetApellido(Persona persona){
			persona.Apellido = SolicitarString("Ingrese el apellido\n");
		}
		public static List<Persona> TieneApellido(List <Persona> persona){
			string valor = SolicitarString("Ingrese un valor");
			bool imprimir = true;
			List<Persona> PERSONA = new List<Persona>();
			foreach(Persona P in persona){
				if (P.Apellido == valor){
					PERSONA.Add(P);
				}
			}
			if (imprimir){
				ImprimirPersona(PERSONA);
			}
			return PERSONA;
		}
		public static void EditarIdPersona(List <Persona> persona, int id){
			try{
				foreach(Persona P in persona){
					if (P.Id == id){
						Console.WriteLine("Actual");
						Console.WriteLine(P);
						SetId(P);
					}
				}
			}catch{
				Console.WriteLine("Id erroneo");
			}}
		public static void SetId(Persona persona){
			persona.Id = SolicitarInt("Ingrese el id\n");
		}
		public static List<Persona> IgualId(List <Persona> persona){
			int valor = SolicitarInt("Ingrese un valor");
			bool imprimir = true;
			List<Persona> PERSONA = new List<Persona>();
			foreach(Persona P in persona){
				if (P.Id == valor){
					PERSONA.Add(P);
				}
			}
			if (imprimir){
				ImprimirPersona(PERSONA);
			}
			return PERSONA;
		}
		public static List<Persona> MayorId(List <Persona> persona){
			int valor = SolicitarInt("Ingrese un valor");
			bool imprimir = true;
			List<Persona> PERSONA = new List<Persona>();
			foreach(Persona P in persona){
				if (P.Id > valor){
					PERSONA.Add(P);
				}
			}
			if (imprimir){
				ImprimirPersona(PERSONA);
			}
			return PERSONA;
		}
		public static List<Persona> MenorId(List <Persona> persona){
			int valor = SolicitarInt("Ingrese un valor");
			bool imprimir = true;
			List<Persona> PERSONA = new List<Persona>();
			foreach(Persona P in persona){
				if (P.Id < valor){
					PERSONA.Add(P);
				}
			}
			if (imprimir){
				ImprimirPersona(PERSONA);
			}
			return PERSONA;
		}
		public static List<Persona> MayorIgualId(List <Persona> persona){
			int valor = SolicitarInt("Ingrese un valor");
			bool imprimir = true;
			List<Persona> PERSONA = new List<Persona>();
			foreach(Persona P in persona){
				if (P.Id >= valor){
					PERSONA.Add(P);
				}
			}
			if (imprimir){
				ImprimirPersona(PERSONA);
			}
			return PERSONA;
		}
		public static List<Persona> MenorIgualId(List <Persona> persona){
			int valor = SolicitarInt("Ingrese un valor");
			bool imprimir = true;
			List<Persona> PERSONA = new List<Persona>();
			foreach(Persona P in persona){
				if (P.Id <= valor){
					PERSONA.Add(P);
				}
			}
			if (imprimir){
				ImprimirPersona(PERSONA);
			}
			return PERSONA;
		}
		public static List<Persona> DistintoId(List <Persona> persona){
			int valor = SolicitarInt("Ingrese un valor");
			bool imprimir = true;
			List<Persona> PERSONA = new List<Persona>();
			foreach(Persona P in persona){
				if (P.Id != valor){
					PERSONA.Add(P);
				}
			}
			if (imprimir){
				ImprimirPersona(PERSONA);
			}
			return PERSONA;
		}
		public static void IngresoPersona(List <Persona> persona){
			Persona personas = new Persona();
			Console.Clear();
			Console.WriteLine("Ingreso de Persona");
			Console.WriteLine("----------------------------------------------------------------");
			SetNombre(personas);
			SetApellido(personas);
			SetId(personas);
			persona.Add(personas);
			Console.WriteLine("----------------------------------------------------------------");
		}

		#endregion
		public static void AddCanciones(List<Cancion> cancions){
			string j = "";
			while (j == ""){
				IngresoCancion(cancions);
				j = SolicitarString("Presione enter para continuar agregando");
				}
		}
		public static void GuardarDatosCancion(List <Cancion> cancion){
			string fileName = "BaseDeDatosCancion.json";
			string jsonString = JsonSerializer.Serialize(cancion);
			File.WriteAllTextAsync(fileName, jsonString);}
		public static List<Cancion> CargarDatosCancion(){
			string fileName = "BaseDeDatosCancion.json";
			string jsonString = File.ReadAllText(fileName);
			List <Cancion> cancion = JsonSerializer.Deserialize<List<Cancion>>(jsonString);
			return cancion;}
		#region "FiltroCancion"
		public static void ImprimirCancion(List <Cancion> cancion){
			int j = 0;
			foreach(Cancion C in cancion){
				Console.WriteLine($"Cancion Nro {j}");
				Console.WriteLine(C);
				j += 1;
			}
		}

		public static void ImprimirCancion(List <Cancion> cancion, int id){
			try{
				foreach(Cancion C in cancion){
					if (C.Id == id){
						Console.WriteLine(cancion[id]);
					}
				}
			}catch{
				Console.WriteLine("Id erroneo");
			}
		}

		public static void EditarNombreCancion(List <Cancion> cancion, int id){
			try{
				foreach(Cancion C in cancion){
					if (C.Id == id){
						Console.WriteLine("Actual");
						Console.WriteLine(C);
						SetNombre(C);
					}
				}
			}catch{
				Console.WriteLine("Id erroneo");
			}}
		public static void SetNombre(Cancion cancion){
			cancion.Nombre = SolicitarString("Ingrese el nombre\n");
		}
		public static List<Cancion> TieneNombre(List <Cancion> cancion){
			string valor = SolicitarString("Ingrese un valor");
			bool imprimir = true;
			List<Cancion> CANCION = new List<Cancion>();
			foreach(Cancion C in cancion){
				if (C.Nombre == valor){
					CANCION.Add(C);
				}
			}
			if (imprimir){
				ImprimirCancion(CANCION);
			}
			return CANCION;
		}
		public static void EditarDuracionCancion(List <Cancion> cancion, int id){
			try{
				foreach(Cancion C in cancion){
					if (C.Id == id){
						Console.WriteLine("Actual");
						Console.WriteLine(C);
						SetDuracion(C);
					}
				}
			}catch{
				Console.WriteLine("Id erroneo");
			}}
		public static void SetDuracion(Cancion cancion){
			cancion.Duracion = SolicitarString("Ingrese la duracion\n");
		}
		public static List<Cancion> TieneDuracion(List <Cancion> cancion){
			string valor = SolicitarString("Ingrese un valor");
			bool imprimir = true;
			List<Cancion> CANCION = new List<Cancion>();
			foreach(Cancion C in cancion){
				if (C.Duracion == valor){
					CANCION.Add(C);
				}
			}
			if (imprimir){
				ImprimirCancion(CANCION);
			}
			return CANCION;
		}
		public static void EditarIdCancion(List <Cancion> cancion, int id){
			try{
				foreach(Cancion C in cancion){
					if (C.Id == id){
						Console.WriteLine("Actual");
						Console.WriteLine(C);
						SetId(C);
					}
				}
			}catch{
				Console.WriteLine("Id erroneo");
			}}
		public static void SetId(Cancion cancion){
			cancion.Id = SolicitarInt("Ingrese el id\n");
		}
		public static List<Cancion> IgualId(List <Cancion> cancion){
			int valor = SolicitarInt("Ingrese un valor");
			bool imprimir = true;
			List<Cancion> CANCION = new List<Cancion>();
			foreach(Cancion C in cancion){
				if (C.Id == valor){
					CANCION.Add(C);
				}
			}
			if (imprimir){
				ImprimirCancion(CANCION);
			}
			return CANCION;
		}
		public static List<Cancion> MayorId(List <Cancion> cancion){
			int valor = SolicitarInt("Ingrese un valor");
			bool imprimir = true;
			List<Cancion> CANCION = new List<Cancion>();
			foreach(Cancion C in cancion){
				if (C.Id > valor){
					CANCION.Add(C);
				}
			}
			if (imprimir){
				ImprimirCancion(CANCION);
			}
			return CANCION;
		}
		public static List<Cancion> MenorId(List <Cancion> cancion){
			int valor = SolicitarInt("Ingrese un valor");
			bool imprimir = true;
			List<Cancion> CANCION = new List<Cancion>();
			foreach(Cancion C in cancion){
				if (C.Id < valor){
					CANCION.Add(C);
				}
			}
			if (imprimir){
				ImprimirCancion(CANCION);
			}
			return CANCION;
		}
		public static List<Cancion> MayorIgualId(List <Cancion> cancion){
			int valor = SolicitarInt("Ingrese un valor");
			bool imprimir = true;
			List<Cancion> CANCION = new List<Cancion>();
			foreach(Cancion C in cancion){
				if (C.Id >= valor){
					CANCION.Add(C);
				}
			}
			if (imprimir){
				ImprimirCancion(CANCION);
			}
			return CANCION;
		}
		public static List<Cancion> MenorIgualId(List <Cancion> cancion){
			int valor = SolicitarInt("Ingrese un valor");
			bool imprimir = true;
			List<Cancion> CANCION = new List<Cancion>();
			foreach(Cancion C in cancion){
				if (C.Id <= valor){
					CANCION.Add(C);
				}
			}
			if (imprimir){
				ImprimirCancion(CANCION);
			}
			return CANCION;
		}
		public static List<Cancion> DistintoId(List <Cancion> cancion){
			int valor = SolicitarInt("Ingrese un valor");
			bool imprimir = true;
			List<Cancion> CANCION = new List<Cancion>();
			foreach(Cancion C in cancion){
				if (C.Id != valor){
					CANCION.Add(C);
				}
			}
			if (imprimir){
				ImprimirCancion(CANCION);
			}
			return CANCION;
		}
		public static void IngresoCancion(List <Cancion> cancion){
			Cancion cancions = new Cancion();
			Console.Clear();
			Console.WriteLine("Ingreso de Cancion");
			Console.WriteLine("----------------------------------------------------------------");
			SetNombre(cancions);
			SetDuracion(cancions);
			SetId(cancions);
			cancion.Add(cancions);
			Console.WriteLine("----------------------------------------------------------------");
		}

		#endregion
		public static void AddAlbumes(List<Album> albums){
			string j = "";
			while (j == ""){
				IngresoAlbum(albums);
				j = SolicitarString("Presione enter para continuar agregando");
				}
		}
		public static void GuardarDatosAlbum(List <Album> album){
			string fileName = "BaseDeDatosAlbum.json";
			string jsonString = JsonSerializer.Serialize(album);
			File.WriteAllTextAsync(fileName, jsonString);}
		public static List<Album> CargarDatosAlbum(){
			string fileName = "BaseDeDatosAlbum.json";
			string jsonString = File.ReadAllText(fileName);
			List <Album> album = JsonSerializer.Deserialize<List<Album>>(jsonString);
			return album;}
		public static void BorrarIndiceAlbum(List <Album> album){
			int id = SolicitarInt("Ingrese un id\n");
			try{
				int j = 0;
				foreach(Album A in album){
					if (A.Id == id){
						album.RemoveAt(j);
					}
				j += 1;
				}
			}catch{
				Console.WriteLine("Id erroneo");
			}}
		#region "FiltroAlbum"
		public static void ImprimirAlbum(List <Album> album){
			int j = 0;
			foreach(Album A in album){
				Console.WriteLine($"Album Nro {j}");
				Console.WriteLine(A);
				j += 1;
			}
		}

		public static void ImprimirAlbum(List <Album> album, int id){
			try{
				foreach(Album A in album){
					if (A.Id == id){
						Console.WriteLine(album[id]);
					}
				}
			}catch{
				Console.WriteLine("Id erroneo");
			}
		}

		public static void EditarNombreAlbum(List <Album> album, int id){
			try{
				foreach(Album A in album){
					if (A.Id == id){
						Console.WriteLine("Actual");
						Console.WriteLine(A);
						SetNombre(A);
					}
				}
			}catch{
				Console.WriteLine("Id erroneo");
			}}
		public static void SetNombre(Album album){
			album.Nombre = SolicitarString("Ingrese el nombre\n");
		}
		public static List<Album> TieneNombre(List <Album> album){
			string valor = SolicitarString("Ingrese un valor");
			bool imprimir = true;
			List<Album> ALBUM = new List<Album>();
			foreach(Album A in album){
				if (A.Nombre == valor){
					ALBUM.Add(A);
				}
			}
			if (imprimir){
				ImprimirAlbum(ALBUM);
			}
			return ALBUM;
		}
		public static void EditarFecha_EstrenoAlbum(List <Album> album, int id){
			try{
				foreach(Album A in album){
					if (A.Id == id){
						Console.WriteLine("Actual");
						Console.WriteLine(A);
						SetFecha_Estreno(A);
					}
				}
			}catch{
				Console.WriteLine("Id erroneo");
			}}
		public static void SetFecha_Estreno(Album album){
			album.Fecha_Estreno = SolicitarDatetime("Ingrese la fecha de estreno\n");
		}
		public static List<Album> TieneFecha_Estreno(List <Album> album){
			DateTime valor = SolicitarDatetime("Ingrese un valor");
			bool imprimir = true;
			List<Album> ALBUM = new List<Album>();
			foreach(Album A in album){
				if (A.Fecha_Estreno == valor){
					ALBUM.Add(A);
				}
			}
			if (imprimir){
				ImprimirAlbum(ALBUM);
			}
			return ALBUM;
		}
		public static void EditarCancionesAlbum(List <Album> album, int id){
			try{
				foreach(Album A in album){
					if (A.Id == id){
						Console.WriteLine("Actual");
						Console.WriteLine(A);
						SetCanciones(A);
					}
				}
			}catch{
				Console.WriteLine("Id erroneo");
			}}
		public static void SetCanciones(Album album){
			List<Cancion> Cancioness = new List<Cancion>();
			string j = "";
			while (j == ""){
				IngresoCancion(Cancioness);
				//j = SolicitarString("Presione enter para continuar agregando");
				j = SolicitarString("Presione enter para continuar agregando");
				}
			album.Canciones = Cancioness;
		}
		public static void EditarIdAlbum(List <Album> album, int id){
			try{
				foreach(Album A in album){
					if (A.Id == id){
						Console.WriteLine("Actual");
						Console.WriteLine(A);
						SetId(A);
					}
				}
			}catch{
				Console.WriteLine("Id erroneo");
			}}
		public static void SetId(Album album){
			album.Id = SolicitarInt("Ingrese el id\n");
		}
		public static List<Album> IgualId(List <Album> album){
			int valor = SolicitarInt("Ingrese un valor");
			bool imprimir = true;
			List<Album> ALBUM = new List<Album>();
			foreach(Album A in album){
				if (A.Id == valor){
					ALBUM.Add(A);
				}
			}
			if (imprimir){
				ImprimirAlbum(ALBUM);
			}
			return ALBUM;
		}
		public static List<Album> MayorId(List <Album> album){
			int valor = SolicitarInt("Ingrese un valor");
			bool imprimir = true;
			List<Album> ALBUM = new List<Album>();
			foreach(Album A in album){
				if (A.Id > valor){
					ALBUM.Add(A);
				}
			}
			if (imprimir){
				ImprimirAlbum(ALBUM);
			}
			return ALBUM;
		}
		public static List<Album> MenorId(List <Album> album){
			int valor = SolicitarInt("Ingrese un valor");
			bool imprimir = true;
			List<Album> ALBUM = new List<Album>();
			foreach(Album A in album){
				if (A.Id < valor){
					ALBUM.Add(A);
				}
			}
			if (imprimir){
				ImprimirAlbum(ALBUM);
			}
			return ALBUM;
		}
		public static List<Album> MayorIgualId(List <Album> album){
			int valor = SolicitarInt("Ingrese un valor");
			bool imprimir = true;
			List<Album> ALBUM = new List<Album>();
			foreach(Album A in album){
				if (A.Id >= valor){
					ALBUM.Add(A);
				}
			}
			if (imprimir){
				ImprimirAlbum(ALBUM);
			}
			return ALBUM;
		}
		public static List<Album> MenorIgualId(List <Album> album){
			int valor = SolicitarInt("Ingrese un valor");
			bool imprimir = true;
			List<Album> ALBUM = new List<Album>();
			foreach(Album A in album){
				if (A.Id <= valor){
					ALBUM.Add(A);
				}
			}
			if (imprimir){
				ImprimirAlbum(ALBUM);
			}
			return ALBUM;
		}
		public static List<Album> DistintoId(List <Album> album){
			int valor = SolicitarInt("Ingrese un valor");
			bool imprimir = true;
			List<Album> ALBUM = new List<Album>();
			foreach(Album A in album){
				if (A.Id != valor){
					ALBUM.Add(A);
				}
			}
			if (imprimir){
				ImprimirAlbum(ALBUM);
			}
			return ALBUM;
		}
		public static void IngresoAlbum(List <Album> album){
			Album albums = new Album();
			Console.Clear();
			Console.WriteLine("Ingreso de Album");
			Console.WriteLine("----------------------------------------------------------------");
			SetNombre(albums);
			SetFecha_Estreno(albums);
			SetCanciones(albums);
			SetId(albums);
			album.Add(albums);
			Console.WriteLine("----------------------------------------------------------------");
		}

		#endregion
		public static void AddBandaes(List<Banda> bandas){
			string j = "";
			while (j == ""){
				IngresoBanda(bandas);
				j = SolicitarString("Presione enter para continuar agregando");
				}
		}
		public static void GuardarDatosBanda(List <Banda> banda){
			string fileName = "BaseDeDatosBanda.json";
			string jsonString = JsonSerializer.Serialize(banda);
			File.WriteAllTextAsync(fileName, jsonString);}
		public static List<Banda> CargarDatosBanda(){
			string fileName = "BaseDeDatosBanda.json";
			string jsonString = File.ReadAllText(fileName);
			List <Banda> banda = JsonSerializer.Deserialize<List<Banda>>(jsonString);
			return banda;}
		public static void BorrarIndiceBanda(List <Banda> banda){
			int id = SolicitarInt("Ingrese un id\n");
			try{
				int j = 0;
				foreach(Banda B in banda){
					if (B.Id == id){
						banda.RemoveAt(j);
					}
				j += 1;
				}
			}catch{
				Console.WriteLine("Id erroneo");
			}}
		#region "FiltroBanda"
		public static void ImprimirBanda(List <Banda> banda){
			int j = 0;
			foreach(Banda B in banda){
				Console.WriteLine($"Banda Nro {j}");
				Console.WriteLine(B);
				j += 1;
			}
		}

		public static void ImprimirBanda(List <Banda> banda, int id){
			try{
				foreach(Banda B in banda){
					if (B.Id == id){
						Console.WriteLine(banda[id]);
					}
				}
			}catch{
				Console.WriteLine("Id erroneo");
			}
		}

		public static void EditarNombreBanda(List <Banda> banda, int id){
			try{
				foreach(Banda B in banda){
					if (B.Id == id){
						Console.WriteLine("Actual");
						Console.WriteLine(B);
						SetNombre(B);
					}
				}
			}catch{
				Console.WriteLine("Id erroneo");
			}}
		public static void SetNombre(Banda banda){
			banda.Nombre = SolicitarString("Ingrese el nombre\n");
		}
		public static List<Banda> TieneNombre(List <Banda> banda){
			string valor = SolicitarString("Ingrese un valor");
			bool imprimir = true;
			List<Banda> BANDA = new List<Banda>();
			foreach(Banda B in banda){
				if (B.Nombre == valor){
					BANDA.Add(B);
				}
			}
			if (imprimir){
				ImprimirBanda(BANDA);
			}
			return BANDA;
		}
		public static Banda SeleccionarBanda(List <Banda> banda){
			int id = SolicitarInt("Ingrese un id\n");
			try{
				int j = 0;
				foreach(Banda B in banda){
					if (B.Id == id){
						return B;
					}
				j += 1;
				}
			}catch{
				Console.WriteLine("Id erroneo");
			}
			return null;
			}
		public static void ListarCanciones(Banda banda){
			int j = 0;
			foreach(Album A in banda.Albumes){
				Console.WriteLine($"Album {A.Nombre} - ID: {A.Id}\n");
				foreach(Cancion C in A.Canciones){
					Console.WriteLine($"\tCancion {C.Nombre} - ID: {C.Id}");
				j += 1;
			}
		}
		}
		public static void CambiarEstado(Banda banda){
			int id = SolicitarInt("Ingrese un id\n");
			try{
					foreach(Persona P in banda.Integrantes){
						if (P.Id == id){
							P.Activo = ! P.Activo;
							Console.WriteLine($"Integrante {P.Nombre} - Nuevo estado: {P.Activo}");
						}
					}
			}catch{
				Console.WriteLine("Id erroneo");
			}
		}
		public static void BorrarIndiceCancion(List <Album> albumes){
			int id = SolicitarInt("Ingrese un id\n");
			try{
				foreach (Album A in albumes){
					foreach(Cancion C in A.Canciones){
						if (C.Id == id){
							A.Canciones.Remove(C);
						}
					}
				}
			}catch{
				Console.WriteLine("Id erroneo");
			}}
		public static void EditarGeneroBanda(List <Banda> banda, int id){
			try{
				foreach(Banda B in banda){
					if (B.Id == id){
						Console.WriteLine("Actual");
						Console.WriteLine(B);
						SetGenero(B);
					}
				}
			}catch{
				Console.WriteLine("Id erroneo");
			}}
		public static void SetGenero(Banda banda){
			banda.Genero = SolicitarString("Ingrese el apellido\n");
		}
		public static List<Banda> TieneGenero(List <Banda> banda){
			string valor = SolicitarString("Ingrese un valor");
			bool imprimir = true;
			List<Banda> BANDA = new List<Banda>();
			foreach(Banda B in banda){
				if (B.Genero == valor){
					BANDA.Add(B);
				}
			}
			if (imprimir){
				ImprimirBanda(BANDA);
			}
			return BANDA;
		}
		public static void EditarIntegrantesBanda(List <Banda> banda, int id){
			try{
				foreach(Banda B in banda){
					if (B.Id == id){
						Console.WriteLine("Actual");
						Console.WriteLine(B);
						SetIntegrantes(B);
					}
				}
			}catch{
				Console.WriteLine("Id erroneo");
			}}
		public static void SetIntegrantes(Banda banda){
			List<Persona> Integrantess = new List<Persona>();
			string j = "";
			while (j == ""){
				IngresoPersona(Integrantess);
				j = SolicitarString("Presione enter para continuar agregando");
				}
			banda.Integrantes = Integrantess;
		}
		public static void EditarAlbumesBanda(List <Banda> banda, int id){
			try{
				foreach(Banda B in banda){
					if (B.Id == id){
						Console.WriteLine("Actual");
						Console.WriteLine(B);
						SetAlbumes(B);
					}
				}
			}catch{
				Console.WriteLine("Id erroneo");
			}}
		public static void SetAlbumes(Banda banda){
			List<Album> Albumess = new List<Album>();
			string j = "";
			while (j == ""){
				IngresoAlbum(Albumess);
				j = SolicitarString("Presione enter para continuar agregando");
				}
			banda.Albumes = Albumess;
		}
		public static void EditarIdBanda(List <Banda> banda, int id){
			try{
				foreach(Banda B in banda){
					if (B.Id == id){
						Console.WriteLine("Actual");
						Console.WriteLine(B);
						SetId(B);
					}
				}
			}catch{
				Console.WriteLine("Id erroneo");
			}}
		public static void SetId(Banda banda){
			banda.Id = SolicitarInt("Ingrese el id\n");
		}
		public static List<Banda> IgualId(List <Banda> banda){
			int valor = SolicitarInt("Ingrese un valor");
			bool imprimir = true;
			List<Banda> BANDA = new List<Banda>();
			foreach(Banda B in banda){
				if (B.Id == valor){
					BANDA.Add(B);
				}
			}
			if (imprimir){
				ImprimirBanda(BANDA);
			}
			return BANDA;
		}
		public static List<Banda> MayorId(List <Banda> banda){
			int valor = SolicitarInt("Ingrese un valor");
			bool imprimir = true;
			List<Banda> BANDA = new List<Banda>();
			foreach(Banda B in banda){
				if (B.Id > valor){
					BANDA.Add(B);
				}
			}
			if (imprimir){
				ImprimirBanda(BANDA);
			}
			return BANDA;
		}
		public static List<Banda> MenorId(List <Banda> banda){
			int valor = SolicitarInt("Ingrese un valor");
			bool imprimir = true;
			List<Banda> BANDA = new List<Banda>();
			foreach(Banda B in banda){
				if (B.Id < valor){
					BANDA.Add(B);
				}
			}
			if (imprimir){
				ImprimirBanda(BANDA);
			}
			return BANDA;
		}
		public static List<Banda> MayorIgualId(List <Banda> banda){
			int valor = SolicitarInt("Ingrese un valor");
			bool imprimir = true;
			List<Banda> BANDA = new List<Banda>();
			foreach(Banda B in banda){
				if (B.Id >= valor){
					BANDA.Add(B);
				}
			}
			if (imprimir){
				ImprimirBanda(BANDA);
			}
			return BANDA;
		}
		public static List<Banda> MenorIgualId(List <Banda> banda){
			int valor = SolicitarInt("Ingrese un valor");
			bool imprimir = true;
			List<Banda> BANDA = new List<Banda>();
			foreach(Banda B in banda){
				if (B.Id <= valor){
					BANDA.Add(B);
				}
			}
			if (imprimir){
				ImprimirBanda(BANDA);
			}
			return BANDA;
		}
		public static List<Banda> DistintoId(List <Banda> banda){
			int valor = SolicitarInt("Ingrese un valor");
			bool imprimir = true;
			List<Banda> BANDA = new List<Banda>();
			foreach(Banda B in banda){
				if (B.Id != valor){
					BANDA.Add(B);
				}
			}
			if (imprimir){
				ImprimirBanda(BANDA);
			}
			return BANDA;
		}
		public static void IngresoBanda(List <Banda> banda){
			Banda bandas = new Banda();
			Console.Clear();
			Console.WriteLine("Ingreso de Banda");
			Console.WriteLine("----------------------------------------------------------------");
			SetNombre(bandas);
			SetGenero(bandas);
			SetIntegrantes(bandas);
			SetAlbumes(bandas);
			SetId(bandas);
			banda.Add(bandas);
			Console.WriteLine("----------------------------------------------------------------");
		}

		#endregion
	}
}
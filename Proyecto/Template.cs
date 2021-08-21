using System;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;
namespace Template{
	#region "Habitacion"
	public class Habitacion
	{
		private string _Tipo;
		public string Tipo { get => _Tipo; set => _Tipo = value; }
		private List <float> _Dimensiones = new List<float>();
		public List <float> Dimensiones { get => _Dimensiones; set => _Dimensiones = value; }
		private string _Color;
		public string Color { get => _Color; set => _Color = value; }
		private int _Id;
		public int Id { get => _Id; set => _Id = value; }
		public Habitacion(string tipo, int id){
			this.Tipo = tipo;
			this.Id = id;
		}
		public Habitacion(){
			this.Tipo = "Cuarto";
			this.Id = 0;
		}
		public override string ToString(){
			string json = JsonSerializer.Serialize(this, new JsonSerializerOptions { WriteIndented = true });
			string espacio = "----------------------------------------------------------------";
			json = $"{espacio}\n{json}\n{espacio}";
			return json;
		}
	}
	#endregion
	#region "Propiedad"
	public class Propiedad
	{
		private List <Habitacion> _Habitaciones = new List<Habitacion>();
		public List <Habitacion> Habitaciones { get => _Habitaciones; set => _Habitaciones = value; }
		private string _Ubicacion;
		public string Ubicacion { get => _Ubicacion; set => _Ubicacion = value; }
		private List <float> _Dimensiones_Patio = new List<float>();
		public List <float> Dimensiones_Patio { get => _Dimensiones_Patio; set => _Dimensiones_Patio = value; }
		private bool _Disponible_Venta;
		public bool Disponible_Venta { get => _Disponible_Venta; set => _Disponible_Venta = value; }
		private bool _Vendida;
		public bool Vendida { get => _Vendida; set => _Vendida = value; }
		private int _Precio_Venta;
		public int Precio_Venta { get => _Precio_Venta; set => _Precio_Venta = value; }
		private bool _Disponible_Alquiler;
		public bool Disponible_Alquiler { get => _Disponible_Alquiler; set => _Disponible_Alquiler = value; }
		private bool _Alquilada;
		public bool Alquilada { get => _Alquilada; set => _Alquilada = value; }
		private int _Precio_Alquiler;
		public int Precio_Alquiler { get => _Precio_Alquiler; set => _Precio_Alquiler = value; }
		private int _Id;
		public int Id { get => _Id; set => _Id = value; }
		public Propiedad(string ubicacion, bool disponible_venta, bool vendida, int precio_venta, bool disponible_alquiler, bool alquilada, int precio_alquiler, int id){
			this.Ubicacion = ubicacion;
			this.Disponible_Venta = disponible_venta;
			this.Vendida = vendida;
			this.Precio_Venta = precio_venta;
			this.Disponible_Alquiler = disponible_alquiler;
			this.Alquilada = alquilada;
			this.Precio_Alquiler = precio_alquiler;
			this.Id = id;
		}
		public Propiedad(){
			this.Ubicacion = "Salto";
			this.Disponible_Venta = false;
			this.Vendida = false;
			this.Precio_Venta = 555;
			this.Disponible_Alquiler = true;
			this.Alquilada = false;
			this.Precio_Alquiler = 555;
			this.Id = 0;
		}
		public override string ToString(){
			string json = JsonSerializer.Serialize(this, new JsonSerializerOptions { WriteIndented = true });
			string espacio = "----------------------------------------------------------------";
			json = $"{espacio}\n{json}\n{espacio}";
			return json;
		}
	}
	#endregion
	#region "Programa"
	public class Programa
	{
		static string SolicitarString(string mensaje){
		Console.WriteLine(mensaje);
		string entrada = Console.ReadLine();
		return entrada;
		}
		static bool SolicitarBool(string mensaje){
		Console.WriteLine(mensaje);
		string entrada = Console.ReadLine();
		try{
			return bool.Parse(entrada);
		}catch{
			Console.WriteLine("Dato erroneo");
			return SolicitarBool(mensaje);}
		}
		static int SolicitarInt(string mensaje){
		Console.WriteLine(mensaje);
		string entrada = Console.ReadLine();
		try{
			return Int32.Parse(entrada);
		}catch{
			Console.WriteLine("Dato erroneo");
			return SolicitarInt(mensaje);}
		}
		static float SolicitarFloat(string mensaje){
		Console.WriteLine(mensaje);
		string entrada = Console.ReadLine();
		try{
			return float.Parse(entrada);
		}catch{
			Console.WriteLine("Dato erroneo");
			return SolicitarFloat(mensaje);}
		}
		static void AddHabitaciones(List<Habitacion> habitacions){
			string j = "";
			while (j == ""){
				IngresoHabitacion(habitacions);
				Console.WriteLine("Presione enter para continuar agregando\n");
				j = Console.ReadLine();
				}
		}
		static void GuardarDatosHabitacion(List <Habitacion> habitacion){
			string fileName = "BaseDeDatosHabitacion.json";
			string jsonString = JsonSerializer.Serialize(habitacion);
			File.WriteAllTextAsync(fileName, jsonString);}
		static List<Habitacion> CargarDatosHabitacion(){
			string fileName = "BaseDeDatosHabitacion.json";
			string jsonString = File.ReadAllText(fileName);
			List <Habitacion> habitacion = JsonSerializer.Deserialize<List<Habitacion>>(jsonString);
			return habitacion;}
		static void BorrarIndiceHabitacion(List <Habitacion> habitacion, int id){
			try{
				int j = 0;
				foreach(Habitacion H in habitacion){
					if (H.Id == id){
						habitacion.RemoveAt(j);
					}
				j += 1;
				}
			}catch{
				Console.WriteLine("Id erroneo");
			}}
		#region "FiltroHabitacion"
		static void ImprimirHabitacion(List <Habitacion> habitacion){
			int j = 0;
			foreach(Habitacion H in habitacion){
				Console.WriteLine($"Habitacion Nro {j}");
				Console.WriteLine(H);
				j += 1;
			}
		}

		static void ImprimirHabitacion(List <Habitacion> habitacion, int id){
			try{
				foreach(Habitacion H in habitacion){
					if (H.Id == id){
						Console.WriteLine(habitacion[id]);
					}
				}
			}catch{
				Console.WriteLine("Id erroneo");
			}
		}

		static void EditarTipoHabitacion(List <Habitacion> habitacion, int id){
			try{
				foreach(Habitacion H in habitacion){
					if (H.Id == id){
						Console.WriteLine("Actual");
						Console.WriteLine(H);
						SetTipo(H);
					}
				}
			}catch{
				Console.WriteLine("Id erroneo");
			}}
		static void SetTipo(Habitacion habitacion){
			habitacion.Tipo = SolicitarString("Ingrese el tipo\n");
		}
		List<Habitacion> TieneTipo(List <Habitacion> habitacion){
			string valor = SolicitarString("Ingrese un valor");
			bool imprimir = true;
			List<Habitacion> HABITACION = new List<Habitacion>();
			foreach(Habitacion H in habitacion){
				if (H.Tipo == valor){
					HABITACION.Add(H);
				}
			}
			if (imprimir){
				ImprimirHabitacion(HABITACION);
			}
			return HABITACION;
		}
		static void EditarDimensionesHabitacion(List <Habitacion> habitacion, int id){
			try{
				foreach(Habitacion H in habitacion){
					if (H.Id == id){
						Console.WriteLine("Actual");
						Console.WriteLine(H);
						SetDimensiones(H);
					}
				}
			}catch{
				Console.WriteLine("Id erroneo");
			}}
		static void SetDimensiones(Habitacion habitacion){
			List<float> Dimensioness = new List<float>();
			Dimensioness.Add(SolicitarFloat("Ingrese otra dimensiones\n"));
			Dimensioness.Add(SolicitarFloat("Ingrese otra dimensiones\n"));
			Dimensioness.Add(SolicitarFloat("Ingrese otra dimensiones\n"));
			habitacion.Dimensiones = Dimensioness;
		}
		static void EditarColorHabitacion(List <Habitacion> habitacion, int id){
			try{
				foreach(Habitacion H in habitacion){
					if (H.Id == id){
						Console.WriteLine("Actual");
						Console.WriteLine(H);
						SetColor(H);
					}
				}
			}catch{
				Console.WriteLine("Id erroneo");
			}}
		static void SetColor(Habitacion habitacion){
			habitacion.Color = SolicitarString("Ingrese el color\n");
		}
		List<Habitacion> TieneColor(List <Habitacion> habitacion){
			string valor = SolicitarString("Ingrese un valor");
			bool imprimir = true;
			List<Habitacion> HABITACION = new List<Habitacion>();
			foreach(Habitacion H in habitacion){
				if (H.Color == valor){
					HABITACION.Add(H);
				}
			}
			if (imprimir){
				ImprimirHabitacion(HABITACION);
			}
			return HABITACION;
		}
		static void EditarIdHabitacion(List <Habitacion> habitacion, int id){
			try{
				foreach(Habitacion H in habitacion){
					if (H.Id == id){
						Console.WriteLine("Actual");
						Console.WriteLine(H);
						SetId(H);
					}
				}
			}catch{
				Console.WriteLine("Id erroneo");
			}}
		static void SetId(Habitacion habitacion){
			habitacion.Id = SolicitarInt("Ingrese el id\n");
		}
		List<Habitacion> IgualId(List <Habitacion> habitacion){
			int valor = SolicitarInt("Ingrese un valor");
			bool imprimir = true;
			List<Habitacion> HABITACION = new List<Habitacion>();
			foreach(Habitacion H in habitacion){
				if (H.Id == valor){
					HABITACION.Add(H);
				}
			}
			if (imprimir){
				ImprimirHabitacion(HABITACION);
			}
			return HABITACION;
		}
		List<Habitacion> MayorId(List <Habitacion> habitacion){
			int valor = SolicitarInt("Ingrese un valor");
			bool imprimir = true;
			List<Habitacion> HABITACION = new List<Habitacion>();
			foreach(Habitacion H in habitacion){
				if (H.Id > valor){
					HABITACION.Add(H);
				}
			}
			if (imprimir){
				ImprimirHabitacion(HABITACION);
			}
			return HABITACION;
		}
		List<Habitacion> MenorId(List <Habitacion> habitacion){
			int valor = SolicitarInt("Ingrese un valor");
			bool imprimir = true;
			List<Habitacion> HABITACION = new List<Habitacion>();
			foreach(Habitacion H in habitacion){
				if (H.Id < valor){
					HABITACION.Add(H);
				}
			}
			if (imprimir){
				ImprimirHabitacion(HABITACION);
			}
			return HABITACION;
		}
		List<Habitacion> MayorIgualId(List <Habitacion> habitacion){
			int valor = SolicitarInt("Ingrese un valor");
			bool imprimir = true;
			List<Habitacion> HABITACION = new List<Habitacion>();
			foreach(Habitacion H in habitacion){
				if (H.Id >= valor){
					HABITACION.Add(H);
				}
			}
			if (imprimir){
				ImprimirHabitacion(HABITACION);
			}
			return HABITACION;
		}
		List<Habitacion> MenorIgualId(List <Habitacion> habitacion){
			int valor = SolicitarInt("Ingrese un valor");
			bool imprimir = true;
			List<Habitacion> HABITACION = new List<Habitacion>();
			foreach(Habitacion H in habitacion){
				if (H.Id <= valor){
					HABITACION.Add(H);
				}
			}
			if (imprimir){
				ImprimirHabitacion(HABITACION);
			}
			return HABITACION;
		}
		List<Habitacion> DistintoId(List <Habitacion> habitacion){
			int valor = SolicitarInt("Ingrese un valor");
			bool imprimir = true;
			List<Habitacion> HABITACION = new List<Habitacion>();
			foreach(Habitacion H in habitacion){
				if (H.Id != valor){
					HABITACION.Add(H);
				}
			}
			if (imprimir){
				ImprimirHabitacion(HABITACION);
			}
			return HABITACION;
		}
		static void IngresoHabitacion(List <Habitacion> habitacion){
			Habitacion habitacions = new Habitacion();
			Console.WriteLine("Ingreso de Habitacion");
			Console.WriteLine("----------------------------------------------------------------");
			SetTipo(habitacions);
			SetDimensiones(habitacions);
			SetColor(habitacions);
			SetId(habitacions);
			habitacion.Add(habitacions);
			Console.WriteLine("----------------------------------------------------------------");
		}

		#endregion
		static void AddPropiedades(List<Propiedad> propiedads){
			string j = "";
			while (j == ""){
				IngresoPropiedad(propiedads);
				Console.WriteLine("Presione enter para continuar agregando\n");
				j = Console.ReadLine();
				}
		}
		static void GuardarDatosPropiedad(List <Propiedad> propiedad){
			string fileName = "BaseDeDatosPropiedad.json";
			string jsonString = JsonSerializer.Serialize(propiedad);
			File.WriteAllTextAsync(fileName, jsonString);}
		static List<Propiedad> CargarDatosPropiedad(){
			string fileName = "BaseDeDatosPropiedad.json";
			string jsonString = File.ReadAllText(fileName);
			List <Propiedad> propiedad = JsonSerializer.Deserialize<List<Propiedad>>(jsonString);
			return propiedad;}
		static void BorrarIndicePropiedad(List <Propiedad> propiedad, int id){
			try{
				int j = 0;
				foreach(Propiedad P in propiedad){
					if (P.Id == id){
						propiedad.RemoveAt(j);
					}
				j += 1;
				}
			}catch{
				Console.WriteLine("Id erroneo");
			}}
		#region "FiltroPropiedad"
		static void ImprimirPropiedad(List <Propiedad> propiedad){
			int j = 0;
			foreach(Propiedad P in propiedad){
				Console.WriteLine($"Propiedad Nro {j}");
				Console.WriteLine(P);
				j += 1;
			}
		}

		static void ImprimirPropiedad(List <Propiedad> propiedad, int id){
			try{
				foreach(Propiedad P in propiedad){
					if (P.Id == id){
						Console.WriteLine(propiedad[id]);
					}
				}
			}catch{
				Console.WriteLine("Id erroneo");
			}
		}

		static void EditarHabitacionesPropiedad(List <Propiedad> propiedad, int id){
			try{
				foreach(Propiedad P in propiedad){
					if (P.Id == id){
						Console.WriteLine("Actual");
						Console.WriteLine(P);
						SetHabitaciones(P);
					}
				}
			}catch{
				Console.WriteLine("Id erroneo");
			}}
		static void SetHabitaciones(Propiedad propiedad){
			List<Habitacion> Habitacioness = new List<Habitacion>();
			string j = "";
			while (j == ""){
				IngresoHabitacion(Habitacioness);
				j = Console.ReadLine();
				}
			propiedad.Habitaciones = Habitacioness;
		}
		static void EditarUbicacionPropiedad(List <Propiedad> propiedad, int id){
			try{
				foreach(Propiedad P in propiedad){
					if (P.Id == id){
						Console.WriteLine("Actual");
						Console.WriteLine(P);
						SetUbicacion(P);
					}
				}
			}catch{
				Console.WriteLine("Id erroneo");
			}}
		static void SetUbicacion(Propiedad propiedad){
			propiedad.Ubicacion = SolicitarString("Ingrese la ubicacion\n");
		}
		List<Propiedad> TieneUbicacion(List <Propiedad> propiedad){
			string valor = SolicitarString("Ingrese un valor");
			bool imprimir = true;
			List<Propiedad> PROPIEDAD = new List<Propiedad>();
			foreach(Propiedad P in propiedad){
				if (P.Ubicacion == valor){
					PROPIEDAD.Add(P);
				}
			}
			if (imprimir){
				ImprimirPropiedad(PROPIEDAD);
			}
			return PROPIEDAD;
		}
		static void EditarDimensiones_PatioPropiedad(List <Propiedad> propiedad, int id){
			try{
				foreach(Propiedad P in propiedad){
					if (P.Id == id){
						Console.WriteLine("Actual");
						Console.WriteLine(P);
						SetDimensiones_Patio(P);
					}
				}
			}catch{
				Console.WriteLine("Id erroneo");
			}}
		static void SetDimensiones_Patio(Propiedad propiedad){
			List<float> Dimensiones_Patios = new List<float>();
			Dimensiones_Patios.Add(SolicitarFloat("Ingrese la dimension una dimension del patio\n"));
			Dimensiones_Patios.Add(SolicitarFloat("Ingrese la dimension una dimension del patio\n"));
			propiedad.Dimensiones_Patio = Dimensiones_Patios;
		}
		static void EditarDisponible_VentaPropiedad(List <Propiedad> propiedad, int id){
			try{
				foreach(Propiedad P in propiedad){
					if (P.Id == id){
						Console.WriteLine("Actual");
						Console.WriteLine(P);
						SetDisponible_Venta(P);
					}
				}
			}catch{
				Console.WriteLine("Id erroneo");
			}}
		static void SetDisponible_Venta(Propiedad propiedad){
			propiedad.Disponible_Venta = SolicitarBool("Ingrese si está a la venta\n");
		}
		List<Propiedad> EstaDisponible_Venta(List <Propiedad> propiedad){
			bool valor = SolicitarBool("Ingrese un valor");
			bool imprimir = true;
			List<Propiedad> PROPIEDAD = new List<Propiedad>();
			foreach(Propiedad P in propiedad){
				if (P.Disponible_Venta == valor){
					PROPIEDAD.Add(P);
				}
			}
			if (imprimir){
				ImprimirPropiedad(PROPIEDAD);
			}
			return PROPIEDAD;
		}
		List<Propiedad> NoEstaDisponible_Venta(List <Propiedad> propiedad){
			bool valor = SolicitarBool("Ingrese un valor");
			bool imprimir = true;
			List<Propiedad> PROPIEDAD = new List<Propiedad>();
			foreach(Propiedad P in propiedad){
				if (P.Disponible_Venta != valor){
					PROPIEDAD.Add(P);
				}
			}
			if (imprimir){
				ImprimirPropiedad(PROPIEDAD);
			}
			return PROPIEDAD;
		}
		static void EditarVendidaPropiedad(List <Propiedad> propiedad, int id){
			try{
				foreach(Propiedad P in propiedad){
					if (P.Id == id){
						Console.WriteLine("Actual");
						Console.WriteLine(P);
						SetVendida(P);
					}
				}
			}catch{
				Console.WriteLine("Id erroneo");
			}}
		static void SetVendida(Propiedad propiedad){
			propiedad.Vendida = SolicitarBool("Ingrese si está vendida\n");
		}
		List<Propiedad> EstaVendida(List <Propiedad> propiedad){
			bool valor = SolicitarBool("Ingrese un valor");
			bool imprimir = true;
			List<Propiedad> PROPIEDAD = new List<Propiedad>();
			foreach(Propiedad P in propiedad){
				if (P.Vendida == valor){
					PROPIEDAD.Add(P);
				}
			}
			if (imprimir){
				ImprimirPropiedad(PROPIEDAD);
			}
			return PROPIEDAD;
		}
		List<Propiedad> NoEstaVendida(List <Propiedad> propiedad){
			bool valor = SolicitarBool("Ingrese un valor");
			bool imprimir = true;
			List<Propiedad> PROPIEDAD = new List<Propiedad>();
			foreach(Propiedad P in propiedad){
				if (P.Vendida != valor){
					PROPIEDAD.Add(P);
				}
			}
			if (imprimir){
				ImprimirPropiedad(PROPIEDAD);
			}
			return PROPIEDAD;
		}
		static void EditarPrecio_VentaPropiedad(List <Propiedad> propiedad, int id){
			try{
				foreach(Propiedad P in propiedad){
					if (P.Id == id){
						Console.WriteLine("Actual");
						Console.WriteLine(P);
						SetPrecio_Venta(P);
					}
				}
			}catch{
				Console.WriteLine("Id erroneo");
			}}
		static void SetPrecio_Venta(Propiedad propiedad){
			propiedad.Precio_Venta = SolicitarInt("Ingrese el precio de venta\n");
		}
		List<Propiedad> IgualPrecio_Venta(List <Propiedad> propiedad){
			int valor = SolicitarInt("Ingrese un valor");
			bool imprimir = true;
			List<Propiedad> PROPIEDAD = new List<Propiedad>();
			foreach(Propiedad P in propiedad){
				if (P.Precio_Venta == valor){
					PROPIEDAD.Add(P);
				}
			}
			if (imprimir){
				ImprimirPropiedad(PROPIEDAD);
			}
			return PROPIEDAD;
		}
		List<Propiedad> MayorPrecio_Venta(List <Propiedad> propiedad){
			int valor = SolicitarInt("Ingrese un valor");
			bool imprimir = true;
			List<Propiedad> PROPIEDAD = new List<Propiedad>();
			foreach(Propiedad P in propiedad){
				if (P.Precio_Venta > valor){
					PROPIEDAD.Add(P);
				}
			}
			if (imprimir){
				ImprimirPropiedad(PROPIEDAD);
			}
			return PROPIEDAD;
		}
		List<Propiedad> MenorPrecio_Venta(List <Propiedad> propiedad){
			int valor = SolicitarInt("Ingrese un valor");
			bool imprimir = true;
			List<Propiedad> PROPIEDAD = new List<Propiedad>();
			foreach(Propiedad P in propiedad){
				if (P.Precio_Venta < valor){
					PROPIEDAD.Add(P);
				}
			}
			if (imprimir){
				ImprimirPropiedad(PROPIEDAD);
			}
			return PROPIEDAD;
		}
		List<Propiedad> MayorIgualPrecio_Venta(List <Propiedad> propiedad){
			int valor = SolicitarInt("Ingrese un valor");
			bool imprimir = true;
			List<Propiedad> PROPIEDAD = new List<Propiedad>();
			foreach(Propiedad P in propiedad){
				if (P.Precio_Venta >= valor){
					PROPIEDAD.Add(P);
				}
			}
			if (imprimir){
				ImprimirPropiedad(PROPIEDAD);
			}
			return PROPIEDAD;
		}
		List<Propiedad> MenorIgualPrecio_Venta(List <Propiedad> propiedad){
			int valor = SolicitarInt("Ingrese un valor");
			bool imprimir = true;
			List<Propiedad> PROPIEDAD = new List<Propiedad>();
			foreach(Propiedad P in propiedad){
				if (P.Precio_Venta <= valor){
					PROPIEDAD.Add(P);
				}
			}
			if (imprimir){
				ImprimirPropiedad(PROPIEDAD);
			}
			return PROPIEDAD;
		}
		List<Propiedad> DistintoPrecio_Venta(List <Propiedad> propiedad){
			int valor = SolicitarInt("Ingrese un valor");
			bool imprimir = true;
			List<Propiedad> PROPIEDAD = new List<Propiedad>();
			foreach(Propiedad P in propiedad){
				if (P.Precio_Venta != valor){
					PROPIEDAD.Add(P);
				}
			}
			if (imprimir){
				ImprimirPropiedad(PROPIEDAD);
			}
			return PROPIEDAD;
		}
		static void EditarDisponible_AlquilerPropiedad(List <Propiedad> propiedad, int id){
			try{
				foreach(Propiedad P in propiedad){
					if (P.Id == id){
						Console.WriteLine("Actual");
						Console.WriteLine(P);
						SetDisponible_Alquiler(P);
					}
				}
			}catch{
				Console.WriteLine("Id erroneo");
			}}
		static void SetDisponible_Alquiler(Propiedad propiedad){
			propiedad.Disponible_Alquiler = SolicitarBool("Ingrese si está disponible para alquilar\n");
		}
		List<Propiedad> EstaDisponible_Alquiler(List <Propiedad> propiedad){
			bool valor = SolicitarBool("Ingrese un valor");
			bool imprimir = true;
			List<Propiedad> PROPIEDAD = new List<Propiedad>();
			foreach(Propiedad P in propiedad){
				if (P.Disponible_Alquiler == valor){
					PROPIEDAD.Add(P);
				}
			}
			if (imprimir){
				ImprimirPropiedad(PROPIEDAD);
			}
			return PROPIEDAD;
		}
		List<Propiedad> NoEstaDisponible_Alquiler(List <Propiedad> propiedad){
			bool valor = SolicitarBool("Ingrese un valor");
			bool imprimir = true;
			List<Propiedad> PROPIEDAD = new List<Propiedad>();
			foreach(Propiedad P in propiedad){
				if (P.Disponible_Alquiler != valor){
					PROPIEDAD.Add(P);
				}
			}
			if (imprimir){
				ImprimirPropiedad(PROPIEDAD);
			}
			return PROPIEDAD;
		}
		static void EditarAlquiladaPropiedad(List <Propiedad> propiedad, int id){
			try{
				foreach(Propiedad P in propiedad){
					if (P.Id == id){
						Console.WriteLine("Actual");
						Console.WriteLine(P);
						SetAlquilada(P);
					}
				}
			}catch{
				Console.WriteLine("Id erroneo");
			}}
		static void SetAlquilada(Propiedad propiedad){
			propiedad.Alquilada = SolicitarBool("Ingrese si está alquilada\n");
		}
		List<Propiedad> EstaAlquilada(List <Propiedad> propiedad){
			bool valor = SolicitarBool("Ingrese un valor");
			bool imprimir = true;
			List<Propiedad> PROPIEDAD = new List<Propiedad>();
			foreach(Propiedad P in propiedad){
				if (P.Alquilada == valor){
					PROPIEDAD.Add(P);
				}
			}
			if (imprimir){
				ImprimirPropiedad(PROPIEDAD);
			}
			return PROPIEDAD;
		}
		List<Propiedad> NoEstaAlquilada(List <Propiedad> propiedad){
			bool valor = SolicitarBool("Ingrese un valor");
			bool imprimir = true;
			List<Propiedad> PROPIEDAD = new List<Propiedad>();
			foreach(Propiedad P in propiedad){
				if (P.Alquilada != valor){
					PROPIEDAD.Add(P);
				}
			}
			if (imprimir){
				ImprimirPropiedad(PROPIEDAD);
			}
			return PROPIEDAD;
		}
		static void EditarPrecio_AlquilerPropiedad(List <Propiedad> propiedad, int id){
			try{
				foreach(Propiedad P in propiedad){
					if (P.Id == id){
						Console.WriteLine("Actual");
						Console.WriteLine(P);
						SetPrecio_Alquiler(P);
					}
				}
			}catch{
				Console.WriteLine("Id erroneo");
			}}
		static void SetPrecio_Alquiler(Propiedad propiedad){
			propiedad.Precio_Alquiler = SolicitarInt("Ingrese el precio de alquiler\n");
		}
		List<Propiedad> IgualPrecio_Alquiler(List <Propiedad> propiedad){
			int valor = SolicitarInt("Ingrese un valor");
			bool imprimir = true;
			List<Propiedad> PROPIEDAD = new List<Propiedad>();
			foreach(Propiedad P in propiedad){
				if (P.Precio_Alquiler == valor){
					PROPIEDAD.Add(P);
				}
			}
			if (imprimir){
				ImprimirPropiedad(PROPIEDAD);
			}
			return PROPIEDAD;
		}
		List<Propiedad> MayorPrecio_Alquiler(List <Propiedad> propiedad){
			int valor = SolicitarInt("Ingrese un valor");
			bool imprimir = true;
			List<Propiedad> PROPIEDAD = new List<Propiedad>();
			foreach(Propiedad P in propiedad){
				if (P.Precio_Alquiler > valor){
					PROPIEDAD.Add(P);
				}
			}
			if (imprimir){
				ImprimirPropiedad(PROPIEDAD);
			}
			return PROPIEDAD;
		}
		List<Propiedad> MenorPrecio_Alquiler(List <Propiedad> propiedad){
			int valor = SolicitarInt("Ingrese un valor");
			bool imprimir = true;
			List<Propiedad> PROPIEDAD = new List<Propiedad>();
			foreach(Propiedad P in propiedad){
				if (P.Precio_Alquiler < valor){
					PROPIEDAD.Add(P);
				}
			}
			if (imprimir){
				ImprimirPropiedad(PROPIEDAD);
			}
			return PROPIEDAD;
		}
		List<Propiedad> MayorIgualPrecio_Alquiler(List <Propiedad> propiedad){
			int valor = SolicitarInt("Ingrese un valor");
			bool imprimir = true;
			List<Propiedad> PROPIEDAD = new List<Propiedad>();
			foreach(Propiedad P in propiedad){
				if (P.Precio_Alquiler >= valor){
					PROPIEDAD.Add(P);
				}
			}
			if (imprimir){
				ImprimirPropiedad(PROPIEDAD);
			}
			return PROPIEDAD;
		}
		List<Propiedad> MenorIgualPrecio_Alquiler(List <Propiedad> propiedad){
			int valor = SolicitarInt("Ingrese un valor");
			bool imprimir = true;
			List<Propiedad> PROPIEDAD = new List<Propiedad>();
			foreach(Propiedad P in propiedad){
				if (P.Precio_Alquiler <= valor){
					PROPIEDAD.Add(P);
				}
			}
			if (imprimir){
				ImprimirPropiedad(PROPIEDAD);
			}
			return PROPIEDAD;
		}
		List<Propiedad> DistintoPrecio_Alquiler(List <Propiedad> propiedad){
			int valor = SolicitarInt("Ingrese un valor");
			bool imprimir = true;
			List<Propiedad> PROPIEDAD = new List<Propiedad>();
			foreach(Propiedad P in propiedad){
				if (P.Precio_Alquiler != valor){
					PROPIEDAD.Add(P);
				}
			}
			if (imprimir){
				ImprimirPropiedad(PROPIEDAD);
			}
			return PROPIEDAD;
		}
		static void EditarIdPropiedad(List <Propiedad> propiedad, int id){
			try{
				foreach(Propiedad P in propiedad){
					if (P.Id == id){
						Console.WriteLine("Actual");
						Console.WriteLine(P);
						SetId(P);
					}
				}
			}catch{
				Console.WriteLine("Id erroneo");
			}}
		static void SetId(Propiedad propiedad){
			propiedad.Id = SolicitarInt("Ingrese el id\n");
		}
		List<Propiedad> IgualId(List <Propiedad> propiedad){
			int valor = SolicitarInt("Ingrese un valor");
			bool imprimir = true;
			List<Propiedad> PROPIEDAD = new List<Propiedad>();
			foreach(Propiedad P in propiedad){
				if (P.Id == valor){
					PROPIEDAD.Add(P);
				}
			}
			if (imprimir){
				ImprimirPropiedad(PROPIEDAD);
			}
			return PROPIEDAD;
		}
		List<Propiedad> MayorId(List <Propiedad> propiedad){
			int valor = SolicitarInt("Ingrese un valor");
			bool imprimir = true;
			List<Propiedad> PROPIEDAD = new List<Propiedad>();
			foreach(Propiedad P in propiedad){
				if (P.Id > valor){
					PROPIEDAD.Add(P);
				}
			}
			if (imprimir){
				ImprimirPropiedad(PROPIEDAD);
			}
			return PROPIEDAD;
		}
		List<Propiedad> MenorId(List <Propiedad> propiedad){
			int valor = SolicitarInt("Ingrese un valor");
			bool imprimir = true;
			List<Propiedad> PROPIEDAD = new List<Propiedad>();
			foreach(Propiedad P in propiedad){
				if (P.Id < valor){
					PROPIEDAD.Add(P);
				}
			}
			if (imprimir){
				ImprimirPropiedad(PROPIEDAD);
			}
			return PROPIEDAD;
		}
		List<Propiedad> MayorIgualId(List <Propiedad> propiedad){
			int valor = SolicitarInt("Ingrese un valor");
			bool imprimir = true;
			List<Propiedad> PROPIEDAD = new List<Propiedad>();
			foreach(Propiedad P in propiedad){
				if (P.Id >= valor){
					PROPIEDAD.Add(P);
				}
			}
			if (imprimir){
				ImprimirPropiedad(PROPIEDAD);
			}
			return PROPIEDAD;
		}
		List<Propiedad> MenorIgualId(List <Propiedad> propiedad){
			int valor = SolicitarInt("Ingrese un valor");
			bool imprimir = true;
			List<Propiedad> PROPIEDAD = new List<Propiedad>();
			foreach(Propiedad P in propiedad){
				if (P.Id <= valor){
					PROPIEDAD.Add(P);
				}
			}
			if (imprimir){
				ImprimirPropiedad(PROPIEDAD);
			}
			return PROPIEDAD;
		}
		List<Propiedad> DistintoId(List <Propiedad> propiedad){
			int valor = SolicitarInt("Ingrese un valor");
			bool imprimir = true;
			List<Propiedad> PROPIEDAD = new List<Propiedad>();
			foreach(Propiedad P in propiedad){
				if (P.Id != valor){
					PROPIEDAD.Add(P);
				}
			}
			if (imprimir){
				ImprimirPropiedad(PROPIEDAD);
			}
			return PROPIEDAD;
		}
		static void IngresoPropiedad(List <Propiedad> propiedad){
			Propiedad propiedads = new Propiedad();
			Console.WriteLine("Ingreso de Propiedad");
			Console.WriteLine("----------------------------------------------------------------");
			SetHabitaciones(propiedads);
			SetUbicacion(propiedads);
			SetDimensiones_Patio(propiedads);
			SetDisponible_Venta(propiedads);
			SetVendida(propiedads);
			SetPrecio_Venta(propiedads);
			SetDisponible_Alquiler(propiedads);
			SetAlquilada(propiedads);
			SetPrecio_Alquiler(propiedads);
			SetId(propiedads);
			propiedad.Add(propiedads);
			Console.WriteLine("----------------------------------------------------------------");
		}

		#endregion
		public static void BuscarPorHabitacion(){
			Console.WriteLine("Menu: Habitacion");
			Console.WriteLine("Elige una opcion:");

			Console.WriteLine("0) Tipo");
			Console.WriteLine("1) Dimensiones");
			Console.WriteLine("2) Color");
			Console.WriteLine("3) Id");
			Console.WriteLine("4) Exit");
			switch (Console.ReadLine()){
				case "0":
					BuscarPorHabitacionTipo();
					break;
				case "1":
					BuscarPorHabitacionDimensiones();
					break;
				case "2":
					BuscarPorHabitacionColor();
					break;
				case "3":
					BuscarPorHabitacionId();
					break;
				default:
					return;
			}
		}
		public static void BuscarHabitacionTipo(){
			Console.WriteLine("Menu: HabitacionTipo");
			Console.WriteLine("Elige una opcion:");

			Console.WriteLine("0) TieneTipo");
			Console.WriteLine("1) Exit");
			switch (Console.ReadLine()){
				case "0":
					TieneTipo();
					break;
				default:
					return;
			}
		}
		public static void BuscarHabitacionDimensiones(){
			Console.WriteLine("Menu: HabitacionDimensiones");
			Console.WriteLine("Elige una opcion:");

			Console.WriteLine("0) Exit");
			switch (Console.ReadLine()){
				default:
					return;
			}
		}
		public static void BuscarHabitacionColor(){
			Console.WriteLine("Menu: HabitacionColor");
			Console.WriteLine("Elige una opcion:");

			Console.WriteLine("0) TieneColor");
			Console.WriteLine("1) Exit");
			switch (Console.ReadLine()){
				case "0":
					TieneColor();
					break;
				default:
					return;
			}
		}
		public static void BuscarHabitacionId(){
			Console.WriteLine("Menu: HabitacionId");
			Console.WriteLine("Elige una opcion:");

			Console.WriteLine("0) IgualId");
			Console.WriteLine("1) MayorId");
			Console.WriteLine("2) MenorId");
			Console.WriteLine("3) MayorIgualId");
			Console.WriteLine("4) MenorIgualId");
			Console.WriteLine("5) DistintoId");
			Console.WriteLine("6) Exit");
			switch (Console.ReadLine()){
				case "0":
					IgualId();
					break;
				case "1":
					MayorId();
					break;
				case "2":
					MenorId();
					break;
				case "3":
					MayorIgualId();
					break;
				case "4":
					MenorIgualId();
					break;
				case "5":
					DistintoId();
					break;
				default:
					return;
			}
		}
		public static void BuscarPorPropiedad(){
			Console.WriteLine("Menu: Propiedad");
			Console.WriteLine("Elige una opcion:");

			Console.WriteLine("0) Habitaciones");
			Console.WriteLine("1) Ubicacion");
			Console.WriteLine("2) Dimensiones_Patio");
			Console.WriteLine("3) Disponible_Venta");
			Console.WriteLine("4) Vendida");
			Console.WriteLine("5) Precio_Venta");
			Console.WriteLine("6) Disponible_Alquiler");
			Console.WriteLine("7) Alquilada");
			Console.WriteLine("8) Precio_Alquiler");
			Console.WriteLine("9) Id");
			Console.WriteLine("10) Exit");
			switch (Console.ReadLine()){
				case "0":
					BuscarPorPropiedadHabitaciones();
					break;
				case "1":
					BuscarPorPropiedadUbicacion();
					break;
				case "2":
					BuscarPorPropiedadDimensiones_Patio();
					break;
				case "3":
					BuscarPorPropiedadDisponible_Venta();
					break;
				case "4":
					BuscarPorPropiedadVendida();
					break;
				case "5":
					BuscarPorPropiedadPrecio_Venta();
					break;
				case "6":
					BuscarPorPropiedadDisponible_Alquiler();
					break;
				case "7":
					BuscarPorPropiedadAlquilada();
					break;
				case "8":
					BuscarPorPropiedadPrecio_Alquiler();
					break;
				case "9":
					BuscarPorPropiedadId();
					break;
				default:
					return;
			}
		}
		public static void BuscarPropiedadHabitaciones(){
			Console.WriteLine("Menu: PropiedadHabitaciones");
			Console.WriteLine("Elige una opcion:");

			Console.WriteLine("0) Exit");
			switch (Console.ReadLine()){
				default:
					return;
			}
		}
		public static void BuscarPropiedadUbicacion(){
			Console.WriteLine("Menu: PropiedadUbicacion");
			Console.WriteLine("Elige una opcion:");

			Console.WriteLine("0) TieneUbicacion");
			Console.WriteLine("1) Exit");
			switch (Console.ReadLine()){
				case "0":
					TieneUbicacion();
					break;
				default:
					return;
			}
		}
		public static void BuscarPropiedadDimensiones_Patio(){
			Console.WriteLine("Menu: PropiedadDimensiones_Patio");
			Console.WriteLine("Elige una opcion:");

			Console.WriteLine("0) Exit");
			switch (Console.ReadLine()){
				default:
					return;
			}
		}
		public static void BuscarPropiedadDisponible_Venta(){
			Console.WriteLine("Menu: PropiedadDisponible_Venta");
			Console.WriteLine("Elige una opcion:");

			Console.WriteLine("0) EstaDisponible_Venta");
			Console.WriteLine("1) NoEstaDisponible_Venta");
			Console.WriteLine("2) Exit");
			switch (Console.ReadLine()){
				case "0":
					EstaDisponible_Venta();
					break;
				case "1":
					NoEstaDisponible_Venta();
					break;
				default:
					return;
			}
		}
		public static void BuscarPropiedadVendida(){
			Console.WriteLine("Menu: PropiedadVendida");
			Console.WriteLine("Elige una opcion:");

			Console.WriteLine("0) EstaVendida");
			Console.WriteLine("1) NoEstaVendida");
			Console.WriteLine("2) Exit");
			switch (Console.ReadLine()){
				case "0":
					EstaVendida();
					break;
				case "1":
					NoEstaVendida();
					break;
				default:
					return;
			}
		}
		public static void BuscarPropiedadPrecio_Venta(){
			Console.WriteLine("Menu: PropiedadPrecio_Venta");
			Console.WriteLine("Elige una opcion:");

			Console.WriteLine("0) IgualPrecio_Venta");
			Console.WriteLine("1) MayorPrecio_Venta");
			Console.WriteLine("2) MenorPrecio_Venta");
			Console.WriteLine("3) MayorIgualPrecio_Venta");
			Console.WriteLine("4) MenorIgualPrecio_Venta");
			Console.WriteLine("5) DistintoPrecio_Venta");
			Console.WriteLine("6) Exit");
			switch (Console.ReadLine()){
				case "0":
					IgualPrecio_Venta();
					break;
				case "1":
					MayorPrecio_Venta();
					break;
				case "2":
					MenorPrecio_Venta();
					break;
				case "3":
					MayorIgualPrecio_Venta();
					break;
				case "4":
					MenorIgualPrecio_Venta();
					break;
				case "5":
					DistintoPrecio_Venta();
					break;
				default:
					return;
			}
		}
		public static void BuscarPropiedadDisponible_Alquiler(){
			Console.WriteLine("Menu: PropiedadDisponible_Alquiler");
			Console.WriteLine("Elige una opcion:");

			Console.WriteLine("0) EstaDisponible_Alquiler");
			Console.WriteLine("1) NoEstaDisponible_Alquiler");
			Console.WriteLine("2) Exit");
			switch (Console.ReadLine()){
				case "0":
					EstaDisponible_Alquiler();
					break;
				case "1":
					NoEstaDisponible_Alquiler();
					break;
				default:
					return;
			}
		}
		public static void BuscarPropiedadAlquilada(){
			Console.WriteLine("Menu: PropiedadAlquilada");
			Console.WriteLine("Elige una opcion:");

			Console.WriteLine("0) EstaAlquilada");
			Console.WriteLine("1) NoEstaAlquilada");
			Console.WriteLine("2) Exit");
			switch (Console.ReadLine()){
				case "0":
					EstaAlquilada();
					break;
				case "1":
					NoEstaAlquilada();
					break;
				default:
					return;
			}
		}
		public static void BuscarPropiedadPrecio_Alquiler(){
			Console.WriteLine("Menu: PropiedadPrecio_Alquiler");
			Console.WriteLine("Elige una opcion:");

			Console.WriteLine("0) IgualPrecio_Alquiler");
			Console.WriteLine("1) MayorPrecio_Alquiler");
			Console.WriteLine("2) MenorPrecio_Alquiler");
			Console.WriteLine("3) MayorIgualPrecio_Alquiler");
			Console.WriteLine("4) MenorIgualPrecio_Alquiler");
			Console.WriteLine("5) DistintoPrecio_Alquiler");
			Console.WriteLine("6) Exit");
			switch (Console.ReadLine()){
				case "0":
					IgualPrecio_Alquiler();
					break;
				case "1":
					MayorPrecio_Alquiler();
					break;
				case "2":
					MenorPrecio_Alquiler();
					break;
				case "3":
					MayorIgualPrecio_Alquiler();
					break;
				case "4":
					MenorIgualPrecio_Alquiler();
					break;
				case "5":
					DistintoPrecio_Alquiler();
					break;
				default:
					return;
			}
		}
		public static void BuscarPropiedadId(){
			Console.WriteLine("Menu: PropiedadId");
			Console.WriteLine("Elige una opcion:");

			Console.WriteLine("0) IgualId");
			Console.WriteLine("1) MayorId");
			Console.WriteLine("2) MenorId");
			Console.WriteLine("3) MayorIgualId");
			Console.WriteLine("4) MenorIgualId");
			Console.WriteLine("5) DistintoId");
			Console.WriteLine("6) Exit");
			switch (Console.ReadLine()){
				case "0":
					IgualId();
					break;
				case "1":
					MayorId();
					break;
				case "2":
					MenorId();
					break;
				case "3":
					MayorIgualId();
					break;
				case "4":
					MenorIgualId();
					break;
				case "5":
					DistintoId();
					break;
				default:
					return;
			}
		}
	}
	#endregion
}

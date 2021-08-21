using System;
using System.Collections.Generic;
using System.Text.Json;
using System.IO;
namespace Proyecto
{
    #region "Habitacion"
	public class Habitacion
	{
		private string _Tipo;
		public string Tipo { get => _Tipo; set => _Tipo = value; }
		private List <float> _Dimensiones = new List<float>();
		public List <float> Dimensiones { get => _Dimensiones; set => _Dimensiones = value; }
		private string _Color;
		public string Color { get => _Color; set => _Color = value; }
		public Habitacion(string tipo){
			this.Tipo = tipo;
		}
		public Habitacion(){
			this.Tipo = "Cuarto";
		}
		public override string ToString(){
			string json = JsonSerializer.Serialize(this, new JsonSerializerOptions { WriteIndented = true });
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
		public Propiedad(string ubicacion, bool disponible_venta, bool vendida, int precio_venta, bool disponible_alquiler, bool alquilada, int precio_alquiler){
			this.Ubicacion = ubicacion;
			this.Disponible_Venta = disponible_venta;
			this.Vendida = vendida;
			this.Precio_Venta = precio_venta;
			this.Disponible_Alquiler = disponible_alquiler;
			this.Alquilada = alquilada;
			this.Precio_Alquiler = precio_alquiler;
		}
		public Propiedad(){
			this.Ubicacion = "Salto";
			this.Disponible_Venta = false;
			this.Vendida = false;
			this.Precio_Venta = 555;
			this.Disponible_Alquiler = true;
			this.Alquilada = false;
			this.Precio_Alquiler = 555;
		}
		public override string ToString(){
			string json = JsonSerializer.Serialize(this, new JsonSerializerOptions { WriteIndented = true });
			return json;
		}
	}
	#endregion
	#region "Programa"
	public class Programa
	{
		string SolicitarString(string mensaje){
		Console.WriteLine(mensaje);
		string entrada = Console.ReadLine();
		return entrada;
		}
		bool SolicitarBool(string mensaje){
		Console.WriteLine(mensaje);
		string entrada = Console.ReadLine();
		try{
			return bool.Parse(entrada);
		}catch{
			Console.WriteLine("Dato erroneo");
			return SolicitarBool(mensaje);}
		}
		int SolicitarInt(string mensaje){
		Console.WriteLine(mensaje);
		string entrada = Console.ReadLine();
		try{
			return Int32.Parse(entrada);
		}catch{
			Console.WriteLine("Dato erroneo");
			return SolicitarInt(mensaje);}
		}
		float SolicitarFloat(string mensaje){
		Console.WriteLine(mensaje);
		string entrada = Console.ReadLine();
		try{
			return float.Parse(entrada);
		}catch{
			Console.WriteLine("Dato erroneo");
			return SolicitarFloat(mensaje);}
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
		void BorrarIndiceHabitacion(List <Habitacion> habitacion, int id){
			habitacion.RemoveAt(id);}
		#region "FiltroHabitacion"
		void ImprimirHabitacion(List <Habitacion> habitacion){
			int j = 0;
			foreach(Habitacion H in habitacion){
				Console.WriteLine($"Habitacion Nro {j}");
				Console.WriteLine(H);
				j += 1;
			}
		}

		void ImprimirHabitacion(List <Habitacion> habitacion, int id){
			Console.WriteLine(habitacion[id]);
		}

		void SetTipo(Habitacion habitacion){
			habitacion.Tipo = SolicitarString("Ingrese el tipo\n");
		}
		List<Habitacion> TieneTipo(List <Habitacion> habitacion, string valor, bool imprimir){
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
		void SetDimensiones(Habitacion habitacion){
			List<float> Dimensioness = new List<float>();
			Dimensioness.Add(SolicitarFloat("Ingrese otra dimensiones\n"));
			Dimensioness.Add(SolicitarFloat("Ingrese otra dimensiones\n"));
			Dimensioness.Add(SolicitarFloat("Ingrese otra dimensiones\n"));
			habitacion.Dimensiones = Dimensioness;
		}
		void SetColor(Habitacion habitacion){
			habitacion.Color = SolicitarString("Ingrese el color\n");
		}
		List<Habitacion> TieneColor(List <Habitacion> habitacion, string valor, bool imprimir){
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
		void IngresoHabitacion(List <Habitacion> habitacion){
			Habitacion habitacions = new Habitacion();
			Console.WriteLine("Ingreso de Habitacion");
			Console.WriteLine("----------------------------------------------------------------");
			SetTipo(habitacions);
			SetDimensiones(habitacions);
			SetColor(habitacions);
			Console.WriteLine("----------------------------------------------------------------");
			habitacion.Add(habitacions);
		}

		#endregion
		static void GuardarDatosPropiedad(List <Propiedad> propiedad){
			string fileName = "BaseDeDatosPropiedad.json";
			string jsonString = JsonSerializer.Serialize(propiedad);
			File.WriteAllTextAsync(fileName, jsonString);}
		static List<Propiedad> CargarDatosPropiedad(){
			string fileName = "BaseDeDatosPropiedad.json";
			string jsonString = File.ReadAllText(fileName);
			List <Propiedad> propiedad = JsonSerializer.Deserialize<List<Propiedad>>(jsonString);
			return propiedad;}
		void BorrarIndicePropiedad(List <Propiedad> propiedad, int id){
			propiedad.RemoveAt(id);}
		#region "FiltroPropiedad"
		void ImprimirPropiedad(List <Propiedad> propiedad){
			int j = 0;
			foreach(Propiedad P in propiedad){
				Console.WriteLine($"Propiedad Nro {j}");
				Console.WriteLine(P);
				j += 1;
			}
		}

		void ImprimirPropiedad(List <Propiedad> propiedad, int id){
			Console.WriteLine(propiedad[id]);
		}

		void SetHabitaciones(Propiedad propiedad){
			List<Habitacion> Habitacioness = new List<Habitacion>();
			string j = "";
			Console.WriteLine("Presione enter para continuar agregando\n");
			while (j == ""){
				IngresoHabitacion(Habitacioness);
				j = Console.ReadLine();
				}
			propiedad.Habitaciones = Habitacioness;
		}
		void SetUbicacion(Propiedad propiedad){
			propiedad.Ubicacion = SolicitarString("Ingrese la ubicacion\n");
		}
		List<Propiedad> TieneUbicacion(List <Propiedad> propiedad, string valor, bool imprimir){
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
		void SetDimensiones_Patio(Propiedad propiedad){
			List<float> Dimensiones_Patios = new List<float>();
			Dimensiones_Patios.Add(SolicitarFloat("Ingrese la dimension una dimension del patio\n"));
			Dimensiones_Patios.Add(SolicitarFloat("Ingrese la dimension una dimension del patio\n"));
			propiedad.Dimensiones_Patio = Dimensiones_Patios;
		}
		void SetDisponible_Venta(Propiedad propiedad){
			propiedad.Disponible_Venta = SolicitarBool("Ingrese si está a la venta\n");
		}
		List<Propiedad> EstaDisponible_Venta(List <Propiedad> propiedad, bool valor, bool imprimir){
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
		List<Propiedad> NoEstaDisponible_Venta(List <Propiedad> propiedad, bool valor, bool imprimir){
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
		void SetVendida(Propiedad propiedad){
			propiedad.Vendida = SolicitarBool("Ingrese si está vendida\n");
		}
		List<Propiedad> EstaVendida(List <Propiedad> propiedad, bool valor, bool imprimir){
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
		List<Propiedad> NoEstaVendida(List <Propiedad> propiedad, bool valor, bool imprimir){
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
		void SetPrecio_Venta(Propiedad propiedad){
			propiedad.Precio_Venta = SolicitarInt("Ingrese el precio de venta\n");
		}
		List<Propiedad> IgualPrecio_Venta(List <Propiedad> propiedad, int valor, bool imprimir){
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
		List<Propiedad> MayorPrecio_Venta(List <Propiedad> propiedad, int valor, bool imprimir){
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
		List<Propiedad> MenorPrecio_Venta(List <Propiedad> propiedad, int valor, bool imprimir){
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
		List<Propiedad> MayorIgualPrecio_Venta(List <Propiedad> propiedad, int valor, bool imprimir){
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
		List<Propiedad> MenorIgualPrecio_Venta(List <Propiedad> propiedad, int valor, bool imprimir){
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
		List<Propiedad> DistintoPrecio_Venta(List <Propiedad> propiedad, int valor, bool imprimir){
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
		void SetDisponible_Alquiler(Propiedad propiedad){
			propiedad.Disponible_Alquiler = SolicitarBool("Ingrese si está disponible para alquilar\n");
		}
		List<Propiedad> EstaDisponible_Alquiler(List <Propiedad> propiedad, bool valor, bool imprimir){
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
		List<Propiedad> NoEstaDisponible_Alquiler(List <Propiedad> propiedad, bool valor, bool imprimir){
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
		void SetAlquilada(Propiedad propiedad){
			propiedad.Alquilada = SolicitarBool("Ingrese si está alquilada\n");
		}
		List<Propiedad> EstaAlquilada(List <Propiedad> propiedad, bool valor, bool imprimir){
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
		List<Propiedad> NoEstaAlquilada(List <Propiedad> propiedad, bool valor, bool imprimir){
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
		void SetPrecio_Alquiler(Propiedad propiedad){
			propiedad.Precio_Alquiler = SolicitarInt("Ingrese el precio de alquiler\n");
		}
		List<Propiedad> IgualPrecio_Alquiler(List <Propiedad> propiedad, int valor, bool imprimir){
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
		List<Propiedad> MayorPrecio_Alquiler(List <Propiedad> propiedad, int valor, bool imprimir){
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
		List<Propiedad> MenorPrecio_Alquiler(List <Propiedad> propiedad, int valor, bool imprimir){
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
		List<Propiedad> MayorIgualPrecio_Alquiler(List <Propiedad> propiedad, int valor, bool imprimir){
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
		List<Propiedad> MenorIgualPrecio_Alquiler(List <Propiedad> propiedad, int valor, bool imprimir){
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
		List<Propiedad> DistintoPrecio_Alquiler(List <Propiedad> propiedad, int valor, bool imprimir){
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
		void IngresoPropiedad(List <Propiedad> propiedad){
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
			Console.WriteLine("----------------------------------------------------------------");
			propiedad.Add(propiedads);
		}

		#endregion
        static void Main(string[] args)
        {
			Programa programa = new Programa();
            Console.WriteLine("Bienvenido a la aplicacion");
            List <Propiedad> Casas = new List<Propiedad>();
			programa.IngresoPropiedad(Casas);
            //AlquiladaOVendida(Casas);
            //Disponible_Alquiler_Venta(Casas);
			programa.ImprimirPropiedad(Casas);
			GuardarDatosPropiedad(Casas);
            //GuardarDatos(Casas);
        }
    }
    #endregion
}

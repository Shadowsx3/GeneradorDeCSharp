using System;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;
namespace Musica
{
    public class Album
	{
		private string _Nombre;
		public string Nombre { get => _Nombre; set => _Nombre = value; }
		private DateTime _Fecha_Estreno;
		public DateTime Fecha_Estreno { get => _Fecha_Estreno; set => _Fecha_Estreno = value; }
		private List <Cancion> _Canciones = new List<Cancion>();
		public List <Cancion> Canciones { get => _Canciones; set => _Canciones = value; }
		private int _Id;
		public int Id { get => _Id; set => _Id = value; }
		public Album(string nombre, DateTime fecha_estreno, List<Cancion> canciones, int id){
			this.Nombre = nombre;
			this.Fecha_Estreno = fecha_estreno;
			this.Canciones = canciones;
			this.Id = id;
		}
		public Album(){
			this.Nombre = "Cuarto";
			this.Id = 0;
		}
		public override string ToString(){
			string json = JsonSerializer.Serialize(this, new JsonSerializerOptions { WriteIndented = true });
			string espacio = "----------------------------------------------------------------";
			json = $"{espacio}\n{json}\n{espacio}";
			return json;
		}
	}
}
using System;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;
namespace Musica
{
    public class Cancion
	{
		private string _Nombre;
		public string Nombre { get => _Nombre; set => _Nombre = value; }
		private string _Duracion;
		public string Duracion { get => _Duracion; set => _Duracion = value; }
		private int _Id;
		public int Id { get => _Id; set => _Id = value; }
		public Cancion(string nombre, string duracion, int id){
			this.Nombre = nombre;
			this.Duracion = duracion;
			this.Id = id;
		}
		public Cancion(){
			this.Nombre = "Juan";
			this.Duracion = "1 minuto";
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
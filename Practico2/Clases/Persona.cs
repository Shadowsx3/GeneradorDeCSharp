using System;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;
namespace Musica
{
    public class Persona
	{
		private string _Nombre;
		public string Nombre { get => _Nombre; set => _Nombre = value; }
		private string _Apellido;
		public string Apellido { get => _Apellido; set => _Apellido = value; }
		private bool _Activo;
		public bool Activo { get => _Activo; set => _Activo = value; }
		private int _Id;
		public int Id { get => _Id; set => _Id = value; }
		public Persona(string nombre, string apellido, bool activo, int id){
			this.Nombre = nombre;
			this.Apellido = apellido;
			this.Activo = activo;
			this.Id = id;
		}
		public Persona(){
			this.Nombre = "Juan";
			this.Apellido = "Perez";
			this.Activo = true;
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
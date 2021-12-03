using System;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;
namespace Musica
{
    public class Banda
	{
		private string _Nombre;
		public string Nombre { get => _Nombre; set => _Nombre = value; }
		private string _Genero;
		public string Genero { get => _Genero; set => _Genero = value; }
		private List <Persona> _Integrantes = new List<Persona>();
		public List <Persona> Integrantes { get => _Integrantes; set => _Integrantes = value; }
		private List <Album> _Albumes = new List<Album>();
		public List <Album> Albumes { get => _Albumes; set => _Albumes = value; }
		private int _Id;
		public int Id { get => _Id; set => _Id = value; }
		public Banda(string nombre, string genero, List<Persona> integrantes, List<Album> albumes, int id){
			this.Nombre = nombre;
			this.Genero = genero;
			this.Integrantes = integrantes;
			this.Albumes = albumes;
			this.Id = id;
		}
		public Banda(){
			this.Nombre = "Juan";
			this.Genero = "Perez";
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
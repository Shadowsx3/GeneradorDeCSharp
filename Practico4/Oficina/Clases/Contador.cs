using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Oficina
{
    public interface IContador
    {
        void GuardarUsuarios();
        void GuardarTienda();
        void GuardarTareas();
        void AddUser(Usuario u);
        void DoTask(string Cedula, int Tarea);
        void DelTask(int Tarea);
        void AddObj(Objeto o);
        void AddTask(Tarea t);
        string LeerArchivo(string Direccion, bool pref = false);
        void AddItem(string Cedula, int Item);
        void ConsumeItem(string Cedula, int Item);
    }
    public class Contador
    {
        private string path = $"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}/Shadow/";
        private List<Objeto> _tienda;
        private List<Tarea> _tareas;
        private Dictionary<string, Usuario> _usuarios;

        public void GuardarUsuarios()
        {
            string json = JsonConvert.SerializeObject(_usuarios, Formatting.Indented);
            File.WriteAllText(path+ "Usuarios.txt", json);
        }
        public void GuardarTienda()
        {
            string json = JsonConvert.SerializeObject(_tienda, Formatting.Indented);
            File.WriteAllText(path + "Tienda.txt", json);
        }
        public void GuardarTareas()
        {
            string json = JsonConvert.SerializeObject(_tareas, Formatting.Indented);
            File.WriteAllText(path + "Tareas.txt", json);
        }
        public void AddUser(Usuario u)
        {
            _usuarios.Add(u.Cedula, u);
            GuardarUsuarios();
        }
        public void DoTask(string Cedula, int Tarea)
        {
            _tareas[Tarea].CompletedBy = Cedula;
            _usuarios[Cedula].Puntos += _tareas[Tarea].Puntos;
            GuardarTareas();
            GuardarUsuarios();
        }
        public void DelTask(int Tarea)
        {
            _tareas[Tarea].CompletedBy = "-1";
            GuardarTareas();
        }
        public void AddObj(Objeto o)
        {
            _tienda.Add(o);
            GuardarTienda();
        }
        public void AddTask(Tarea t)
        {
            _tareas.Add(t);
            GuardarTareas();
        }

        public List<Objeto> Tienda
        {
            get => _tienda;
            set => _tienda = value;
        }

        public List<Tarea> Tareas
        {
            get => _tareas;
            set => _tareas = value;
        }

        public Dictionary<string, Usuario> Usuarios
        {
            get => _usuarios;
            set => _usuarios = value;
        }

        public string LeerArchivo(string Direccion, bool pref = false)
        {
            string output = "[]";
            if (pref)
            {
                output = @"{""1"":{""Puntos"":0,""Inventario"":[],""Tipo"":""Administrador"",""Contraseña"":""1"",""Cedula"":""1"",""Nombre"":""Admin""}}";
            }
            if (File.Exists(path+Direccion))
            {
                output = File.ReadAllText($"{path}{Direccion}");
            }

            return output;
        }

        public void AddItem(string Cedula, int Item)
        {
            _tienda[Item].Comprador = Cedula;
            _usuarios[Cedula].AddItem(_tienda[Item]);
            _usuarios[Cedula].Puntos -= _tienda[Item].Puntos;
            GuardarTienda();
            GuardarUsuarios();
        }
        public void ConsumeItem(string Cedula, int Item)
        {
            _tienda[Item].Consumido = true;
            _usuarios[Cedula].ConsumeItem(_tienda[Item]);
            GuardarTienda();
            GuardarUsuarios();
        }

        public Contador()
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            _tienda = JsonConvert.DeserializeObject<List<Objeto>>(LeerArchivo("Tienda.txt")) ?? new List<Objeto>();
            _tareas = JsonConvert.DeserializeObject<List<Tarea>>(LeerArchivo("Tareas.txt")) ?? new List<Tarea>();
            _usuarios = JsonConvert.DeserializeObject<Dictionary<string, Usuario>>(LeerArchivo("Usuarios.txt", true)) ?? new Dictionary<string, Usuario>();
        }
    }
}

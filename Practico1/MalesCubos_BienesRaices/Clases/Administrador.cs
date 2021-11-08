using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MalesCubos_BienesRaices.Clases
{
    public class Administrador
    {
        private string path = $"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}/Bienes/";

        private List<Propiedad> propiedades;
        private Dictionary<int, List<Habitacion>> habitaciones;

        public void RemoveAll(int idp)
        {
            List<Habitacion> borrar = habitaciones[idp];
            foreach (Habitacion h in borrar)
            {
                habitaciones[-1].Add(h);
                habitaciones[idp].Remove(h);
            }
            Guardar();
        }

        public void Update()
        {

        }
        public void AddHabitacion(int idp, List<int> habs)
        {
            List<Habitacion> borrar = new List<Habitacion>();
            foreach (Habitacion h in habitaciones[-1])
            {
                if (habs.Contains(h.IdHabitacion))
                {
                    borrar.Add(h);
                }
            }
            foreach (Habitacion h in borrar)
            {
                habitaciones[idp].Add(h);
                habitaciones[-1].Remove(h);
            }
            Guardar();
        }

        public void RemoveHabitacion(int idp, List<int> habs)
        {
            List<Habitacion> borrar = new List<Habitacion>();
            foreach (Habitacion h in habitaciones[idp])
            {
                if (habs.Contains(h.IdHabitacion))
                {
                    borrar.Add(h);
                }
            }
            foreach (Habitacion h in borrar)
            {
                habitaciones[-1].Add(h);
                habitaciones[idp].Remove(h);
            }
            Guardar();
        }
        public int LastP()
        {
            return propiedades.Count;
        }
        public int LastH()
        {
            int x = 0;
            foreach (KeyValuePair<int, List<Habitacion>> lh in habitaciones)
            {
                x += lh.Value.Count;
            }
            return x;
        }
        public void Guardar()
        {
            string json = JsonConvert.SerializeObject(propiedades, Formatting.Indented);
            File.WriteAllText(path + "Propiedades.txt", json);
            json = JsonConvert.SerializeObject(habitaciones, Formatting.Indented);
            File.WriteAllText(path + "Habitaciones.txt", json);
        }
        public string LeerArchivo(string Direccion, bool diccionario = false)
        {
            string output = "[]";
            if (diccionario)
            {
                output = @"{""-1"":[]}";
            }
            if (File.Exists(path + Direccion))
            {
                output = File.ReadAllText($"{path}{Direccion}");
            }

            return output;
        }
        public Administrador()
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            propiedades = JsonConvert.DeserializeObject<List<Propiedad>>(LeerArchivo("Propiedades.txt")) ?? new List<Propiedad>();
            habitaciones = JsonConvert.DeserializeObject<Dictionary<int, List<Habitacion>>>(LeerArchivo("Habitaciones.txt", true)) ?? new Dictionary<int, List<Habitacion>>();
        }
        public void AddPropiedad(Propiedad p)
        {
            propiedades.Add(p);
            habitaciones.Add(p.IdPropiedad, new List<Habitacion>());
            Guardar();
        }

        public void AddHabitacion(Habitacion h)
        {
            habitaciones[-1].Add(h);
            Guardar();
        }
        public Administrador(List<Propiedad> propiedades, Dictionary<int, List<Habitacion>> habitaciones)
        {
            this.propiedades = propiedades;
            this.habitaciones = habitaciones;
        }

        public List<Propiedad> Propiedades
        {
            get => propiedades;
            set => propiedades = value;
        }

        public Dictionary<int, List<Habitacion>> Habitaciones
        {
            get => habitaciones;
            set => habitaciones = value;
        }
    }
}

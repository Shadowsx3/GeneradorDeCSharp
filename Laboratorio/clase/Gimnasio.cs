using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using Newtonsoft.Json;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace gestor_gimnasio.clase
{
    class Gimnasio
    {
        private string path = $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}/save.text";
        private Dictionary<int, Cliente> Socios = new Dictionary<int, Cliente>();
        public Gimnasio()
        {
            string output = "{}";
            if (File.Exists(path))
            {
                output = File.ReadAllText($"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}/save.text");
            }
            Socios = JsonConvert.DeserializeObject<Dictionary<int, Cliente>>(output);
        }
        public void Guardar()
        {
            string json = JsonConvert.SerializeObject(Socios, Formatting.Indented);
            File.WriteAllText(path, json);
        }
        public string IngresarSocio(string Numero, string Nombre, string Apellido, string Peso, string Altura)
        {
            int xNumero = int.Parse(Numero);
            float xPeso = float.Parse(Peso);
            float xAltura = float.Parse(Altura);
            Cliente nuevocliente = new Cliente(xNumero, Nombre, Apellido, xPeso, xAltura);
            if (Socios.ContainsKey(xNumero))
                {
                    return "Ya existe el id";
                }
            Socios.Add(xNumero, nuevocliente);
            Guardar();
            return "Agregado correctamente";
        }
        public float CalcularImc(int Id)
        {
            return Socios[Id].Imc();
        }
        public void PagarCuota(int Id, DateTime fecha)
        { 
            Socios[Id].PagarCuota(fecha);
            Guardar();
        }
        public void Ejercitarse(int Id, string ejercicio)
        {
           Socios[Id].Ejercitarse(ejercicio);
           Guardar();
        }
        public void ActualizarPeso(int Id, string nuevopeso)
        {
           Socios[Id].CambiarPeso(float.Parse(nuevopeso));
           Guardar();
        }
        public void Eliminar(int Id)
        {
           Socios.Remove(Id);
           Guardar();
        }
        public Dictionary<int, Cliente> Listado()
        {
            return Socios;
        }

        public void AddCuota(int Id, DateTime fecha, int Monto)
        {
            Socios[Id].AddCuota(fecha, Monto);
            Guardar();
        }

        public Dictionary<int, int> Deudas(DateTime fecha)
        {
            Dictionary<int, int> res = new Dictionary<int, int>();
            foreach (Cliente c in Socios.Values)
            {
                foreach (Cuota cu in c.Cuotas)
                {
                    if (cu.Fecha.Month == fecha.Month && cu.Fecha.Year == fecha.Year && cu.Pendiente)
                    {
                        res.Add(c.IdSocio, cu.Monto);
                        break;
                    }
                }
            }

            return res;
        }


    }
}

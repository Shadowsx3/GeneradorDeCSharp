using gestor_gimnasio.clase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace gestor_gimnasio
{
    public partial class Form1 : Form
    {
        Gimnasio gym = new Gimnasio();
        int selected;
        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            cbSocio.Items.Clear();
            RenderSocios();
            RenderDeudas();
        }

        private void RenderDeudas()
        {
            dgvClientes.Rows.Clear();
            Dictionary<int, Cliente> People = gym.Listado();
            foreach (KeyValuePair<int, int> entry in gym.Deudas(dtpBuscar.Value))
            {
                Cliente c = People[entry.Key];
                dgvClientes.Rows.Add(entry.Key, $"{c.Nombre} {c.Apellido}", entry.Value);
            }
        }
        private void RenderSocios()
        {
            cbSocio.Items.Clear();
            foreach (Cliente c in gym.Listado().Values.ToArray())
            {
                cbSocio.Items.Add($"{c.IdSocio}) {c.Nombre} {c.Apellido}");
            }
        }
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                string res = gym.IngresarSocio(txtnumero.Text, txtnombre.Text, txtapellido.Text, txtpeso.Text, txtaltura.Text);
                lblEstado.Text = "Estado:" + res;
            }
            catch (Exception ef) { lblEstado.Text = "Estado: Error"; }
            RenderSocios();
        }

        private void Cargar()
        {
            lblImc.Text = $"IMC: {gym.CalcularImc(selected).ToString()}";
            tbPeso.Text = gym.Listado()[selected].Peso.ToString();
            tbEjercicio.Text = gym.Listado()[selected].UltimoEjercicio;
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            gym.Eliminar(selected);
            RenderSocios();
            RenderDeudas();
            lblEstado.Text = "Estado:" + " Cliente eliminado";
        }

        private void cbSocio_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cbSocio.SelectedIndex;
            selected = gym.Listado().Values.ToArray()[index].IdSocio;
            Cargar();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            gym.ActualizarPeso(selected, tbPeso.Text);
            gym.Ejercitarse(selected, tbEjercicio.Text);
            lblEstado.Text = "Estado:" + " Actualizado";
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            gym.PagarCuota(selected, dtpPFecha.Value);
            RenderDeudas();
            lblEstado.Text = "Estado:" + " Cuota pagada";
        }

        private void btnAniadir_Click(object sender, EventArgs e)
        {
            gym.AddCuota(selected, dtpACuota.Value, Convert.ToInt32(tbMonto.Text));
            RenderDeudas();
            lblEstado.Text = "Estado:" + " Cuota añadida";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            RenderDeudas();
        }
    }
}

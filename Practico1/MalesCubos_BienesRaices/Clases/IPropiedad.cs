using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MalesCubos_BienesRaices.Clases
{
    public partial class IPropiedad : Form
    {
        private Administrador admin;
        private Propiedad p;
        public IPropiedad()
        {
            InitializeComponent();
        }
        public void RenderSuperficie()
        {
            float suma = 0;
            dgvSuperficie.Rows.Clear();
            List<Habitacion> hs = new List<Habitacion>();
            if (admin.Habitaciones.TryGetValue(p.IdPropiedad, out hs))
            {
                foreach (Habitacion h in hs)
                {
                    suma += h.Dimensiones;
                    dgvSuperficie.Rows.Add(h.IdHabitacion, h.Nombre, h.Dimensiones);
                }
            }

            tbArea.Text = suma.ToString();
        }
        public void RenderHabitaciones()
        {
            List<Habitacion> hd = admin.Habitaciones[-1];
            List<Habitacion> hs = new List<Habitacion>();
            dgvHabs.Rows.Clear();
            if (admin.Habitaciones.TryGetValue(p.IdPropiedad, out hs))
            {
                foreach (Habitacion h in hs)
                {
                    dgvHabs.Rows.Add(h.IdHabitacion, h.Nombre, false);
                }
            }
            dgvDisp.Rows.Clear();
            foreach (Habitacion h in hd)
            {
                dgvDisp.Rows.Add(h.IdHabitacion, h.Nombre, false);
            }

        }
        public void SetPropiedad(int idP, Administrador Admin)
        {
            admin = Admin;
            foreach (Propiedad po in Admin.Propiedades)
            {
                if (po.IdPropiedad == idP)
                {
                    p = po;
                    break;
                }
            }
            tbNombreP.Text = p.Nombre;
            tbDirP.Text = p.Direccion;
            cbAlquilada.Checked = p.Alquilada;
            cbComprada.Checked = p.Comprada;
            cbDisponibleA.Checked = p.Dalquiler;
            cbDisponibleC.Checked = p.Dcompra;
        }
        private void IPropiedad_Load(object sender, EventArgs e)
        {

        }

        private void tc_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tc.SelectedIndex)
            {
                case 1:
                    RenderHabitaciones();
                    break;
                case 2:
                    RenderSuperficie();
                    break;
            }
        }

        public List<int> Checkear(DataGridView dgv)
        {
            List<int> ids = new List<int>();
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                if ((bool)dgv.Rows[i].Cells[2].Value)
                {
                    ids.Add((int)dgv.Rows[i].Cells[0].Value);
                }
            }

            return ids;
        }
        private void btnAñadir_Click(object sender, EventArgs e)
        {
            admin.AddHabitacion(p.IdPropiedad, Checkear(dgvDisp));
            RenderHabitaciones();
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            admin.RemoveHabitacion(p.IdPropiedad, Checkear(dgvHabs));
            RenderHabitaciones();
        }

        private void IPropiedad_FormClosing(object sender, FormClosingEventArgs e)
        {
            admin.Guardar();
            Form1 parent = (Form1)this.Owner;
            parent.SetAdmin(admin);
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            admin.RemoveAll(p.IdPropiedad);
            admin.Propiedades.Remove(p);
            p.Activo = false;
            admin.Propiedades.Add(p);
            this.Close();
        }
        public bool Checkear(List<TextBox> textos)
        {
            foreach (TextBox t in textos)
            {
                if (t.Text.Trim() == "")
                {
                    return false;
                }
            }

            return true;
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Checkear(new List<TextBox>() {tbNombreP, tbDirP}))
            {
                Propiedad pi = new Propiedad(
                    p.IdPropiedad,
                    tbDirP.Text,
                    tbNombreP.Text,
                    cbComprada.Checked,
                    cbAlquilada.Checked,
                    cbDisponibleC.Checked,
                    cbDisponibleA.Checked);
                admin.Propiedades.Remove(p);
                admin.Propiedades.Add(pi);
                p = pi;
            }
        }
    }
}

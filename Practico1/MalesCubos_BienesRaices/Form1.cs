using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MalesCubos_BienesRaices.Clases;

namespace MalesCubos_BienesRaices
{
    public partial class Form1 : Form
    {
        private Administrador admin;
        private IPropiedad propi;
        public Form1()
        {
            InitializeComponent();
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
        private void Form1_Load(object sender, EventArgs e)
        {
            admin = new Administrador();
            RenderBuscador();
        }

        private void btnAP_Click(object sender, EventArgs e)
        {
            if (Checkear(new List<TextBox>() { tbNombreP, tbDirP }))
            {
                Propiedad p = new Propiedad(
                    admin.LastP(), 
                    tbDirP.Text, 
                    tbNombreP.Text,
                    cbComprada.Checked, 
                    cbAlquilada.Checked, 
                    cbDisponibleC.Checked, 
                    cbDisponibleA.Checked);
                admin.AddPropiedad(p);
                tbDirP.Text = "";
                tbNombreP.Text = "";
                cbComprada.Checked = false;
                cbAlquilada.Checked = false;
                cbDisponibleC.Checked = false;
                cbDisponibleA.Checked = false;
            }
        }

        private void btnAH_Click(object sender, EventArgs e)
        {
            if (Checkear(new List<TextBox>() { tbNombreH }))
            {
                Habitacion h = new Habitacion(
                    admin.LastH(),
                    tbNombreH.Text,
                    (float)nuAreaH.Value);
                admin.AddHabitacion(h);
                tbNombreH.Text = "";
                nuAreaH.Value = 0;
            }
        }

        public void RenderSuperficie()
        {
            Dictionary<int, List<Habitacion>>hs = admin.Habitaciones;
            List<Propiedad> ps = admin.Propiedades;
            dgvSuperficie.Rows.Clear();
            foreach (Propiedad p in ps)
            {
                foreach (Habitacion h in hs[p.IdPropiedad])
                {
                    dgvSuperficie.Rows.Add(h.IdHabitacion, h.Nombre, p.Nombre, h.Dimensiones, false);
                }
            }
            foreach (Habitacion h in hs[-1])
            {
                dgvSuperficie.Rows.Add(h.IdHabitacion, h.Nombre, "", h.Dimensiones, false);
            }
        }

        public void RenderBuscador(object sender = default, EventArgs e = default)
        {
            List<Propiedad> ps = admin.Propiedades;
            foreach (Propiedad p in admin.Propiedades)
            {
                if (!p.Activo)
                {
                    ps.Remove(p);
                }

            }
            List<Propiedad> psfiltradas = new List<Propiedad>();
            if (tbNombreBP.Text.Trim() != "")
            {
                foreach (Propiedad p in ps)
                {
                    if (p.Nombre.Contains(tbNombreBP.Text, StringComparison.InvariantCultureIgnoreCase))
                    {
                        psfiltradas.Add(p);
                    }
                }
                ps = psfiltradas;
            }
            ps = filtroCb(cbBAlquilada, ps, 0);
            ps = filtroCb(cbBComprada, ps, 1);
            ps = filtroCb(cbBDAlquiler, ps, 2);
            ps = filtroCb(cbBDCompra, ps, 3);
            dgvPB.Rows.Clear();
            foreach (Propiedad p in ps)
            {
                dgvPB.Rows.Add(p.IdPropiedad, p.Nombre);
            }
        }

        private List<Propiedad> filtroCb(CheckBox cb, List<Propiedad> actual, int num)
        {
            if (cb.CheckState != CheckState.Unchecked)
            {
                List<Propiedad> res = new List<Propiedad>();
                bool checke = cb.CheckState == CheckState.Checked;
                switch (num)
                {
                    case 0:
                        foreach (Propiedad p in actual)
                        {
                            if (p.Alquilada == checke)
                            {
                                res.Add(p);
                            }
                        }

                        break;
                    case 1:
                        foreach (Propiedad p in actual)
                        {
                            if (p.Comprada == checke)
                            {
                                res.Add(p);
                            }
                        }

                        break;
                    case 2:
                        foreach (Propiedad p in actual)
                        {
                            if (p.Dalquiler == checke)
                            {
                                res.Add(p);
                            }
                        }

                        break;
                    case 3:
                        foreach (Propiedad p in actual)
                        {
                            if (p.Dcompra == checke)
                            {
                                res.Add(p);
                            }
                        }

                        break;

                }
                return res;
            }

            return actual;

        }
        private void btnBuscarP_Click(object sender, EventArgs e)
        {
            RenderBuscador();
        }

        private void tc_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tc.SelectedIndex)
            {
                case 0:
                    RenderBuscador();
                    break;
                case 2:
                    RenderSuperficie();
                    break;
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            float area = 0;
            for (int i = 0; i < dgvSuperficie.Rows.Count; i++)
            {
                if ((bool)dgvSuperficie.Rows[i].Cells[4].Value)
                {
                    area += float.Parse(dgvSuperficie.Rows[i].Cells[3].Value.ToString());
                }
            }

            tbAreaTotal.Text = area.ToString();
        }

        private void dgvPB_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        public void SetAdmin(Administrador a)
        {
            admin = a;
        }
        private void dgvPB_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            int id = (int)dgvPB.Rows[dgvPB.SelectedCells[0].RowIndex].Cells[0].Value;
            propi = new IPropiedad();
            propi.Closed += new EventHandler(RenderBuscador);
            propi.SetPropiedad(id, admin);
            propi.ShowDialog(this);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            admin.Guardar();
        }
        
    }
}

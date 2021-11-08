using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Oficina
{
    public partial class Menu : Form
    {
        private Contador contador;
        private Usuario user;
        private List<string> cedulas = new List<string>();
        private string cedula;
        public Menu(Contador xcontador, string Cedula)
        {
            InitializeComponent();
            contador = xcontador;
            user = contador.Usuarios[Cedula];
            cedula = Cedula;
            RenderUser();
            RenderTareas();
            if (user.Tipo == "Usuario")
            {
                tc1.TabPages[3].Visible = false;
                tc1.TabPages[4].Visible = false;
                lblSel.Visible = false;
                cbUsuario.Visible = false;
                button1.Visible = false;
            }
            else if (user.Tipo == "Coordinador")
            {
                tc1.TabPages[4].Visible = false;
                lblSel.Visible = false;
                cbUsuario.Visible = false;
                button1.Visible = false;
            }
        }

        public void UpdateUser()
        {
            user = contador.Usuarios[user.Cedula];
        }
        private void Menu_Load(object sender, EventArgs e)
        {
        }

        public void RenderUser()
        {
            tbNombreP.Text = user.Nombre;
            tbPuntosP.Text = user.Puntos.ToString();
            tbAñadido.Text = user.Nombre;
            tbPuntos.Text = user.Puntos.ToString();
        }
       
        
        private void Inicio_Click(object sender, EventArgs e)
        {

        }

        public bool Checkear(List<TextBox> textos)
        {
            foreach (TextBox t in textos)
            {
                if (t.Text.Trim() == "")
                {
                    lblEstado.Text = "Falta completar un campo";
                    return false;
                }
            }

            return true;
        }

        public void RenderContador()
        {
            dgvContador.Rows.Clear();
            foreach (Usuario u in contador.Usuarios.Values)
            {
                dgvContador.Rows.Add(u.Nombre, u.Puntos.ToString());
            }
            dgvContador.Sort(dgvContador.Columns[1], ListSortDirection.Descending);
        }
        public void RenderTareas()
        {
            dgvTareas.Rows.Clear();
            foreach (Tarea t in contador.Tareas)
            {
                if (t.CompletedBy == "")
                {
                    dgvTareas.Rows.Add(t.Id, t.Nombre, t.Puntos.ToString(), false);
                }
            }
        }
        public void RenderTienda()
        {
            dgvTienda.Rows.Clear();
            foreach (Objeto o in contador.Tienda)
            {
                if (o.Comprador == "")
                {
                    dgvTienda.Rows.Add(o.Id, o.Nombre, o.Puntos.ToString(), contador.Usuarios[o.Cedula].Nombre, false);
                }
            }
        }
        public void RenderInventario(string Cedula)
        {
            dgvInventario.Rows.Clear();
            foreach (Objeto o in contador.Usuarios[Cedula].Inventario)
            {
                if (!o.Consumido)
                {
                    dgvInventario.Rows.Add(o.Id, o.Nombre, false);
                }
            }
        }
        private void btnAgregarU_Click(object sender, EventArgs e)
        {
            if (Checkear(new List<TextBox>() {tbNombre, tbCedula, tbContraseña}))
            {
                Usuario u = new Usuario(tbCedula.Text, tbNombre.Text, tbContraseña.Text, sbTipo.Text);
                contador.AddUser(u);
                lblEstado.Text = "Agregado";
            }

            RenderContador();
        }

        public void RenderUsuarios()
        {
            cbUsuario.Items.Clear();
            cedulas.Clear();
            foreach (Usuario u in contador.Usuarios.Values)
            {
                cedulas.Add(u.Cedula);
                cbUsuario.Items.Add(u.Nombre);
            }
        }
        private void tc1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tc1.SelectedIndex)
            {
                case 0:
                    RenderTareas();
                    break;
                case 1:
                    RenderTienda();
                    break;
                case 2:
                    RenderInventario(cedula);
                    RenderUsuarios();
                    break;
                case 4:
                  RenderContador();
                    break;

            }
        }

        private void btnAgregarO_Click(object sender, EventArgs e)
        {
            if (Checkear(new List<TextBox>() { tbNombreO }))
            {
                
                Objeto o = new Objeto(contador.Tienda.Count,user.Cedula, tbNombreO.Text, (int)nuO.Value);
                contador.AddObj(o);
                lblEstado.Text = "Agregado";
            }
        }

        private void btnCanjear_Click(object sender, EventArgs e)
        {
            int points = user.Puntos;
            List<int> compras = new List<int>();
            for (int i = 0; i < dgvTienda.Rows.Count; i++)
            {
                if ((bool)dgvTienda.Rows[i].Cells[4].Value)
                {
                    compras.Add(int.Parse(dgvTienda.Rows[i].Cells[0].Value.ToString()));
                    points -= int.Parse(dgvTienda.Rows[i].Cells[2].Value.ToString());
                }
            }

            if (points < 0)
            {
                lblEstado.Text = "No alcanzan los puntos";
            }
            else
            {
                foreach (int i in compras)
                {
                    contador.AddItem(user.Cedula, i);
                }
                lblEstado.Text = "Compra realizada";
                UpdateUser();
                RenderUser();
                RenderTienda();
            }
        }

        private void btnConsumir_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvInventario.Rows.Count; i++)
            {
                if ((bool)dgvInventario.Rows[i].Cells[2].Value)
                {
                    contador.ConsumeItem(cedula, int.Parse(dgvInventario.Rows[i].Cells[0].Value.ToString()));
                }
            }
            RenderInventario(cedula);
        }

        private void bgnAgregarT_Click(object sender, EventArgs e)
        {
            if (Checkear(new List<TextBox>() { tbNombreT }))
            {
                Tarea t = new Tarea(contador.Tareas.Count, tbNombreT.Text, (int)nuT.Value);
                contador.AddTask(t);
                lblEstado.Text = "Agregada";
            }
        }

        private void btnRealizarTarea_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvTareas.Rows.Count; i++)
            {
                if ((bool)dgvTareas.Rows[i].Cells[3].Value)
                {
                    contador.DoTask(user.Cedula, int.Parse(dgvTareas.Rows[i].Cells[0].Value.ToString()));
                }
            }
            RenderUser();
            RenderTareas();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvTareas.Rows.Count; i++)
            {
                if ((bool)dgvTareas.Rows[i].Cells[3].Value)
                {
                    contador.DelTask( int.Parse(dgvTareas.Rows[i].Cells[0].Value.ToString()));
                }
            }
            RenderTareas();
        }

        private void cbUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            cedula = cedulas[cbUsuario.SelectedIndex];
            RenderInventario(cedula);
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Login l = (Login)this.Owner;
            l.Visible = true;
        }
    }
}

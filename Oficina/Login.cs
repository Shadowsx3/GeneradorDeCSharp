using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Oficina;

namespace Oficina
{
    public partial class Login : Form
    {
        private Dictionary<string, Usuario> _usuarios;
        private bool Logued = false;
        Menu parent;
        public Login(Dictionary<string, Usuario> usuarios)
        {
            InitializeComponent();
            _usuarios = usuarios;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Usuario user;
            bool keyExists = _usuarios.TryGetValue(tbCedulaL.Text, out user);
            if (keyExists)
            {
                if (tbContraseña.Text == user.Contraseña)
                {
                    Logued = true;
                }
            }
            parent.Logued(Logued, tbCedulaL.Text);
            this.Close();
        }
        

        private void Login_Load(object sender, EventArgs e)
        {
            parent = (Menu)this.Owner;
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            parent.Cerrar();
        }
    }
}

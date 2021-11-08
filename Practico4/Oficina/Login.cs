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
        private Contador contador;
        private Menu menu;
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Usuario user;
            bool keyExists = contador.Usuarios.TryGetValue(tbCedulaL.Text, out user);
            if (keyExists)
            {
                if (tbContraseña.Text == user.Contraseña)
                {
                    menu = new Menu(contador, tbCedulaL.Text);
                    menu.Show(this);
                    this.Visible = false;
                }
            }
        }

        public void Cerrar()
        {
            this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            contador = new Contador();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
    }
}

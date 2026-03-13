using CapaNegocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            txtClave.PasswordChar = '*';
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string nombre = txtUsuario.Text.Trim();
            string clave = txtClave.Text.Trim();

            if (nombre == "" || clave == "")
            {
                MessageBox.Show("Complete todos los campos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Validar credenciales
            if (nombre == "admin" && clave == "1234")
            {

                Usuario usuario = new Usuario(nombre, clave);


                MessageBox.Show(usuario.Bienvenida(), "Acceso concedido", MessageBoxButtons.OK, MessageBoxIcon.Information);


                MessageBox.Show("Rol: " + usuario.ObtenerRol());


                WF_home home = new WF_home();
                home.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o clave incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

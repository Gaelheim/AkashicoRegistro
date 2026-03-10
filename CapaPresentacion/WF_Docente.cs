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
    public partial class WF_Docente : Form
    {
        CN_Docente docente = new CN_Docente();
        private int docenteID = 0;
        private bool Editar = false;
        public WF_Docente()
        {
            InitializeComponent();
            txtCorreo.KeyPress += txtCorreo_KeyPress;
            txtCorreo.Leave += txtCorreo_Leave;
            txtCorreo.TextChanged += txtCorreo_TextChanged;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void WF_Docente_Load(object sender, EventArgs e)
        {
            MostrarDocente();
        }

        private void MostrarDocente()
        {
            dgvDocente.DataSource = docente.MostrarDocente();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Editar == false)
            {

                try
                {

                    docente.InsertarDocente(txtNombre.Text, txtTitulo.Text, txtCorreo.Text, txtTelefono.Text);
                    MessageBox.Show("Se guardaron los datos correctamente!");
                    MostrarDocente();
                    LimpiarForm();


                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudieron guardar los datos por: " + ex);
                }

            }

            if (Editar == true)
            {

                try
                {

                    docente.EditarDocente(docenteID, txtNombre.Text, txtTitulo.Text, txtCorreo.Text, txtTelefono.Text);
                    MessageBox.Show("Se editaron los datos correctamente!");
                    MostrarDocente();
                    LimpiarForm();
                    Editar = false;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudieron editar los datos por: " + ex);
                }

            }
        }

        private void LimpiarForm()
        {
            txtNombre.Clear();
            txtTitulo.Clear();
            txtCorreo.Clear();
            txtTelefono.Clear();

        }
        private void btnEditar_Click(object sender, EventArgs e)
        {

            if (dgvDocente.SelectedRows.Count > 0)
            {
                Editar = true;
                txtNombre.Text = dgvDocente.CurrentRow.Cells["Nombre"].Value.ToString();
                txtTitulo.Text = dgvDocente.CurrentRow.Cells["Titulo"].Value.ToString();
                txtCorreo.Text = dgvDocente.CurrentRow.Cells["Correo"].Value.ToString();
                txtTelefono.Text = dgvDocente.CurrentRow.Cells["Telefono"].Value.ToString();
                docenteID = Convert.ToInt32(dgvDocente.CurrentRow.Cells["DocenteID"].Value);
            }
            else
            {
                MessageBox.Show("Seleccione una fila, por favor");
            }
        }

        private void btnParticipantes_Click(object sender, EventArgs e)
        {
            Form1 participante = new Form1();
            participante.Show();
            this.Close();
        }

        private void btnCursos_Click(object sender, EventArgs e)
        {
            WF_Curso curso = new WF_Curso();
            curso.Show();
            this.Close();
        }

        private void btnPrograma_Click(object sender, EventArgs e)
        {
            WF_Programa programa = new WF_Programa();
            programa.Show();
            this.Close();
        }

        private void btnInscripciones_Click(object sender, EventArgs e)
        {
            WF_Inscripciones_Centro inscripciones = new WF_Inscripciones_Centro();
            inscripciones.Show();
            this.Close();
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                return;
            }

            // Evita espacio al inicio o espacios dobles
            if (e.KeyChar == ' ')
            {
                string texto = ((TextBox)sender).Text;
                if (texto.Length == 0 || texto.EndsWith(" "))
                {
                    e.Handled = true;
                }
            }
        }

        private void txtTitulo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                return;
            }

            // Evita espacio al inicio o espacios dobles
            if (e.KeyChar == ' ')
            {
                string texto = ((TextBox)sender).Text;
                if (texto.Length == 0 || texto.EndsWith(" "))
                {
                    e.Handled = true;
                }
            }
        }

        private void txtCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Este es otro keypress que estaremos modificando para que se adapte a lo necesario
            //para el formato de correo electrónico, permitiendo solo caracteres válidos para un correo

            string caracteresValidos = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789@._-+";

            if (!caracteresValidos.Contains(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtCorreo_Leave(object sender, EventArgs e)
        {
            //con este evento validamos el formato del correo electrónico utilizando una expresión regular, mostrando un mensaje de error si el formato es inválido

            TextBox txt = (TextBox)sender; //convertimos el sender a un TextBox para poder manipular su texto y así validar el formato del correo

            // Expresión regular para validar el formato del correo electrónico
            string patron = @"^[a-zA-Z0-9._%+\-]+@[a-zA-Z0-9.\-]+\.[a-zA-Z]{2,}$";

            if (!System.Text.RegularExpressions.Regex.IsMatch(txt.Text, patron))
            {
                MessageBox.Show("Formato inválido. Use: ejemplo@correo.com",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                txt.Focus();
                txt.SelectAll();
            }
        }

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            string patron = @"^[a-zA-Z0-9._%+\-]+@[a-zA-Z0-9.\-]+\.[a-zA-Z]{2,}$";

            if (System.Text.RegularExpressions.Regex.IsMatch(txt.Text, patron))
            {
                txt.BackColor = Color.LightGreen;  // Correo válido
            }
            else
            {
                txt.BackColor = Color.LightCoral;  // Correo inválido
            }
        }
        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txt = (TextBox)sender;
            string caracteresValidos = "0123456789()-";
            string texto = txt.Text;

            if (!caracteresValidos.Contains(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }

            if (texto.Length >= 13 && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            WF_home home = new WF_home();
            home.Show();
            this.Close();
        }
    }
}

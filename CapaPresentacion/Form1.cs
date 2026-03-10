using CapaNegocios;
using static System.Net.Mime.MediaTypeNames;


namespace CapaPresentacion
{
    public partial class Form1 : Form
    {
        Estudiantes estudiante = new Estudiantes();
        private string matricula = null;
        private bool Editar = false;
        public Form1()
        {
            InitializeComponent();
            txtCorreo.KeyPress += txtCorreo_KeyPress;
            txtCorreo.Leave += txtCorreo_Leave;
            txtCorreo.TextChanged += txtCorreo_TextChanged;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Mostrarestudiante();
        }

        private void Mostrarestudiante()
        {
            dataGridView1.DataSource = estudiante.MostrarEstudiantes();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (Editar == false)
            {

                try
                {
                    estudiante.InsertarEstudiante(txtNombre.Text, txtApellido.Text, txtCedula.Text, txtCorreo.Text, txtTelefono.Text);
                    MessageBox.Show("Se guardaron los datos correctamente!");
                    Mostrarestudiante();
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
                    estudiante.EditarParticipante(matricula, txtNombre.Text, txtApellido.Text, txtCedula.Text, txtCorreo.Text, txtTelefono.Text);
                    MessageBox.Show("Se editaron los datos correctamente!");
                    Mostrarestudiante();
                    LimpiarForm();
                    Editar = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudieron editar los datos por: " + ex);
                }

            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Editar = true;
                txtNombre.Text = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
                txtApellido.Text = dataGridView1.CurrentRow.Cells["Apellido"].Value.ToString();
                txtCedula.Text = dataGridView1.CurrentRow.Cells["Cedula"].Value.ToString();
                txtCorreo.Text = dataGridView1.CurrentRow.Cells["Correo"].Value.ToString();
                txtTelefono.Text = dataGridView1.CurrentRow.Cells["Telefono"].Value.ToString();
                matricula = dataGridView1.CurrentRow.Cells["Matricula"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione una fila, por favor");
            }
        }

        private void LimpiarForm()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtCedula.Clear();
            txtCorreo.Clear();
            txtTelefono.Clear();

        }

        private void btnBajaA_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                matricula = dataGridView1.CurrentRow.Cells["Matricula"].Value.ToString();
                estudiante.CambiarEstatusA(matricula);
                MessageBox.Show("Estatus modificado con exito");
                Mostrarestudiante();
            }
            else
            {
                MessageBox.Show("Seleccione una fila, por favor");
            }
        }

        private void btnBajaM_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                matricula = dataGridView1.CurrentRow.Cells["Matricula"].Value.ToString();
                estudiante.CambiarEstatusM(matricula);
                MessageBox.Show("Estatus modificado con exito");
                Mostrarestudiante();
            }
            else
            {
                MessageBox.Show("Seleccione una fila, por favor");
            }
        }

        private void btnActivar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                matricula = dataGridView1.CurrentRow.Cells["Matricula"].Value.ToString();
                estudiante.ActivarEstudiante(matricula);
                MessageBox.Show("Estatus modificado con exito");
                Mostrarestudiante();
            }
            else
            {
                MessageBox.Show("Seleccione una fila, por favor");
            }
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

        private void btnDocentes_Click(object sender, EventArgs e)
        {
            WF_Docente docente = new WF_Docente();
            docente.Show();
            this.Close();
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            //usamos este KeyPress para validar que solo se puedan ingresar letras y espacios en el campo de nombre
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                return;
            }

            if (e.KeyChar == ' ')
            {
                string texto = ((TextBox)sender).Text;
                if (texto.Length == 0 || texto.EndsWith(" "))
                {
                    e.Handled = true;
                }
            }
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            //En este caso nuestro KeyPress se hace un poco más complejo, debido al formato necesario para la CEDULA

            TextBox txt = (TextBox)sender; //convertimos el sender a un TextBox para poder manipular su texto y la posición del cursor
            string texto = txt.Text; //variable que nos servira para validar el formato de la cedula y así insertar el guión en el lugar correcto
            int pos = txt.SelectionStart; //variable que nos servira para saber la posición del cursor y así insertar el guión en el lugar correcto

            // Solo permite números y Backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                return;
            }

            // Inserta guión automáticamente
            if (e.KeyChar != (char)Keys.Back)
            {
                if (pos == 3 || pos == 11) // Posición del guión
                {
                    txt.Text = texto.Insert(pos, "-"); //inserta el guión en la posición correcta
                    txt.SelectionStart = pos + 1; //mueve el cursor después del guión
                }
            }

            // Limita la longitud máxima a 13 caracteres
            if (texto.Length >= 13 && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
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
            //Este KeyPress es similar al de la cedula, pero con un formato diferente, permitiendo solo números, guiones y paréntesis, y limitando la longitud a 13 caracteres

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

        private void txtCedula_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnInscripciones_Click(object sender, EventArgs e)
        {
            WF_Inscripciones_Centro inscripciones_Centro = new WF_Inscripciones_Centro();
            inscripciones_Centro.Show();
            this.Close();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            WF_home home = new WF_home();
            home.Show();
            this.Close();
        }
    }
}

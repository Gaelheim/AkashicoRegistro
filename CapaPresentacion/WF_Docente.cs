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
    //TODO: Formulario para gestionar los docentes, con funcionalidades para agregar, editar, eliminar
    public partial class WF_Docente : Form
    {
        CN_Docente docente = new CN_Docente(); // Instancia de la clase CN_Docente para acceder a las operaciones relacionadas con los docentes
        private int docenteID = 0; // Variable para almacenar el ID del docente seleccionado para editar o eliminar
        private bool Editar = false; // Variable para indicar si se está editando un docente (true) o insertando uno nuevo (false)
        public WF_Docente()
        {
            InitializeComponent();
            txtCorreo.KeyPress += txtCorreo_KeyPress; // Evento KeyPress para validar caracteres permitidos en el campo de correo electrónico
            txtCorreo.Leave += txtCorreo_Leave;  // Evento Leave para validar el formato del correo electrónico cuando el usuario sale del campo
            txtCorreo.TextChanged += txtCorreo_TextChanged; // Evento TextChanged para cambiar el color de fondo del campo de correo según la validez del formato
        }

        //TODO: Evento Load del formulario para mostrar los docentes al cargar la ventana.
        private void WF_Docente_Load(object sender, EventArgs e)
        {
            MostrarDocente();
        }

        //evento para mostrar los datos de los docentes en el DataGridView, obteniendo los datos a través de la clase CN_Docente
        private void MostrarDocente()
        {
            dgvDocente.DataSource = docente.MostrarDocente();
        }


        //evento Click del botón "Guardar" para agregar un nuevo docente o editar uno existente, dependiendo del estado de la variable Editar.
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

        //evento Click del botón "Editar" para cargar los datos del docente seleccionado en los campos de texto para su edición, y establecer la variable Editar en true para indicar que se está editando un docente existente.
        private void LimpiarForm()
        {
            txtNombre.Clear();
            txtTitulo.Clear();
            txtCorreo.Clear();
            txtTelefono.Clear();

        }

        //evento Click del botón "Editar" para cargar los datos del docente seleccionado en los campos de texto para su edición, y establecer la variable Editar en true para indicar que se está editando un docente existente.
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

        //eventos Click de los botones para navegar a otras secciones del sistema, como participantes, cursos, programas e inscripciones, cerrando el formulario actual y abriendo el formulario correspondiente a la sección seleccionada.
        private void btnParticipantes_Click(object sender, EventArgs e)
        {
            Form1 participante = new Form1();
            participante.Show();
            this.Close();
        }

        //evento Click del botón "Cursos" para abrir el formulario de gestión de cursos, cerrando el formulario actual.
        private void btnCursos_Click(object sender, EventArgs e)
        {
            WF_Curso curso = new WF_Curso();
            curso.Show();
            this.Close();
        }

        //evento Click del botón "Programas" para abrir el formulario de gestión de programas, cerrando el formulario actual.
        private void btnPrograma_Click(object sender, EventArgs e)
        {
            WF_Programa programa = new WF_Programa();
            programa.Show();
            this.Close();
        }

        //evento Click del botón "Inscripciones" para abrir el formulario de gestión de inscripciones, cerrando el formulario actual.
        private void btnInscripciones_Click(object sender, EventArgs e)
        {
            WF_Inscripciones_Centro inscripciones = new WF_Inscripciones_Centro();
            inscripciones.Show();
            this.Close();
        }

        //eventos KeyPress para validar la entrada de texto en los campos de nombre y título, permitiendo solo letras, espacios y caracteres de control, y evitando espacios al inicio o dobles espacios.
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

        //evento KeyPress para validar la entrada de texto en el campo de título, permitiendo solo letras, espacios y caracteres de control, y evitando espacios al inicio o dobles espacios.
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

        //evento KeyPress para validar la entrada de texto en el campo de correo electrónico, permitiendo solo caracteres válidos para un correo, como letras, números y algunos símbolos comunes en direcciones de correo.
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

        //evento Leave para validar el formato del correo electrónico utilizando una expresión regular, mostrando un mensaje de error si el formato es inválido, y enfocando el campo de correo para que el usuario pueda corregirlo.
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

        //evento TextChanged para cambiar el color de fondo del campo de correo electrónico según la validez del formato, utilizando la misma expresión regular para validar el formato y aplicando un color verde claro para un formato válido y un color rojo claro para un formato inválido.
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

        //evento KeyPress para validar la entrada de texto en el campo de teléfono, permitiendo solo números, paréntesis, guiones y caracteres de control, y limitando la longitud del texto a un máximo de 13 caracteres para adaptarse a formatos comunes de números telefónicos.
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

        //eventos Click de los botones para navegar a otras secciones del sistema, como participantes, cursos, programas e inscripciones, cerrando el formulario actual y abriendo el formulario correspondiente a la sección seleccionada.
        private void btnHome_Click(object sender, EventArgs e)
        {
            WF_home home = new WF_home();
            home.Show();
            this.Close();
        }
    }
}

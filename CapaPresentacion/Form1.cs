using CapaNegocios;
using static System.Net.Mime.MediaTypeNames;


namespace CapaPresentacion
{
    //TODO: FORM PARTICIPANTES En este formulario se manejan todas las operaciones relacionadas con los Participantes, como insertar, editar, cambiar estatus, etc.
    //Además, se incluyen validaciones para los campos de entrada, como el formato de correo electrónico y la estructura de la cédula.
    //También se proporcionan botones para navegar a otros formularios relacionados con cursos, programas y docentes.
    public partial class Form1 : Form
    {

        Estudiantes estudiante = new Estudiantes(); //instancia de la clase Estudiantes para acceder a sus métodos y realizar operaciones relacionadas con los estudiantes
        private string matricula = null; //variable para almacenar la matricula del estudiante seleccionado, utilizada principalmente para las operaciones de edición y cambio de estatus
        private bool Editar = false;  //variable booleana para determinar si se está en modo de edición o inserción, utilizada para controlar el flujo de las operaciones al guardar los datos
        public Form1()
        {
            InitializeComponent();
            txtCorreo.KeyPress += txtCorreo_KeyPress; //evento para validar los caracteres permitidos en el campo de correo electrónico, asegurando que solo se puedan ingresar caracteres válidos para un correo
            txtCorreo.Leave += txtCorreo_Leave;      //evento para validar el formato del correo electrónico cuando el usuario sale del campo, mostrando un mensaje de error si el formato es inválido
            txtCorreo.TextChanged += txtCorreo_TextChanged;  //evento para cambiar el color de fondo del campo de correo electrónico en tiempo real, indicando visualmente si el formato del correo es válido o no
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Mostrarestudiante(); //llama al método para mostrar los estudiantes en el DataGridView al cargar el formulario
        }

        //metodo para mostrar los estudiantes en el DataGridView, obteniendo los datos de la base de datos.
        private void Mostrarestudiante()
        {
            dataGridView1.DataSource = estudiante.MostrarEstudiantes();
        }

        //metodo para insertar o editar un estudiante, dependiendo del valor de la variable Editar.
        //Si Editar es false, se inserta un nuevo estudiante; si Editar es true, se editan los datos del estudiante seleccionado.
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


        //metodo para cargar los datos del estudiante seleccionado en los campos de texto para su edición, y establecer la variable Editar en true para indicar que se está en modo de edición.
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

        //metodo para limpiar los campos de texto después de insertar o editar un estudiante, preparando el formulario para una nueva operación.
        private void LimpiarForm()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtCedula.Clear();
            txtCorreo.Clear();
            txtTelefono.Clear();

        }

        //metodo para moficiar el estatus de un estudiante a baja academica
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

        //metodo para moficiar el estatus de un estudiante a baja administrativa
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

        //metodo para moficiar el estatus de un estudiante a activo
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

        //botones para navegar a otros formularios relacionados con cursos, programas y docentes, cerrando el formulario actual al abrir el nuevo formulario.
        private void btnCursos_Click(object sender, EventArgs e)
        {
            WF_Curso curso = new WF_Curso();
            curso.Show();
            this.Hide();
        }

        private void btnPrograma_Click(object sender, EventArgs e)
        {
            WF_Programa programa = new WF_Programa();
            programa.Show();
            this.Hide();
        }

        private void btnDocentes_Click(object sender, EventArgs e)
        {
            WF_Docente docente = new WF_Docente();
            docente.Show();
            this.Hide();
        }

        //eventos KeyPress para validar los campos de entrada, asegurando que solo se puedan ingresar caracteres válidos según el tipo de dato esperado
        //(letras para nombre y apellido, formato específico para cédula, caracteres válidos para correo, etc.)
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
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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


        //botón para navegar al formulario de inscripciones, cerrando el formulario actual al abrir el nuevo formulario.
        private void btnInscripciones_Click(object sender, EventArgs e)
        {
            WF_Inscripciones_Centro inscripciones_Centro = new WF_Inscripciones_Centro();
            inscripciones_Centro.Show();
            this.Hide();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            WF_home home = new WF_home();
            home.Show();
            this.Hide();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}

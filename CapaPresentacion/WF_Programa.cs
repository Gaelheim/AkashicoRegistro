using CapaDatos;
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
    //TODO: Formulario para gestionar los programas, con funcionalidades para agregar, editar, eliminar
    public partial class WF_Programa : Form
    {
        CN_Programa programa = new CN_Programa(); // Instancia de la clase CN_Programa para acceder a las operaciones relacionadas con los programas
        private bool Editar = false; // Variable para indicar si se está editando un programa (true) o insertando uno nuevo (false)
        private string programaID = null; // Variable para almacenar el ID del programa seleccionado para editar o eliminar
        public WF_Programa()
        {
            InitializeComponent();
        }

        //TODO: Evento Load del formulario para mostrar los programas al cargar la ventana, así como cargar los cursos y docentes en los ComboBox.
        private void WF_Programa_Load(object sender, EventArgs e)
        {
            MostrarPrograma();
            CargarCursos();
            CargarDocentes();

        }

        //TODO: Método para mostrar los programas en el DataGridView, obteniendo los datos a través de la clase CN_Programa.
        private void MostrarPrograma()
        {
            dgvPrograma.DataSource = programa.MostrarPrograma();
        }


        //TODO: Método para cargar los docentes en el ComboBox, obteniendo los datos a través de la clase CN_Programa y configurando las propiedades DisplayMember
        //y ValueMember para mostrar el nombre del docente y usar el ID del docente como valor.
        private void CargarDocentes()
        {
            cbxDocente.DataSource = programa.MostrarDocente();
            cbxDocente.DisplayMember = "Nombre";     // lo que VE el usuario
            cbxDocente.ValueMember = "DocenteID";  // lo que usa el código
            cbxDocente.SelectedIndex = -1;           // inicia vacío
        }

        //TODO: Método para cargar los cursos en el ComboBox, obteniendo los datos a través de la clase CN_Programa y configurando las propiedades DisplayMember
        //y ValueMember para mostrar el nombre del curso y usar el ID del curso como valor.
        private void CargarCursos()
        {
            cbxCurso.DataSource = programa.MostrarCurso();
            cbxCurso.DisplayMember = "Nombre";    // lo que VE el usuario
            cbxCurso.ValueMember = "CursoID";   // lo que usa el código
            cbxCurso.SelectedIndex = -1;          // inicia vacío
        }

        //TODO: Evento Click del botón "Docente" para mostrar los docentes en el DataGridView, obteniendo los datos a través de la clase CN_Programa.
        private void MostrarDocentes()
        {
            dgvPrograma.DataSource = programa.MostrarDocentes();
        }

        //TODO: Evento Click del botón "Docente" para mostrar los docentes en el DataGridView, obteniendo los datos a través de la clase CN_Programa.
        private void btnDocente_Click(object sender, EventArgs e)
        {
            MostrarDocentes();
            btnEditar.Enabled = false; // Deshabilitar el botón Editar al mostrar docentes, ya que no se pueden editar desde este formulario
            btnEliminar.Enabled = false; // Deshabilitar el botón Eliminar al mostrar docentes, ya que no se pueden eliminar desde este formulario
            btnGuardar.Enabled = false; // Deshabilitar el botón Guardar al mostrar docentes, ya que no se pueden guardar cambios desde este formulario
        }

        //TODO: Evento para mostrar los cursos en el DataGridView, obteniendo los datos a través de la clase CN_Programa.
        private void MostrarCursos()
        {
            dgvPrograma.DataSource = programa.MostrarCursos();
        }
        //TODO: Evento Click del botón "Curso" para mostrar los cursos en el DataGridView, obteniendo los datos a través de la clase CN_Programa.
        private void btnCurso_Click(object sender, EventArgs e)
        {
            MostrarCursos();
            btnGuardar.Enabled = false; // Deshabilitar el botón Guardar al mostrar cursos, ya que no se pueden guardar cambios desde este formulario
            btnEliminar.Enabled = false; // Deshabilitar el botón Eliminar al mostrar cursos, ya que no se pueden eliminar desde este formulario
            btnEditar.Enabled = false; // Deshabilitar el botón Editar al mostrar cursos, ya que no se pueden editar desde este formulario
        }

        //TODO: Evento Click del botón "Programa" para mostrar los programas en el DataGridView, obteniendo los datos a través de la clase CN_Programa.
        private void btnPrograma_Click(object sender, EventArgs e)
        {
            MostrarPrograma();
            btnEditar.Enabled = true; // Habilitar el botón Editar al mostrar programas, ya que se pueden editar desde este formulario
            btnEliminar.Enabled = true; // Habilitar el botón Eliminar al mostrar programas, ya que se pueden eliminar desde este formulario
            btnGuardar.Enabled = true; // Habilitar el botón Guardar al mostrar programas, ya que se pueden guardar cambios desde este formulario
        }

        //TODO: Evento Click del botón "Guardar" para agregar un nuevo programa o editar uno existente, dependiendo del estado de la variable Editar.
        //Se obtienen los datos ingresados por el usuario, se validan y se guardan a través de la clase CN_Programa. Después de guardar, se actualiza la lista de programas mostrada y se limpia el formulario.
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Editar == false)

            {
                try
                {
                    string nombre = txtNombre.Text;
                    string cursoID = cbxCurso.SelectedValue.ToString();
                    int docenteID = Convert.ToInt32(cbxDocente.SelectedValue);
                    int duracion_Semana = Convert.ToInt32(txtDuracion.Text);
                    string dia = cbxDias.SelectedItem.ToString();
                    TimeSpan horario = TimeSpan.Parse(cbxHorario.SelectedItem.ToString());

                    programa.InsertarPrograma(nombre, cursoID, docenteID, duracion_Semana, dia, horario);

                    MessageBox.Show("Programa guardado correctamente!");
                    MostrarPrograma();
                    LimpiarForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo guardar por: " + ex.Message);
                }
            }
            //TODO: Si Editar es true, se llama al método EditarPrograma de la clase CN_Programa para actualizar los datos del programa seleccionado,
            //y luego se actualiza la vista y se limpia el formulario.
            if (Editar == true)
            {
                try
                {
                    string nombre = txtNombre.Text;
                    string cursoID = cbxCurso.SelectedValue.ToString();
                    int docenteID = Convert.ToInt32(cbxDocente.SelectedValue);
                    int duracion_Semana = Convert.ToInt32(txtDuracion.Text);
                    string dia = cbxDias.SelectedItem.ToString();
                    TimeSpan horario = TimeSpan.Parse(cbxHorario.SelectedItem.ToString());

                    programa.EditarPrograma(programaID, nombre, cursoID, docenteID, duracion_Semana, dia, horario);
                    MessageBox.Show("Programa editado correctamente!");
                    MostrarPrograma();
                    LimpiarForm();
                    Editar = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo editar por: " + ex.Message);
                }
            }

        }

        //TODO: Método para limpiar los campos del formulario después de guardar o editar un programa, dejando los ComboBox sin selección y los TextBox vacíos.
        private void LimpiarForm()
        {
            txtNombre.Clear();
            cbxCurso.SelectedIndex = -1;
            cbxDocente.SelectedIndex = -1;
            txtDuracion.Clear();
            cbxDias.SelectedIndex = -1;
            cbxHorario.SelectedIndex = -1;
        }

        //TODO: Evento Click del botón "Editar" para cargar los datos del programa seleccionado en el DataGridView en los campos del formulario,
        //permitiendo al usuario modificar los datos y luego guardarlos. Si no hay datos para editar, se muestra un mensaje de advertencia.
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvPrograma.Rows.Count > 0)
            {

                Editar = true;
                txtNombre.Text = dgvPrograma.CurrentRow.Cells["NombrePrograma"].Value.ToString();
                cbxCurso.SelectedValue = dgvPrograma.CurrentRow.Cells["CursoID"].Value;
                cbxDocente.SelectedValue = dgvPrograma.CurrentRow.Cells["DocenteID"].Value;
                txtDuracion.Text = dgvPrograma.CurrentRow.Cells["Duracion_Semana"].Value.ToString();
                cbxDias.SelectedItem = dgvPrograma.CurrentRow.Cells["Dia"].Value.ToString();
                cbxHorario.SelectedItem = dgvPrograma.CurrentRow.Cells["Horario"].Value.ToString();
                programaID = dgvPrograma.CurrentRow.Cells["CodigoPrograma"].Value.ToString();

            }
            else { MessageBox.Show("No hay datos para editar."); }
        }

        //TODO: Evento Click del botón "Curso" para abrir el formulario WF_Curso, permitiendo al usuario gestionar los cursos desde esa ventana.
        //Al abrir el nuevo formulario, se cierra el formulario actual.
        private void btnWfcurso_Click(object sender, EventArgs e)
        {
            WF_Curso curso = new WF_Curso();
            curso.Show();
            this.Hide();
        }

        //TODO: Evento Click del botón "Docente" para abrir el formulario WF_Docente, permitiendo al usuario gestionar los docentes desde esa ventana.
        private void btnWfDocente_Click(object sender, EventArgs e)
        {
            WF_Docente docente = new WF_Docente();
            docente.Show();
            this.Hide();
        }

        //TODO: Evento Click del botón "Participantes" para abrir el formulario Form1, permitiendo al usuario gestionar los participantes desde esa ventana.
        private void btnParticipantes_Click(object sender, EventArgs e)
        {
            Form1 participantes = new Form1();
            participantes.Show();
            this.Hide();
        }

        //TODO: Evento Click del botón "Eliminar" para eliminar el programa seleccionado en el DataGridView, verificando que haya datos para eliminar. Si se elimina correctamente,
        //se muestra un mensaje de confirmación y se actualiza la lista de programas mostrada.
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvPrograma.Rows.Count > 0)
            {
                string codigoPrograma = dgvPrograma.CurrentRow.Cells["CodigoPrograma"].Value.ToString();
                programa.EliminarPrograma(codigoPrograma);
                MessageBox.Show("Programa eliminado correctamente!");
                MostrarPrograma();
            }
            else
            {
                MessageBox.Show("No hay datos para eliminar.");
            }

        }

        //TODO: Evento KeyPress para el TextBox de duración, permitiendo solo la entrada de dígitos y controlando que no se ingresen caracteres no numéricos.
        private void txtDuracion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Evitar que se ingrese el carácter
            }
        }

        //TODO: Evento KeyPress para el TextBox de nombre, permitiendo solo la entrada de letras, espacios y controlando que no se ingresen caracteres no válidos, como números o símbolos.
        //Además, se evita que el usuario ingrese espacios al inicio o espacios dobles.
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

        //TODO: Evento Click del botón "Centro de Inscripciones" para abrir el formulario WF_Inscripciones_Centro,
        //permitiendo al usuario gestionar las inscripciones desde esa ventana.
        private void button1_Click(object sender, EventArgs e) //boton para ir al centro de inscripciones
        {
            WF_Inscripciones_Centro inscripciones_Centro = new WF_Inscripciones_Centro();
            inscripciones_Centro.Show();
            this.Hide();
        }

        //TODO: Evento Click del botón "Reportes" para abrir el formulario WF_Reportes, permitiendo al usuario generar y visualizar reportes desde esa ventana.
        private void btnHome_Click(object sender, EventArgs e)
        {
            WF_home home = new WF_home();
            home.Show();
            this.Hide();
        }

        private void WF_Programa_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocios;

namespace CapaPresentacion
{
    //TODO: Formulario para gestionar los cursos, con funcionalidades para agregar, editar, eliminar
    //y mostrar cursos, así como navegar a otras secciones de la aplicación.

    public partial class WF_Curso : Form
    {
        CN_Curso curso = new CN_Curso(); // Instancia de la clase CN_Curso para acceder a las operaciones relacionadas con los cursos
        private string cursoID = null; // Variable para almacenar el ID del curso seleccionado para editar o eliminar
        private bool Editar = false; // Variable para indicar si se está editando un curso (true) o insertando uno nuevo (false)
        public WF_Curso()
        {
            InitializeComponent();
        }

        //TODO: Evento Load del formulario para mostrar los cursos al cargar la ventana.
        private void WF_Curso_Load(object sender, EventArgs e)
        {
            MostrarCurso();
        }

        //TODO: Método para mostrar los cursos en el DataGridView, obteniendo los datos a través de la clase CN_Curso
        private void MostrarCurso()
        {
            dgvCurso.DataSource = curso.MostrarCurso();
        }

        //TODO: Evento Click del botón "Insertar" para agregar un nuevo curso o editar uno existente, dependiendo del estado de la variable Editar.
        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (Editar == false)
            {

                try
                {
                    DateTime fecha = DtFecha.Value.Date;
                    curso.InsertarCurso(txtNombre.Text, int.Parse(txtCapacidad.Text), fecha);
                    MessageBox.Show("Se guardaron los datos correctamente!");
                    MostrarCurso();
                    LimpiarForm();


                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudieron guardar los datos por: " + ex);
                }

            }
            //TODO: Si Editar es true, se llama al método EditarCurso de la clase CN_Curso para actualizar los datos del curso seleccionado,
            //y luego se actualiza la vista y se limpia el formulario.
            if (Editar == true)
            {

                try
                {
                    DateTime fecha = DtFecha.Value.Date;
                    curso.EditarCurso(cursoID, txtNombre.Text, int.Parse(txtCapacidad.Text), fecha);
                    MessageBox.Show("Se editaron los datos correctamente!");
                    MostrarCurso();
                    LimpiarForm();
                    Editar = false;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudieron editar los datos por: " + ex);
                }

            }


        }

        //TODO: Método para limpiar los campos del formulario después de insertar o editar un curso.
        private void LimpiarForm()
        {
            txtNombre.Clear();
            txtCapacidad.Clear();

        }

        //metodo para cargar los datos del curso seleccionado en el DataGridView a los campos del formulario para su edición, y establecer la variable Editar en true.
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvCurso.SelectedRows.Count > 0)
            {
                Editar = true;
                txtNombre.Text = dgvCurso.CurrentRow.Cells["Nombre"].Value.ToString();
                txtCapacidad.Text = dgvCurso.CurrentRow.Cells["CapacidadMax"].Value.ToString();
                DtFecha.Value = Convert.ToDateTime(dgvCurso.CurrentRow.Cells["FechaInicio"].Value);
                cursoID = dgvCurso.CurrentRow.Cells["CursoID"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione una fila, por favor");
            }
        }

        //TODO: Evento Click del botón "Eliminar" para eliminar el curso seleccionado, utilizando el método EliminarCurso de la clase CN_Curso, y luego actualizar la vista.
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvCurso.SelectedRows.Count > 0)
            {
                cursoID = dgvCurso.CurrentRow.Cells["CursoID"].Value.ToString();
                curso.EliminarCurso(cursoID);
                MessageBox.Show("Curso Eliminado con exito");
                MostrarCurso();
            }
            else
            {
                MessageBox.Show("Seleccione una fila, por favor");
            }
        }

        //TODO: Eventos Click de los botones para navegar a otras secciones de la aplicación, como participantes, programas, docentes e inscripciones.
        private void btnParticipantes_Click(object sender, EventArgs e)
        {
            Form1 participante = new Form1();
            participante.Show();
            this.Close();
        }

        private void btnProgramas_Click(object sender, EventArgs e)
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

        //TODO: Eventos KeyPress para validar la entrada de datos en los campos de texto,
        //permitiendo solo letras para el nombre del curso y solo números para la capacidad máxima.
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

        //TODO: Evento KeyPress para el campo de capacidad máxima, permitiendo solo dígitos y control
        //(como backspace) para evitar la entrada de caracteres no numéricos.
        private void txtCapacidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Evitar que se ingrese el carácter
            }
        }

        //TODO: Evento Click del botón "Inscripciones" para abrir el formulario de inscripciones y cerrar el formulario actual.
        private void btnInscripciones_Click(object sender, EventArgs e)
        {
            WF_Inscripciones_Centro inscripciones_Centro = new WF_Inscripciones_Centro();
            inscripciones_Centro.Show();
            this.Close();
        }

        //TODO: Evento Click del botón "Home" para volver al formulario principal de la aplicación, cerrando el formulario actual.
        private void btnHome_Click(object sender, EventArgs e)
        {
            WF_home home = new WF_home();
            home.Show();
            this.Close();
        }
    }
}

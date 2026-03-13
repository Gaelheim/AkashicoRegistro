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
    //TODO: Formulario para gestionar las inscripciones, con funcionalidades para agregar, eliminar
    //y mostrar inscripciones, así como navegar a otras secciones de la aplicación.
    public partial class WF_Inscripciones : Form
    {
        CN_Inscripciones objeto = new CN_Inscripciones(); // Instancia de la clase CN_Inscripciones para acceder a las operaciones relacionadas con las inscripciones
        int idInscripcion = 0; // Variable para almacenar el ID de la inscripción seleccionada para eliminar
        public WF_Inscripciones()
        {
            InitializeComponent();
        }

        //TODO: Evento Load del formulario para mostrar las inscripciones al cargar la ventana, así como cargar los participantes y cursos en los ComboBox.
        private void WF_Inscripciones_Load(object sender, EventArgs e)
        {
            MostrarInscripciones();
            CargarParticipante();
            CargarCursos();
        }

        //TODO: Método para mostrar las inscripciones en el DataGridView, obteniendo los datos a través de la clase CN_Inscripciones.
        private void MostrarInscripciones()
        {

            dgvInscripciones.DataSource = objeto.MostrarInscripciones();

        }

        //TODO: Método para cargar los participantes en el ComboBox, obteniendo los datos a través de la clase CN_Inscripciones y configurando las propiedades DisplayMember y ValueMember para mostrar la matrícula y usarla como valor.
        private void CargarParticipante()
        {
            cbxParticipante.DataSource = objeto.MostrarParticipante();
            cbxParticipante.DisplayMember = "Matricula";     // lo que VE el usuario
            cbxParticipante.ValueMember = "Matricula";  // lo que usa el código
            cbxParticipante.SelectedIndex = -1;           // inicia vacío
        }

        //TODO: Método para cargar los cursos en el ComboBox, obteniendo los datos a través de la clase CN_Inscripciones y configurando las propiedades DisplayMember y ValueMember para mostrar el nombre del programa y usar el código del programa como valor.
        private void CargarCursos()
        {
            cbxCurso.DataSource = objeto.MostrarPrograma();
            cbxCurso.DisplayMember = "Nombre";    // lo que VE el usuario
            cbxCurso.ValueMember = "CodigoPrograma";   // lo que usa el código
            cbxCurso.SelectedIndex = -1;          // inicia vacío
        }

        //TODO: Evento Click del botón "Guardar" para agregar una nueva inscripción, verificando que se hayan seleccionado un participante y un programa, y que la inscripción no exista previamente. Si la inscripción es válida, se guarda a través de la clase CN_Inscripciones y se actualiza la lista de inscripciones mostrada.
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbxParticipante.SelectedIndex == -1 || cbxCurso.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe seleccionar un participante y un programa.",
                                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string matricula = cbxParticipante.SelectedValue.ToString();
                string codigoPrograma = cbxCurso.SelectedValue.ToString();

                if (objeto.InscripcionExiste(matricula, codigoPrograma))
                {
                    MessageBox.Show("Este participante ya está inscrito en ese programa.",
                                    "Inscripción duplicada",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    return;
                }

                objeto.InsertarInscripcion(matricula, codigoPrograma);
                MessageBox.Show("Inscripción guardada correctamente!",
                                "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MostrarInscripciones();
                LimpiarForm();
            }
            catch (Exception ex)
            {
                // Todos los errores incluido el de verificación se muestran aquí
                MessageBox.Show("No se pudo guardar por: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //TODO: Método para limpiar los ComboBox después de guardar una inscripción, restableciendo la selección a un estado vacío.
        private void LimpiarForm()
        {
            cbxParticipante.SelectedIndex = -1;
            cbxCurso.SelectedIndex = -1;
        }

        //TODO: Evento Click del botón "Eliminar" para eliminar la inscripción seleccionada en el DataGridView, verificando que haya datos para eliminar. Si se elimina correctamente, se muestra un mensaje de confirmación y se actualiza la lista de inscripciones mostrada.
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvInscripciones.Rows.Count > 0)
            {
                int inscripcionID = Convert.ToInt32(dgvInscripciones.CurrentRow.Cells["InscripcionID"].Value);
                objeto.EliminarInscripcion(inscripcionID);
                MessageBox.Show("Programa eliminado correctamente!");
                MostrarInscripciones();
            }
            else
            {
                MessageBox.Show("No hay datos para eliminar.");
            }
        }

        //TODO: Evento Click del botón "Volver al menú" para cerrar el formulario actual y abrir el formulario principal de inscripciones, permitiendo al usuario navegar de regreso al menú principal de la aplicación.
        private void button1_Click(object sender, EventArgs e) //boton para volver al menu principal
        {
            WF_Inscripciones_Centro inscripciones_Centro = new WF_Inscripciones_Centro();
            inscripciones_Centro.Show();
            this.Hide();
        }

        private void WF_Inscripciones_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}

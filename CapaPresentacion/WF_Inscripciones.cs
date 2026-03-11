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
    public partial class WF_Inscripciones : Form
    {
        CN_Inscripciones objeto = new CN_Inscripciones();
        int idInscripcion = 0;
        public WF_Inscripciones()
        {
            InitializeComponent();
        }

        private void WF_Inscripciones_Load(object sender, EventArgs e)
        {
            MostrarInscripciones();
            CargarParticipante();
            CargarCursos();
        }

        private void MostrarInscripciones()
        {

            dgvInscripciones.DataSource = objeto.MostrarInscripciones();

        }

        private void CargarParticipante()
        {
            cbxParticipante.DataSource = objeto.MostrarParticipante();
            cbxParticipante.DisplayMember = "Matricula";     // lo que VE el usuario
            cbxParticipante.ValueMember = "Matricula";  // lo que usa el código
            cbxParticipante.SelectedIndex = -1;           // inicia vacío
        }

        private void CargarCursos()
        {
            cbxCurso.DataSource = objeto.MostrarPrograma();
            cbxCurso.DisplayMember = "Nombre";    // lo que VE el usuario
            cbxCurso.ValueMember = "CodigoPrograma";   // lo que usa el código
            cbxCurso.SelectedIndex = -1;          // inicia vacío
        }

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

        private void LimpiarForm()
        {
            cbxParticipante.SelectedIndex = -1;
            cbxCurso.SelectedIndex = -1;
        }

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

        private void button1_Click(object sender, EventArgs e) //boton para volver al menu principal
        {
            WF_Inscripciones_Centro inscripciones_Centro = new WF_Inscripciones_Centro();
            inscripciones_Centro.Show();
            this.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using CapaNegocios;

namespace CapaPresentacion
{

    //TODO: Formulario para administrar las inscripciones, con funcionalidades para modificar el estatus de los participantes a "Inscrito" o "Retirado",
    //mostrar las inscripciones en un DataGridView y navegar a otras secciones de la aplicación.
    public partial class WF_Inscripciones_Administrar : Form
    {
        CN_Inscripciones objeto1 = new CN_Inscripciones(); // Instancia de la clase CN_Inscripciones para acceder a las operaciones relacionadas con las inscripciones
        int id = 0;
        public WF_Inscripciones_Administrar()
        {
            InitializeComponent();
        }

        //TODO: Evento Load del formulario para mostrar las inscripciones al cargar la ventana.
        private void WF_Inscripciones_Administrar_Load(object sender, EventArgs e)
        {
            MostrarInscripciones();

        }

        //TODO: Método para mostrar las inscripciones en el DataGridView, obteniendo los datos a través de la clase CN_Inscripciones.
        private void MostrarInscripciones()
        {

            dgvInscripciones.DataSource = objeto1.MostrarInscripciones();

        }

        //TODO: Evento Click del botón "Inscrito" para modificar el estatus de la inscripción seleccionada a "Inscrito", verificando que no esté ya inscrito o retirado. Si la modificación es válida,
        //se actualiza a través de la clase CN_Inscripciones y se muestra un mensaje de éxito.
        private void btnInscrito_Click(object sender, EventArgs e)
        {
            if (dgvInscripciones.SelectedRows.Count > 0)
            {
                id = Convert.ToInt32(dgvInscripciones.CurrentRow.Cells[0].Value.ToString());

                // Trim() elimina espacios, ToUpper() evita problemas de mayúsculas
                string estatusActual = dgvInscripciones.CurrentRow.Cells[4].Value.ToString().Trim().ToUpper();

                // Verificar el estatus actual antes de modificar
                if (estatusActual == "RETIRADO")
                {

                    MessageBox.Show("Este participante está Retirado y no puede volver a ser Inscrito.",
                                    "Acción no permitida",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    return;
                }

                // Verificar si ya está inscrito para evitar modificaciones innecesarias
                if (estatusActual == "INSCRITO")
                {
                    MessageBox.Show("Este participante ya se encuentra Inscrito.",
                                    "Aviso",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    return;
                }

                // Si pasa las validaciones, modificar el estatus a Inscrito
                objeto1.ModificarAInscrito(id);
                MessageBox.Show("Estatus modificado con éxito.",
                                "Éxito",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                MostrarInscripciones();
            }
            else
            {
                MessageBox.Show("Seleccione una fila, por favor.",
                                "Aviso",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
        }

        //TODO: Evento Click del botón "Retirado" para modificar el estatus de la inscripción seleccionada a "Retirado",
        //verificando que no esté ya retirado o inscrito. Si la modificación es válida,
        private void btnRetirado_Click(object sender, EventArgs e)
        {
            if (dgvInscripciones.SelectedRows.Count > 0)
            {
                id = Convert.ToInt32(dgvInscripciones.CurrentRow.Cells[0].Value.ToString());
                objeto1.ModificarARetirado(id);
                MessageBox.Show("Estatus modificado con exito");
                MostrarInscripciones();
            }
            else
            {
                MessageBox.Show("Seleccione una fila, por favor");
            }
        }

        //Botón para regresar al menú principal, cerrando el formulario actual y mostrando la ventana de inicio (WF_home).
        private void button1_Click(object sender, EventArgs e)
        {
            WF_home home = new WF_home();
            home.ShowDialog();
            this.Hide();
        }

        private void WF_Inscripciones_Administrar_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}

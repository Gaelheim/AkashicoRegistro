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

    public partial class WF_Inscripciones_Administrar : Form
    {
        CN_Inscripciones objeto1 = new CN_Inscripciones();
        int id = 0;
        public WF_Inscripciones_Administrar()
        {
            InitializeComponent();
        }

        private void WF_Inscripciones_Administrar_Load(object sender, EventArgs e)
        {
            MostrarInscripciones();

        }

        private void MostrarInscripciones()
        {

            dgvInscripciones.DataSource = objeto1.MostrarInscripciones();

        }

        private void btnInscrito_Click(object sender, EventArgs e)
        {
            if (dgvInscripciones.SelectedRows.Count > 0)
            {
                id = Convert.ToInt32(dgvInscripciones.CurrentRow.Cells[0].Value.ToString());

                // Trim() elimina espacios, ToUpper() evita problemas de mayúsculas
                string estatusActual = dgvInscripciones.CurrentRow.Cells[4].Value.ToString().Trim().ToUpper();

                if (estatusActual == "RETIRADO")
                {
                    MessageBox.Show("Este participante está Retirado y no puede volver a ser Inscrito.",
                                    "Acción no permitida",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    return;
                }

                if (estatusActual == "INSCRITO")
                {
                    MessageBox.Show("Este participante ya se encuentra Inscrito.",
                                    "Aviso",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    return;
                }

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

        private void button1_Click(object sender, EventArgs e)
        {
            WF_home home = new WF_home();
            home.ShowDialog();
            this.Close();
        }
    }
}

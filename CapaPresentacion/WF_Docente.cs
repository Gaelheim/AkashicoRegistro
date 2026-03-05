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
    }
}

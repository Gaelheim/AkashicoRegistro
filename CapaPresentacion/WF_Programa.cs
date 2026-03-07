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
    public partial class WF_Programa : Form
    {
        CN_Programa programa = new CN_Programa();
        private bool Editar = false;
        private string programaID = null;
        public WF_Programa()
        {
            InitializeComponent();
        }

        private void WF_Programa_Load(object sender, EventArgs e)
        {
            MostrarPrograma();
            CargarCursos();
            CargarDocentes();

        }

        private void MostrarPrograma()
        {
            dgvPrograma.DataSource = programa.MostrarPrograma();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CargarDocentes()
        {
            cbxDocente.DataSource = programa.MostrarDocente();
            cbxDocente.DisplayMember = "Nombre";     // lo que VE el usuario
            cbxDocente.ValueMember = "DocenteID";  // lo que usa el código
            cbxDocente.SelectedIndex = -1;           // inicia vacío
        }

        private void CargarCursos()
        {
            cbxCurso.DataSource = programa.MostrarCurso();
            cbxCurso.DisplayMember = "Nombre";    // lo que VE el usuario
            cbxCurso.ValueMember = "CursoID";   // lo que usa el código
            cbxCurso.SelectedIndex = -1;          // inicia vacío
        }

        private void MostrarDocentes()
        {
            dgvPrograma.DataSource = programa.MostrarDocentes();
        }

        private void btnDocente_Click(object sender, EventArgs e)
        {
            MostrarDocentes();
        }

        private void MostrarCursos()
        {
            dgvPrograma.DataSource = programa.MostrarCursos();
        }

        private void btnCurso_Click(object sender, EventArgs e)
        {
            MostrarCursos();
        }

        private void btnPrograma_Click(object sender, EventArgs e)
        {
            MostrarPrograma();
        }

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

        private void LimpiarForm()
        {
            txtNombre.Clear();
            cbxCurso.SelectedIndex = -1;
            cbxDocente.SelectedIndex = -1;
            txtDuracion.Clear();
            cbxDias.SelectedIndex = -1;
            cbxHorario.SelectedIndex = -1;
        }

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

        private void btnWfcurso_Click(object sender, EventArgs e)
        {
            WF_Curso curso = new WF_Curso();
            curso.Show();
            this.Hide();
        }

        private void btnWfDocente_Click(object sender, EventArgs e)
        {
            WF_Docente docente = new WF_Docente();
            docente.Show();
            this.Hide();
        }

        private void btnParticipantes_Click(object sender, EventArgs e)
        {
            Form1 participantes = new Form1();
            participantes.Show();
            this.Hide();
        }

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
    }
}

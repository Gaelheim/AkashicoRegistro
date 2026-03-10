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

    public partial class WF_Curso : Form
    {
        CN_Curso curso = new CN_Curso();
        private string cursoID = null;
        private bool Editar = false;
        public WF_Curso()
        {
            InitializeComponent();
        }

        private void WF_Curso_Load(object sender, EventArgs e)
        {
            MostrarCurso();
        }

        private void MostrarCurso()
        {
            dgvCurso.DataSource = curso.MostrarCurso();
        }

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

        private void LimpiarForm()
        {
            txtNombre.Clear();
            txtCapacidad.Clear();

        }

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
            WF_Curso curso = new WF_Curso();
            curso.Show();
            this.Close();
        }

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

        private void txtCapacidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Evitar que se ingrese el carácter
            }
        }

        private void btnInscripciones_Click(object sender, EventArgs e)
        {
            WF_Inscripciones_Centro inscripciones_Centro = new WF_Inscripciones_Centro();
            inscripciones_Centro.Show();
            this.Close();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            WF_home home = new WF_home();
            home.Show();
            this.Close();
        }
    }
}

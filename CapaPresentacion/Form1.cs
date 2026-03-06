using CapaNegocios;


namespace CapaPresentacion
{
    public partial class Form1 : Form
    {
        Estudiantes estudiante = new Estudiantes();
        private string matricula = null;
        private bool Editar = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Mostrarestudiante();
        }

        private void Mostrarestudiante()
        {
            dataGridView1.DataSource = estudiante.MostrarEstudiantes();
        }

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

        private void LimpiarForm()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtCedula.Clear();
            txtCorreo.Clear();
            txtTelefono.Clear();

        }

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
    }
}

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
        Curso curso = new Curso();
        private string cursoID = null;
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

        private void LimpiarForm()
        {
            txtNombre.Clear();
            txtCapacidad.Clear();

        }
    }
}

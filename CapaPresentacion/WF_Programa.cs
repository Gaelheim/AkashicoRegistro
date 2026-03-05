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
    }
}

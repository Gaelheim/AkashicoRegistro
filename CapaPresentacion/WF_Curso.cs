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
    }
}

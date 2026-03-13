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
    //TODO: Formulario principal de la aplicación con botones para navegar
    //a las diferentes secciones (Inscripciones, Participantes, Cursos, Programas, Docentes, Reportes).
    public partial class WF_home : Form
    {
        public WF_home()
        {
            InitializeComponent();
        }

        //TODO: Implementar eventos de clic para cada botón que abra el formulario correspondiente y oculte el formulario principal.
        private void btnInscripciones_Click(object sender, EventArgs e) // Inscripciones
        {
            WF_Inscripciones_Centro inscripciones_Centro = new WF_Inscripciones_Centro();
            inscripciones_Centro.Show();
            this.Hide();
        }

        private void btnParticipantes_Click(object sender, EventArgs e)
        {
            Form1 participante = new Form1();
            participante.Show();
            this.Hide();
        }

        private void btnCurso_Click(object sender, EventArgs e)
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

        private void btnDocente_Click(object sender, EventArgs e)
        {
            WF_Docente docente = new WF_Docente();
            docente.Show();
            this.Hide();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            WF_Reportes reportes = new WF_Reportes();
            reportes.Show();
            this.Hide();
        }

        private void WF_home_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}

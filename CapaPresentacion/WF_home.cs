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
    public partial class WF_home : Form
    {
        public WF_home()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e) // Inscripciones
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

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}

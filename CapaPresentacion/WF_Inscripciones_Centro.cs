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
    public partial class WF_Inscripciones_Centro : Form
    {
        public WF_Inscripciones_Centro()
        {
            InitializeComponent();
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            WF_Inscripciones anadir = new WF_Inscripciones();
            anadir.Show();
            this.Close();
        }

        private void btnAdministrar_Click(object sender, EventArgs e)
        {
            WF_Inscripciones_Administrar administrar = new WF_Inscripciones_Administrar();
            administrar.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WF_home home = new WF_home();
            home.Show();
            this.Close();
        }
    }
}

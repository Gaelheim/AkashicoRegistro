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
    //TODO: Formulario para gestionar las inscripciones, con opciones para añadir nuevas inscripciones, administrar las existentes y navegar a otras secciones de la aplicación.
    public partial class WF_Inscripciones_Centro : Form
    {
        public WF_Inscripciones_Centro()
        {
            InitializeComponent();
        }

        // Evento para abrir el formulario de añadir inscripciones
        private void btnAñadir_Click(object sender, EventArgs e)
        {
            WF_Inscripciones anadir = new WF_Inscripciones();
            anadir.Show();
            this.Close();
        }

        // Evento para abrir el formulario de administrar inscripciones
        private void btnAdministrar_Click(object sender, EventArgs e)
        {
            WF_Inscripciones_Administrar administrar = new WF_Inscripciones_Administrar();
            administrar.Show();
            this.Close();
        }

        // Evento para volver al formulario principal
        private void button1_Click(object sender, EventArgs e)
        {
            WF_home home = new WF_home();
            home.Show();
            this.Close();
        }
    }
}

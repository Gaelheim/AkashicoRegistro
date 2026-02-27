using CapaNegocios;


namespace CapaPresentacion
{
    public partial class Form1 : Form
    {
        CN_Participantes estudiante = new CN_Participantes();
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
            dataGridView1.DataSource = estudiante.MostrarParticipantes();
        }
    }
}

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
using ScottPlot;
using ScottPlot.WinForms;


namespace CapaPresentacion
{
    public partial class WF_Reportes : Form
    {
        CN_Reportes objeto = new CN_Reportes();
        private FormsPlot chartOcupacion;
        private FormsPlot chartDesercion;

        public WF_Reportes()
        {
            InitializeComponent();
        }

        private void btnOcupacion_Click(object sender, EventArgs e)
        {
            tabOcupacion.Enabled = true; // Habilitar la pestaña de ocupación
            tabDesercion.Enabled = false; // Deshabilitar la pestaña de deserción
            MostrarOcupacion();
            GraficaOcupacion();



        }

        private void MostrarOcupacion()
        {

            dgvOcupacion.DataSource = objeto.ObtenerOcupacionPorCurso();

        }


        private void btnDesercion_Click(object sender, EventArgs e)
        {
            tabDesercion.Enabled = true; // Habilitar la pestaña de deserción
            tabOcupacion.Enabled = false; // Deshabilitar la pestaña de ocupación
            MostrarDesercion();
            GraficaDesercion();


        }

        private void MostrarDesercion()
        {
            dgvDesercion.DataSource = objeto.ObtenerTasaDesercion();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            WF_home home = new WF_home();
            home.Show();
            this.Close();
        }

        private void InicializarGraficas()
        {
            chartOcupacion = new FormsPlot() { Dock = DockStyle.Fill };
            chartDesercion = new FormsPlot() { Dock = DockStyle.Fill };
            panelOcupacion.Controls.Add(chartOcupacion);
            panelDesercion.Controls.Add(chartDesercion);
        }

        private void GraficaOcupacion()
        {
            DataTable dt = objeto.ObtenerOcupacionPorCurso();

            var valores = new List<double>();
            var etiquetas = new List<string>();

            foreach (DataRow row in dt.Rows)
            {
                etiquetas.Add(row["NombreCurso"].ToString());

                double valor = row["TotalInscritos"] == DBNull.Value ? 0 : Convert.ToDouble(row["TotalInscritos"]);
                valores.Add(valor);
            }

            // Sintaxis ScottPlot 5
            chartOcupacion.Plot.Clear();

            double[] posiciones = Enumerable.Range(0, valores.Count)
                                            .Select(i => (double)i).ToArray();

            var barras = chartOcupacion.Plot.Add.Bars(posiciones, valores.ToArray());

            // Etiquetas en el eje X
            ScottPlot.TickGenerators.NumericManual tickGen = new();
            for (int i = 0; i < etiquetas.Count; i++)
                tickGen.AddMajor(i, etiquetas[i]);

            chartOcupacion.Plot.Axes.Bottom.TickGenerator = tickGen;
            chartOcupacion.Plot.Title("Ocupación por Curso");
            chartOcupacion.Plot.YLabel("% Ocupación");
            chartOcupacion.Plot.XLabel("Cursos");
            chartOcupacion.Refresh();
        }

        private void GraficaDesercion()
        {
            DataTable dt = objeto.ObtenerTasaDesercion();

            var valores = new List<double>();
            var etiquetas = new List<string>();

            foreach (DataRow row in dt.Rows)
            {
                etiquetas.Add(row["NombreCurso"].ToString());

                double valor = row["TasaDesercion"] == DBNull.Value ? 0 : Convert.ToDouble(row["TasaDesercion"]);
                valores.Add(valor);
            }

            chartDesercion.Plot.Clear();

            double[] posiciones = Enumerable.Range(0, valores.Count)
                                            .Select(i => (double)i).ToArray();

            var barras = chartDesercion.Plot.Add.Bars(posiciones, valores.ToArray());

            ScottPlot.TickGenerators.NumericManual tickGen = new();
            for (int i = 0; i < etiquetas.Count; i++)
                tickGen.AddMajor(i, etiquetas[i]);

            chartDesercion.Plot.Axes.Bottom.TickGenerator = tickGen;
            chartDesercion.Plot.Title("Tasa de Deserción por Curso");
            chartDesercion.Plot.YLabel("% Deserción");
            chartDesercion.Plot.XLabel("Cursos");
            chartDesercion.Refresh();
        }

        private void WF_Reportes_Load(object sender, EventArgs e)
        {
            InicializarGraficas();
        }
    }
}

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
    //TODO: Formulario para mostrar los reportes de ocupación y deserción por curso,
    //con funcionalidades para navegar entre las pestañas de cada reporte y volver a la pantalla principal.
    public partial class WF_Reportes : Form
    {
        CN_Reportes objeto = new CN_Reportes(); // Instancia de la clase CN_Reportes para acceder a las operaciones relacionadas con los reportes
        private FormsPlot chartOcupacion; // Instancia de FormsPlot para mostrar la gráfica de ocupación por curso
        private FormsPlot chartDesercion; // Instancia de FormsPlot para mostrar la gráfica de deserción por curso

        public WF_Reportes()
        {
            InitializeComponent();
        }

        //TODO: Evento Click del botón "Ocupación" para mostrar el reporte de ocupación por curso, habilitando la pestaña correspondiente y deshabilitando la otra, así como mostrar los datos en el DataGridView y generar la gráfica.
        private void btnOcupacion_Click(object sender, EventArgs e)
        {
            tabOcupacion.Enabled = true; // Habilitar la pestaña de ocupación
            tabDesercion.Enabled = false; // Deshabilitar la pestaña de deserción
            MostrarOcupacion(); // Mostrar los datos de ocupación en el DataGridView
            GraficaOcupacion(); // Generar la gráfica de ocupación por curso

        }

        //metodo para mostrar los datos de ocupación por curso en el DataGridView, obteniendo los datos a través de la clase CN_Reportes.
        private void MostrarOcupacion()
        {

            dgvOcupacion.DataSource = objeto.ObtenerOcupacionPorCurso();

        }

        //TODO: Evento Click del botón "Deserción" para mostrar el reporte de deserción por curso, habilitando la pestaña correspondiente y deshabilitando la otra, así como mostrar los datos en el DataGridView y generar la gráfica.
        private void btnDesercion_Click(object sender, EventArgs e)
        {
            tabDesercion.Enabled = true; // Habilitar la pestaña de deserción
            tabOcupacion.Enabled = false; // Deshabilitar la pestaña de ocupación
            MostrarDesercion(); // Mostrar los datos de deserción en el DataGridView
            GraficaDesercion(); // Generar la gráfica de deserción por curso


        }

        //metodo para mostrar los datos de deserción por curso en el DataGridView, obteniendo los datos a través de la clase CN_Reportes.
        private void MostrarDesercion()
        {
            dgvDesercion.DataSource = objeto.ObtenerTasaDesercion();
        }

        //TODO: Evento Click del botón "Home" para volver a la pantalla principal, cerrando el formulario actual y abriendo el formulario de inicio (WF_home).
        private void btnHome_Click(object sender, EventArgs e)
        {
            WF_home home = new WF_home();
            home.Show();
            this.Hide();
        }

        //TODO: Método para inicializar las gráficas de ocupación y deserción, creando instancias de FormsPlot y agregándolas a los paneles correspondientes en el formulario.
        private void InicializarGraficas()
        {
            chartOcupacion = new FormsPlot() { Dock = DockStyle.Fill };
            chartDesercion = new FormsPlot() { Dock = DockStyle.Fill };
            panelOcupacion.Controls.Add(chartOcupacion);
            panelDesercion.Controls.Add(chartDesercion);
        }

        //TODO: Método para generar la gráfica de ocupación por curso, obteniendo los datos a través de la clase CN_Reportes, procesando los valores y etiquetas, y utilizando ScottPlot para crear un gráfico de barras con las etiquetas en el eje X y los valores en el eje Y.
        private void GraficaOcupacion()
        {
            DataTable dt = objeto.ObtenerOcupacionPorCurso();

            var valores = new List<double>(); // Lista para almacenar los valores de ocupación por curso
            var etiquetas = new List<string>(); // Lista para almacenar las etiquetas de los cursos

            // Procesar los datos del DataTable para llenar las listas de valores y etiquetas
            foreach (DataRow row in dt.Rows)
            {
                etiquetas.Add(row["NombreCurso"].ToString());

                double valor = row["TotalInscritos"] == DBNull.Value ? 0 : Convert.ToDouble(row["TotalInscritos"]);
                valores.Add(valor);
            }

            // Limpiar la gráfica antes de agregar los nuevos datos
            chartOcupacion.Plot.Clear();


            double[] posiciones = Enumerable.Range(0, valores.Count)
                                            .Select(i => (double)i).ToArray(); // Generar un arreglo de posiciones para las barras en el eje X

            var barras = chartOcupacion.Plot.Add.Bars(posiciones, valores.ToArray()); // Agregar las barras a la gráfica utilizando las posiciones y los valores de ocupación

            // Etiquetas en el eje X utilizando un generador de ticks manual para mostrar los nombres de los cursos en lugar de números
            ScottPlot.TickGenerators.NumericManual tickGen = new();
            for (int i = 0; i < etiquetas.Count; i++)
                tickGen.AddMajor(i, etiquetas[i]); // Agregar un tick mayor para cada posición con la etiqueta correspondiente

            chartOcupacion.Plot.Axes.Bottom.TickGenerator = tickGen; // Asignar el generador de ticks al eje X para mostrar las etiquetas de los cursos
            chartOcupacion.Plot.Title("Ocupación por Curso");
            chartOcupacion.Plot.YLabel("% Ocupación");
            chartOcupacion.Plot.XLabel("Cursos");
            chartOcupacion.Refresh();
        }

        //TODO: Método para generar la gráfica de deserción por curso, obteniendo los datos a través de la clase CN_Reportes,
        //procesando los valores y etiquetas, y utilizando ScottPlot para crear un gráfico de barras con las etiquetas en el eje X y los valores en el eje Y.
        private void GraficaDesercion()
        {
            DataTable dt = objeto.ObtenerTasaDesercion(); // Obtener los datos de deserción por curso a través de la clase CN_Reportes

            var valores = new List<double>(); // Lista para almacenar los valores de tasa de deserción por curso
            var etiquetas = new List<string>(); // Lista para almacenar las etiquetas de los cursos

            // Procesar los datos del DataTable para llenar las listas de valores y etiquetas
            foreach (DataRow row in dt.Rows)
            {
                etiquetas.Add(row["NombreCurso"].ToString()); // Agregar el nombre del curso a la lista de etiquetas

                double valor = row["TasaDesercion"] == DBNull.Value ? 0 : Convert.ToDouble(row["TasaDesercion"]); // Obtener el valor de la tasa de deserción, manejando posibles valores nulos y convirtiéndolos a double
                valores.Add(valor);
            }

            // Limpiar la gráfica antes de agregar los nuevos datos
            chartDesercion.Plot.Clear();

            // Generar un arreglo de posiciones para las barras en el eje X, utilizando el índice de cada valor en la lista de valores
            double[] posiciones = Enumerable.Range(0, valores.Count)
                                            .Select(i => (double)i).ToArray();

            // Agregar las barras a la gráfica utilizando las posiciones y los valores de tasa de deserción
            var barras = chartDesercion.Plot.Add.Bars(posiciones, valores.ToArray());

            // Etiquetas en el eje X utilizando un generador de ticks manual para mostrar los nombres de los cursos en lugar de números
            ScottPlot.TickGenerators.NumericManual tickGen = new();
            for (int i = 0; i < etiquetas.Count; i++)
                tickGen.AddMajor(i, etiquetas[i]); // Agregar un tick mayor para cada posición con la etiqueta correspondiente

            chartDesercion.Plot.Axes.Bottom.TickGenerator = tickGen; // Asignar el generador de ticks al eje X para mostrar las etiquetas de los cursos
            chartDesercion.Plot.Title("Tasa de Deserción por Curso");
            chartDesercion.Plot.YLabel("% Deserción");
            chartDesercion.Plot.XLabel("Cursos");
            chartDesercion.Refresh();
        }

        //evento Load del formulario para inicializar las gráficas de ocupación y deserción al cargar la ventana, asegurando que las instancias de FormsPlot estén listas para mostrar los datos cuando se seleccionen los reportes correspondientes.
        private void WF_Reportes_Load(object sender, EventArgs e)
        {
            InicializarGraficas();
        }

        private void WF_Reportes_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}

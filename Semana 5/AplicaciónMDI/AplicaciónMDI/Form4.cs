using System;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace AplicaciónMDI
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            chartPromedios.Series.Clear();

            Series serie = new Series("Promedios");
            serie.ChartType = SeriesChartType.Column; // Barras verticales
            serie.Color = System.Drawing.Color.SkyBlue;

            // Verificar si hay estudiantes
            if (Form1.DatosCompartidos.ListaEstudiantes.Count > 0)
            {
                foreach (var est in Form1.DatosCompartidos.ListaEstudiantes)
                {
                    double promedio = est.Asignaturas.Count > 0
                        ? est.Asignaturas.Average(a => a.Nota)
                        : 0;

                    serie.Points.AddXY(est.Nombre, promedio);
                }
            }

            chartPromedios.Series.Add(serie);
            chartPromedios.ChartAreas[0].AxisX.Title = "Estudiantes";
            chartPromedios.ChartAreas[0].AxisY.Title = "Promedio";
        }
    }
}

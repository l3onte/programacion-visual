using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicaciónMDI
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            dgvDatos.ColumnCount = 3;
            dgvDatos.Columns[0].Name = "Carnet";
            dgvDatos.Columns[1].Name = "Nombre";
            dgvDatos.Columns[2].Name = "Promedio";

            dgvDatos.Rows.Clear();

            if (Form1.DatosCompartidos.ListaEstudiantes.Count > 0)
            {
                foreach (var est in Form1.DatosCompartidos.ListaEstudiantes)
                {
                    double promedio = est.Asignaturas.Count > 0
                        ? est.Asignaturas.Average(a => a.Nota)
                        : 0;

                    dgvDatos.Rows.Add(est.Carnet, est.Nombre, promedio);
                }
            }
            else
            {
                MessageBox.Show("No hay estudiantes registrados.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

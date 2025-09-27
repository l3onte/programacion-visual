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
            if (Form1.DatosCompartidos.EstudianteActual != null)
            {
                search_carnet.Text = Form1.DatosCompartidos.EstudianteActual.Carnet;
                search_nombre.Text = Form1.DatosCompartidos.EstudianteActual.Nombre;

                dgvDatos.Rows.Clear();

                foreach (var asign in Form1.DatosCompartidos.EstudianteActual.Asignaturas)
                {
                    dgvDatos.Rows.Add(asign.Nombre, asign.Nota);
                }
            }
            else
            {
                MessageBox.Show("No hay datos de estudiante cargados.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

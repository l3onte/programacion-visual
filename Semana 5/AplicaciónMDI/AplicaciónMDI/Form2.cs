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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(carnetTB.Text) || string.IsNullOrWhiteSpace(nameTB.Text))
            {
                MessageBox.Show("Debe ingresar el Carnet y el Nombre del estudiante.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Form1.Estudiante estudiante = new Form1.Estudiante
            {
                Carnet = carnetTB.Text,
                Nombre = nameTB.Text
            };

            foreach (DataGridViewRow fila in notasGrid.Rows)
            {
                if (fila.IsNewRow) continue;

                if (fila.Cells[0].Value != null && fila.Cells[1].Value != null)
                {
                    string asignatura = fila.Cells[0].Value.ToString();
                    double nota;

                    if (double.TryParse(fila.Cells[1].Value.ToString(), out nota))
                    {
                        estudiante.Asignaturas.Add(new Form1.Asignatura
                        {
                            Nombre = asignatura,
                            Nota = nota
                        });
                    }
                    else
                    {
                        MessageBox.Show($"La nota de la asignatura '{asignatura}' no es válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }

            Form1.DatosCompartidos.ListaEstudiantes.Add(estudiante);
            MessageBox.Show("Datos guardados correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}

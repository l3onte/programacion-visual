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
    public partial class Form1 : Form 
    {
        public class Estudiante
        {
            public string Carnet { get; set; }
            public string Nombre { get; set; }
            public List<Asignatura> Asignaturas { get; set; } = new List<Asignatura>();
        }

        public class Asignatura
        {
            public string Nombre { get; set; }
            public double Nota { get; set; }
        }

        public static class DatosCompartidos
        {
            public static Estudiante EstudianteActual { get; set; }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            Form2 AddStudentsView = new Form2();
            AddStudentsView.MdiParent = this;
            AddStudentsView.Show();
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            Form3 ShowStudentsView = new Form3();
            ShowStudentsView.MdiParent = this;
            ShowStudentsView.Show();    
        }
    }
}

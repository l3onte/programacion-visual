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
            public static List<Estudiante> ListaEstudiantes { get; set; } = new List<Estudiante>();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f is Form2)
                {
                    f.Activate();
                    return;
                }
            }

            Form2 AddStudentsView = new Form2();
            AddStudentsView.MdiParent = this;
            AddStudentsView.Show();
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f is Form3)
                {
                    f.Activate();
                    return;
                }
            }

            Form3 ShowStudentsView = new Form3();
            ShowStudentsView.MdiParent = this;
            ShowStudentsView.Show();    
        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f is Form4)
                {
                    f.Activate();
                    return;
                }
            }

            Form4 chartView = new Form4();
            chartView.MdiParent = this;
            chartView.Show();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisorDeImagenes
{
    public partial class Form1 : Form
    {
        string carpeta = @"D:\programacion-visual\Semana 4\source";

        public Form1()
        {
            InitializeComponent();
            CargarImagenes();
        }

        private void CargarImagenes()
        {
            string[] extensiones = { "*.jpg", "*.png", "*.jpeg", "*.bmp", "*.gif" };

            foreach (var ext in extensiones)
            {
                string[] archivos = Directory.GetFiles(carpeta, ext);
                foreach (var archivo in archivos)
                {
                    comboBox1.Items.Add(Path.GetFileName(archivo));
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string archivoSeleccionado = Path.Combine(carpeta, comboBox1.SelectedItem.ToString());

            pictureBox1.Image = System.Drawing.Image.FromFile(archivoSeleccionado);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }
    }
}

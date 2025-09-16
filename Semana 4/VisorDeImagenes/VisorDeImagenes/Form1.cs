using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace VisorDeImagenes
{
    public partial class Form1 : Form
    {
        string carpeta = @"D:\programacion-visual\Semana 4\source";
        List<string> listaImagenes = new List<string>();
        int indiceActual = -1;

        // estado centralizado
        private bool modoGris = false;
        private bool sincronizando = false; // evita recursividad al actualizar Checked

        public Form1()
        {
            InitializeComponent();
            CargarImagenes();

            // Asegurarnos que los ToolStripButtons actúen como "toggle"
            toolStripButton1.CheckOnClick = true; // botón "Normal"
            toolStripButton2.CheckOnClick = true; // botón "Escala de grises"

            // Eventos (si algunos ya los tenías asignados en designer, está bien reasignarlos aquí)
            girar90ALaDerechaToolStripMenuItem.Click += rotarDerecha_Click;
            girar90ALaIzquierdaToolStripMenuItem1.Click += rotarIzquierda_Click;
            copiarToolStripMenuItem.Click += copiar_Click;

            // ToolStripButtons (normal / grises)
            toolStripButton1.Click += toolStripButton1_Click; // Normal
            toolStripButton2.Click += toolStripButton2_Click; // Grises

            // CheckBoxes (si usas Click para evitar bucle CheckedChanged)
            checkBox1.Click += (s, e) => SetMode(false); // Normal
            checkBox2.Click += (s, e) => SetMode(true);  // Escala de grises

            // MenuStrip items (si existen)
            normalToolStripMenuItem.Click += (s, e) => SetMode(false);
            escalaDeGrisesToolStripMenuItem.Click += (s, e) => SetMode(true);
        }

        private void CargarImagenes()
        {
            string[] extensiones = { "*.jpg", "*.png", "*.jpeg", "*.bmp", "*.gif" };

            foreach (var ext in extensiones)
            {
                string[] archivos = Directory.GetFiles(carpeta, ext);
                foreach (var archivo in archivos)
                {
                    listaImagenes.Add(archivo);
                    comboBox1.Items.Add(Path.GetFileName(archivo));
                }
            }

            // si hay imágenes, mostrar la primera y garantizar estado inicial (normal)
            if (listaImagenes.Count > 0)
            {
                SetMode(false); // arranca en Normal por defecto
                MostrarImagen(0);
            }
        }

        private void MostrarImagen(int indice)
        {
            if (indice < 0 || indice >= listaImagenes.Count) return;

            indiceActual = indice;
            string archivoSeleccionado = listaImagenes[indice];

            // liberar imagen previa
            if (pictureBox1.Image != null)
            {
                var prev = pictureBox1.Image;
                pictureBox1.Image = null;
                prev.Dispose();
            }

            // cargar imagen sin dejar archivo bloqueado
            using (var temp = Image.FromFile(archivoSeleccionado))
            {
                // clonamos a Bitmap para trabajar con ella
                Image original = new Bitmap(temp);

                // aplicar el modo actual
                if (modoGris)
                    pictureBox1.Image = ConvertirAGris(original);
                else
                    pictureBox1.Image = new Bitmap(original);

                // guardamos/clonamos la original en imageOriginal si la necesitas en otras operaciones
                original.Dispose();
            }

            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            comboBox1.SelectedIndex = indice;
            toolStripStatusLabel1.Text = archivoSeleccionado;
        }

        private Bitmap ConvertirAGris(Image original)
        {
            var src = new Bitmap(original);
            Bitmap bmp = new Bitmap(src.Width, src.Height);

            for (int y = 0; y < src.Height; y++)
            {
                for (int x = 0; x < src.Width; x++)
                {
                    Color pixel = src.GetPixel(x, y);
                    int gris = (pixel.R + pixel.G + pixel.B) / 3;
                    bmp.SetPixel(x, y, Color.FromArgb(gris, gris, gris));
                }
            }

            src.Dispose();
            return bmp;
        }

        // Método centralizado que pone el modo y sincroniza todos los controles
        private void SetMode(bool gris)
        {
            // si ya estamos sincronizando, salir (evita loops)
            if (sincronizando) return;

            sincronizando = true;
            modoGris = gris;

            // actualizar CheckBoxes
            checkBox2.Checked = gris;   // suponiendo checkBox2 = Escala de grises
            checkBox1.Checked = !gris;  // suponiendo checkBox1 = Normal

            // actualizar ToolStripButtons
            toolStripButton2.Checked = gris;
            toolStripButton1.Checked = !gris;

            // actualizar MenuStrip (si existen)
            if (this.normalToolStripMenuItem != null)
                normalToolStripMenuItem.Checked = !gris;
            if (this.escalaDeGrisesToolStripMenuItem != null)
                escalaDeGrisesToolStripMenuItem.Checked = gris;

            // refrescar la imagen actual con el nuevo modo
            if (indiceActual >= 0)
                MostrarImagen(indiceActual);

            sincronizando = false;
        }

        // ---------- Handlers auxiliares ----------
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarImagen(comboBox1.SelectedIndex);
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (indiceActual > 0) MostrarImagen(indiceActual - 1);
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (indiceActual < listaImagenes.Count - 1) MostrarImagen(indiceActual + 1);
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            MostrarImagen(0);
        }

        private void btnFinal_Click(object sender, EventArgs e)
        {
            MostrarImagen(listaImagenes.Count - 1);
        }

        // ToolStripButton "Normal"
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            // toolStripButton1.CheckOnClick = true hace que toolStripButton1.Checked ya cambie,
            // pero centralizamos por si se quiere forzar un estado:
            SetMode(false);
        }

        // ToolStripButton "Grises"
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            // togglea según el Checked actual del botón
            SetMode(toolStripButton2.Checked);
        }

        // Rotaciones y copiar (igual que tenías)
        private void rotarIzquierda_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null) return;
            pictureBox1.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
            pictureBox1.Refresh();
        }

        private void rotarDerecha_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null) return;
            pictureBox1.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            pictureBox1.Refresh();
        }

        private void copiar_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                Clipboard.SetImage(pictureBox1.Image);
                MessageBox.Show("Imagen copiada en el portapapeles.");
            }
        }

        // Modos de visualización (centrar/ajustar/zoom) si los mantienes
        private void checkBox3_Click(object sender, EventArgs e)
        {
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
        }

        private void checkBox4_Click(object sender, EventArgs e)
        {
            checkBox3.Checked = false;
            checkBox5.Checked = false;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void checkBox5_Click(object sender, EventArgs e)
        {
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void toolStripButtonGuardar_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("No hay ninguna imagen para guardar.");
                return;
            }

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Title = "Guardar imagen";
                saveFileDialog.Filter = "Imagen JPG|*.jpg|Imagen PNG|*.png|Bitmap|*.bmp";
                saveFileDialog.FileName = "miImagen";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var formato = System.Drawing.Imaging.ImageFormat.Png;

                    switch (saveFileDialog.FilterIndex)
                    {
                        case 1: formato = System.Drawing.Imaging.ImageFormat.Jpeg; break;
                        case 2: formato = System.Drawing.Imaging.ImageFormat.Png; break;
                        case 3: formato = System.Drawing.Imaging.ImageFormat.Bmp; break;
                    }

                    pictureBox1.Image.Save(saveFileDialog.FileName, formato);
                    MessageBox.Show("Imagen guardada en:\n" + saveFileDialog.FileName);
                }
            }
        }

        private void toolStripButtonSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}

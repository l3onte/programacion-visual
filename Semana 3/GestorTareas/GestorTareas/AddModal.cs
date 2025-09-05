using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorTareas
{
    public partial class AddModal : Form
    {

        public string Nombre
        {
            get => txtNombre.Text;
            set => txtNombre.Text = value;
        }

        public string Descripcion
        {
            get => txtDescripcion.Text;
            set => txtDescripcion.Text = value;
        }

        public DateTime Fecha
        {
            get => dptFecha.Value;
            set => dptFecha.Value = value;
        }

        public string Lugar
        {
            get => txtLugar.Text;
            set => txtLugar.Text = value;
        }

        public string Estado
        {
            get => comboBox1.Text;
            set => comboBox1.Text = value;
        }


        public AddModal()
        {
            InitializeComponent();

            comboBox1.Items.AddRange(new[] { "No realizada", "En proceso", "Terminada" });
            comboBox1.SelectedIndex = 0;

            btnSave.Click += btnSave_Click;

            this.AcceptButton = btnSave;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}

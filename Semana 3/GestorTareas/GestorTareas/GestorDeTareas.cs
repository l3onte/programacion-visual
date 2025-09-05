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
    public partial class GestorDeTareas : Form
    {
        private void Form1_Load(object sender, EventArgs e)
        {
            // Columna de Eliminar
            DataGridViewButtonColumn btnEliminar = new DataGridViewButtonColumn();
            btnEliminar.HeaderText = "Eliminar";
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseColumnTextForButtonValue = true;
            dgvTareas.Columns.Add(btnEliminar);

            // Columna de Editar
            DataGridViewButtonColumn btnEditar = new DataGridViewButtonColumn();
            btnEditar.HeaderText = "Editar";
            btnEditar.Name = "btnEditar";
            btnEditar.Text = "Editar";
            btnEditar.UseColumnTextForButtonValue = true;
            dgvTareas.Columns.Add(btnEditar);

            dgvTareas.Rows.Add("001", "Tarea 1", "Descripción corta", "04/09/2025", "Oficina", "Pendiente");
            dgvTareas.Rows.Add("002", "Tarea 2", "Otra descripción", "05/09/2025", "Casa", "Completada");
        }

        public GestorDeTareas()
        {
            InitializeComponent();
            dgvTareas.CellClick += DataGridView1_CellClick;
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dgvTareas.Columns[e.ColumnIndex].Name == "btnEliminar")
            {
                dgvTareas.Rows.RemoveAt(e.RowIndex);
            }

            if (dgvTareas.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                string codigo = dgvTareas.Rows[e.RowIndex].Cells["lblCodigo"].Value?.ToString();
                string nombre = dgvTareas.Rows[e.RowIndex].Cells["lblNombre"].Value?.ToString();

                MessageBox.Show($"Editar tarea:\nCódigo: {codigo}\nNombre: {nombre}");
            }
        }
    }
}

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
        public GestorDeTareas()
        {
            InitializeComponent();

            this.Load -= Form1_Load;
            this.Load += Form1_Load;

            dgvTareas.CellClick -= DataGridView1_CellClick;
            dgvTareas.CellClick += DataGridView1_CellClick;

            ModalButon.Click -= ModalButon_Click;
            ModalButon.Click += ModalButon_Click;
            
            dgvTareas.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvTareas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTareas.MultiSelect = false;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            // Columna de Eliminar
            if (!dgvTareas.Columns.Contains("btnEliminar"))
            {
                var btnEliminar = new DataGridViewButtonColumn
                {
                    HeaderText = "Eliminar",
                    Name = "btnEliminar",
                    Text = "Eliminar",
                    UseColumnTextForButtonValue = true
                };
                dgvTareas.Columns.Add(btnEliminar);
            }

            if (!dgvTareas.Columns.Contains("btnEditar"))
            {
                var btnEditar = new DataGridViewButtonColumn
                {
                    HeaderText = "Editar",
                    Name = "btnEditar",
                    Text = "Editar",
                    UseColumnTextForButtonValue = true
                };
                dgvTareas.Columns.Add(btnEditar);
            }
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            var column = dgvTareas.Columns[e.ColumnIndex];

            if (column.Name == "btnEliminar")
            {
                var confirm = MessageBox.Show(
                    "¿Seguro que quieres eliminar esta tarea?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (confirm == DialogResult.Yes)
                {
                    dgvTareas.Rows.RemoveAt(e.RowIndex);
                }
                return; // <-- Muy importante: salir del método para que no siga ejecutando nada más
            }

            if (column.Name == "btnEditar")
            {
                // Deselecciona solo antes de abrir el modal
                dgvTareas.ClearSelection();
                var row = dgvTareas.Rows[e.RowIndex];

                using (var editForm = new AddModal())
                {
                    editForm.StartPosition = FormStartPosition.CenterParent;

                    editForm.Nombre = row.Cells["colNombre"].Value?.ToString();
                    editForm.Descripcion = row.Cells["colDescripcion"].Value?.ToString();
                    editForm.Fecha = DateTime.Parse(row.Cells["colFecha"].Value?.ToString() ?? DateTime.Now.ToString());
                    editForm.Lugar = row.Cells["colLugar"].Value?.ToString();
                    editForm.Estado = row.Cells["colEstado"].Value?.ToString();

                    if (editForm.ShowDialog(this) == DialogResult.OK)
                    {
                        row.Cells["colNombre"].Value = editForm.Nombre;
                        row.Cells["colDescripcion"].Value = editForm.Descripcion;
                        row.Cells["colFecha"].Value = editForm.Fecha.ToShortDateString();
                        row.Cells["colLugar"].Value = editForm.Lugar;
                        row.Cells["colEstado"].Value = editForm.Estado;
                    }
                }
            }
        }


        private void ModalButon_Click(object sender, EventArgs e)
        {
            using (var addForm = new AddModal())
            {
                addForm.StartPosition = FormStartPosition.CenterParent;

                if (addForm.ShowDialog(this) == DialogResult.OK)
                {
                    // Si no pides "Código" en el modal, lo generamos simple y bonito:
                    string codigo = (dgvTareas.Rows.Count).ToString("000");

                    dgvTareas.Rows.Add(
                        codigo,
                        addForm.Nombre,
                        addForm.Descripcion,
                        addForm.Fecha.ToShortDateString(),
                        addForm.Lugar,
                        addForm.Estado
                    );
                }
            }
        }
    }
}

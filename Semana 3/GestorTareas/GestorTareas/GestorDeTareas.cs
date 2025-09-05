using System;
using System.Globalization;
using System.Linq;
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

        // ---------------- FILTROS ----------------

        private void AplicarFiltros()
        {
            // Forzar la confirmación de cualquier edición pendiente
            dgvTareas.EndEdit();
            dgvTareas.ClearSelection();

            // Cambiar el foco a otro control para asegurar que se termina la edición
            if (!btnBuscarCodigo.Focused)
                btnBuscarCodigo.Focus();

            // Pequeña pausa para permitir que se complete la operación de edición
            System.Threading.Thread.Sleep(10);
            Application.DoEvents();

            string codigoFiltro = txtBuscarCodigo.Text;
            string estadoFiltro = cbBuscarEstado.SelectedItem?.ToString();
            DateTime inicio = dtpInicio.Value.Date;
            DateTime fin = dtpFinal.Value.Date;

            // Deshabilitar redibujado para mejorar rendimiento
            dgvTareas.SuspendLayout();

            foreach (DataGridViewRow row in dgvTareas.Rows)
            {
                if (row.IsNewRow) continue;

                bool mostrar = true;

                // Filtrar por código (corregido)
                if (!string.IsNullOrEmpty(codigoFiltro))
                {
                    var cellCodigo = row.Cells["colCodigo"].Value?.ToString() ?? "";
                    // Usar ToLower() en lugar de StringComparison
                    mostrar &= cellCodigo.ToLower().Contains(codigoFiltro.ToLower());
                }

                // Filtrar por estado
                if (!string.IsNullOrEmpty(estadoFiltro))
                {
                    var cellEstado = row.Cells["colEstado"].Value?.ToString() ?? "";
                    // Usar ToLower() en lugar de StringComparison
                    mostrar &= cellEstado.Trim().ToLower() == estadoFiltro.Trim().ToLower();
                }

                // Filtrar por fecha
                var fechaStr = row.Cells["colFecha"].Value?.ToString();
                if (!string.IsNullOrEmpty(fechaStr) &&
                    DateTime.TryParseExact(fechaStr, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime fecha))
                {
                    mostrar &= fecha >= inicio && fecha <= fin;
                }
                else
                {
                    mostrar = false;
                }

                // Solo cambiar la visibilidad si es necesario
                if (row.Visible != mostrar)
                {
                    row.Visible = mostrar;
                }
            }

            // Reanudar el redibujado
            dgvTareas.ResumeLayout();
        }


        private void LimpiarFiltros()
        {
            // Limpiar los controles de filtro
            txtBuscarCodigo.Text = "";
            cbBuscarEstado.SelectedIndex = -1; // Deselecciona cualquier estado
            dtpInicio.Value = DateTime.Now.Date; // Puedes poner la fecha mínima si quieres
            dtpFinal.Value = DateTime.Now.Date;

            // Mostrar todas las filas
            foreach (DataGridViewRow row in dgvTareas.Rows)
            {
                if (row.IsNewRow) continue; // Ignorar fila nueva
                row.Visible = true;
            }
        }

        // ---------------- CARGA DE FORM ----------------

        private void Form1_Load(object sender, EventArgs e)
        {
            // Botón Eliminar
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

            // Botón Editar
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

        // ---------------- EVENTO CLICK CELDA ----------------

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            var column = dgvTareas.Columns[e.ColumnIndex];

            // Eliminar fila
            if (column.Name == "btnEliminar")
            {
                var confirm = MessageBox.Show(
                    "¿Seguro que quieres eliminar esta tarea?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (confirm == DialogResult.Yes)
                    dgvTareas.Rows.RemoveAt(e.RowIndex);

                return;
            }

            // Editar fila
            if (column.Name == "btnEditar")
            {
                dgvTareas.ClearSelection();
                var row = dgvTareas.Rows[e.RowIndex];

                using (var editForm = new AddModal())
                {
                    editForm.Text = "Editar Tarea";
                    editForm.StartPosition = FormStartPosition.CenterParent;

                    editForm.Nombre = row.Cells["colNombre"].Value?.ToString();
                    editForm.Descripcion = row.Cells["colDescripcion"].Value?.ToString();
                    editForm.Fecha = DateTime.ParseExact(row.Cells["colFecha"].Value?.ToString() ?? DateTime.Now.ToString("dd/MM/yyyy"), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    editForm.Lugar = row.Cells["colLugar"].Value?.ToString();
                    editForm.Estado = row.Cells["colEstado"].Value?.ToString();

                    if (editForm.ShowDialog(this) == DialogResult.OK)
                    {
                        row.Cells["colNombre"].Value = editForm.Nombre;
                        row.Cells["colDescripcion"].Value = editForm.Descripcion;
                        row.Cells["colFecha"].Value = editForm.Fecha.ToString("dd/MM/yyyy");
                        row.Cells["colLugar"].Value = editForm.Lugar;
                        row.Cells["colEstado"].Value = editForm.Estado;
                    }
                }
            }
        }

        // ---------------- MODAL AGREGAR ----------------

        private void ModalButon_Click(object sender, EventArgs e)
        {
            using (var addForm = new AddModal())
            {
                addForm.StartPosition = FormStartPosition.CenterParent;

                if (addForm.ShowDialog(this) == DialogResult.OK)
                {
                    string codigo = (dgvTareas.Rows.Count).ToString("000");

                    dgvTareas.Rows.Add(
                        codigo,
                        addForm.Nombre,
                        addForm.Descripcion,
                        addForm.Fecha.ToString("dd/MM/yyyy"),
                        addForm.Lugar,
                        addForm.Estado
                    );
                }
            }
        }

        // ---------------- BOTONES FILTRAR ----------------

        private void btnBuscarCodigo_Click(object sender, EventArgs e)
        {
            AplicarFiltros();
        }

        private void btnBuscarEstado_Click(object sender, EventArgs e)
        {
            AplicarFiltros();
        }

        private void btnBuscarFecha_Click(object sender, EventArgs e)
        {
            AplicarFiltros();
        }

        private void btLimpiarFiltros_Click(object sender, EventArgs e)
        {
            LimpiarFiltros();
        }
    }
}
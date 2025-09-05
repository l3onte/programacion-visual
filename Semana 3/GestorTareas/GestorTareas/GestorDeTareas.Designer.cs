using System.Windows.Forms;

namespace GestorTareas
{
    partial class GestorDeTareas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestorDeTareas));
            this.ModalButon = new System.Windows.Forms.Button();
            this.txtBuscarCodigo = new System.Windows.Forms.TextBox();
            this.dgvTareas = new System.Windows.Forms.DataGridView();
            this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLugar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbBuscarEstado = new System.Windows.Forms.ComboBox();
            this.btnBuscarCodigo = new System.Windows.Forms.Button();
            this.btnBuscarEstado = new System.Windows.Forms.Button();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpFinal = new System.Windows.Forms.DateTimePicker();
            this.btnBuscarFecha = new System.Windows.Forms.Button();
            this.btLimpiarFiltros = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTareas)).BeginInit();
            this.SuspendLayout();
            // 
            // ModalButon
            // 
            this.ModalButon.BackColor = System.Drawing.Color.PaleGreen;
            this.ModalButon.Location = new System.Drawing.Point(40, 15);
            this.ModalButon.Margin = new System.Windows.Forms.Padding(4);
            this.ModalButon.Name = "ModalButon";
            this.ModalButon.Size = new System.Drawing.Size(164, 47);
            this.ModalButon.TabIndex = 0;
            this.ModalButon.Text = "Agregar Tarea";
            this.ModalButon.UseVisualStyleBackColor = false;
            this.ModalButon.Click += new System.EventHandler(this.ModalButon_Click);
            // 
            // txtBuscarCodigo
            // 
            this.txtBuscarCodigo.Location = new System.Drawing.Point(212, 36);
            this.txtBuscarCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscarCodigo.Name = "txtBuscarCodigo";
            this.txtBuscarCodigo.Size = new System.Drawing.Size(323, 22);
            this.txtBuscarCodigo.TabIndex = 1;
            // 
            // dgvTareas
            // 
            this.dgvTareas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTareas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodigo,
            this.colNombre,
            this.colDescripcion,
            this.colFecha,
            this.colLugar,
            this.colEstado});
            this.dgvTareas.Location = new System.Drawing.Point(40, 114);
            this.dgvTareas.Margin = new System.Windows.Forms.Padding(4);
            this.dgvTareas.Name = "dgvTareas";
            this.dgvTareas.RowHeadersWidth = 51;
            this.dgvTareas.Size = new System.Drawing.Size(1339, 362);
            this.dgvTareas.TabIndex = 2;
            this.dgvTareas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellClick);
            // 
            // colCodigo
            // 
            this.colCodigo.HeaderText = "Codigo";
            this.colCodigo.MinimumWidth = 6;
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.Width = 125;
            // 
            // colNombre
            // 
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.MinimumWidth = 6;
            this.colNombre.Name = "colNombre";
            this.colNombre.Width = 125;
            // 
            // colDescripcion
            // 
            this.colDescripcion.HeaderText = "Descripcion";
            this.colDescripcion.MinimumWidth = 6;
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.Width = 125;
            // 
            // colFecha
            // 
            this.colFecha.HeaderText = "Fecha";
            this.colFecha.MinimumWidth = 6;
            this.colFecha.Name = "colFecha";
            this.colFecha.Width = 125;
            // 
            // colLugar
            // 
            this.colLugar.HeaderText = "Lugar";
            this.colLugar.MinimumWidth = 6;
            this.colLugar.Name = "colLugar";
            this.colLugar.Width = 125;
            // 
            // colEstado
            // 
            this.colEstado.HeaderText = "Estado";
            this.colEstado.MinimumWidth = 6;
            this.colEstado.Name = "colEstado";
            this.colEstado.Width = 125;
            // 
            // cbBuscarEstado
            // 
            this.cbBuscarEstado.FormattingEnabled = true;
            this.cbBuscarEstado.Items.AddRange(new object[] {
            "No realizada",
            "En proceso",
            "Terminada"});
            this.cbBuscarEstado.Location = new System.Drawing.Point(631, 32);
            this.cbBuscarEstado.Margin = new System.Windows.Forms.Padding(4);
            this.cbBuscarEstado.Name = "cbBuscarEstado";
            this.cbBuscarEstado.Size = new System.Drawing.Size(97, 24);
            this.cbBuscarEstado.TabIndex = 3;
            // 
            // btnBuscarCodigo
            // 
            this.btnBuscarCodigo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscarCodigo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscarCodigo.BackgroundImage")));
            this.btnBuscarCodigo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBuscarCodigo.Location = new System.Drawing.Point(567, 13);
            this.btnBuscarCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarCodigo.Name = "btnBuscarCodigo";
            this.btnBuscarCodigo.Size = new System.Drawing.Size(47, 47);
            this.btnBuscarCodigo.TabIndex = 4;
            this.btnBuscarCodigo.UseVisualStyleBackColor = false;
            this.btnBuscarCodigo.Click += new System.EventHandler(this.btnBuscarCodigo_Click);
            // 
            // btnBuscarEstado
            // 
            this.btnBuscarEstado.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscarEstado.BackgroundImage")));
            this.btnBuscarEstado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBuscarEstado.Location = new System.Drawing.Point(745, 12);
            this.btnBuscarEstado.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarEstado.Name = "btnBuscarEstado";
            this.btnBuscarEstado.Size = new System.Drawing.Size(47, 47);
            this.btnBuscarEstado.TabIndex = 5;
            this.btnBuscarEstado.UseVisualStyleBackColor = true;
            this.btnBuscarEstado.Click += new System.EventHandler(this.btnBuscarEstado_Click);
            // 
            // dtpInicio
            // 
            this.dtpInicio.Location = new System.Drawing.Point(805, 33);
            this.dtpInicio.Margin = new System.Windows.Forms.Padding(4);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(194, 22);
            this.dtpInicio.TabIndex = 6;
            // 
            // dtpFinal
            // 
            this.dtpFinal.Location = new System.Drawing.Point(1014, 33);
            this.dtpFinal.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFinal.Name = "dtpFinal";
            this.dtpFinal.Size = new System.Drawing.Size(196, 22);
            this.dtpFinal.TabIndex = 7;
            // 
            // btnBuscarFecha
            // 
            this.btnBuscarFecha.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscarFecha.BackgroundImage")));
            this.btnBuscarFecha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBuscarFecha.Location = new System.Drawing.Point(1226, 14);
            this.btnBuscarFecha.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarFecha.Name = "btnBuscarFecha";
            this.btnBuscarFecha.Size = new System.Drawing.Size(47, 47);
            this.btnBuscarFecha.TabIndex = 8;
            this.btnBuscarFecha.UseVisualStyleBackColor = true;
            this.btnBuscarFecha.Click += new System.EventHandler(this.btnBuscarFecha_Click);
            // 
            // btLimpiarFiltros
            // 
            this.btLimpiarFiltros.BackColor = System.Drawing.Color.SkyBlue;
            this.btLimpiarFiltros.Location = new System.Drawing.Point(1286, 13);
            this.btLimpiarFiltros.Margin = new System.Windows.Forms.Padding(4);
            this.btLimpiarFiltros.Name = "btLimpiarFiltros";
            this.btLimpiarFiltros.Size = new System.Drawing.Size(93, 50);
            this.btLimpiarFiltros.TabIndex = 9;
            this.btLimpiarFiltros.Text = "Limpiar Filtros";
            this.btLimpiarFiltros.UseVisualStyleBackColor = false;
            this.btLimpiarFiltros.Click += new System.EventHandler(this.btLimpiarFiltros_Click);
            // 
            // GestorDeTareas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1425, 530);
            this.Controls.Add(this.btLimpiarFiltros);
            this.Controls.Add(this.btnBuscarFecha);
            this.Controls.Add(this.dtpFinal);
            this.Controls.Add(this.dtpInicio);
            this.Controls.Add(this.btnBuscarEstado);
            this.Controls.Add(this.btnBuscarCodigo);
            this.Controls.Add(this.cbBuscarEstado);
            this.Controls.Add(this.dgvTareas);
            this.Controls.Add(this.txtBuscarCodigo);
            this.Controls.Add(this.ModalButon);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GestorDeTareas";
            this.Text = "Gestor de Tareas";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTareas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ModalButon;
        private System.Windows.Forms.TextBox txtBuscarCodigo;
        private System.Windows.Forms.DataGridView dgvTareas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLugar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstado;
        private System.Windows.Forms.ComboBox cbBuscarEstado;
        private System.Windows.Forms.Button btnBuscarCodigo;
        private System.Windows.Forms.Button btnBuscarEstado;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.DateTimePicker dtpFinal;
        private System.Windows.Forms.Button btnBuscarFecha;
        private Button btLimpiarFiltros;
    }
}


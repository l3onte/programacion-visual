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
            this.ModalButon.Location = new System.Drawing.Point(30, 12);
            this.ModalButon.Name = "ModalButon";
            this.ModalButon.Size = new System.Drawing.Size(123, 38);
            this.ModalButon.TabIndex = 0;
            this.ModalButon.Text = "Agregar Tarea";
            this.ModalButon.UseVisualStyleBackColor = true;
            this.ModalButon.Click += new System.EventHandler(this.ModalButon_Click);
            // 
            // txtBuscarCodigo
            // 
            this.txtBuscarCodigo.Location = new System.Drawing.Point(159, 29);
            this.txtBuscarCodigo.Name = "txtBuscarCodigo";
            this.txtBuscarCodigo.Size = new System.Drawing.Size(243, 20);
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
            this.dgvTareas.Location = new System.Drawing.Point(30, 93);
            this.dgvTareas.Name = "dgvTareas";
            this.dgvTareas.Size = new System.Drawing.Size(843, 294);
            this.dgvTareas.TabIndex = 2;
            this.dgvTareas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellClick);
            // 
            // colCodigo
            // 
            this.colCodigo.HeaderText = "Codigo";
            this.colCodigo.Name = "colCodigo";
            // 
            // colNombre
            // 
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.Name = "colNombre";
            // 
            // colDescripcion
            // 
            this.colDescripcion.HeaderText = "Descripcion";
            this.colDescripcion.Name = "colDescripcion";
            // 
            // colFecha
            // 
            this.colFecha.HeaderText = "Fecha";
            this.colFecha.Name = "colFecha";
            // 
            // colLugar
            // 
            this.colLugar.HeaderText = "Lugar";
            this.colLugar.Name = "colLugar";
            // 
            // colEstado
            // 
            this.colEstado.HeaderText = "Estado";
            this.colEstado.Name = "colEstado";
            // 
            // cbBuscarEstado
            // 
            this.cbBuscarEstado.FormattingEnabled = true;
            this.cbBuscarEstado.Items.AddRange(new object[] {
            "No realizada",
            "En proceso",
            "Terminada"});
            this.cbBuscarEstado.Location = new System.Drawing.Point(449, 30);
            this.cbBuscarEstado.Name = "cbBuscarEstado";
            this.cbBuscarEstado.Size = new System.Drawing.Size(74, 21);
            this.cbBuscarEstado.TabIndex = 3;
            // 
            // btnBuscarCodigo
            // 
            this.btnBuscarCodigo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBuscarCodigo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscarCodigo.BackgroundImage")));
            this.btnBuscarCodigo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBuscarCodigo.Location = new System.Drawing.Point(408, 15);
            this.btnBuscarCodigo.Name = "btnBuscarCodigo";
            this.btnBuscarCodigo.Size = new System.Drawing.Size(35, 38);
            this.btnBuscarCodigo.TabIndex = 4;
            this.btnBuscarCodigo.UseVisualStyleBackColor = false;
            this.btnBuscarCodigo.Click += new System.EventHandler(this.btnBuscarCodigo_Click);
            // 
            // btnBuscarEstado
            // 
            this.btnBuscarEstado.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscarEstado.BackgroundImage")));
            this.btnBuscarEstado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBuscarEstado.Location = new System.Drawing.Point(529, 17);
            this.btnBuscarEstado.Name = "btnBuscarEstado";
            this.btnBuscarEstado.Size = new System.Drawing.Size(35, 38);
            this.btnBuscarEstado.TabIndex = 5;
            this.btnBuscarEstado.UseVisualStyleBackColor = true;
            this.btnBuscarEstado.Click += new System.EventHandler(this.btnBuscarEstado_Click);
            // 
            // dtpInicio
            // 
            this.dtpInicio.Location = new System.Drawing.Point(570, 32);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(90, 20);
            this.dtpInicio.TabIndex = 6;
            // 
            // dtpFinal
            // 
            this.dtpFinal.Location = new System.Drawing.Point(666, 31);
            this.dtpFinal.Name = "dtpFinal";
            this.dtpFinal.Size = new System.Drawing.Size(90, 20);
            this.dtpFinal.TabIndex = 7;
            // 
            // btnBuscarFecha
            // 
            this.btnBuscarFecha.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscarFecha.BackgroundImage")));
            this.btnBuscarFecha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBuscarFecha.Location = new System.Drawing.Point(762, 15);
            this.btnBuscarFecha.Name = "btnBuscarFecha";
            this.btnBuscarFecha.Size = new System.Drawing.Size(35, 38);
            this.btnBuscarFecha.TabIndex = 8;
            this.btnBuscarFecha.UseVisualStyleBackColor = true;
            this.btnBuscarFecha.Click += new System.EventHandler(this.btnBuscarFecha_Click);
            // 
            // btLimpiarFiltros
            // 
            this.btLimpiarFiltros.Location = new System.Drawing.Point(803, 12);
            this.btLimpiarFiltros.Name = "btLimpiarFiltros";
            this.btLimpiarFiltros.Size = new System.Drawing.Size(70, 41);
            this.btLimpiarFiltros.TabIndex = 9;
            this.btLimpiarFiltros.Text = "Limpiar Filtros";
            this.btLimpiarFiltros.UseVisualStyleBackColor = true;
            this.btLimpiarFiltros.Click += new System.EventHandler(this.btLimpiarFiltros_Click);
            // 
            // GestorDeTareas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 431);
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


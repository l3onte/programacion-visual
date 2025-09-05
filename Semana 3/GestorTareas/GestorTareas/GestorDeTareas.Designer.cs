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
            this.ModalButon = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dgvTareas = new System.Windows.Forms.DataGridView();
            this.lblCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblLugar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTareas)).BeginInit();
            this.SuspendLayout();
            // 
            // ModalButon
            // 
            this.ModalButon.Location = new System.Drawing.Point(30, 19);
            this.ModalButon.Name = "ModalButon";
            this.ModalButon.Size = new System.Drawing.Size(123, 38);
            this.ModalButon.TabIndex = 0;
            this.ModalButon.Text = "Agregar Tarea";
            this.ModalButon.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(159, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(714, 20);
            this.textBox1.TabIndex = 1;
            // 
            // dgvTareas
            // 
            this.dgvTareas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTareas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lblCodigo,
            this.lblNombre,
            this.lblDescripcion,
            this.lblFecha,
            this.lblLugar,
            this.lblEstado});
            this.dgvTareas.Location = new System.Drawing.Point(30, 100);
            this.dgvTareas.Name = "dgvTareas";
            this.dgvTareas.Size = new System.Drawing.Size(843, 294);
            this.dgvTareas.TabIndex = 2;
            this.dgvTareas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellClick);
            // 
            // lblCodigo
            // 
            this.lblCodigo.HeaderText = "Codigo";
            this.lblCodigo.Name = "lblCodigo";
            // 
            // lblNombre
            // 
            this.lblNombre.HeaderText = "Nombre";
            this.lblNombre.Name = "lblNombre";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.HeaderText = "Descripcion";
            this.lblDescripcion.Name = "lblDescripcion";
            // 
            // lblFecha
            // 
            this.lblFecha.HeaderText = "Fecha";
            this.lblFecha.Name = "lblFecha";
            // 
            // lblLugar
            // 
            this.lblLugar.HeaderText = "Lugar";
            this.lblLugar.Name = "lblLugar";
            // 
            // lblEstado
            // 
            this.lblEstado.HeaderText = "Estado";
            this.lblEstado.Name = "lblEstado";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 431);
            this.Controls.Add(this.dgvTareas);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ModalButon);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTareas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ModalButon;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dgvTareas;
        private System.Windows.Forms.DataGridViewTextBoxColumn lblCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn lblNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn lblDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn lblFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn lblLugar;
        private System.Windows.Forms.DataGridViewTextBoxColumn lblEstado;
    }
}


namespace AplicaciónMDI
{
    partial class Form3
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
            this.carnetLabelShowView = new System.Windows.Forms.Label();
            this.nameLabelShowView = new System.Windows.Forms.Label();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.asignature_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.note_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.search_carnet = new System.Windows.Forms.TextBox();
            this.search_nombre = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // carnetLabelShowView
            // 
            this.carnetLabelShowView.AutoSize = true;
            this.carnetLabelShowView.Location = new System.Drawing.Point(33, 36);
            this.carnetLabelShowView.Name = "carnetLabelShowView";
            this.carnetLabelShowView.Size = new System.Drawing.Size(38, 13);
            this.carnetLabelShowView.TabIndex = 0;
            this.carnetLabelShowView.Text = "Carnet";
            // 
            // nameLabelShowView
            // 
            this.nameLabelShowView.AutoSize = true;
            this.nameLabelShowView.Location = new System.Drawing.Point(33, 80);
            this.nameLabelShowView.Name = "nameLabelShowView";
            this.nameLabelShowView.Size = new System.Drawing.Size(44, 13);
            this.nameLabelShowView.TabIndex = 1;
            this.nameLabelShowView.Text = "Nombre";
            // 
            // dgvDatos
            // 
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.asignature_,
            this.note_});
            this.dgvDatos.Location = new System.Drawing.Point(36, 148);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.Size = new System.Drawing.Size(243, 128);
            this.dgvDatos.TabIndex = 2;
            // 
            // asignature_
            // 
            this.asignature_.HeaderText = "Asignatura";
            this.asignature_.Name = "asignature_";
            // 
            // note_
            // 
            this.note_.HeaderText = "Nota";
            this.note_.Name = "note_";
            // 
            // search_carnet
            // 
            this.search_carnet.Location = new System.Drawing.Point(37, 54);
            this.search_carnet.Name = "search_carnet";
            this.search_carnet.Size = new System.Drawing.Size(242, 20);
            this.search_carnet.TabIndex = 3;
            // 
            // search_nombre
            // 
            this.search_nombre.Location = new System.Drawing.Point(36, 96);
            this.search_nombre.Name = "search_nombre";
            this.search_nombre.Size = new System.Drawing.Size(243, 20);
            this.search_nombre.TabIndex = 4;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 349);
            this.Controls.Add(this.search_nombre);
            this.Controls.Add(this.search_carnet);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.nameLabelShowView);
            this.Controls.Add(this.carnetLabelShowView);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label carnetLabelShowView;
        private System.Windows.Forms.Label nameLabelShowView;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn asignature_;
        private System.Windows.Forms.DataGridViewTextBoxColumn note_;
        private System.Windows.Forms.TextBox search_carnet;
        private System.Windows.Forms.TextBox search_nombre;
    }
}
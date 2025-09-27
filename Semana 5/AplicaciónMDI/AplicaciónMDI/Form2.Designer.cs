namespace AplicaciónMDI
{
    partial class Form2
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
            this.carnetLabel = new System.Windows.Forms.Label();
            this.carnetTB = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.notasGrid = new System.Windows.Forms.DataGridView();
            this.asignatureCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finalNoteCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saveBtn = new System.Windows.Forms.Button();
            this.cancelarBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.notasGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // carnetLabel
            // 
            this.carnetLabel.AutoSize = true;
            this.carnetLabel.Location = new System.Drawing.Point(38, 25);
            this.carnetLabel.Name = "carnetLabel";
            this.carnetLabel.Size = new System.Drawing.Size(38, 13);
            this.carnetLabel.TabIndex = 0;
            this.carnetLabel.Text = "Carnet";
            // 
            // carnetTB
            // 
            this.carnetTB.Location = new System.Drawing.Point(41, 41);
            this.carnetTB.Name = "carnetTB";
            this.carnetTB.Size = new System.Drawing.Size(240, 20);
            this.carnetTB.TabIndex = 1;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(41, 86);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "Name";
            // 
            // nameTB
            // 
            this.nameTB.Location = new System.Drawing.Point(41, 102);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(240, 20);
            this.nameTB.TabIndex = 3;
            // 
            // notasGrid
            // 
            this.notasGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.notasGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.asignatureCol,
            this.finalNoteCol});
            this.notasGrid.Location = new System.Drawing.Point(41, 158);
            this.notasGrid.Name = "notasGrid";
            this.notasGrid.Size = new System.Drawing.Size(240, 95);
            this.notasGrid.TabIndex = 4;
            // 
            // asignatureCol
            // 
            this.asignatureCol.HeaderText = "Asignatura";
            this.asignatureCol.Name = "asignatureCol";
            // 
            // finalNoteCol
            // 
            this.finalNoteCol.HeaderText = "Nota Final";
            this.finalNoteCol.Name = "finalNoteCol";
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(172, 294);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(109, 23);
            this.saveBtn.TabIndex = 5;
            this.saveBtn.Text = "Guardar";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // cancelarBtn
            // 
            this.cancelarBtn.Location = new System.Drawing.Point(41, 294);
            this.cancelarBtn.Name = "cancelarBtn";
            this.cancelarBtn.Size = new System.Drawing.Size(110, 23);
            this.cancelarBtn.TabIndex = 6;
            this.cancelarBtn.Text = "Cancelar";
            this.cancelarBtn.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 347);
            this.Controls.Add(this.cancelarBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.notasGrid);
            this.Controls.Add(this.nameTB);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.carnetTB);
            this.Controls.Add(this.carnetLabel);
            this.Name = "Form2";
            this.Text = "Registrar Alumno";
            ((System.ComponentModel.ISupportInitialize)(this.notasGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label carnetLabel;
        private System.Windows.Forms.TextBox carnetTB;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.DataGridView notasGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn asignatureCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn finalNoteCol;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button cancelarBtn;
    }
}
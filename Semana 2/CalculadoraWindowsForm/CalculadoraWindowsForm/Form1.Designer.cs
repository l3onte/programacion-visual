namespace CalculadoraWindowsForm
{
    partial class Form1
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
            this.Display = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.BtSum = new System.Windows.Forms.Button();
            this.BtResta = new System.Windows.Forms.Button();
            this.BtMultiplicacion = new System.Windows.Forms.Button();
            this.BtDivision = new System.Windows.Forms.Button();
            this.BtMmas = new System.Windows.Forms.Button();
            this.Bt3 = new System.Windows.Forms.Button();
            this.Bt2 = new System.Windows.Forms.Button();
            this.Bt1 = new System.Windows.Forms.Button();
            this.BtMmenos = new System.Windows.Forms.Button();
            this.Bt6 = new System.Windows.Forms.Button();
            this.Bt5 = new System.Windows.Forms.Button();
            this.Bt4 = new System.Windows.Forms.Button();
            this.Bt9 = new System.Windows.Forms.Button();
            this.Bt8 = new System.Windows.Forms.Button();
            this.Bt7 = new System.Windows.Forms.Button();
            this.Bt0 = new System.Windows.Forms.Button();
            this.BtPunto = new System.Windows.Forms.Button();
            this.BtMc = new System.Windows.Forms.Button();
            this.BtLog = new System.Windows.Forms.Button();
            this.BtPi = new System.Windows.Forms.Button();
            this.BtRaizCuadrada = new System.Windows.Forms.Button();
            this.BtExponente = new System.Windows.Forms.Button();
            this.BtMr = new System.Windows.Forms.Button();
            this.BtCos = new System.Windows.Forms.Button();
            this.BtFactorial = new System.Windows.Forms.Button();
            this.BtPorcentaje = new System.Windows.Forms.Button();
            this.BtSin = new System.Windows.Forms.Button();
            this.BtIgual = new System.Windows.Forms.Button();
            this.BtBa = new System.Windows.Forms.Button();
            this.BtCe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Display
            // 
            this.Display.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Display.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Display.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Display.ForeColor = System.Drawing.Color.Black;
            this.Display.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Display.Location = new System.Drawing.Point(21, 64);
            this.Display.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Display.Name = "Display";
            this.Display.Padding = new System.Windows.Forms.Padding(8);
            this.Display.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Display.Size = new System.Drawing.Size(366, 43);
            this.Display.TabIndex = 0;
            this.Display.Text = "0";
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Bebas Neue", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(69, 15);
            this.Title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(300, 35);
            this.Title.TabIndex = 1;
            this.Title.Text = "Calculadora con Windows Form";
            // 
            // BtSum
            // 
            this.BtSum.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtSum.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrchid;
            this.BtSum.FlatAppearance.BorderSize = 0;
            this.BtSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtSum.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtSum.Location = new System.Drawing.Point(21, 118);
            this.BtSum.Margin = new System.Windows.Forms.Padding(2);
            this.BtSum.Name = "BtSum";
            this.BtSum.Size = new System.Drawing.Size(58, 54);
            this.BtSum.TabIndex = 2;
            this.BtSum.Text = "+";
            this.BtSum.UseVisualStyleBackColor = false;
            this.BtSum.Click += new System.EventHandler(this.SetOperation);
            // 
            // BtResta
            // 
            this.BtResta.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtResta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtResta.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtResta.Location = new System.Drawing.Point(83, 118);
            this.BtResta.Margin = new System.Windows.Forms.Padding(2);
            this.BtResta.Name = "BtResta";
            this.BtResta.Size = new System.Drawing.Size(58, 54);
            this.BtResta.TabIndex = 3;
            this.BtResta.Text = "-";
            this.BtResta.UseVisualStyleBackColor = false;
            this.BtResta.Click += new System.EventHandler(this.SetOperation);
            // 
            // BtMultiplicacion
            // 
            this.BtMultiplicacion.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtMultiplicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtMultiplicacion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtMultiplicacion.Location = new System.Drawing.Point(146, 118);
            this.BtMultiplicacion.Margin = new System.Windows.Forms.Padding(2);
            this.BtMultiplicacion.Name = "BtMultiplicacion";
            this.BtMultiplicacion.Size = new System.Drawing.Size(58, 54);
            this.BtMultiplicacion.TabIndex = 4;
            this.BtMultiplicacion.Text = "x";
            this.BtMultiplicacion.UseVisualStyleBackColor = false;
            this.BtMultiplicacion.Click += new System.EventHandler(this.SetOperation);
            // 
            // BtDivision
            // 
            this.BtDivision.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtDivision.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtDivision.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtDivision.Location = new System.Drawing.Point(208, 118);
            this.BtDivision.Margin = new System.Windows.Forms.Padding(2);
            this.BtDivision.Name = "BtDivision";
            this.BtDivision.Size = new System.Drawing.Size(58, 54);
            this.BtDivision.TabIndex = 5;
            this.BtDivision.Text = "/";
            this.BtDivision.UseVisualStyleBackColor = false;
            this.BtDivision.Click += new System.EventHandler(this.SetOperation);
            // 
            // BtMmas
            // 
            this.BtMmas.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtMmas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtMmas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtMmas.Location = new System.Drawing.Point(208, 176);
            this.BtMmas.Margin = new System.Windows.Forms.Padding(2);
            this.BtMmas.Name = "BtMmas";
            this.BtMmas.Size = new System.Drawing.Size(58, 54);
            this.BtMmas.TabIndex = 9;
            this.BtMmas.Text = "M+";
            this.BtMmas.UseVisualStyleBackColor = false;
            // 
            // Bt3
            // 
            this.Bt3.Location = new System.Drawing.Point(146, 176);
            this.Bt3.Margin = new System.Windows.Forms.Padding(2);
            this.Bt3.Name = "Bt3";
            this.Bt3.Size = new System.Drawing.Size(58, 54);
            this.Bt3.TabIndex = 8;
            this.Bt3.Text = "3";
            this.Bt3.UseVisualStyleBackColor = true;
            this.Bt3.Click += new System.EventHandler(this.BtNumero_Click);
            // 
            // Bt2
            // 
            this.Bt2.Location = new System.Drawing.Point(83, 176);
            this.Bt2.Margin = new System.Windows.Forms.Padding(2);
            this.Bt2.Name = "Bt2";
            this.Bt2.Size = new System.Drawing.Size(58, 54);
            this.Bt2.TabIndex = 7;
            this.Bt2.Text = "2";
            this.Bt2.UseVisualStyleBackColor = true;
            this.Bt2.Click += new System.EventHandler(this.BtNumero_Click);
            // 
            // Bt1
            // 
            this.Bt1.Location = new System.Drawing.Point(21, 176);
            this.Bt1.Margin = new System.Windows.Forms.Padding(2);
            this.Bt1.Name = "Bt1";
            this.Bt1.Size = new System.Drawing.Size(58, 54);
            this.Bt1.TabIndex = 6;
            this.Bt1.Text = "1";
            this.Bt1.UseVisualStyleBackColor = true;
            this.Bt1.Click += new System.EventHandler(this.BtNumero_Click);
            // 
            // BtMmenos
            // 
            this.BtMmenos.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtMmenos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtMmenos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtMmenos.Location = new System.Drawing.Point(208, 235);
            this.BtMmenos.Margin = new System.Windows.Forms.Padding(2);
            this.BtMmenos.Name = "BtMmenos";
            this.BtMmenos.Size = new System.Drawing.Size(58, 54);
            this.BtMmenos.TabIndex = 13;
            this.BtMmenos.Text = "M-";
            this.BtMmenos.UseVisualStyleBackColor = false;
            // 
            // Bt6
            // 
            this.Bt6.Location = new System.Drawing.Point(146, 235);
            this.Bt6.Margin = new System.Windows.Forms.Padding(2);
            this.Bt6.Name = "Bt6";
            this.Bt6.Size = new System.Drawing.Size(58, 54);
            this.Bt6.TabIndex = 12;
            this.Bt6.Text = "6";
            this.Bt6.UseVisualStyleBackColor = true;
            this.Bt6.Click += new System.EventHandler(this.BtNumero_Click);
            // 
            // Bt5
            // 
            this.Bt5.Location = new System.Drawing.Point(83, 235);
            this.Bt5.Margin = new System.Windows.Forms.Padding(2);
            this.Bt5.Name = "Bt5";
            this.Bt5.Size = new System.Drawing.Size(58, 54);
            this.Bt5.TabIndex = 11;
            this.Bt5.Text = "5";
            this.Bt5.UseVisualStyleBackColor = true;
            this.Bt5.Click += new System.EventHandler(this.BtNumero_Click);
            // 
            // Bt4
            // 
            this.Bt4.Location = new System.Drawing.Point(21, 235);
            this.Bt4.Margin = new System.Windows.Forms.Padding(2);
            this.Bt4.Name = "Bt4";
            this.Bt4.Size = new System.Drawing.Size(58, 54);
            this.Bt4.TabIndex = 10;
            this.Bt4.Text = "4";
            this.Bt4.UseVisualStyleBackColor = true;
            this.Bt4.Click += new System.EventHandler(this.BtNumero_Click);
            // 
            // Bt9
            // 
            this.Bt9.Location = new System.Drawing.Point(146, 293);
            this.Bt9.Margin = new System.Windows.Forms.Padding(2);
            this.Bt9.Name = "Bt9";
            this.Bt9.Size = new System.Drawing.Size(58, 54);
            this.Bt9.TabIndex = 16;
            this.Bt9.Text = "9";
            this.Bt9.UseVisualStyleBackColor = true;
            this.Bt9.Click += new System.EventHandler(this.BtNumero_Click);
            // 
            // Bt8
            // 
            this.Bt8.Location = new System.Drawing.Point(83, 293);
            this.Bt8.Margin = new System.Windows.Forms.Padding(2);
            this.Bt8.Name = "Bt8";
            this.Bt8.Size = new System.Drawing.Size(58, 54);
            this.Bt8.TabIndex = 15;
            this.Bt8.Text = "8";
            this.Bt8.UseVisualStyleBackColor = true;
            this.Bt8.Click += new System.EventHandler(this.BtNumero_Click);
            // 
            // Bt7
            // 
            this.Bt7.Location = new System.Drawing.Point(21, 293);
            this.Bt7.Margin = new System.Windows.Forms.Padding(2);
            this.Bt7.Name = "Bt7";
            this.Bt7.Size = new System.Drawing.Size(58, 54);
            this.Bt7.TabIndex = 14;
            this.Bt7.Text = "7";
            this.Bt7.UseVisualStyleBackColor = true;
            this.Bt7.Click += new System.EventHandler(this.BtNumero_Click);
            // 
            // Bt0
            // 
            this.Bt0.Location = new System.Drawing.Point(21, 352);
            this.Bt0.Margin = new System.Windows.Forms.Padding(2);
            this.Bt0.Name = "Bt0";
            this.Bt0.Size = new System.Drawing.Size(120, 54);
            this.Bt0.TabIndex = 17;
            this.Bt0.Text = "0";
            this.Bt0.UseVisualStyleBackColor = true;
            this.Bt0.Click += new System.EventHandler(this.BtNumero_Click);
            // 
            // BtPunto
            // 
            this.BtPunto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtPunto.Location = new System.Drawing.Point(146, 352);
            this.BtPunto.Margin = new System.Windows.Forms.Padding(2);
            this.BtPunto.Name = "BtPunto";
            this.BtPunto.Size = new System.Drawing.Size(58, 54);
            this.BtPunto.TabIndex = 18;
            this.BtPunto.Text = ".";
            this.BtPunto.UseVisualStyleBackColor = true;
            // 
            // BtMc
            // 
            this.BtMc.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtMc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtMc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtMc.Location = new System.Drawing.Point(208, 293);
            this.BtMc.Margin = new System.Windows.Forms.Padding(2);
            this.BtMc.Name = "BtMc";
            this.BtMc.Size = new System.Drawing.Size(58, 54);
            this.BtMc.TabIndex = 19;
            this.BtMc.Text = "MC";
            this.BtMc.UseVisualStyleBackColor = false;
            // 
            // BtLog
            // 
            this.BtLog.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtLog.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtLog.Location = new System.Drawing.Point(331, 118);
            this.BtLog.Margin = new System.Windows.Forms.Padding(2);
            this.BtLog.Name = "BtLog";
            this.BtLog.Size = new System.Drawing.Size(58, 54);
            this.BtLog.TabIndex = 23;
            this.BtLog.Text = "Log";
            this.BtLog.UseVisualStyleBackColor = false;
            // 
            // BtPi
            // 
            this.BtPi.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtPi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtPi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtPi.Location = new System.Drawing.Point(270, 235);
            this.BtPi.Margin = new System.Windows.Forms.Padding(2);
            this.BtPi.Name = "BtPi";
            this.BtPi.Size = new System.Drawing.Size(58, 54);
            this.BtPi.TabIndex = 22;
            this.BtPi.Text = "π";
            this.BtPi.UseVisualStyleBackColor = false;
            // 
            // BtRaizCuadrada
            // 
            this.BtRaizCuadrada.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtRaizCuadrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtRaizCuadrada.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtRaizCuadrada.Location = new System.Drawing.Point(270, 176);
            this.BtRaizCuadrada.Margin = new System.Windows.Forms.Padding(2);
            this.BtRaizCuadrada.Name = "BtRaizCuadrada";
            this.BtRaizCuadrada.Size = new System.Drawing.Size(58, 54);
            this.BtRaizCuadrada.TabIndex = 21;
            this.BtRaizCuadrada.Text = "√";
            this.BtRaizCuadrada.UseVisualStyleBackColor = false;
            // 
            // BtExponente
            // 
            this.BtExponente.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtExponente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtExponente.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtExponente.Location = new System.Drawing.Point(270, 118);
            this.BtExponente.Margin = new System.Windows.Forms.Padding(2);
            this.BtExponente.Name = "BtExponente";
            this.BtExponente.Size = new System.Drawing.Size(58, 54);
            this.BtExponente.TabIndex = 20;
            this.BtExponente.Text = "^ ";
            this.BtExponente.UseVisualStyleBackColor = false;
            // 
            // BtMr
            // 
            this.BtMr.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtMr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtMr.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtMr.Location = new System.Drawing.Point(208, 352);
            this.BtMr.Margin = new System.Windows.Forms.Padding(2);
            this.BtMr.Name = "BtMr";
            this.BtMr.Size = new System.Drawing.Size(58, 54);
            this.BtMr.TabIndex = 24;
            this.BtMr.Text = "MR";
            this.BtMr.UseVisualStyleBackColor = false;
            // 
            // BtCos
            // 
            this.BtCos.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtCos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtCos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtCos.Location = new System.Drawing.Point(331, 235);
            this.BtCos.Margin = new System.Windows.Forms.Padding(2);
            this.BtCos.Name = "BtCos";
            this.BtCos.Size = new System.Drawing.Size(58, 54);
            this.BtCos.TabIndex = 27;
            this.BtCos.Text = "cos";
            this.BtCos.UseVisualStyleBackColor = false;
            // 
            // BtFactorial
            // 
            this.BtFactorial.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtFactorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtFactorial.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtFactorial.Location = new System.Drawing.Point(270, 352);
            this.BtFactorial.Margin = new System.Windows.Forms.Padding(2);
            this.BtFactorial.Name = "BtFactorial";
            this.BtFactorial.Size = new System.Drawing.Size(58, 54);
            this.BtFactorial.TabIndex = 26;
            this.BtFactorial.Text = "!";
            this.BtFactorial.UseVisualStyleBackColor = false;
            // 
            // BtPorcentaje
            // 
            this.BtPorcentaje.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtPorcentaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtPorcentaje.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtPorcentaje.Location = new System.Drawing.Point(270, 293);
            this.BtPorcentaje.Margin = new System.Windows.Forms.Padding(2);
            this.BtPorcentaje.Name = "BtPorcentaje";
            this.BtPorcentaje.Size = new System.Drawing.Size(58, 54);
            this.BtPorcentaje.TabIndex = 25;
            this.BtPorcentaje.Text = "%";
            this.BtPorcentaje.UseVisualStyleBackColor = false;
            // 
            // BtSin
            // 
            this.BtSin.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtSin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtSin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtSin.Location = new System.Drawing.Point(332, 176);
            this.BtSin.Margin = new System.Windows.Forms.Padding(2);
            this.BtSin.Name = "BtSin";
            this.BtSin.Size = new System.Drawing.Size(58, 54);
            this.BtSin.TabIndex = 28;
            this.BtSin.Text = "sin";
            this.BtSin.UseVisualStyleBackColor = false;
            // 
            // BtIgual
            // 
            this.BtIgual.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtIgual.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtIgual.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtIgual.Location = new System.Drawing.Point(332, 293);
            this.BtIgual.Margin = new System.Windows.Forms.Padding(2);
            this.BtIgual.Name = "BtIgual";
            this.BtIgual.Size = new System.Drawing.Size(58, 112);
            this.BtIgual.TabIndex = 29;
            this.BtIgual.Text = "=";
            this.BtIgual.UseVisualStyleBackColor = false;
            this.BtIgual.Click += new System.EventHandler(this.BtIgual_Click);
            // 
            // BtBa
            // 
            this.BtBa.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtBa.ForeColor = System.Drawing.Color.White;
            this.BtBa.Location = new System.Drawing.Point(21, 410);
            this.BtBa.Margin = new System.Windows.Forms.Padding(2);
            this.BtBa.Name = "BtBa";
            this.BtBa.Size = new System.Drawing.Size(182, 54);
            this.BtBa.TabIndex = 30;
            this.BtBa.Text = "BA";
            this.BtBa.UseVisualStyleBackColor = false;
            // 
            // BtCe
            // 
            this.BtCe.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtCe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtCe.ForeColor = System.Drawing.Color.White;
            this.BtCe.Location = new System.Drawing.Point(208, 410);
            this.BtCe.Margin = new System.Windows.Forms.Padding(2);
            this.BtCe.Name = "BtCe";
            this.BtCe.Size = new System.Drawing.Size(182, 54);
            this.BtCe.TabIndex = 31;
            this.BtCe.Text = "CE";
            this.BtCe.UseVisualStyleBackColor = false;
            this.BtCe.Click += new System.EventHandler(this.BtCe_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 476);
            this.Controls.Add(this.BtCe);
            this.Controls.Add(this.BtBa);
            this.Controls.Add(this.BtIgual);
            this.Controls.Add(this.BtSin);
            this.Controls.Add(this.BtCos);
            this.Controls.Add(this.BtFactorial);
            this.Controls.Add(this.BtPorcentaje);
            this.Controls.Add(this.BtMr);
            this.Controls.Add(this.BtLog);
            this.Controls.Add(this.BtPi);
            this.Controls.Add(this.BtRaizCuadrada);
            this.Controls.Add(this.BtExponente);
            this.Controls.Add(this.BtMc);
            this.Controls.Add(this.BtPunto);
            this.Controls.Add(this.Bt0);
            this.Controls.Add(this.Bt9);
            this.Controls.Add(this.Bt8);
            this.Controls.Add(this.Bt7);
            this.Controls.Add(this.BtMmenos);
            this.Controls.Add(this.Bt6);
            this.Controls.Add(this.Bt5);
            this.Controls.Add(this.Bt4);
            this.Controls.Add(this.BtMmas);
            this.Controls.Add(this.Bt3);
            this.Controls.Add(this.Bt2);
            this.Controls.Add(this.Bt1);
            this.Controls.Add(this.BtDivision);
            this.Controls.Add(this.BtMultiplicacion);
            this.Controls.Add(this.BtResta);
            this.Controls.Add(this.BtSum);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.Display);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Calculadora con Windows Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Display;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button BtSum;
        private System.Windows.Forms.Button BtResta;
        private System.Windows.Forms.Button BtMultiplicacion;
        private System.Windows.Forms.Button BtDivision;
        private System.Windows.Forms.Button BtMmas;
        private System.Windows.Forms.Button Bt3;
        private System.Windows.Forms.Button Bt2;
        private System.Windows.Forms.Button Bt1;
        private System.Windows.Forms.Button BtMmenos;
        private System.Windows.Forms.Button Bt6;
        private System.Windows.Forms.Button Bt5;
        private System.Windows.Forms.Button Bt4;
        private System.Windows.Forms.Button Bt9;
        private System.Windows.Forms.Button Bt8;
        private System.Windows.Forms.Button Bt7;
        private System.Windows.Forms.Button Bt0;
        private System.Windows.Forms.Button BtPunto;
        private System.Windows.Forms.Button BtMc;
        private System.Windows.Forms.Button BtLog;
        private System.Windows.Forms.Button BtPi;
        private System.Windows.Forms.Button BtRaizCuadrada;
        private System.Windows.Forms.Button BtExponente;
        private System.Windows.Forms.Button BtMr;
        private System.Windows.Forms.Button BtCos;
        private System.Windows.Forms.Button BtFactorial;
        private System.Windows.Forms.Button BtPorcentaje;
        private System.Windows.Forms.Button BtSin;
        private System.Windows.Forms.Button BtIgual;
        private System.Windows.Forms.Button BtBa;
        private System.Windows.Forms.Button BtCe;
    }
}


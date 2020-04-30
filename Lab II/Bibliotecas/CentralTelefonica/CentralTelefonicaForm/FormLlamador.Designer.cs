namespace CentralTelefonicaForm
{
    partial class FormLlamador
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
            this.cmbFranja = new System.Windows.Forms.ComboBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtNroOrigen = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnLlamar = new System.Windows.Forms.Button();
            this.txtNroDestino = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gpBoxNum = new System.Windows.Forms.GroupBox();
            this.btnNumeral = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnAsterisc = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.gpBoxNum.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbFranja
            // 
            this.cmbFranja.Enabled = false;
            this.cmbFranja.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFranja.FormattingEnabled = true;
            this.cmbFranja.Items.AddRange(new object[] {
            "Franja_1",
            "Franja_2",
            "Franja_3"});
            this.cmbFranja.Location = new System.Drawing.Point(12, 309);
            this.cmbFranja.Name = "cmbFranja";
            this.cmbFranja.Size = new System.Drawing.Size(399, 33);
            this.cmbFranja.TabIndex = 35;
            this.cmbFranja.Text = "Franja";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(226, 243);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(185, 47);
            this.btnSalir.TabIndex = 34;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtNroOrigen
            // 
            this.txtNroOrigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNroOrigen.Location = new System.Drawing.Point(226, 196);
            this.txtNroOrigen.Name = "txtNroOrigen";
            this.txtNroOrigen.Size = new System.Drawing.Size(185, 31);
            this.txtNroOrigen.TabIndex = 33;
            this.txtNroOrigen.Text = "Nro Origen";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(226, 136);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(185, 47);
            this.btnLimpiar.TabIndex = 32;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnLlamar
            // 
            this.btnLlamar.Location = new System.Drawing.Point(226, 83);
            this.btnLlamar.Name = "btnLlamar";
            this.btnLlamar.Size = new System.Drawing.Size(185, 47);
            this.btnLlamar.TabIndex = 31;
            this.btnLlamar.Text = "Llamar";
            this.btnLlamar.UseVisualStyleBackColor = true;
            this.btnLlamar.Click += new System.EventHandler(this.btnLlamar_Click);
            // 
            // txtNroDestino
            // 
            this.txtNroDestino.Enabled = false;
            this.txtNroDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNroDestino.Location = new System.Drawing.Point(12, 12);
            this.txtNroDestino.Name = "txtNroDestino";
            this.txtNroDestino.Size = new System.Drawing.Size(399, 35);
            this.txtNroDestino.TabIndex = 18;
            this.txtNroDestino.Text = "Nro Destino";
            this.txtNroDestino.TextChanged += new System.EventHandler(this.txtNroDestino_TextChanged);
            // 
            // gpBoxNum
            // 
            this.gpBoxNum.Controls.Add(this.btnNumeral);
            this.gpBoxNum.Controls.Add(this.btn0);
            this.gpBoxNum.Controls.Add(this.btnAsterisc);
            this.gpBoxNum.Controls.Add(this.btn9);
            this.gpBoxNum.Controls.Add(this.btn8);
            this.gpBoxNum.Controls.Add(this.btn7);
            this.gpBoxNum.Controls.Add(this.btn6);
            this.gpBoxNum.Controls.Add(this.btn5);
            this.gpBoxNum.Controls.Add(this.btn4);
            this.gpBoxNum.Controls.Add(this.btn3);
            this.gpBoxNum.Controls.Add(this.btn2);
            this.gpBoxNum.Controls.Add(this.btn1);
            this.gpBoxNum.Location = new System.Drawing.Point(13, 64);
            this.gpBoxNum.Name = "gpBoxNum";
            this.gpBoxNum.Size = new System.Drawing.Size(207, 239);
            this.gpBoxNum.TabIndex = 36;
            this.gpBoxNum.TabStop = false;
            this.gpBoxNum.Text = "Panel";
            // 
            // btnNumeral
            // 
            this.btnNumeral.Location = new System.Drawing.Point(140, 179);
            this.btnNumeral.Name = "btnNumeral";
            this.btnNumeral.Size = new System.Drawing.Size(50, 47);
            this.btnNumeral.TabIndex = 42;
            this.btnNumeral.Text = "#";
            this.btnNumeral.UseVisualStyleBackColor = true;
            this.btnNumeral.Click += new System.EventHandler(this.btnNumeral_Click);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(75, 179);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(50, 47);
            this.btn0.TabIndex = 41;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btnAsterisc
            // 
            this.btnAsterisc.Location = new System.Drawing.Point(13, 179);
            this.btnAsterisc.Name = "btnAsterisc";
            this.btnAsterisc.Size = new System.Drawing.Size(50, 47);
            this.btnAsterisc.TabIndex = 40;
            this.btnAsterisc.Text = "*";
            this.btnAsterisc.UseVisualStyleBackColor = true;
            this.btnAsterisc.Click += new System.EventHandler(this.btnAsterisc_Click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(140, 126);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(50, 47);
            this.btn9.TabIndex = 39;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(75, 126);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(50, 47);
            this.btn8.TabIndex = 38;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(13, 126);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(50, 47);
            this.btn7.TabIndex = 37;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(140, 72);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(50, 47);
            this.btn6.TabIndex = 36;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(75, 72);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(50, 47);
            this.btn5.TabIndex = 35;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(13, 72);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(50, 47);
            this.btn4.TabIndex = 34;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(140, 19);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(50, 47);
            this.btn3.TabIndex = 33;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(75, 19);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(50, 47);
            this.btn2.TabIndex = 32;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(13, 19);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(50, 47);
            this.btn1.TabIndex = 31;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // FormLlamador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 359);
            this.Controls.Add(this.gpBoxNum);
            this.Controls.Add(this.cmbFranja);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.txtNroOrigen);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnLlamar);
            this.Controls.Add(this.txtNroDestino);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLlamador";
            this.Text = "Llamador";
            this.gpBoxNum.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbFranja;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtNroOrigen;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnLlamar;
        private System.Windows.Forms.TextBox txtNroDestino;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox gpBoxNum;
        private System.Windows.Forms.Button btnNumeral;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnAsterisc;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
    }
}
namespace Ejercicio_25
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
            this.lblBinario = new System.Windows.Forms.Label();
            this.lblDecimal = new System.Windows.Forms.Label();
            this.txtBinarioToDecimal = new System.Windows.Forms.TextBox();
            this.txtDecimalToBinario = new System.Windows.Forms.TextBox();
            this.btnConvertBinary = new System.Windows.Forms.Button();
            this.btnConvertDecimal = new System.Windows.Forms.Button();
            this.txtConvertedToDecimal = new System.Windows.Forms.TextBox();
            this.txtConvertedToBinary = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblBinario
            // 
            this.lblBinario.AutoSize = true;
            this.lblBinario.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBinario.Location = new System.Drawing.Point(12, 22);
            this.lblBinario.Name = "lblBinario";
            this.lblBinario.Size = new System.Drawing.Size(190, 28);
            this.lblBinario.TabIndex = 0;
            this.lblBinario.Text = "Binario a Decimal";
            // 
            // lblDecimal
            // 
            this.lblDecimal.AutoSize = true;
            this.lblDecimal.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDecimal.Location = new System.Drawing.Point(12, 84);
            this.lblDecimal.Name = "lblDecimal";
            this.lblDecimal.Size = new System.Drawing.Size(190, 28);
            this.lblDecimal.TabIndex = 1;
            this.lblDecimal.Text = "Decimal a Binario";
            // 
            // txtBinarioToDecimal
            // 
            this.txtBinarioToDecimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBinarioToDecimal.Location = new System.Drawing.Point(231, 22);
            this.txtBinarioToDecimal.Name = "txtBinarioToDecimal";
            this.txtBinarioToDecimal.Size = new System.Drawing.Size(171, 31);
            this.txtBinarioToDecimal.TabIndex = 2;
            this.txtBinarioToDecimal.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtDecimalToBinario
            // 
            this.txtDecimalToBinario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDecimalToBinario.Location = new System.Drawing.Point(231, 81);
            this.txtDecimalToBinario.Name = "txtDecimalToBinario";
            this.txtDecimalToBinario.Size = new System.Drawing.Size(171, 31);
            this.txtDecimalToBinario.TabIndex = 3;
            // 
            // btnConvertBinary
            // 
            this.btnConvertBinary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvertBinary.Location = new System.Drawing.Point(448, 22);
            this.btnConvertBinary.Name = "btnConvertBinary";
            this.btnConvertBinary.Size = new System.Drawing.Size(84, 31);
            this.btnConvertBinary.TabIndex = 4;
            this.btnConvertBinary.Text = "-->";
            this.btnConvertBinary.UseVisualStyleBackColor = true;
            this.btnConvertBinary.Click += new System.EventHandler(this.btnConvertBinary_Click);
            // 
            // btnConvertDecimal
            // 
            this.btnConvertDecimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvertDecimal.Location = new System.Drawing.Point(448, 81);
            this.btnConvertDecimal.Name = "btnConvertDecimal";
            this.btnConvertDecimal.Size = new System.Drawing.Size(84, 31);
            this.btnConvertDecimal.TabIndex = 5;
            this.btnConvertDecimal.Text = "-->";
            this.btnConvertDecimal.UseVisualStyleBackColor = true;
            this.btnConvertDecimal.Click += new System.EventHandler(this.btnConvertDecimal_Click);
            // 
            // txtConvertedToDecimal
            // 
            this.txtConvertedToDecimal.Enabled = false;
            this.txtConvertedToDecimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConvertedToDecimal.Location = new System.Drawing.Point(572, 22);
            this.txtConvertedToDecimal.Name = "txtConvertedToDecimal";
            this.txtConvertedToDecimal.Size = new System.Drawing.Size(175, 31);
            this.txtConvertedToDecimal.TabIndex = 6;
            // 
            // txtConvertedToBinary
            // 
            this.txtConvertedToBinary.Enabled = false;
            this.txtConvertedToBinary.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConvertedToBinary.Location = new System.Drawing.Point(572, 81);
            this.txtConvertedToBinary.Name = "txtConvertedToBinary";
            this.txtConvertedToBinary.Size = new System.Drawing.Size(278, 31);
            this.txtConvertedToBinary.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 126);
            this.Controls.Add(this.txtConvertedToBinary);
            this.Controls.Add(this.txtConvertedToDecimal);
            this.Controls.Add(this.btnConvertDecimal);
            this.Controls.Add(this.btnConvertBinary);
            this.Controls.Add(this.txtDecimalToBinario);
            this.Controls.Add(this.txtBinarioToDecimal);
            this.Controls.Add(this.lblDecimal);
            this.Controls.Add(this.lblBinario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBinario;
        private System.Windows.Forms.Label lblDecimal;
        private System.Windows.Forms.TextBox txtBinarioToDecimal;
        private System.Windows.Forms.TextBox txtDecimalToBinario;
        private System.Windows.Forms.Button btnConvertBinary;
        private System.Windows.Forms.Button btnConvertDecimal;
        private System.Windows.Forms.TextBox txtConvertedToDecimal;
        private System.Windows.Forms.TextBox txtConvertedToBinary;
    }
}


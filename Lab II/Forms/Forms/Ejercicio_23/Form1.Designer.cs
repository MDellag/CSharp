namespace Ejercicio_23
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblDolarA = new System.Windows.Forms.Label();
            this.btnCotizacion = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.txtCotizDolar = new System.Windows.Forms.TextBox();
            this.txtCotizEuro = new System.Windows.Forms.TextBox();
            this.txtCotizPeso = new System.Windows.Forms.TextBox();
            this.lblEuroA = new System.Windows.Forms.Label();
            this.lblPesoA = new System.Windows.Forms.Label();
            this.lblDolar = new System.Windows.Forms.Label();
            this.lblEuro = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.txtDolarAmmount = new System.Windows.Forms.TextBox();
            this.txtEuroAmmount = new System.Windows.Forms.TextBox();
            this.txtPesoAmmount = new System.Windows.Forms.TextBox();
            this.btnConvDolar = new System.Windows.Forms.Button();
            this.btnConvEuro = new System.Windows.Forms.Button();
            this.btnConvPeso = new System.Windows.Forms.Button();
            this.txtDolarToDolar = new System.Windows.Forms.TextBox();
            this.txtDolarToEuro = new System.Windows.Forms.TextBox();
            this.txtDolarToPeso = new System.Windows.Forms.TextBox();
            this.txtEuroToDolar = new System.Windows.Forms.TextBox();
            this.txtEuroToEuro = new System.Windows.Forms.TextBox();
            this.txtEuroToPeso = new System.Windows.Forms.TextBox();
            this.txtPesoToDolar = new System.Windows.Forms.TextBox();
            this.txtPesoToEuro = new System.Windows.Forms.TextBox();
            this.txtPesoToPeso = new System.Windows.Forms.TextBox();
            this.lblCotizacion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDolarA
            // 
            this.lblDolarA.AutoSize = true;
            this.lblDolarA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDolarA.Location = new System.Drawing.Point(414, 69);
            this.lblDolarA.Name = "lblDolarA";
            this.lblDolarA.Size = new System.Drawing.Size(59, 24);
            this.lblDolarA.TabIndex = 0;
            this.lblDolarA.Text = "Dolar";
            // 
            // btnCotizacion
            // 
            this.btnCotizacion.BackColor = System.Drawing.Color.White;
            this.btnCotizacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCotizacion.ImageIndex = 1;
            this.btnCotizacion.ImageList = this.imageList1;
            this.btnCotizacion.Location = new System.Drawing.Point(279, 28);
            this.btnCotizacion.Name = "btnCotizacion";
            this.btnCotizacion.Size = new System.Drawing.Size(75, 31);
            this.btnCotizacion.TabIndex = 1;
            this.btnCotizacion.UseVisualStyleBackColor = false;
            this.btnCotizacion.Click += new System.EventHandler(this.btnCotizacion_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "icons8_padlock_24px.png");
            this.imageList1.Images.SetKeyName(1, "icons8_lock_24px.png");
            // 
            // txtCotizDolar
            // 
            this.txtCotizDolar.Location = new System.Drawing.Point(392, 28);
            this.txtCotizDolar.Name = "txtCotizDolar";
            this.txtCotizDolar.Size = new System.Drawing.Size(100, 20);
            this.txtCotizDolar.TabIndex = 2;
            // 
            // txtCotizEuro
            // 
            this.txtCotizEuro.Location = new System.Drawing.Point(541, 28);
            this.txtCotizEuro.Name = "txtCotizEuro";
            this.txtCotizEuro.Size = new System.Drawing.Size(100, 20);
            this.txtCotizEuro.TabIndex = 3;
            // 
            // txtCotizPeso
            // 
            this.txtCotizPeso.Location = new System.Drawing.Point(696, 28);
            this.txtCotizPeso.Name = "txtCotizPeso";
            this.txtCotizPeso.Size = new System.Drawing.Size(100, 20);
            this.txtCotizPeso.TabIndex = 4;
            // 
            // lblEuroA
            // 
            this.lblEuroA.AutoSize = true;
            this.lblEuroA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEuroA.Location = new System.Drawing.Point(562, 69);
            this.lblEuroA.Name = "lblEuroA";
            this.lblEuroA.Size = new System.Drawing.Size(55, 24);
            this.lblEuroA.TabIndex = 5;
            this.lblEuroA.Text = "Euro";
            // 
            // lblPesoA
            // 
            this.lblPesoA.AutoSize = true;
            this.lblPesoA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesoA.Location = new System.Drawing.Point(720, 69);
            this.lblPesoA.Name = "lblPesoA";
            this.lblPesoA.Size = new System.Drawing.Size(57, 24);
            this.lblPesoA.TabIndex = 6;
            this.lblPesoA.Text = "Peso";
            // 
            // lblDolar
            // 
            this.lblDolar.AutoSize = true;
            this.lblDolar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDolar.Location = new System.Drawing.Point(31, 131);
            this.lblDolar.Name = "lblDolar";
            this.lblDolar.Size = new System.Drawing.Size(59, 24);
            this.lblDolar.TabIndex = 7;
            this.lblDolar.Text = "Dolar";
            // 
            // lblEuro
            // 
            this.lblEuro.AutoSize = true;
            this.lblEuro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEuro.Location = new System.Drawing.Point(31, 188);
            this.lblEuro.Name = "lblEuro";
            this.lblEuro.Size = new System.Drawing.Size(55, 24);
            this.lblEuro.TabIndex = 8;
            this.lblEuro.Text = "Euro";
            this.lblEuro.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeso.Location = new System.Drawing.Point(31, 244);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(57, 24);
            this.lblPeso.TabIndex = 9;
            this.lblPeso.Text = "Peso";
            // 
            // txtDolarAmmount
            // 
            this.txtDolarAmmount.Location = new System.Drawing.Point(131, 135);
            this.txtDolarAmmount.Name = "txtDolarAmmount";
            this.txtDolarAmmount.Size = new System.Drawing.Size(100, 20);
            this.txtDolarAmmount.TabIndex = 10;
            this.txtDolarAmmount.TextChanged += new System.EventHandler(this.txtDolarAmmount_TextChanged);
            
            // 
            // txtEuroAmmount
            // 
            this.txtEuroAmmount.Location = new System.Drawing.Point(131, 193);
            this.txtEuroAmmount.Name = "txtEuroAmmount";
            this.txtEuroAmmount.Size = new System.Drawing.Size(100, 20);
            this.txtEuroAmmount.TabIndex = 11;
            // 
            // txtPesoAmmount
            // 
            this.txtPesoAmmount.Location = new System.Drawing.Point(131, 248);
            this.txtPesoAmmount.Name = "txtPesoAmmount";
            this.txtPesoAmmount.Size = new System.Drawing.Size(100, 20);
            this.txtPesoAmmount.TabIndex = 12;
            // 
            // btnConvDolar
            // 
            this.btnConvDolar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvDolar.Location = new System.Drawing.Point(279, 132);
            this.btnConvDolar.Name = "btnConvDolar";
            this.btnConvDolar.Size = new System.Drawing.Size(75, 23);
            this.btnConvDolar.TabIndex = 13;
            this.btnConvDolar.Text = "-->";
            this.btnConvDolar.UseVisualStyleBackColor = true;
            this.btnConvDolar.Click += new System.EventHandler(this.btnConvDolar_Click);
            // 
            // btnConvEuro
            // 
            this.btnConvEuro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvEuro.Location = new System.Drawing.Point(279, 191);
            this.btnConvEuro.Name = "btnConvEuro";
            this.btnConvEuro.Size = new System.Drawing.Size(75, 23);
            this.btnConvEuro.TabIndex = 14;
            this.btnConvEuro.Text = "-->";
            this.btnConvEuro.UseVisualStyleBackColor = true;
            this.btnConvEuro.Click += new System.EventHandler(this.btnConvEuro_Click);
            // 
            // btnConvPeso
            // 
            this.btnConvPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvPeso.Location = new System.Drawing.Point(279, 245);
            this.btnConvPeso.Name = "btnConvPeso";
            this.btnConvPeso.Size = new System.Drawing.Size(75, 23);
            this.btnConvPeso.TabIndex = 15;
            this.btnConvPeso.Text = "-->";
            this.btnConvPeso.UseVisualStyleBackColor = true;
            this.btnConvPeso.Click += new System.EventHandler(this.btnConvPeso_Click);
            // 
            // txtDolarToDolar
            // 
            this.txtDolarToDolar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDolarToDolar.Enabled = false;
            this.txtDolarToDolar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDolarToDolar.Location = new System.Drawing.Point(392, 135);
            this.txtDolarToDolar.Name = "txtDolarToDolar";
            this.txtDolarToDolar.Size = new System.Drawing.Size(100, 17);
            this.txtDolarToDolar.TabIndex = 16;
            this.txtDolarToDolar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDolarToEuro
            // 
            this.txtDolarToEuro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDolarToEuro.Enabled = false;
            this.txtDolarToEuro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDolarToEuro.Location = new System.Drawing.Point(541, 136);
            this.txtDolarToEuro.Name = "txtDolarToEuro";
            this.txtDolarToEuro.Size = new System.Drawing.Size(100, 17);
            this.txtDolarToEuro.TabIndex = 17;
            this.txtDolarToEuro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDolarToEuro.TextChanged += new System.EventHandler(this.txtDolarToEuro_TextChanged);
            // 
            // txtDolarToPeso
            // 
            this.txtDolarToPeso.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDolarToPeso.Enabled = false;
            this.txtDolarToPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDolarToPeso.Location = new System.Drawing.Point(696, 136);
            this.txtDolarToPeso.Name = "txtDolarToPeso";
            this.txtDolarToPeso.Size = new System.Drawing.Size(100, 17);
            this.txtDolarToPeso.TabIndex = 18;
            this.txtDolarToPeso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtEuroToDolar
            // 
            this.txtEuroToDolar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEuroToDolar.Enabled = false;
            this.txtEuroToDolar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEuroToDolar.Location = new System.Drawing.Point(392, 193);
            this.txtEuroToDolar.Name = "txtEuroToDolar";
            this.txtEuroToDolar.Size = new System.Drawing.Size(100, 17);
            this.txtEuroToDolar.TabIndex = 19;
            this.txtEuroToDolar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtEuroToEuro
            // 
            this.txtEuroToEuro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEuroToEuro.Enabled = false;
            this.txtEuroToEuro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEuroToEuro.Location = new System.Drawing.Point(541, 193);
            this.txtEuroToEuro.Name = "txtEuroToEuro";
            this.txtEuroToEuro.Size = new System.Drawing.Size(100, 17);
            this.txtEuroToEuro.TabIndex = 20;
            this.txtEuroToEuro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtEuroToPeso
            // 
            this.txtEuroToPeso.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEuroToPeso.Enabled = false;
            this.txtEuroToPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEuroToPeso.Location = new System.Drawing.Point(696, 193);
            this.txtEuroToPeso.Name = "txtEuroToPeso";
            this.txtEuroToPeso.Size = new System.Drawing.Size(100, 17);
            this.txtEuroToPeso.TabIndex = 21;
            this.txtEuroToPeso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPesoToDolar
            // 
            this.txtPesoToDolar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPesoToDolar.Enabled = false;
            this.txtPesoToDolar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesoToDolar.Location = new System.Drawing.Point(392, 247);
            this.txtPesoToDolar.Name = "txtPesoToDolar";
            this.txtPesoToDolar.Size = new System.Drawing.Size(100, 17);
            this.txtPesoToDolar.TabIndex = 22;
            this.txtPesoToDolar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPesoToEuro
            // 
            this.txtPesoToEuro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPesoToEuro.Enabled = false;
            this.txtPesoToEuro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesoToEuro.Location = new System.Drawing.Point(541, 247);
            this.txtPesoToEuro.Name = "txtPesoToEuro";
            this.txtPesoToEuro.Size = new System.Drawing.Size(100, 17);
            this.txtPesoToEuro.TabIndex = 23;
            this.txtPesoToEuro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPesoToPeso
            // 
            this.txtPesoToPeso.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPesoToPeso.Enabled = false;
            this.txtPesoToPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesoToPeso.Location = new System.Drawing.Point(696, 248);
            this.txtPesoToPeso.Name = "txtPesoToPeso";
            this.txtPesoToPeso.Size = new System.Drawing.Size(100, 17);
            this.txtPesoToPeso.TabIndex = 24;
            this.txtPesoToPeso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCotizacion
            // 
            this.lblCotizacion.AutoSize = true;
            this.lblCotizacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCotizacion.Location = new System.Drawing.Point(127, 30);
            this.lblCotizacion.Name = "lblCotizacion";
            this.lblCotizacion.Size = new System.Drawing.Size(107, 24);
            this.lblCotizacion.TabIndex = 25;
            this.lblCotizacion.Text = "Cotizacion";
            this.lblCotizacion.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 299);
            this.Controls.Add(this.lblCotizacion);
            this.Controls.Add(this.txtPesoToPeso);
            this.Controls.Add(this.txtPesoToEuro);
            this.Controls.Add(this.txtPesoToDolar);
            this.Controls.Add(this.txtEuroToPeso);
            this.Controls.Add(this.txtEuroToEuro);
            this.Controls.Add(this.txtEuroToDolar);
            this.Controls.Add(this.txtDolarToPeso);
            this.Controls.Add(this.txtDolarToEuro);
            this.Controls.Add(this.txtDolarToDolar);
            this.Controls.Add(this.btnConvPeso);
            this.Controls.Add(this.btnConvEuro);
            this.Controls.Add(this.btnConvDolar);
            this.Controls.Add(this.txtPesoAmmount);
            this.Controls.Add(this.txtEuroAmmount);
            this.Controls.Add(this.txtDolarAmmount);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.lblEuro);
            this.Controls.Add(this.lblDolar);
            this.Controls.Add(this.lblPesoA);
            this.Controls.Add(this.lblEuroA);
            this.Controls.Add(this.txtCotizPeso);
            this.Controls.Add(this.txtCotizEuro);
            this.Controls.Add(this.txtCotizDolar);
            this.Controls.Add(this.btnCotizacion);
            this.Controls.Add(this.lblDolarA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Convertidor de Moneda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDolarA;
        private System.Windows.Forms.Button btnCotizacion;
        private System.Windows.Forms.TextBox txtCotizDolar;
        private System.Windows.Forms.TextBox txtCotizEuro;
        private System.Windows.Forms.TextBox txtCotizPeso;
        private System.Windows.Forms.Label lblEuroA;
        private System.Windows.Forms.Label lblPesoA;
        private System.Windows.Forms.Label lblDolar;
        private System.Windows.Forms.Label lblEuro;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.TextBox txtDolarAmmount;
        private System.Windows.Forms.TextBox txtEuroAmmount;
        private System.Windows.Forms.TextBox txtPesoAmmount;
        private System.Windows.Forms.Button btnConvDolar;
        private System.Windows.Forms.Button btnConvEuro;
        private System.Windows.Forms.Button btnConvPeso;
        private System.Windows.Forms.TextBox txtDolarToDolar;
        private System.Windows.Forms.TextBox txtDolarToEuro;
        private System.Windows.Forms.TextBox txtDolarToPeso;
        private System.Windows.Forms.TextBox txtEuroToDolar;
        private System.Windows.Forms.TextBox txtEuroToEuro;
        private System.Windows.Forms.TextBox txtEuroToPeso;
        private System.Windows.Forms.TextBox txtPesoToDolar;
        private System.Windows.Forms.TextBox txtPesoToEuro;
        private System.Windows.Forms.TextBox txtPesoToPeso;
        private System.Windows.Forms.Label lblCotizacion;
        private System.Windows.Forms.ImageList imageList1;
    }
}


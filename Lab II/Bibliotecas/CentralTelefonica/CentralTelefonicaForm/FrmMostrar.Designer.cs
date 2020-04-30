namespace CentralTelefonicaForm
{
    partial class FrmMostrar
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
            this.rchTxtMostrar = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rchTxtMostrar
            // 
            this.rchTxtMostrar.Enabled = false;
            this.rchTxtMostrar.Location = new System.Drawing.Point(12, 12);
            this.rchTxtMostrar.Name = "rchTxtMostrar";
            this.rchTxtMostrar.Size = new System.Drawing.Size(665, 430);
            this.rchTxtMostrar.TabIndex = 0;
            this.rchTxtMostrar.Text = "";
            this.rchTxtMostrar.TextChanged += new System.EventHandler(this.rchTxtMostrar_TextChanged);
            // 
            // FrmMostrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 506);
            this.Controls.Add(this.rchTxtMostrar);
            this.Name = "FrmMostrar";
            this.Text = "Facturacion";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rchTxtMostrar;
    }
}
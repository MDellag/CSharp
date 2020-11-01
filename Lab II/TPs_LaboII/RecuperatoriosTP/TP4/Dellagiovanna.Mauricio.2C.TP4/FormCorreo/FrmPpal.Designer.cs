namespace FormCorreo
{
    partial class FrmPpal
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
            this.btnMostrarTodos = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.gboxEstadosPaquete = new System.Windows.Forms.GroupBox();
            this.listboxEntregado = new System.Windows.Forms.ListBox();
            this.lblIngresado = new System.Windows.Forms.Label();
            this.lblEnViaje = new System.Windows.Forms.Label();
            this.lblEntregado = new System.Windows.Forms.Label();
            this.listboxEnViaje = new System.Windows.Forms.ListBox();
            this.listboxIngresado = new System.Windows.Forms.ListBox();
            this.gboxPaquete = new System.Windows.Forms.GroupBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.mtxtTrackId = new System.Windows.Forms.MaskedTextBox();
            this.lblTrackId = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.rtbMostrar = new System.Windows.Forms.RichTextBox();
            this.cmsMostrar = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mostrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gboxEstadosPaquete.SuspendLayout();
            this.gboxPaquete.SuspendLayout();
            this.cmsMostrar.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMostrarTodos
            // 
            this.btnMostrarTodos.Location = new System.Drawing.Point(154, 80);
            this.btnMostrarTodos.Name = "btnMostrarTodos";
            this.btnMostrarTodos.Size = new System.Drawing.Size(107, 33);
            this.btnMostrarTodos.TabIndex = 0;
            this.btnMostrarTodos.Text = "Mostrar Todos";
            this.btnMostrarTodos.UseVisualStyleBackColor = true;
            this.btnMostrarTodos.Click += new System.EventHandler(this.btnMostrarTodos_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(154, 29);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(107, 33);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // gboxEstadosPaquete
            // 
            this.gboxEstadosPaquete.BackColor = System.Drawing.Color.Transparent;
            this.gboxEstadosPaquete.Controls.Add(this.listboxEntregado);
            this.gboxEstadosPaquete.Controls.Add(this.lblIngresado);
            this.gboxEstadosPaquete.Controls.Add(this.lblEnViaje);
            this.gboxEstadosPaquete.Controls.Add(this.lblEntregado);
            this.gboxEstadosPaquete.Controls.Add(this.listboxEnViaje);
            this.gboxEstadosPaquete.Controls.Add(this.listboxIngresado);
            this.gboxEstadosPaquete.Location = new System.Drawing.Point(12, 27);
            this.gboxEstadosPaquete.Name = "gboxEstadosPaquete";
            this.gboxEstadosPaquete.Size = new System.Drawing.Size(721, 262);
            this.gboxEstadosPaquete.TabIndex = 3;
            this.gboxEstadosPaquete.TabStop = false;
            this.gboxEstadosPaquete.Text = "Estados Paquete";
            // 
            // listboxEntregado
            // 
            this.listboxEntregado.ContextMenuStrip = this.cmsMostrar;
            this.listboxEntregado.FormattingEnabled = true;
            this.listboxEntregado.Location = new System.Drawing.Point(499, 46);
            this.listboxEntregado.Name = "listboxEntregado";
            this.listboxEntregado.Size = new System.Drawing.Size(188, 212);
            this.listboxEntregado.TabIndex = 12;
            // 
            // lblIngresado
            // 
            this.lblIngresado.AutoSize = true;
            this.lblIngresado.BackColor = System.Drawing.Color.Transparent;
            this.lblIngresado.Location = new System.Drawing.Point(67, 21);
            this.lblIngresado.Name = "lblIngresado";
            this.lblIngresado.Size = new System.Drawing.Size(54, 13);
            this.lblIngresado.TabIndex = 5;
            this.lblIngresado.Text = "Ingresado";
            // 
            // lblEnViaje
            // 
            this.lblEnViaje.AutoSize = true;
            this.lblEnViaje.Location = new System.Drawing.Point(309, 21);
            this.lblEnViaje.Name = "lblEnViaje";
            this.lblEnViaje.Size = new System.Drawing.Size(46, 13);
            this.lblEnViaje.TabIndex = 6;
            this.lblEnViaje.Text = "En Viaje";
            // 
            // lblEntregado
            // 
            this.lblEntregado.AutoSize = true;
            this.lblEntregado.Location = new System.Drawing.Point(578, 21);
            this.lblEntregado.Name = "lblEntregado";
            this.lblEntregado.Size = new System.Drawing.Size(56, 13);
            this.lblEntregado.TabIndex = 7;
            this.lblEntregado.Text = "Entregado";
            // 
            // listboxEnViaje
            // 
            this.listboxEnViaje.FormattingEnabled = true;
            this.listboxEnViaje.Location = new System.Drawing.Point(256, 46);
            this.listboxEnViaje.Name = "listboxEnViaje";
            this.listboxEnViaje.Size = new System.Drawing.Size(188, 212);
            this.listboxEnViaje.TabIndex = 11;
            // 
            // listboxIngresado
            // 
            this.listboxIngresado.FormattingEnabled = true;
            this.listboxIngresado.Location = new System.Drawing.Point(22, 46);
            this.listboxIngresado.Name = "listboxIngresado";
            this.listboxIngresado.Size = new System.Drawing.Size(188, 212);
            this.listboxIngresado.TabIndex = 10;
            // 
            // gboxPaquete
            // 
            this.gboxPaquete.BackColor = System.Drawing.Color.Transparent;
            this.gboxPaquete.Controls.Add(this.txtDireccion);
            this.gboxPaquete.Controls.Add(this.mtxtTrackId);
            this.gboxPaquete.Controls.Add(this.lblTrackId);
            this.gboxPaquete.Controls.Add(this.lblDireccion);
            this.gboxPaquete.Controls.Add(this.btnMostrarTodos);
            this.gboxPaquete.Controls.Add(this.btnAgregar);
            this.gboxPaquete.Location = new System.Drawing.Point(462, 307);
            this.gboxPaquete.Name = "gboxPaquete";
            this.gboxPaquete.Size = new System.Drawing.Size(271, 131);
            this.gboxPaquete.TabIndex = 4;
            this.gboxPaquete.TabStop = false;
            this.gboxPaquete.Text = "Paquete";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(6, 96);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(129, 20);
            this.txtDireccion.TabIndex = 15;
            // 
            // mtxtTrackId
            // 
            this.mtxtTrackId.Location = new System.Drawing.Point(6, 42);
            this.mtxtTrackId.Name = "mtxtTrackId";
            this.mtxtTrackId.Size = new System.Drawing.Size(129, 20);
            this.mtxtTrackId.TabIndex = 14;
            this.mtxtTrackId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTrackId
            // 
            this.lblTrackId.AutoSize = true;
            this.lblTrackId.Location = new System.Drawing.Point(35, 26);
            this.lblTrackId.Name = "lblTrackId";
            this.lblTrackId.Size = new System.Drawing.Size(63, 13);
            this.lblTrackId.TabIndex = 8;
            this.lblTrackId.Text = "Tracking ID";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(46, 80);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(52, 13);
            this.lblDireccion.TabIndex = 9;
            this.lblDireccion.Text = "Direccion";
            // 
            // rtbMostrar
            // 
            this.rtbMostrar.Location = new System.Drawing.Point(12, 307);
            this.rtbMostrar.Name = "rtbMostrar";
            this.rtbMostrar.ReadOnly = true;
            this.rtbMostrar.Size = new System.Drawing.Size(444, 131);
            this.rtbMostrar.TabIndex = 16;
            this.rtbMostrar.Text = "";
            // 
            // cmsMostrar
            // 
            this.cmsMostrar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mostrarToolStripMenuItem});
            this.cmsMostrar.Name = "cmsMostrar";
            this.cmsMostrar.Size = new System.Drawing.Size(181, 48);
            // 
            // mostrarToolStripMenuItem
            // 
            this.mostrarToolStripMenuItem.Name = "mostrarToolStripMenuItem";
            this.mostrarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mostrarToolStripMenuItem.Text = "Mostrar";
            this.mostrarToolStripMenuItem.Click += new System.EventHandler(this.mostrarToolStripMenuItem_Click);
            // 
            // FrmPpal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(745, 449);
            this.Controls.Add(this.rtbMostrar);
            this.Controls.Add(this.gboxPaquete);
            this.Controls.Add(this.gboxEstadosPaquete);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmPpal";
            this.Text = "Correo UTN por Mauricio.Dellagiovanna.2C";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPpal_FormClosing);
            this.Load += new System.EventHandler(this.FrmPpal_Load);
            this.gboxEstadosPaquete.ResumeLayout(false);
            this.gboxEstadosPaquete.PerformLayout();
            this.gboxPaquete.ResumeLayout(false);
            this.gboxPaquete.PerformLayout();
            this.cmsMostrar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMostrarTodos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.GroupBox gboxEstadosPaquete;
        private System.Windows.Forms.GroupBox gboxPaquete;
        private System.Windows.Forms.Label lblIngresado;
        private System.Windows.Forms.Label lblEnViaje;
        private System.Windows.Forms.Label lblEntregado;
        private System.Windows.Forms.Label lblTrackId;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.ListBox listboxIngresado;
        private System.Windows.Forms.ListBox listboxEnViaje;
        private System.Windows.Forms.ListBox listboxEntregado;
        private System.Windows.Forms.MaskedTextBox mtxtTrackId;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.RichTextBox rtbMostrar;
        private System.Windows.Forms.ContextMenuStrip cmsMostrar;
        private System.Windows.Forms.ToolStripMenuItem mostrarToolStripMenuItem;
    }
}


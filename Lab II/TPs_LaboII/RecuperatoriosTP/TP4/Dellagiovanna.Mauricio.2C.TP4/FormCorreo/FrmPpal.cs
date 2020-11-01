using Entidades;
using Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace FormCorreo
{
    public partial class FrmPpal : Form
    {
        private Correo correo;

        public FrmPpal()
        {
            InitializeComponent();
        }


        #region Load & Closing
        private void FrmPpal_Load(object sender, EventArgs e)
        {
            correo = new Correo();
            mtxtTrackId.Mask = "000-000-0000";
        }


        private void FrmPpal_FormClosing(object sender, FormClosingEventArgs e)
        {
            correo.FinEntregas();
        }
        #endregion

        /// <summary>
        /// Agrega un nuevo paquete al correo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Paquete paquet = new Paquete(txtDireccion.Text, mtxtTrackId.Text);
            paquet.InformaEstado += paq_InformaEstado;
            paquet.EventoException += MensajeBBDD;

            txtDireccion.Clear();
            mtxtTrackId.Clear();
            try
            {

                correo += paquet;
                ActualizarEstados();

            }
            catch (Exception innerExc)
            {
                string stacktraceT = string.Empty;

                while (innerExc.InnerException != null)
                {
                    stacktraceT += innerExc.StackTrace.ToString() + "\n";
                    innerExc = innerExc.InnerException;
                }
                MessageBox.Show(innerExc.Message, "Error Paquete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        /// <summary>
        /// Indica al usuario que hubo un error al ingresar el paquete en
        /// la base de datos
        /// Manejador del evento paquete.eventoexception
        /// </summary>
        /// <param name="msj"></param>
        private void MensajeBBDD(string msj)
        {
            MessageBox.Show(msj, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Actualiza los estados de los paquetes
        /// en los ListBox
        /// </summary>
        private void ActualizarEstados()
        {
            listboxEntregado.Items.Clear();
            listboxEnViaje.Items.Clear();
            listboxIngresado.Items.Clear();

            foreach (Paquete paketito in correo.Paquetes)
            {
                switch (paketito.Estado)
                {   //Corregido el tipo de dato asignado a la lista (antes paketito.toString())
                    case Paquete.EEstado.Ingresado:
                        listboxIngresado.Items.Add(paketito);
                        break;
                    case Paquete.EEstado.EnViaje:
                        listboxEnViaje.Items.Add(paketito);
                        break;
                    case Paquete.EEstado.Entregado:
                        listboxEntregado.Items.Add(paketito);
                        break;
                }
            }
        }

        /// <summary>
        /// Informa el estado del paquete al evento y los actualiza
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="e"></param>
        private void paq_InformaEstado(object obj, EventArgs e)
        {
            if (this.InvokeRequired)
            {
                Paquete.DelegadoPaquete d = new Paquete.DelegadoPaquete(paq_InformaEstado);
                this.Invoke(d, new object[] { obj, e });
            }
            else
            {
                ActualizarEstados();
            }
        }

        /// <summary>
        /// Muestra la informacion de los paquetes en el richTextbox
        /// Guarda un txt de la informacion
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="elemento"></param>
        private void MostrarInformacion<T>(IMostrar<T> elemento)
        {
            if (!(elemento is null))
            {
                string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                rtbMostrar.Text = elemento.MostrarDatos(elemento);

                try
                {
                    rtbMostrar.Text.Guardar(Path.Combine(desktop, "salida.txt"));
                    //MessageBox.Show(Path.Combine(desktop, "salida.txt")); para debugear el path que no andaba..
                }
                catch (Exception e)
                {
                    string stacktraceT = string.Empty;

                    while (e.InnerException != null)
                    {
                        stacktraceT += e.StackTrace.ToString() + "\n";
                        e = e.InnerException;
                    }
                    MessageBox.Show(stacktraceT, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Muestra todos los envios ya sea cual sea su estado en el richTextBox
        /// luego guarda en .txt en el escritorio toda la info sobreescribiendo el archivo
        /// de ya existir
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            this.MostrarInformacion<List<Paquete>>((IMostrar<List<Paquete>>)correo);
        }

        /// <summary>
        /// Muestran en el richTextbox solo el item seleccionado de la 
        /// lista entregados.
        /// Guarda en un txt la informacion mostrada.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.MostrarInformacion<Paquete>((IMostrar<Paquete>)listboxEntregado.SelectedItem);
        }
    }
}

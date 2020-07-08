using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_63
{
    public partial class Form1 : Form
    {
        Thread t;
        public Form1()
        {
            InitializeComponent();
        }

        private delegate void DelegadoActualizarHora();

        /// <summary>
        /// utiliza un delegadon para modificar la etiqueta
        /// "en otro hilo"
        /// </summary>
        private void ActualizarHora()
        {
            if (lblHora.InvokeRequired)
            {
                DelegadoActualizarHora delegHora = new DelegadoActualizarHora(ActualizarHora);
                this.Invoke(delegHora);
            }
            else
                this.lblHora.Text = DateTime.Now.ToString();
        }

        /// <summary>
        /// permanentemente, se encarga de refrescar
        /// la etiqueta de la hora cada 1000 ms
        /// </summary>
        void RefrescarHora()
        {
            while (true)
            {
                ActualizarHora();
                Thread.Sleep(1000);
            }
        }

        /// <summary>
        /// mientras carga el formulario, instancia el thread
        /// y le da start()
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            t = new Thread(RefrescarHora);
            t.Start();
        }

        /// <summary>
        /// aborta los hilos en ejecucion mientras se esta cerrando
        /// el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (t.IsAlive)
            {
                t.Abort();
            }
        }
    }
}

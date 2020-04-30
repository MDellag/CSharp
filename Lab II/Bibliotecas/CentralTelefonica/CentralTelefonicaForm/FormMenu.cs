using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;
using CentralitaHerencia;


namespace CentralTelefonicaForm
{
    public partial class FormMenu : Form
    {
        
        public  Centralita central;
        FormLlamador llamador;
        FrmMostrar formMostrar;

        public Centralita Central
        {
            get { return this.central; }
            set { this.central = value; }
        }

        public FormMenu()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            
            central = new Centralita();
            llamador = new FormLlamador(Central);
            formMostrar = new FrmMostrar(Central);

            //if (llamador.S)
            //{

            //}

            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGenerarLlamada_Click(object sender, EventArgs e)
        {
            //this.Hide();
            // a.MdiParent = this;
            llamador.ShowDialog();

            //this.central = llamador.Central;
        }

        private void btnFacturacionTotal_Click(object sender, EventArgs e)
        {
            formMostrar.Tipo = Llamada.TipoLlamada.Todas;

            formMostrar.ShowDialog();        
        }
    }
}

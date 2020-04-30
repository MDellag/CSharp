using CentralitaHerencia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CentralTelefonicaForm
{
    public partial class FrmMostrar : Form
    {
        private Llamada.TipoLlamada tipo;
        private Centralita central;

        public Llamada.TipoLlamada Tipo
        {
            set { this.tipo = value; }
        }

        public FrmMostrar(Centralita central)
        {
            this.central = central;
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private void rchTxtMostrar_TextChanged(object sender, EventArgs e)
        {
            switch (tipo)
            {
                case Llamada.TipoLlamada.Local:
                    break;
                case Llamada.TipoLlamada.Provincial:
                    break;
                case Llamada.TipoLlamada.Todas: rchTxtMostrar.Text = central.Llamadas.ToString();
                    break;
                default:
                    break;
            }
        }
    }
}

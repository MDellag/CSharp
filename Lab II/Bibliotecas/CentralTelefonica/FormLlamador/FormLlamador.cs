using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CentralTelefonicaForm;

namespace FormLlamador
{
    public partial class FormLlamador : Form
    {
        public FormLlamador()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            //this.IsMdiChild = FormMenu;
            InitializeComponent();
        }

        private void FormLlamador_Load(object sender, EventArgs e)
        {

        }

        private void txtNroDestino_TextChanged(object sender, EventArgs e)
        {
            WaterMK wmk = new WaterMK();

            wmk.WaterMarkText = "Nro Destino";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

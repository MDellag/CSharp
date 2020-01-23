using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace @interface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        

        private void bunifuFlatButton8_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuFlatButton10_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton9_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuCustomTextbox1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBox0.Text))
            {
                txtBox0.Text = "What are u lookin for?";
            }
            else
            {
                txtBox0.Text = "";
            }
        }


        public void RemoveText(object sender, EventArgs e)
        {
            if (txtBox0.Text == "Enter text here...")
            {
                txtBox0.Text = "";
            }
        }

        public void AddText(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBox0.Text))
                txtBox0.Text = "Enter text here...";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void DashBoardBtn_Click(object sender, EventArgs e)
        {
            indexPanelBtn.Location = new Point(3, 54);
        }

        private void indexPanelBtn_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SendTokensBtn_Click(object sender, EventArgs e)
        {
            indexPanelBtn.Location = new Point(3, 99);
        }

        private void DataBtn_Click(object sender, EventArgs e)
        {
            indexPanelBtn.Location = new Point(3, 144);
        }

        private void PaymentsBtn_Click(object sender, EventArgs e)
        {
            indexPanelBtn.Location = new Point(3, 189);
        }

        private void WalletBtn_Click(object sender, EventArgs e)
        {
            indexPanelBtn.Location = new Point(3, 234);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            indexPanelBtn.Location = new Point(3, 279);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            indexPanelBtn.Location = new Point(3, 324);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private Persona persona;
        

        public Form1()
        {          
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            //persona.EventoString += NotificarCambio;
            if (persona is null)
            {
                persona = new Persona();
                persona.EventoString += NotificarCambio;
                btnCrear.Text = "Actualizar";
            }
           
                persona.Nombre = txtNombre.Text;
                persona.Apellido = txtApellido.Text; 
        }

        static void NotificarCambio(string cambio)
        {
            MessageBox.Show(cambio, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}

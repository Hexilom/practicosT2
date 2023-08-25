using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practico1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bGuardar_Click(object sender, EventArgs e)
        {
            txtApeNom.Text = txtApellido.Text + " " + txtNombre.Text;

        }

        private void bEliminar_Click(object sender, EventArgs e)
        {
            foreach (Control ctr in this.Controls)
            {
                if(ctr is TextBox)
                    ((TextBox)ctr).Text = string.Empty;
                else if (ctr is ComboBox)
                {
                    ((ComboBox)ctr).Text = String.Empty;
                }
            }
        }

        private void bSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == (Keys.Control | Keys.S))
                this.Close();
        }
    }

}

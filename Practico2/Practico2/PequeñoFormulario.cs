using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practico3
{
    public partial class PequeñoFormulario : Form
    {
        public PequeñoFormulario()
        {
            InitializeComponent();
        }
        
        //Funcion para limpiar los textbox y los combobox del formulario
        public void limpiar()
        {
            foreach (Control ctr in this.Controls)
            {
                if (ctr is TextBox)
                    ((TextBox)ctr).Text = string.Empty;
                else if (ctr is ComboBox)
                {
                    ((ComboBox)ctr).Text = string.Empty;
                }

            }
        }
        //Funcion para solo permitir numeros en el textbox DNI
        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))//(Si se quiere agregar puntos) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            /* permitir solo 1 punto 
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }*/
        }
        //Funcion para solo permitir letras en el textbox Apellido
        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        //Funcion para solo permitir letras en el textbox Nombre
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DialogResult ask; 
            ask = DialogResult.No;// Inicializa una variable de tipo dialogResult para 
            if (string.IsNullOrWhiteSpace(txtDni.Text) || string.IsNullOrWhiteSpace(txtApellido.Text) || string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Existen Campos Vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            }
            else//Mensaje de insercion del nuevo cliente
               ask = MessageBox.Show("Seguro que desea insertar un nuevo cliente?","Confirmar Insercion", MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button1);
            if (ask == DialogResult.Yes)
            {
                lblModificar.Text = txtNombre.Text + " " + txtApellido.Text;
                //Mensaje de insercion correcta
                MessageBox.Show("El cliente : " + lblModificar.Text + " se inserto correctamente", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

             }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if ((lblModificar.Text == "modificar") || (lblModificar.Text == String.Empty)) {
                MessageBox.Show("No hay nada que eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else {
                DialogResult ask;
                ask = MessageBox.Show("Está apunto de eliminar el Cliente : " + lblModificar.Text, "Confirmar Eliminacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (ask == DialogResult.Yes)  {
                    limpiar();
                    lblModificar.Text = String.Empty;
                }
            }
        }

 
    }
}

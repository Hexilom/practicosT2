using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Practico5
{
    public partial class practico5 : Form
    {
        public practico5()
        {
            InitializeComponent();
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSaldo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))//&& ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1)))//(Si se quiere agregar puntos) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            /* permitir solo 1 punto 
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }*/
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            // Obtiene el texto del textboxx
            string cadena = txtNombre.Text;
            // Verifica que la cadena no este vacia
            if (!string.IsNullOrEmpty(cadena))
            {
                // Hace mayuscula al 1er miembro del string y minusculas al resto
                string cadenaMayuscula = char.ToUpper(cadena[0]) + cadena.Substring(1).ToLower();
                // Actualiza la cadena 
                txtNombre.Text = cadenaMayuscula;
                // Pone el cursor al final de la cadena para prevenir que vaya al comienzo
                txtNombre.SelectionStart = txtNombre.Text.Length;
            }
        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
            // Obtiene el texto del textboxx
            string cadena = txtApellido.Text;
            // Verifica que la cadena no este vacia
            if (!string.IsNullOrEmpty(cadena))
            {
                // Hace mayuscula al 1er miembro del string y minusculas al resto
                string cadenaMayuscula = char.ToUpper(cadena[0]) + cadena.Substring(1).ToLower();
                // Actualiza la cadena 
                txtApellido.Text = cadenaMayuscula;
                // Pone el cursor al final de la cadena para prevenir que vaya al comienzo
                txtApellido.SelectionStart = txtApellido.Text.Length;
            }
        }

        private void btnFoto_Click(object sender, EventArgs e)
        {

            if (ofdFoto.ShowDialog() == DialogResult.OK)
            {
                ofdFoto.Title = "Open File";
                ofdFoto.Filter = "Archivos de imagenes (*.jpg)|*.jpg|Archivos de imagenes (*.png)|*.png";
                ofdFoto.InitialDirectory = "C:";

                pbxImagen.ImageLocation = ofdFoto.FileName;
                pbxImagen.BackgroundImage = null;

            }
        }

        private void ofdFoto_FileOk(object sender, CancelEventArgs e)
        {
            string rutaProyecto = Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetName().CodeBase).Remove(0, 6);

            string rutaArchivo = ofdFoto.FileName.ToString();

            FileInfo archivo = new FileInfo(rutaArchivo);

            string archivoNombre = archivo.Name;

            string destino = rutaProyecto + "/fotos/" + archivoNombre;

            destino = destino.Replace("\\", "/");

            txtFoto.Text = destino;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtNombre.Text) &&
                !string.IsNullOrWhiteSpace(txtApellido.Text) &&
                !string.IsNullOrWhiteSpace(txtSaldo.Text) &&
                !string.IsNullOrWhiteSpace(txtFoto.Text) &&
                (rbtHombre.Checked == true || rbtMujer.Checked == true))
            {
                var index = this.dgvUsuario.Rows.Add();
                string sexo;
                string nombre = txtNombre.Text;
                string apellido = txtApellido.Text;

                if (rbtHombre.Checked == true)
                {
                    sexo = "Hombre";
                }
                else
                {
                    sexo = "Mujer";
                }
                //DGV_EMPLEADO.Columns[0].DefaultCellStyle.Font = new Font("Comic Sans MS", 8);
                //DGV_EMPLEADO.Columns[1].DefaultCellStyle.Font = new Font("Comic Sans MS", 8);

                dgvUsuario.Rows[index].Cells[0].Value = nombre;
                dgvUsuario.Rows[index].Cells[1].Value = apellido;
                dgvUsuario.Rows[index].Cells[2].Value = dtpFechaNac.Value.ToShortDateString();
                dgvUsuario.Rows[index].Cells[3].Value = sexo;
                dgvUsuario.Rows[index].Cells[5].Value = txtSaldo.Text;
                dgvUsuario.Rows[index].Cells[4].Value = "Eliminar";
                dgvUsuario.Rows[index].Cells[6].Value = Image.FromFile(ofdFoto.FileName);
                dgvUsuario.Rows[index].Cells[7].Value = txtFoto.Text; //preguntar al profe sobre si deberia guardarse la ubicacion original o /fotos/

                if (Convert.ToInt32(dgvUsuario.Rows[index].Cells[5].Value) < 50)
                {
                    dgvUsuario.Rows[index].DefaultCellStyle.BackColor = Color.Red;
                    dgvUsuario.Rows[index].DefaultCellStyle.ForeColor = Color.White;
                }

                string rutaArchivo = ofdFoto.FileName.ToString();
                File.Copy(rutaArchivo, txtFoto.Text);
                
                this.limpiarCampos();
            }
            else
            {
                MessageBox.Show("Faltan campos por completar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void limpiarCampos()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            rbtHombre.Checked = false;
            rbtMujer.Checked = false;
            txtSaldo.Clear();
            txtFoto.Clear();
            pbxImagen.ImageLocation = null;
            pbxImagen.BackgroundImage = Properties.Resources.avatardefault_92824;
        }

        private void dgvUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if click is on new row or header row
            if (e.RowIndex == dgvUsuario.NewRowIndex || e.RowIndex < 0)
            {
                return;
            }

            //Check if click is on specific column 
            if (e.ColumnIndex == dgvUsuario.Columns["eliminar"].Index)
            {
                DialogResult resp = MessageBox.Show("Seguro desea eliminar el registro?",
                    "Advertencia", MessageBoxButtons.YesNo);
                if (resp == DialogResult.Yes)
                {
                    dgvUsuario.Rows.RemoveAt(e.RowIndex);
                }
            }

            DataGridViewRow fila = dgvUsuario.CurrentCell.OwningRow;

            if (e.ColumnIndex == dgvUsuario.Columns["sexo"].Index)
            {
                if (fila.Cells["sexo"].Value.ToString() == "Hombre")
                {
                    rbtHombre.Checked = true;
                }
                else
                {
                    rbtMujer.Checked = true;
                }
            }
        }
    }
    
}

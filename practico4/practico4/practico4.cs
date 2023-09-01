using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practico4
{
    public partial class practico4 : Form
    {
        public practico4()
        {
            InitializeComponent();
        }
        
        private void btnGenerar_Click(object sender, EventArgs e)
        {
            lstNumeros.Items.Clear();
          
            if (string.IsNullOrWhiteSpace(txtDesde.Text) || string.IsNullOrWhiteSpace(txtHasta.Text))
            {
                MessageBox.Show("Hay Campos Vacios!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
            int desde = Int32.Parse(txtDesde.Text);
            int hasta = Int32.Parse(txtHasta.Text);
                if (desde <= hasta)
                {
                    for (int i = desde; i <= hasta; i++)
                    {
                        lstNumeros.Items.Add(i);
                    }
                    //probanding

                   // int cantidad =  lstNumeros.Items.Count;
                   // test.Text = Convert.ToString(cantidad);
                   // for(int j = 0; j <= cantidad; j ++)
                   // {
                   // chart1.Series["graficarFuncion"].Points.AddXY("aaa",545);
                   // chart1.Series["graficarFuncion"].Points.AddXY("bbbba", 2135);
                   // }
                    //chart1.Series["graficarFuncion"].Points.AddXY("JACOB", 200);              
                }
                else
                {
                    MessageBox.Show("El campo hasta es mayor al campo desde", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void txtDesde_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtHasta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

       

        private void btnPrimos_Click(object sender, EventArgs e)
        {
            int desde = Int32.Parse(txtDesde.Text);
            int hasta = Int32.Parse(txtHasta.Text);
           
            if (desde <= hasta)
            {
                for (int i = desde; i <= hasta; i++)
                {
                    if (!((i % hasta) == 0))
                    {

                    }
                }
            }
            else
            {
                MessageBox.Show("El campo hasta es mayor al campo desde", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnPares_Click(object sender, EventArgs e)
        {
            int desde = Int32.Parse(txtDesde.Text);
            int hasta = Int32.Parse(txtHasta.Text);

            if (desde <= hasta)
            {
                for (int i = desde; i <= hasta; i++)
                {
                    if(i % 2 == 0)
                    {
                        lstNumeros.Items.Add(i);
                    }
                    
                }
            }
            else
            {
                MessageBox.Show("El campo hasta es mayor al campo desde", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnImpares_Click(object sender, EventArgs e)
        {
            int desde = Int32.Parse(txtDesde.Text);
            int hasta = Int32.Parse(txtHasta.Text);

            if (desde <= hasta)
            {
                for (int i = desde; i <= hasta; i++)
                {
                    if (i % 2 != 0)
                    {
                        lstNumeros.Items.Add(i);
                    }

                }
            }
            else
            {
                MessageBox.Show("El campo hasta es mayor al campo desde", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void chkPares_CheckedChanged(object sender, EventArgs e)
        {
            if(chkPares.Checked == true)
            {
                chkImpares.Checked = false;
                chkPrimos.Checked = false;
            }
        }

        private void chkImpares_CheckedChanged(object sender, EventArgs e)
        {
            if (chkImpares.Checked == true)
            {
                chkPares.Checked = false;
                chkPrimos.Checked = false;
            }
        }

        private void chkPrimos_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPrimos.Checked == true)
            {
                chkImpares.Checked = false;
                chkPares.Checked = false;
            }
        }

        private void btnGenerarMod_Click(object sender, EventArgs e)
        {
            lstNumeros.Items.Clear();
            //Verificacion de campos nulos
            if (string.IsNullOrWhiteSpace(txtDesde.Text) || string.IsNullOrWhiteSpace(txtHasta.Text))
            {
                MessageBox.Show("Hay Campos Vacios!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int desde = Int32.Parse(txtDesde.Text);
                int hasta = Int32.Parse(txtHasta.Text);
                //Verificacion de que el campo desde sea menor al campo hasta
                if (desde <= hasta)
                {
                    //Pares
                    if(chkPares.Checked == true)
                    {
                        if (desde <= hasta)
                        {
                            for (int i = desde; i <= hasta; i++)
                            {
                                if (i % 2 == 0)
                                {
                                    lstNumeros.Items.Add(i);
                                }

                            }
                        }
                    }
                    //Impares
                    if(chkImpares.Checked == true)
                    {
                        for (int i = desde; i <= hasta; i++)
                        {
                            if (i % 2 != 0)
                            {
                                lstNumeros.Items.Add(i);
                            }
                        }
                    }
                    //Primos
                    if(chkPrimos.Checked == true)
                    {
                        int contador;
                        
                        for (int i = desde; i < hasta; i++)
                        {
                            contador = 0;
                            if (i > 1)
                            {
                                for (int j = 2; j < i; j++)
                                {
                                    if (i % j == 0)
                                    {
                                        contador = 1;
                                        break;
                                    }
                                }
                                if (contador == 0)
                                {
                                    lstNumeros.Items.Add(i);
                                }
                                //prob
                                
                            }
                           // int sonda = 3;
                                
                               
                                
                                
                                
                           // int cantidad = lstNumeros.Items.Count;
                           // test.Text = Convert.ToString(cantidad);
                           // Object prueba = lstNumeros.Items;
                           // test.Text = Convert.ToString(cantidad);
                            //this.lstNumeros.SetSelected(1,true);

                            // test.Text = Convert.ToString(cantidad);
                            //this.listBox1.GetItemValue(this.listBox1.Items[2]);
                            //foreach lstNumeros.Items {
                                //test.Text = lstNumeros.Items
                            //}
                            
                        }
                    }
                }
                else
                {
                    MessageBox.Show("El campo hasta es mayor al campo desde", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        
        private void btnGraficar_Click(object sender, EventArgs e)
        {
            //int sonda = 1;
            
            chart1.Series["graficarFuncion"].Points.Clear();
            int cantidad = 0;
            ListBox lstAux = lstNumeros;
            cantidad = lstAux.Items.Count;
           
            for(int i = 0; i < cantidad;i ++)
            {
                chart1.Series["graficarFuncion"].Points.AddXY(Convert.ToString(i + 1), lstAux.Items[i].ToString());
            }
            // int cantidad =  lstNumeros.Items.Count;
            // test.Text = Convert.ToString(cantidad);
            // for(int j = 0; j <= cantidad; j ++)
            // {
            // chart1.Series["graficarFuncion"].Points.AddXY("aaa",545);
            // chart1.Series["graficarFuncion"].Points.AddXY("bbbba", 2135);
            // }
            //chart1.Series["graficarFuncion"].Points.AddXY("JACOB", 200);    
        }
    }
}

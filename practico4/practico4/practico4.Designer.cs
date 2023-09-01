namespace practico4
{
    partial class practico4
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDesde = new System.Windows.Forms.TextBox();
            this.txtHasta = new System.Windows.Forms.TextBox();
            this.btnGenerarLineal = new System.Windows.Forms.Button();
            this.lstNumeros = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chkPares = new System.Windows.Forms.CheckBox();
            this.chkImpares = new System.Windows.Forms.CheckBox();
            this.chkPrimos = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGenerarMod = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnGraficar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Desde";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hasta";
            // 
            // txtDesde
            // 
            this.txtDesde.Location = new System.Drawing.Point(59, 42);
            this.txtDesde.Name = "txtDesde";
            this.txtDesde.Size = new System.Drawing.Size(77, 20);
            this.txtDesde.TabIndex = 2;
            this.txtDesde.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDesde_KeyPress);
            // 
            // txtHasta
            // 
            this.txtHasta.Location = new System.Drawing.Point(59, 78);
            this.txtHasta.Name = "txtHasta";
            this.txtHasta.Size = new System.Drawing.Size(77, 20);
            this.txtHasta.TabIndex = 3;
            this.txtHasta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHasta_KeyPress);
            // 
            // btnGenerarLineal
            // 
            this.btnGenerarLineal.Location = new System.Drawing.Point(15, 113);
            this.btnGenerarLineal.Name = "btnGenerarLineal";
            this.btnGenerarLineal.Size = new System.Drawing.Size(130, 23);
            this.btnGenerarLineal.TabIndex = 4;
            this.btnGenerarLineal.Text = "Generar Funcion Lineal";
            this.btnGenerarLineal.UseVisualStyleBackColor = true;
            this.btnGenerarLineal.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // lstNumeros
            // 
            this.lstNumeros.FormattingEnabled = true;
            this.lstNumeros.Location = new System.Drawing.Point(237, 43);
            this.lstNumeros.MultiColumn = true;
            this.lstNumeros.Name = "lstNumeros";
            this.lstNumeros.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstNumeros.Size = new System.Drawing.Size(95, 251);
            this.lstNumeros.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(243, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Lista de Numeros";
            // 
            // chkPares
            // 
            this.chkPares.AutoSize = true;
            this.chkPares.Location = new System.Drawing.Point(15, 176);
            this.chkPares.Name = "chkPares";
            this.chkPares.Size = new System.Drawing.Size(53, 17);
            this.chkPares.TabIndex = 12;
            this.chkPares.Text = "Pares";
            this.chkPares.UseVisualStyleBackColor = true;
            this.chkPares.CheckedChanged += new System.EventHandler(this.chkPares_CheckedChanged);
            // 
            // chkImpares
            // 
            this.chkImpares.AutoSize = true;
            this.chkImpares.Location = new System.Drawing.Point(15, 199);
            this.chkImpares.Name = "chkImpares";
            this.chkImpares.Size = new System.Drawing.Size(63, 17);
            this.chkImpares.TabIndex = 13;
            this.chkImpares.Text = "Impares";
            this.chkImpares.UseVisualStyleBackColor = true;
            this.chkImpares.CheckedChanged += new System.EventHandler(this.chkImpares_CheckedChanged);
            // 
            // chkPrimos
            // 
            this.chkPrimos.AutoSize = true;
            this.chkPrimos.Location = new System.Drawing.Point(15, 222);
            this.chkPrimos.Name = "chkPrimos";
            this.chkPrimos.Size = new System.Drawing.Size(57, 17);
            this.chkPrimos.TabIndex = 14;
            this.chkPrimos.Text = "Primos";
            this.chkPrimos.UseVisualStyleBackColor = true;
            this.chkPrimos.CheckedChanged += new System.EventHandler(this.chkPrimos_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnGenerarMod);
            this.panel1.Controls.Add(this.btnGenerarLineal);
            this.panel1.Controls.Add(this.chkPrimos);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.chkImpares);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.chkPares);
            this.panel1.Controls.Add(this.txtDesde);
            this.panel1.Controls.Add(this.txtHasta);
            this.panel1.Location = new System.Drawing.Point(23, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(189, 317);
            this.panel1.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Generar Funcion Lineal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Generar Funcion Mod";
            // 
            // btnGenerarMod
            // 
            this.btnGenerarMod.Location = new System.Drawing.Point(15, 245);
            this.btnGenerarMod.Name = "btnGenerarMod";
            this.btnGenerarMod.Size = new System.Drawing.Size(130, 23);
            this.btnGenerarMod.TabIndex = 15;
            this.btnGenerarMod.Text = "Generar Funcion Mod";
            this.btnGenerarMod.UseVisualStyleBackColor = true;
            this.btnGenerarMod.Click += new System.EventHandler(this.btnGenerarMod_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(414, 33);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "graficarFuncion";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(311, 285);
            this.chart1.TabIndex = 16;
            this.chart1.Text = "chart1";
            // 
            // btnGraficar
            // 
            this.btnGraficar.Location = new System.Drawing.Point(257, 306);
            this.btnGraficar.Name = "btnGraficar";
            this.btnGraficar.Size = new System.Drawing.Size(75, 23);
            this.btnGraficar.TabIndex = 18;
            this.btnGraficar.Text = "Graficar";
            this.btnGraficar.UseVisualStyleBackColor = true;
            this.btnGraficar.Click += new System.EventHandler(this.btnGraficar_Click);
            // 
            // practico4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 384);
            this.Controls.Add(this.btnGraficar);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstNumeros);
            this.KeyPreview = true;
            this.Name = "practico4";
            this.Text = "Practico 4";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDesde;
        private System.Windows.Forms.TextBox txtHasta;
        private System.Windows.Forms.Button btnGenerarLineal;
        private System.Windows.Forms.ListBox lstNumeros;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkPares;
        private System.Windows.Forms.CheckBox chkImpares;
        private System.Windows.Forms.CheckBox chkPrimos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGenerarMod;
        private System.Windows.Forms.Button btnGraficar;
        public System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}


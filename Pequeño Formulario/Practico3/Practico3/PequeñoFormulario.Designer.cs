namespace Practico3
{
    partial class PequeñoFormulario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PequeñoFormulario));
            this.lblDni = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblNyA = new System.Windows.Forms.Label();
            this.lblModificar = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkMaster = new System.Windows.Forms.CheckBox();
            this.chkVisa = new System.Windows.Forms.CheckBox();
            this.chkNaranja = new System.Windows.Forms.CheckBox();
            this.lblTarjeta = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.pbxSexo = new System.Windows.Forms.PictureBox();
            this.RBVaron = new System.Windows.Forms.RadioButton();
            this.RBMujer = new System.Windows.Forms.RadioButton();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSexo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDni
            // 
            this.lblDni.AllowDrop = true;
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(21, 68);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(30, 13);
            this.lblDni.TabIndex = 0;
            this.lblDni.Text = "*DNI";
            // 
            // lblApellido
            // 
            this.lblApellido.AllowDrop = true;
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(21, 96);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(48, 13);
            this.lblApellido.TabIndex = 1;
            this.lblApellido.Text = "*Apellido";
            // 
            // lblNombre
            // 
            this.lblNombre.AllowDrop = true;
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(21, 122);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(48, 13);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "*Nombre";
            // 
            // lblNyA
            // 
            this.lblNyA.AllowDrop = true;
            this.lblNyA.AutoSize = true;
            this.lblNyA.Location = new System.Drawing.Point(21, 26);
            this.lblNyA.Name = "lblNyA";
            this.lblNyA.Size = new System.Drawing.Size(92, 13);
            this.lblNyA.TabIndex = 3;
            this.lblNyA.Text = "Nombre y Apellido";
            // 
            // lblModificar
            // 
            this.lblModificar.AllowDrop = true;
            this.lblModificar.AutoSize = true;
            this.lblModificar.ForeColor = System.Drawing.Color.Red;
            this.lblModificar.Location = new System.Drawing.Point(157, 26);
            this.lblModificar.Name = "lblModificar";
            this.lblModificar.Size = new System.Drawing.Size(49, 13);
            this.lblModificar.TabIndex = 4;
            this.lblModificar.Text = "modificar";
            // 
            // txtDni
            // 
            this.txtDni.AllowDrop = true;
            this.txtDni.Location = new System.Drawing.Point(139, 65);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(132, 20);
            this.txtDni.TabIndex = 5;
            this.txtDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDni_KeyPress);
            // 
            // txtApellido
            // 
            this.txtApellido.AllowDrop = true;
            this.txtApellido.Location = new System.Drawing.Point(139, 93);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(132, 20);
            this.txtApellido.TabIndex = 6;
            this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.AllowDrop = true;
            this.txtNombre.Location = new System.Drawing.Point(139, 119);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(132, 20);
            this.txtNombre.TabIndex = 7;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // btnGuardar
            // 
            this.btnGuardar.AllowDrop = true;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.Location = new System.Drawing.Point(65, 388);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnGuardar.Size = new System.Drawing.Size(90, 54);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.AllowDrop = true;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(202, 388);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(92, 54);
            this.btnEliminar.TabIndex = 9;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.chkMaster);
            this.panel1.Controls.Add(this.chkVisa);
            this.panel1.Controls.Add(this.chkNaranja);
            this.panel1.Controls.Add(this.lblTarjeta);
            this.panel1.Controls.Add(this.txtTelefono);
            this.panel1.Controls.Add(this.lblTelefono);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.lblDni);
            this.panel1.Controls.Add(this.lblApellido);
            this.panel1.Controls.Add(this.lblNombre);
            this.panel1.Controls.Add(this.txtApellido);
            this.panel1.Controls.Add(this.lblNyA);
            this.panel1.Controls.Add(this.txtDni);
            this.panel1.Controls.Add(this.lblModificar);
            this.panel1.Location = new System.Drawing.Point(42, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(287, 296);
            this.panel1.TabIndex = 10;
            // 
            // chkMaster
            // 
            this.chkMaster.AutoSize = true;
            this.chkMaster.Location = new System.Drawing.Point(139, 224);
            this.chkMaster.Name = "chkMaster";
            this.chkMaster.Size = new System.Drawing.Size(79, 17);
            this.chkMaster.TabIndex = 13;
            this.chkMaster.Text = "Mastercard";
            this.chkMaster.UseVisualStyleBackColor = true;
            // 
            // chkVisa
            // 
            this.chkVisa.AutoSize = true;
            this.chkVisa.Location = new System.Drawing.Point(139, 201);
            this.chkVisa.Name = "chkVisa";
            this.chkVisa.Size = new System.Drawing.Size(46, 17);
            this.chkVisa.TabIndex = 12;
            this.chkVisa.Text = "Visa";
            this.chkVisa.UseVisualStyleBackColor = true;
            // 
            // chkNaranja
            // 
            this.chkNaranja.AutoSize = true;
            this.chkNaranja.Location = new System.Drawing.Point(139, 178);
            this.chkNaranja.Name = "chkNaranja";
            this.chkNaranja.Size = new System.Drawing.Size(63, 17);
            this.chkNaranja.TabIndex = 11;
            this.chkNaranja.Text = "Naranja";
            this.chkNaranja.UseVisualStyleBackColor = true;
            // 
            // lblTarjeta
            // 
            this.lblTarjeta.AutoSize = true;
            this.lblTarjeta.Location = new System.Drawing.Point(21, 178);
            this.lblTarjeta.Name = "lblTarjeta";
            this.lblTarjeta.Size = new System.Drawing.Size(96, 13);
            this.lblTarjeta.TabIndex = 10;
            this.lblTarjeta.Text = "Tarjeta de Creditos";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(139, 145);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(132, 20);
            this.txtTelefono.TabIndex = 9;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(21, 148);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(49, 13);
            this.lblTelefono.TabIndex = 8;
            this.lblTelefono.Text = "Telefono";
            // 
            // pbxSexo
            // 
            this.pbxSexo.Image = ((System.Drawing.Image)(resources.GetObject("pbxSexo.Image")));
            this.pbxSexo.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbxSexo.InitialImage")));
            this.pbxSexo.Location = new System.Drawing.Point(378, 68);
            this.pbxSexo.Name = "pbxSexo";
            this.pbxSexo.Size = new System.Drawing.Size(172, 196);
            this.pbxSexo.TabIndex = 11;
            this.pbxSexo.TabStop = false;
            this.pbxSexo.WaitOnLoad = true;
            // 
            // RBVaron
            // 
            this.RBVaron.AutoSize = true;
            this.RBVaron.Checked = true;
            this.RBVaron.Location = new System.Drawing.Point(412, 270);
            this.RBVaron.Name = "RBVaron";
            this.RBVaron.Size = new System.Drawing.Size(53, 17);
            this.RBVaron.TabIndex = 12;
            this.RBVaron.TabStop = true;
            this.RBVaron.Text = "Varon";
            this.RBVaron.UseVisualStyleBackColor = true;
            this.RBVaron.CheckedChanged += new System.EventHandler(this.RBVaron_CheckedChanged);
            // 
            // RBMujer
            // 
            this.RBMujer.AutoSize = true;
            this.RBMujer.Location = new System.Drawing.Point(471, 270);
            this.RBMujer.Name = "RBMujer";
            this.RBMujer.Size = new System.Drawing.Size(51, 17);
            this.RBMujer.TabIndex = 13;
            this.RBMujer.Text = "Mujer";
            this.RBMujer.UseVisualStyleBackColor = true;
            this.RBMujer.CheckedChanged += new System.EventHandler(this.RBMujer_CheckedChanged);
            // 
            // btnSalir
            // 
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(474, 390);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(76, 52);
            this.btnSalir.TabIndex = 14;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 18.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cyan;
            this.label1.Location = new System.Drawing.Point(197, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 30);
            this.label1.TabIndex = 15;
            this.label1.Text = "Nuevo Cliente";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PequeñoFormulario
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 462);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.RBMujer);
            this.Controls.Add(this.RBVaron);
            this.Controls.Add(this.pbxSexo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnGuardar);
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.KeyPreview = true;
            this.Name = "PequeñoFormulario";
            this.Text = "PequeñoFormulario";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSexo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblNyA;
        private System.Windows.Forms.Label lblModificar;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chkMaster;
        private System.Windows.Forms.CheckBox chkVisa;
        private System.Windows.Forms.CheckBox chkNaranja;
        private System.Windows.Forms.Label lblTarjeta;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.PictureBox pbxSexo;
        private System.Windows.Forms.RadioButton RBVaron;
        private System.Windows.Forms.RadioButton RBMujer;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label1;
    }
}


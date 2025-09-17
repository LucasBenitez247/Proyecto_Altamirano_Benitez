namespace Administrador
{
    partial class UserControlGestionUsuario
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lGestionUsuario = new System.Windows.Forms.Label();
            this.lNombre = new System.Windows.Forms.Label();
            this.lApellido = new System.Windows.Forms.Label();
            this.lcuil = new System.Windows.Forms.Label();
            this.lFechaNacimiento = new System.Windows.Forms.Label();
            this.lDireccion = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtCuil = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lTelefono = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lGestionUsuario
            // 
            this.lGestionUsuario.AutoSize = true;
            this.lGestionUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lGestionUsuario.Location = new System.Drawing.Point(163, 39);
            this.lGestionUsuario.Name = "lGestionUsuario";
            this.lGestionUsuario.Size = new System.Drawing.Size(183, 25);
            this.lGestionUsuario.TabIndex = 0;
            this.lGestionUsuario.Text = "Datos del Usuario";
            // 
            // lNombre
            // 
            this.lNombre.AutoSize = true;
            this.lNombre.Location = new System.Drawing.Point(85, 134);
            this.lNombre.Name = "lNombre";
            this.lNombre.Size = new System.Drawing.Size(44, 13);
            this.lNombre.TabIndex = 1;
            this.lNombre.Text = "Nombre";
            // 
            // lApellido
            // 
            this.lApellido.AutoSize = true;
            this.lApellido.Location = new System.Drawing.Point(85, 176);
            this.lApellido.Name = "lApellido";
            this.lApellido.Size = new System.Drawing.Size(44, 13);
            this.lApellido.TabIndex = 2;
            this.lApellido.Text = "Apellido";
            // 
            // lcuil
            // 
            this.lcuil.AutoSize = true;
            this.lcuil.Location = new System.Drawing.Point(89, 218);
            this.lcuil.Name = "lcuil";
            this.lcuil.Size = new System.Drawing.Size(31, 13);
            this.lcuil.TabIndex = 3;
            this.lcuil.Text = "CUIL";
            // 
            // lFechaNacimiento
            // 
            this.lFechaNacimiento.AutoSize = true;
            this.lFechaNacimiento.Location = new System.Drawing.Point(89, 252);
            this.lFechaNacimiento.Name = "lFechaNacimiento";
            this.lFechaNacimiento.Size = new System.Drawing.Size(106, 13);
            this.lFechaNacimiento.TabIndex = 4;
            this.lFechaNacimiento.Text = "Fecha de nacimiento";
            // 
            // lDireccion
            // 
            this.lDireccion.AutoSize = true;
            this.lDireccion.Location = new System.Drawing.Point(89, 308);
            this.lDireccion.Name = "lDireccion";
            this.lDireccion.Size = new System.Drawing.Size(55, 13);
            this.lDireccion.TabIndex = 5;
            this.lDireccion.Text = "Dirección:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(168, 131);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(178, 20);
            this.txtNombre.TabIndex = 6;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(171, 169);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(175, 20);
            this.txtApellido.TabIndex = 7;
            // 
            // txtCuil
            // 
            this.txtCuil.Location = new System.Drawing.Point(171, 211);
            this.txtCuil.Name = "txtCuil";
            this.txtCuil.Size = new System.Drawing.Size(175, 20);
            this.txtCuil.TabIndex = 8;
            this.txtCuil.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(215, 252);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(131, 20);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(168, 308);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Calle";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 338);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Altura";
            // 
            // lTelefono
            // 
            this.lTelefono.AutoSize = true;
            this.lTelefono.Location = new System.Drawing.Point(95, 373);
            this.lTelefono.Name = "lTelefono";
            this.lTelefono.Size = new System.Drawing.Size(49, 13);
            this.lTelefono.TabIndex = 12;
            this.lTelefono.Text = "Teléfono";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(95, 411);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Correo electrónico";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtCalle
            // 
            this.txtCalle.Location = new System.Drawing.Point(234, 303);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(100, 20);
            this.txtCalle.TabIndex = 14;
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(234, 329);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(100, 20);
            this.txtAltura.TabIndex = 15;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(180, 370);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(154, 20);
            this.textBox3.TabIndex = 16;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(194, 404);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(152, 20);
            this.textBox1.TabIndex = 17;
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Location = new System.Drawing.Point(189, 87);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(157, 20);
            this.txtNombreUsuario.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Nombre de usuario";
            // 
            // UserControlGestionUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNombreUsuario);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.txtCalle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lTelefono);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtCuil);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lDireccion);
            this.Controls.Add(this.lFechaNacimiento);
            this.Controls.Add(this.lcuil);
            this.Controls.Add(this.lApellido);
            this.Controls.Add(this.lNombre);
            this.Controls.Add(this.lGestionUsuario);
            this.Name = "UserControlGestionUsuario";
            this.Size = new System.Drawing.Size(469, 402);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lGestionUsuario;
        private System.Windows.Forms.Label lNombre;
        private System.Windows.Forms.Label lApellido;
        private System.Windows.Forms.Label lcuil;
        private System.Windows.Forms.Label lFechaNacimiento;
        private System.Windows.Forms.Label lDireccion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtCuil;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lTelefono;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCalle;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.Label label3;
    }
}

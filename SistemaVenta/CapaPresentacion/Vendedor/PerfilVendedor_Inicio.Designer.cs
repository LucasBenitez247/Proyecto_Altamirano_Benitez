namespace CapaPresentacion
{
    partial class PerfilVendedor_Inicio
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PerfilVendedor_Inicio));
            this.PContenedor = new System.Windows.Forms.Panel();
            this.LblHora = new System.Windows.Forms.Label();
            this.LblFecha = new System.Windows.Forms.Label();
            this.PSubMenuClientes = new System.Windows.Forms.Panel();
            this.BtnVerLista = new FontAwesome.Sharp.IconButton();
            this.BtnClientesRegistrar = new FontAwesome.Sharp.IconButton();
            this.BtnInicio = new FontAwesome.Sharp.IconButton();
            this.BtnClientes = new FontAwesome.Sharp.IconButton();
            this.BtnVentas = new FontAwesome.Sharp.IconButton();
            this.BtnHistorial = new FontAwesome.Sharp.IconButton();
            this.BtnCatalogo = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnSalir = new FontAwesome.Sharp.IconButton();
            this.HoraFecha = new System.Windows.Forms.Timer(this.components);
            this.PContenedor.SuspendLayout();
            this.PSubMenuClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PContenedor
            // 
            this.PContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.PContenedor.Controls.Add(this.LblHora);
            this.PContenedor.Controls.Add(this.LblFecha);
            this.PContenedor.Location = new System.Drawing.Point(157, 77);
            this.PContenedor.Name = "PContenedor";
            this.PContenedor.Size = new System.Drawing.Size(1201, 660);
            this.PContenedor.TabIndex = 1;
            // 
            // LblHora
            // 
            this.LblHora.AutoSize = true;
            this.LblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LblHora.Location = new System.Drawing.Point(285, 89);
            this.LblHora.Name = "LblHora";
            this.LblHora.Size = new System.Drawing.Size(212, 91);
            this.LblHora.TabIndex = 1;
            this.LblHora.Text = "Hora";
            // 
            // LblFecha
            // 
            this.LblFecha.AutoSize = true;
            this.LblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LblFecha.Location = new System.Drawing.Point(235, 189);
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.Size = new System.Drawing.Size(131, 46);
            this.LblFecha.TabIndex = 0;
            this.LblFecha.Text = "Fecha";
            // 
            // PSubMenuClientes
            // 
            this.PSubMenuClientes.Controls.Add(this.BtnVerLista);
            this.PSubMenuClientes.Controls.Add(this.BtnClientesRegistrar);
            this.PSubMenuClientes.Location = new System.Drawing.Point(4, 389);
            this.PSubMenuClientes.Name = "PSubMenuClientes";
            this.PSubMenuClientes.Size = new System.Drawing.Size(154, 117);
            this.PSubMenuClientes.TabIndex = 6;
            this.PSubMenuClientes.Visible = false;
            this.PSubMenuClientes.MouseLeave += new System.EventHandler(this.PSubMenuClientes_MouseLeave);
            // 
            // BtnVerLista
            // 
            this.BtnVerLista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.BtnVerLista.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnVerLista.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnVerLista.FlatAppearance.BorderSize = 0;
            this.BtnVerLista.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtnVerLista.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.BtnVerLista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVerLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVerLista.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnVerLista.IconChar = FontAwesome.Sharp.IconChar.ClipboardList;
            this.BtnVerLista.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnVerLista.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnVerLista.IconSize = 32;
            this.BtnVerLista.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnVerLista.Location = new System.Drawing.Point(0, 57);
            this.BtnVerLista.Name = "BtnVerLista";
            this.BtnVerLista.Size = new System.Drawing.Size(154, 58);
            this.BtnVerLista.TabIndex = 6;
            this.BtnVerLista.Text = "Ver lista";
            this.BtnVerLista.UseCompatibleTextRendering = true;
            this.BtnVerLista.UseVisualStyleBackColor = false;
            this.BtnVerLista.Click += new System.EventHandler(this.BtnVerLista_Click);
            // 
            // BtnClientesRegistrar
            // 
            this.BtnClientesRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.BtnClientesRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClientesRegistrar.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnClientesRegistrar.FlatAppearance.BorderSize = 0;
            this.BtnClientesRegistrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtnClientesRegistrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.BtnClientesRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClientesRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClientesRegistrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnClientesRegistrar.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.BtnClientesRegistrar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnClientesRegistrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnClientesRegistrar.IconSize = 32;
            this.BtnClientesRegistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnClientesRegistrar.Location = new System.Drawing.Point(0, 0);
            this.BtnClientesRegistrar.Name = "BtnClientesRegistrar";
            this.BtnClientesRegistrar.Size = new System.Drawing.Size(154, 57);
            this.BtnClientesRegistrar.TabIndex = 5;
            this.BtnClientesRegistrar.Text = "Registar";
            this.BtnClientesRegistrar.UseCompatibleTextRendering = true;
            this.BtnClientesRegistrar.UseVisualStyleBackColor = false;
            this.BtnClientesRegistrar.Click += new System.EventHandler(this.BtnClientesRegistrar_Click);
            // 
            // BtnInicio
            // 
            this.BtnInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnInicio.FlatAppearance.BorderSize = 0;
            this.BtnInicio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtnInicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.BtnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnInicio.IconChar = FontAwesome.Sharp.IconChar.HomeLg;
            this.BtnInicio.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnInicio.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnInicio.IconSize = 32;
            this.BtnInicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnInicio.Location = new System.Drawing.Point(-4, 80);
            this.BtnInicio.Name = "BtnInicio";
            this.BtnInicio.Size = new System.Drawing.Size(162, 57);
            this.BtnInicio.TabIndex = 0;
            this.BtnInicio.Text = "Inicio";
            this.BtnInicio.UseCompatibleTextRendering = true;
            this.BtnInicio.UseVisualStyleBackColor = true;
            this.BtnInicio.Click += new System.EventHandler(this.BtnInicio_Click);
            // 
            // BtnClientes
            // 
            this.BtnClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.BtnClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClientes.FlatAppearance.BorderSize = 0;
            this.BtnClientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtnClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.BtnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnClientes.IconChar = FontAwesome.Sharp.IconChar.UserGroup;
            this.BtnClientes.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnClientes.IconSize = 32;
            this.BtnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnClientes.Location = new System.Drawing.Point(-3, 332);
            this.BtnClientes.Name = "BtnClientes";
            this.BtnClientes.Size = new System.Drawing.Size(161, 57);
            this.BtnClientes.TabIndex = 4;
            this.BtnClientes.Text = "Clientes";
            this.BtnClientes.UseCompatibleTextRendering = true;
            this.BtnClientes.UseVisualStyleBackColor = false;
            this.BtnClientes.MouseLeave += new System.EventHandler(this.BtnClientes_MouseLeave);
            this.BtnClientes.MouseHover += new System.EventHandler(this.BtnClientes_MouseHover);
            // 
            // BtnVentas
            // 
            this.BtnVentas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnVentas.FlatAppearance.BorderSize = 0;
            this.BtnVentas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtnVentas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.BtnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVentas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnVentas.IconChar = FontAwesome.Sharp.IconChar.CartShopping;
            this.BtnVentas.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnVentas.IconSize = 32;
            this.BtnVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnVentas.Location = new System.Drawing.Point(-3, 143);
            this.BtnVentas.Name = "BtnVentas";
            this.BtnVentas.Size = new System.Drawing.Size(161, 57);
            this.BtnVentas.TabIndex = 1;
            this.BtnVentas.Text = "Ventas";
            this.BtnVentas.UseCompatibleTextRendering = true;
            this.BtnVentas.UseVisualStyleBackColor = true;
            this.BtnVentas.Click += new System.EventHandler(this.BtnVentas_Click);
            // 
            // BtnHistorial
            // 
            this.BtnHistorial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnHistorial.FlatAppearance.BorderSize = 0;
            this.BtnHistorial.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtnHistorial.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.BtnHistorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHistorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHistorial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnHistorial.IconChar = FontAwesome.Sharp.IconChar.ClockFour;
            this.BtnHistorial.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnHistorial.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnHistorial.IconSize = 32;
            this.BtnHistorial.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnHistorial.Location = new System.Drawing.Point(-3, 269);
            this.BtnHistorial.Name = "BtnHistorial";
            this.BtnHistorial.Size = new System.Drawing.Size(161, 57);
            this.BtnHistorial.TabIndex = 3;
            this.BtnHistorial.Text = "Historial";
            this.BtnHistorial.UseCompatibleTextRendering = true;
            this.BtnHistorial.UseVisualStyleBackColor = true;
            this.BtnHistorial.Click += new System.EventHandler(this.BtnHistorial_Click);
            // 
            // BtnCatalogo
            // 
            this.BtnCatalogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCatalogo.FlatAppearance.BorderSize = 0;
            this.BtnCatalogo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtnCatalogo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.BtnCatalogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCatalogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCatalogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnCatalogo.IconChar = FontAwesome.Sharp.IconChar.Table;
            this.BtnCatalogo.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnCatalogo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnCatalogo.IconSize = 32;
            this.BtnCatalogo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCatalogo.Location = new System.Drawing.Point(-4, 206);
            this.BtnCatalogo.Name = "BtnCatalogo";
            this.BtnCatalogo.Size = new System.Drawing.Size(162, 57);
            this.BtnCatalogo.TabIndex = 2;
            this.BtnCatalogo.Text = "Catálogo";
            this.BtnCatalogo.UseCompatibleTextRendering = true;
            this.BtnCatalogo.UseVisualStyleBackColor = true;
            this.BtnCatalogo.Click += new System.EventHandler(this.BtnCatalogo_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-4, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(162, 74);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // BtnSalir
            // 
            this.BtnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSalir.FlatAppearance.BorderSize = 0;
            this.BtnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnSalir.IconChar = FontAwesome.Sharp.IconChar.SignOut;
            this.BtnSalir.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnSalir.IconSize = 32;
            this.BtnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSalir.Location = new System.Drawing.Point(1243, 5);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(115, 57);
            this.BtnSalir.TabIndex = 4;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // HoraFecha
            // 
            this.HoraFecha.Enabled = true;
            this.HoraFecha.Tick += new System.EventHandler(this.HoraFecha_Tick);
            // 
            // PerfilVendedor_Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.PSubMenuClientes);
            this.Controls.Add(this.BtnClientes);
            this.Controls.Add(this.BtnInicio);
            this.Controls.Add(this.BtnHistorial);
            this.Controls.Add(this.BtnVentas);
            this.Controls.Add(this.BtnCatalogo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.PContenedor);
            this.KeyPreview = true;
            this.Name = "PerfilVendedor_Inicio";
            this.Text = "Vendedor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PerfilVendedor_KeyDown);
            this.PContenedor.ResumeLayout(false);
            this.PContenedor.PerformLayout();
            this.PSubMenuClientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PContenedor;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton BtnSalir;
        private FontAwesome.Sharp.IconButton BtnClientesRegistrar;
        private System.Windows.Forms.Panel PSubMenuClientes;
        private FontAwesome.Sharp.IconButton BtnInicio;
        private FontAwesome.Sharp.IconButton BtnClientes;
        private FontAwesome.Sharp.IconButton BtnVentas;
        private FontAwesome.Sharp.IconButton BtnHistorial;
        private FontAwesome.Sharp.IconButton BtnCatalogo;
        private FontAwesome.Sharp.IconButton BtnVerLista;
        private System.Windows.Forms.Label LblFecha;
        private System.Windows.Forms.Label LblHora;
        private System.Windows.Forms.Timer HoraFecha;
    }
}


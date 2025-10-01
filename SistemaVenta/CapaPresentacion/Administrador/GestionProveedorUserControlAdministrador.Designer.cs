namespace CapaPresentacion.Administrador
{
    partial class GestionProveedorUserControlAdministrador
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
            this.components = new System.ComponentModel.Container();
            this.PFormulario = new System.Windows.Forms.Panel();
            this.BtnCancelar = new FontAwesome.Sharp.IconButton();
            this.BtnLimpiar = new FontAwesome.Sharp.IconButton();
            this.BtnRegistrar = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TTelefono = new System.Windows.Forms.TextBox();
            this.LPrecio = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.LEstado = new System.Windows.Forms.Label();
            this.TNroDocumento = new System.Windows.Forms.TextBox();
            this.LNombre = new System.Windows.Forms.Label();
            this.TRazonSocial = new System.Windows.Forms.TextBox();
            this.LCódigo = new System.Windows.Forms.Label();
            this.LDescripcion = new System.Windows.Forms.Label();
            this.TCorreo = new System.Windows.Forms.TextBox();
            this.LRegistroProducto = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.CNroDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CRazonSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCiudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.PFormulario.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            this.SuspendLayout();
            // 
            // PFormulario
            // 
            this.PFormulario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.PFormulario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PFormulario.Controls.Add(this.BtnCancelar);
            this.PFormulario.Controls.Add(this.BtnLimpiar);
            this.PFormulario.Controls.Add(this.BtnRegistrar);
            this.PFormulario.Controls.Add(this.panel1);
            this.PFormulario.Controls.Add(this.LRegistroProducto);
            this.PFormulario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.PFormulario.Location = new System.Drawing.Point(0, 3);
            this.PFormulario.Name = "PFormulario";
            this.PFormulario.Size = new System.Drawing.Size(522, 624);
            this.PFormulario.TabIndex = 5;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.BtnCancelar.FlatAppearance.BorderSize = 2;
            this.BtnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.BtnCancelar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnCancelar.IconSize = 32;
            this.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCancelar.Location = new System.Drawing.Point(366, 558);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(146, 33);
            this.BtnCancelar.TabIndex = 26;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.BtnLimpiar.FlatAppearance.BorderSize = 2;
            this.BtnLimpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpiar.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.BtnLimpiar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnLimpiar.IconSize = 32;
            this.BtnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnLimpiar.Location = new System.Drawing.Point(192, 558);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(146, 33);
            this.BtnLimpiar.TabIndex = 25;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // BtnRegistrar
            // 
            this.BtnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRegistrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BtnRegistrar.FlatAppearance.BorderSize = 2;
            this.BtnRegistrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnRegistrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.BtnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegistrar.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.BtnRegistrar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnRegistrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnRegistrar.IconSize = 32;
            this.BtnRegistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRegistrar.Location = new System.Drawing.Point(13, 558);
            this.BtnRegistrar.Name = "BtnRegistrar";
            this.BtnRegistrar.Size = new System.Drawing.Size(146, 33);
            this.BtnRegistrar.TabIndex = 24;
            this.BtnRegistrar.Text = "Registrar";
            this.BtnRegistrar.UseVisualStyleBackColor = true;
            this.BtnRegistrar.Click += new System.EventHandler(this.BtnRegistrar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.TTelefono);
            this.panel1.Controls.Add(this.LPrecio);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.LEstado);
            this.panel1.Controls.Add(this.TNroDocumento);
            this.panel1.Controls.Add(this.LNombre);
            this.panel1.Controls.Add(this.TRazonSocial);
            this.panel1.Controls.Add(this.LCódigo);
            this.panel1.Controls.Add(this.LDescripcion);
            this.panel1.Controls.Add(this.TCorreo);
            this.panel1.Location = new System.Drawing.Point(11, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(501, 495);
            this.panel1.TabIndex = 3;
            // 
            // TTelefono
            // 
            this.TTelefono.Location = new System.Drawing.Point(119, 255);
            this.TTelefono.Name = "TTelefono";
            this.TTelefono.Size = new System.Drawing.Size(206, 20);
            this.TTelefono.TabIndex = 24;
            this.TTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TTelefono_KeyPress);
            // 
            // LPrecio
            // 
            this.LPrecio.AutoSize = true;
            this.LPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LPrecio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LPrecio.Location = new System.Drawing.Point(115, 232);
            this.LPrecio.Name = "LPrecio";
            this.LPrecio.Size = new System.Drawing.Size(75, 20);
            this.LPrecio.TabIndex = 23;
            this.LPrecio.Text = "Telefono:";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.comboBox2.Location = new System.Drawing.Point(119, 322);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(206, 21);
            this.comboBox2.TabIndex = 22;
            // 
            // LEstado
            // 
            this.LEstado.AutoSize = true;
            this.LEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LEstado.Location = new System.Drawing.Point(120, 299);
            this.LEstado.Name = "LEstado";
            this.LEstado.Size = new System.Drawing.Size(64, 20);
            this.LEstado.TabIndex = 21;
            this.LEstado.Text = "Estado:";
            // 
            // TNroDocumento
            // 
            this.TNroDocumento.Location = new System.Drawing.Point(119, 54);
            this.TNroDocumento.Name = "TNroDocumento";
            this.TNroDocumento.Size = new System.Drawing.Size(206, 20);
            this.TNroDocumento.TabIndex = 4;
            this.TNroDocumento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TNroDocumento_KeyPress);
            // 
            // LNombre
            // 
            this.LNombre.AutoSize = true;
            this.LNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LNombre.Location = new System.Drawing.Point(115, 100);
            this.LNombre.Name = "LNombre";
            this.LNombre.Size = new System.Drawing.Size(108, 20);
            this.LNombre.TabIndex = 0;
            this.LNombre.Text = "Razón social :";
            // 
            // TRazonSocial
            // 
            this.TRazonSocial.Location = new System.Drawing.Point(119, 123);
            this.TRazonSocial.Name = "TRazonSocial";
            this.TRazonSocial.Size = new System.Drawing.Size(206, 20);
            this.TRazonSocial.TabIndex = 2;
            this.TRazonSocial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TRazonSocial_KeyPress);
            // 
            // LCódigo
            // 
            this.LCódigo.AutoSize = true;
            this.LCódigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCódigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LCódigo.Location = new System.Drawing.Point(115, 31);
            this.LCódigo.Name = "LCódigo";
            this.LCódigo.Size = new System.Drawing.Size(125, 20);
            this.LCódigo.TabIndex = 3;
            this.LCódigo.Text = "Nro Documento:";
            // 
            // LDescripcion
            // 
            this.LDescripcion.AutoSize = true;
            this.LDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDescripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LDescripcion.Location = new System.Drawing.Point(115, 165);
            this.LDescripcion.Name = "LDescripcion";
            this.LDescripcion.Size = new System.Drawing.Size(61, 20);
            this.LDescripcion.TabIndex = 10;
            this.LDescripcion.Text = "Correo:";
            // 
            // TCorreo
            // 
            this.TCorreo.Location = new System.Drawing.Point(119, 188);
            this.TCorreo.Name = "TCorreo";
            this.TCorreo.Size = new System.Drawing.Size(206, 20);
            this.TCorreo.TabIndex = 11;
            this.TCorreo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TCorreo_KeyPress);
            // 
            // LRegistroProducto
            // 
            this.LRegistroProducto.AutoSize = true;
            this.LRegistroProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LRegistroProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LRegistroProducto.Location = new System.Drawing.Point(114, 0);
            this.LRegistroProducto.Name = "LRegistroProducto";
            this.LRegistroProducto.Size = new System.Drawing.Size(328, 39);
            this.LRegistroProducto.TabIndex = 1;
            this.LRegistroProducto.Text = "Registrar Proveedor";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CNroDocumento,
            this.CRazonSocial,
            this.CTelefono,
            this.CCiudad,
            this.CEliminar});
            this.dataGridView2.Location = new System.Drawing.Point(520, 5);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(667, 621);
            this.dataGridView2.TabIndex = 6;
            // 
            // CNroDocumento
            // 
            this.CNroDocumento.HeaderText = "Nro Documento";
            this.CNroDocumento.Name = "CNroDocumento";
            this.CNroDocumento.Width = 140;
            // 
            // CRazonSocial
            // 
            this.CRazonSocial.HeaderText = "Razón Social";
            this.CRazonSocial.Name = "CRazonSocial";
            this.CRazonSocial.Width = 140;
            // 
            // CTelefono
            // 
            this.CTelefono.HeaderText = "Teléfono";
            this.CTelefono.Name = "CTelefono";
            this.CTelefono.Width = 140;
            // 
            // CCiudad
            // 
            this.CCiudad.HeaderText = "Estado";
            this.CCiudad.Name = "CCiudad";
            // 
            // CEliminar
            // 
            this.CEliminar.HeaderText = "Eliminar";
            this.CEliminar.Name = "CEliminar";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // errorProvider4
            // 
            this.errorProvider4.ContainerControl = this;
            // 
            // GestionProveedorUserControlAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.PFormulario);
            this.Name = "GestionProveedorUserControlAdministrador";
            this.Size = new System.Drawing.Size(1190, 660);
            this.PFormulario.ResumeLayout(false);
            this.PFormulario.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PFormulario;
        private FontAwesome.Sharp.IconButton BtnCancelar;
        private FontAwesome.Sharp.IconButton BtnLimpiar;
        private FontAwesome.Sharp.IconButton BtnRegistrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label LEstado;
        private System.Windows.Forms.TextBox TNroDocumento;
        private System.Windows.Forms.Label LNombre;
        private System.Windows.Forms.TextBox TRazonSocial;
        private System.Windows.Forms.Label LCódigo;
        private System.Windows.Forms.Label LRegistroProducto;
        private System.Windows.Forms.TextBox TTelefono;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label LPrecio;
        private System.Windows.Forms.Label LDescripcion;
        private System.Windows.Forms.TextBox TCorreo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNroDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn CRazonSocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn CTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCiudad;
        private System.Windows.Forms.DataGridViewButtonColumn CEliminar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider4;
    }
}

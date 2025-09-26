namespace CapaPresentacion.Administrador
{
    partial class GestionUsuarioUserControlAdministrador
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
            this.PFormulario = new System.Windows.Forms.Panel();
            this.BtnCancelar = new FontAwesome.Sharp.IconButton();
            this.BtnLimpiar = new FontAwesome.Sharp.IconButton();
            this.BtnRegistrar = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CBEstado = new System.Windows.Forms.ComboBox();
            this.LEstado = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TRContrasenia = new System.Windows.Forms.TextBox();
            this.LContraseña = new System.Windows.Forms.Label();
            this.TContrasenia = new System.Windows.Forms.TextBox();
            this.CBPerfil = new System.Windows.Forms.ComboBox();
            this.LPerfil = new System.Windows.Forms.Label();
            this.LCorreo = new System.Windows.Forms.Label();
            this.TCorreo = new System.Windows.Forms.TextBox();
            this.TApellido = new System.Windows.Forms.TextBox();
            this.LNombre = new System.Windows.Forms.Label();
            this.TNombre = new System.Windows.Forms.TextBox();
            this.LApellido = new System.Windows.Forms.Label();
            this.LRegistroUsuario = new System.Windows.Forms.Label();
            this.DGUsuarios = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.PFormulario.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGUsuarios)).BeginInit();
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
            this.PFormulario.Controls.Add(this.LRegistroUsuario);
            this.PFormulario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.PFormulario.Location = new System.Drawing.Point(3, 3);
            this.PFormulario.Name = "PFormulario";
            this.PFormulario.Size = new System.Drawing.Size(522, 624);
            this.PFormulario.TabIndex = 4;
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
            this.panel1.Controls.Add(this.CBEstado);
            this.panel1.Controls.Add(this.LEstado);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.TRContrasenia);
            this.panel1.Controls.Add(this.LContraseña);
            this.panel1.Controls.Add(this.TContrasenia);
            this.panel1.Controls.Add(this.CBPerfil);
            this.panel1.Controls.Add(this.LPerfil);
            this.panel1.Controls.Add(this.LCorreo);
            this.panel1.Controls.Add(this.TCorreo);
            this.panel1.Controls.Add(this.TApellido);
            this.panel1.Controls.Add(this.LNombre);
            this.panel1.Controls.Add(this.TNombre);
            this.panel1.Controls.Add(this.LApellido);
            this.panel1.Location = new System.Drawing.Point(11, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(501, 495);
            this.panel1.TabIndex = 3;
            // 
            // CBEstado
            // 
            this.CBEstado.FormattingEnabled = true;
            this.CBEstado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.CBEstado.Location = new System.Drawing.Point(133, 335);
            this.CBEstado.Name = "CBEstado";
            this.CBEstado.Size = new System.Drawing.Size(206, 21);
            this.CBEstado.TabIndex = 22;
            // 
            // LEstado
            // 
            this.LEstado.AutoSize = true;
            this.LEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LEstado.Location = new System.Drawing.Point(129, 312);
            this.LEstado.Name = "LEstado";
            this.LEstado.Size = new System.Drawing.Size(64, 20);
            this.LEstado.TabIndex = 21;
            this.LEstado.Text = "Estado:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(129, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Repetir Contraseña:";
            // 
            // TRContrasenia
            // 
            this.TRContrasenia.Location = new System.Drawing.Point(133, 290);
            this.TRContrasenia.Name = "TRContrasenia";
            this.TRContrasenia.Size = new System.Drawing.Size(206, 20);
            this.TRContrasenia.TabIndex = 19;
            // 
            // LContraseña
            // 
            this.LContraseña.AutoSize = true;
            this.LContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LContraseña.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LContraseña.Location = new System.Drawing.Point(129, 212);
            this.LContraseña.Name = "LContraseña";
            this.LContraseña.Size = new System.Drawing.Size(96, 20);
            this.LContraseña.TabIndex = 16;
            this.LContraseña.Text = "Contraseña:";
            // 
            // TContrasenia
            // 
            this.TContrasenia.Location = new System.Drawing.Point(133, 235);
            this.TContrasenia.Name = "TContrasenia";
            this.TContrasenia.Size = new System.Drawing.Size(206, 20);
            this.TContrasenia.TabIndex = 17;
            // 
            // CBPerfil
            // 
            this.CBPerfil.FormattingEnabled = true;
            this.CBPerfil.Items.AddRange(new object[] {
            "Administrador",
            "Vendedor",
            "Dueño de negocio"});
            this.CBPerfil.Location = new System.Drawing.Point(133, 138);
            this.CBPerfil.Name = "CBPerfil";
            this.CBPerfil.Size = new System.Drawing.Size(206, 21);
            this.CBPerfil.TabIndex = 15;
            // 
            // LPerfil
            // 
            this.LPerfil.AutoSize = true;
            this.LPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LPerfil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LPerfil.Location = new System.Drawing.Point(129, 115);
            this.LPerfil.Name = "LPerfil";
            this.LPerfil.Size = new System.Drawing.Size(48, 20);
            this.LPerfil.TabIndex = 14;
            this.LPerfil.Text = "Perfil:";
            // 
            // LCorreo
            // 
            this.LCorreo.AutoSize = true;
            this.LCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCorreo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LCorreo.Location = new System.Drawing.Point(129, 162);
            this.LCorreo.Name = "LCorreo";
            this.LCorreo.Size = new System.Drawing.Size(61, 20);
            this.LCorreo.TabIndex = 12;
            this.LCorreo.Text = "Correo:";
            // 
            // TCorreo
            // 
            this.TCorreo.Location = new System.Drawing.Point(133, 185);
            this.TCorreo.Name = "TCorreo";
            this.TCorreo.Size = new System.Drawing.Size(206, 20);
            this.TCorreo.TabIndex = 13;
            // 
            // TApellido
            // 
            this.TApellido.Location = new System.Drawing.Point(133, 84);
            this.TApellido.Name = "TApellido";
            this.TApellido.Size = new System.Drawing.Size(206, 20);
            this.TApellido.TabIndex = 4;
            // 
            // LNombre
            // 
            this.LNombre.AutoSize = true;
            this.LNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LNombre.Location = new System.Drawing.Point(129, 15);
            this.LNombre.Name = "LNombre";
            this.LNombre.Size = new System.Drawing.Size(69, 20);
            this.LNombre.TabIndex = 0;
            this.LNombre.Text = "Nombre:";
            // 
            // TNombre
            // 
            this.TNombre.Location = new System.Drawing.Point(133, 38);
            this.TNombre.Name = "TNombre";
            this.TNombre.Size = new System.Drawing.Size(206, 20);
            this.TNombre.TabIndex = 2;
            // 
            // LApellido
            // 
            this.LApellido.AutoSize = true;
            this.LApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LApellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LApellido.Location = new System.Drawing.Point(129, 61);
            this.LApellido.Name = "LApellido";
            this.LApellido.Size = new System.Drawing.Size(69, 20);
            this.LApellido.TabIndex = 3;
            this.LApellido.Text = "Apellido:";
            // 
            // LRegistroUsuario
            // 
            this.LRegistroUsuario.AutoSize = true;
            this.LRegistroUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LRegistroUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LRegistroUsuario.Location = new System.Drawing.Point(114, 0);
            this.LRegistroUsuario.Name = "LRegistroUsuario";
            this.LRegistroUsuario.Size = new System.Drawing.Size(288, 39);
            this.LRegistroUsuario.TabIndex = 1;
            this.LRegistroUsuario.Text = "Registrar Usuario";
            // 
            // DGUsuarios
            // 
            this.DGUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar});
            this.DGUsuarios.Location = new System.Drawing.Point(523, 6);
            this.DGUsuarios.Name = "DGUsuarios";
            this.DGUsuarios.Size = new System.Drawing.Size(651, 621);
            this.DGUsuarios.TabIndex = 6;
            this.DGUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGUsuarios_CellClick);
            this.DGUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGUsuarios_CellContentClick);
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Eliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // GestionUsuarioUserControlAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DGUsuarios);
            this.Controls.Add(this.PFormulario);
            this.Name = "GestionUsuarioUserControlAdministrador";
            this.Size = new System.Drawing.Size(1190, 660);
            this.PFormulario.ResumeLayout(false);
            this.PFormulario.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PFormulario;
        private FontAwesome.Sharp.IconButton BtnCancelar;
        private FontAwesome.Sharp.IconButton BtnLimpiar;
        private FontAwesome.Sharp.IconButton BtnRegistrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TApellido;
        private System.Windows.Forms.Label LNombre;
        private System.Windows.Forms.TextBox TNombre;
        private System.Windows.Forms.Label LApellido;
        private System.Windows.Forms.Label LRegistroUsuario;
        private System.Windows.Forms.DataGridView DGUsuarios;
        private System.Windows.Forms.Label LPerfil;
        private System.Windows.Forms.Label LCorreo;
        private System.Windows.Forms.TextBox TCorreo;
        private System.Windows.Forms.Label LContraseña;
        private System.Windows.Forms.TextBox TContrasenia;
        private System.Windows.Forms.ComboBox CBPerfil;
        private System.Windows.Forms.ComboBox CBEstado;
        private System.Windows.Forms.Label LEstado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TRContrasenia;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
    }
}

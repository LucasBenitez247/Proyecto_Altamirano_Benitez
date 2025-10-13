namespace CapaPresentacion.Vendedor
{
    partial class RegistrarClienteUserControl
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
            this.CBEstado = new System.Windows.Forms.ComboBox();
            this.LEstado = new System.Windows.Forms.Label();
            this.RBOtro = new System.Windows.Forms.RadioButton();
            this.RBFemenino = new System.Windows.Forms.RadioButton();
            this.RBMasculino = new System.Windows.Forms.RadioButton();
            this.TProvincia = new System.Windows.Forms.TextBox();
            this.TApellido = new System.Windows.Forms.TextBox();
            this.LCodigoPostal = new System.Windows.Forms.Label();
            this.LProvincia = new System.Windows.Forms.Label();
            this.LNombre = new System.Windows.Forms.Label();
            this.TCodigoPostal = new System.Windows.Forms.TextBox();
            this.TCalleNro = new System.Windows.Forms.TextBox();
            this.TNombre = new System.Windows.Forms.TextBox();
            this.LCiudad = new System.Windows.Forms.Label();
            this.LCalleNro = new System.Windows.Forms.Label();
            this.LApellido = new System.Windows.Forms.Label();
            this.TCiudad = new System.Windows.Forms.TextBox();
            this.LGenero = new System.Windows.Forms.Label();
            this.LDireccionCompleta = new System.Windows.Forms.Label();
            this.LInformacionPersonal = new System.Windows.Forms.Label();
            this.LInformacionContacto = new System.Windows.Forms.Label();
            this.TCorreo = new System.Windows.Forms.TextBox();
            this.LTelefono = new System.Windows.Forms.Label();
            this.LDni = new System.Windows.Forms.Label();
            this.LCorreo = new System.Windows.Forms.Label();
            this.TTelefono = new System.Windows.Forms.TextBox();
            this.TDni = new System.Windows.Forms.TextBox();
            this.LRegistroCliente = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider5 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider6 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider7 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider8 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider9 = new System.Windows.Forms.ErrorProvider(this.components);
            this.PFormulario.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider9)).BeginInit();
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
            this.PFormulario.Controls.Add(this.LRegistroCliente);
            this.PFormulario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.PFormulario.Location = new System.Drawing.Point(3, 0);
            this.PFormulario.Name = "PFormulario";
            this.PFormulario.Size = new System.Drawing.Size(522, 624);
            this.PFormulario.TabIndex = 3;
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
            this.BtnCancelar.Text = "Eliminar";
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
            this.panel1.Controls.Add(this.RBOtro);
            this.panel1.Controls.Add(this.RBFemenino);
            this.panel1.Controls.Add(this.RBMasculino);
            this.panel1.Controls.Add(this.TProvincia);
            this.panel1.Controls.Add(this.TApellido);
            this.panel1.Controls.Add(this.LCodigoPostal);
            this.panel1.Controls.Add(this.LProvincia);
            this.panel1.Controls.Add(this.LNombre);
            this.panel1.Controls.Add(this.TCodigoPostal);
            this.panel1.Controls.Add(this.TCalleNro);
            this.panel1.Controls.Add(this.TNombre);
            this.panel1.Controls.Add(this.LCiudad);
            this.panel1.Controls.Add(this.LCalleNro);
            this.panel1.Controls.Add(this.LApellido);
            this.panel1.Controls.Add(this.TCiudad);
            this.panel1.Controls.Add(this.LGenero);
            this.panel1.Controls.Add(this.LDireccionCompleta);
            this.panel1.Controls.Add(this.LInformacionPersonal);
            this.panel1.Controls.Add(this.LInformacionContacto);
            this.panel1.Controls.Add(this.TCorreo);
            this.panel1.Controls.Add(this.LTelefono);
            this.panel1.Controls.Add(this.LDni);
            this.panel1.Controls.Add(this.LCorreo);
            this.panel1.Controls.Add(this.TTelefono);
            this.panel1.Controls.Add(this.TDni);
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
            this.CBEstado.Location = new System.Drawing.Point(13, 439);
            this.CBEstado.Name = "CBEstado";
            this.CBEstado.Size = new System.Drawing.Size(206, 21);
            this.CBEstado.TabIndex = 24;
            // 
            // LEstado
            // 
            this.LEstado.AutoSize = true;
            this.LEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LEstado.Location = new System.Drawing.Point(9, 416);
            this.LEstado.Name = "LEstado";
            this.LEstado.Size = new System.Drawing.Size(71, 20);
            this.LEstado.TabIndex = 23;
            this.LEstado.Text = "Estado:";
            // 
            // RBOtro
            // 
            this.RBOtro.AutoSize = true;
            this.RBOtro.Location = new System.Drawing.Point(99, 183);
            this.RBOtro.Name = "RBOtro";
            this.RBOtro.Size = new System.Drawing.Size(45, 17);
            this.RBOtro.TabIndex = 22;
            this.RBOtro.TabStop = true;
            this.RBOtro.Text = "Otro";
            this.RBOtro.UseVisualStyleBackColor = true;
            // 
            // RBFemenino
            // 
            this.RBFemenino.AutoSize = true;
            this.RBFemenino.Location = new System.Drawing.Point(99, 160);
            this.RBFemenino.Name = "RBFemenino";
            this.RBFemenino.Size = new System.Drawing.Size(71, 17);
            this.RBFemenino.TabIndex = 21;
            this.RBFemenino.TabStop = true;
            this.RBFemenino.Text = "Femenino";
            this.RBFemenino.UseVisualStyleBackColor = true;
            // 
            // RBMasculino
            // 
            this.RBMasculino.AutoSize = true;
            this.RBMasculino.Location = new System.Drawing.Point(99, 137);
            this.RBMasculino.Name = "RBMasculino";
            this.RBMasculino.Size = new System.Drawing.Size(73, 17);
            this.RBMasculino.TabIndex = 20;
            this.RBMasculino.TabStop = true;
            this.RBMasculino.Text = "Masculino";
            this.RBMasculino.UseVisualStyleBackColor = true;
            // 
            // TProvincia
            // 
            this.TProvincia.Location = new System.Drawing.Point(286, 382);
            this.TProvincia.Name = "TProvincia";
            this.TProvincia.Size = new System.Drawing.Size(198, 20);
            this.TProvincia.TabIndex = 17;
            this.TProvincia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TProvincia_KeyPress);
            // 
            // TApellido
            // 
            this.TApellido.Location = new System.Drawing.Point(327, 50);
            this.TApellido.Name = "TApellido";
            this.TApellido.Size = new System.Drawing.Size(146, 20);
            this.TApellido.TabIndex = 4;
            this.TApellido.TextChanged += new System.EventHandler(this.TApellido_TextChanged);
            this.TApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TApellido_KeyPress);
            // 
            // LCodigoPostal
            // 
            this.LCodigoPostal.AutoSize = true;
            this.LCodigoPostal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCodigoPostal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LCodigoPostal.Location = new System.Drawing.Point(282, 417);
            this.LCodigoPostal.Name = "LCodigoPostal";
            this.LCodigoPostal.Size = new System.Drawing.Size(111, 20);
            this.LCodigoPostal.TabIndex = 18;
            this.LCodigoPostal.Text = "Código Postal:";
            // 
            // LProvincia
            // 
            this.LProvincia.AutoSize = true;
            this.LProvincia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LProvincia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LProvincia.Location = new System.Drawing.Point(282, 359);
            this.LProvincia.Name = "LProvincia";
            this.LProvincia.Size = new System.Drawing.Size(76, 20);
            this.LProvincia.TabIndex = 16;
            this.LProvincia.Text = "Provincia:";
            // 
            // LNombre
            // 
            this.LNombre.AutoSize = true;
            this.LNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LNombre.Location = new System.Drawing.Point(12, 50);
            this.LNombre.Name = "LNombre";
            this.LNombre.Size = new System.Drawing.Size(69, 20);
            this.LNombre.TabIndex = 0;
            this.LNombre.Text = "Nombre:";
            // 
            // TCodigoPostal
            // 
            this.TCodigoPostal.Location = new System.Drawing.Point(286, 440);
            this.TCodigoPostal.Name = "TCodigoPostal";
            this.TCodigoPostal.Size = new System.Drawing.Size(198, 20);
            this.TCodigoPostal.TabIndex = 19;
            this.TCodigoPostal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TCodigoPostal_KeyPress);
            // 
            // TCalleNro
            // 
            this.TCalleNro.Location = new System.Drawing.Point(286, 276);
            this.TCalleNro.Name = "TCalleNro";
            this.TCalleNro.Size = new System.Drawing.Size(198, 20);
            this.TCalleNro.TabIndex = 13;
            this.TCalleNro.Leave += new System.EventHandler(this.TCalleNro_Leave);
            // 
            // TNombre
            // 
            this.TNombre.Location = new System.Drawing.Point(91, 52);
            this.TNombre.Name = "TNombre";
            this.TNombre.Size = new System.Drawing.Size(146, 20);
            this.TNombre.TabIndex = 2;
            this.TNombre.TextChanged += new System.EventHandler(this.TNombre_TextChanged);
            this.TNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TNombre_KeyPress);
            // 
            // LCiudad
            // 
            this.LCiudad.AutoSize = true;
            this.LCiudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCiudad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LCiudad.Location = new System.Drawing.Point(282, 311);
            this.LCiudad.Name = "LCiudad";
            this.LCiudad.Size = new System.Drawing.Size(63, 20);
            this.LCiudad.TabIndex = 14;
            this.LCiudad.Text = "Ciudad:";
            // 
            // LCalleNro
            // 
            this.LCalleNro.AutoSize = true;
            this.LCalleNro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCalleNro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LCalleNro.Location = new System.Drawing.Point(282, 253);
            this.LCalleNro.Name = "LCalleNro";
            this.LCalleNro.Size = new System.Drawing.Size(119, 20);
            this.LCalleNro.TabIndex = 12;
            this.LCalleNro.Text = "Calle y Número:";
            // 
            // LApellido
            // 
            this.LApellido.AutoSize = true;
            this.LApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LApellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LApellido.Location = new System.Drawing.Point(252, 52);
            this.LApellido.Name = "LApellido";
            this.LApellido.Size = new System.Drawing.Size(69, 20);
            this.LApellido.TabIndex = 3;
            this.LApellido.Text = "Apellido:";
            // 
            // TCiudad
            // 
            this.TCiudad.Location = new System.Drawing.Point(286, 334);
            this.TCiudad.Name = "TCiudad";
            this.TCiudad.Size = new System.Drawing.Size(198, 20);
            this.TCiudad.TabIndex = 15;
            this.TCiudad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TCiudad_KeyPress);
            // 
            // LGenero
            // 
            this.LGenero.AutoSize = true;
            this.LGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LGenero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LGenero.Location = new System.Drawing.Point(9, 134);
            this.LGenero.Name = "LGenero";
            this.LGenero.Size = new System.Drawing.Size(67, 20);
            this.LGenero.TabIndex = 14;
            this.LGenero.Text = "Genero:";
            // 
            // LDireccionCompleta
            // 
            this.LDireccionCompleta.AutoSize = true;
            this.LDireccionCompleta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDireccionCompleta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LDireccionCompleta.Location = new System.Drawing.Point(282, 215);
            this.LDireccionCompleta.Name = "LDireccionCompleta";
            this.LDireccionCompleta.Size = new System.Drawing.Size(177, 24);
            this.LDireccionCompleta.TabIndex = 11;
            this.LDireccionCompleta.Text = "Dirección completa:";
            // 
            // LInformacionPersonal
            // 
            this.LInformacionPersonal.AutoSize = true;
            this.LInformacionPersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LInformacionPersonal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LInformacionPersonal.Location = new System.Drawing.Point(-4, 11);
            this.LInformacionPersonal.Name = "LInformacionPersonal";
            this.LInformacionPersonal.Size = new System.Drawing.Size(192, 24);
            this.LInformacionPersonal.TabIndex = 9;
            this.LInformacionPersonal.Text = "Información Personal:";
            // 
            // LInformacionContacto
            // 
            this.LInformacionContacto.AutoSize = true;
            this.LInformacionContacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LInformacionContacto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LInformacionContacto.Location = new System.Drawing.Point(3, 215);
            this.LInformacionContacto.Name = "LInformacionContacto";
            this.LInformacionContacto.Size = new System.Drawing.Size(219, 24);
            this.LInformacionContacto.TabIndex = 10;
            this.LInformacionContacto.Text = "Información de Contacto:";
            // 
            // TCorreo
            // 
            this.TCorreo.Location = new System.Drawing.Point(10, 276);
            this.TCorreo.Name = "TCorreo";
            this.TCorreo.Size = new System.Drawing.Size(185, 20);
            this.TCorreo.TabIndex = 6;
            this.TCorreo.Validating += new System.ComponentModel.CancelEventHandler(this.TCorreo_Validating);
            // 
            // LTelefono
            // 
            this.LTelefono.AutoSize = true;
            this.LTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTelefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LTelefono.Location = new System.Drawing.Point(6, 311);
            this.LTelefono.Name = "LTelefono";
            this.LTelefono.Size = new System.Drawing.Size(75, 20);
            this.LTelefono.TabIndex = 7;
            this.LTelefono.Text = "Teléfono:";
            // 
            // LDni
            // 
            this.LDni.AutoSize = true;
            this.LDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDni.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LDni.Location = new System.Drawing.Point(34, 87);
            this.LDni.Name = "LDni";
            this.LDni.Size = new System.Drawing.Size(41, 20);
            this.LDni.TabIndex = 10;
            this.LDni.Text = "DNI:";
            // 
            // LCorreo
            // 
            this.LCorreo.AutoSize = true;
            this.LCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCorreo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LCorreo.Location = new System.Drawing.Point(6, 253);
            this.LCorreo.Name = "LCorreo";
            this.LCorreo.Size = new System.Drawing.Size(61, 20);
            this.LCorreo.TabIndex = 5;
            this.LCorreo.Text = "Correo:";
            // 
            // TTelefono
            // 
            this.TTelefono.Location = new System.Drawing.Point(10, 334);
            this.TTelefono.Name = "TTelefono";
            this.TTelefono.Size = new System.Drawing.Size(185, 20);
            this.TTelefono.TabIndex = 8;
            this.TTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TTelefono_KeyPress);
            // 
            // TDni
            // 
            this.TDni.Location = new System.Drawing.Point(91, 89);
            this.TDni.Name = "TDni";
            this.TDni.Size = new System.Drawing.Size(146, 20);
            this.TDni.TabIndex = 11;
            this.TDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TDni_KeyPress);
            // 
            // LRegistroCliente
            // 
            this.LRegistroCliente.AutoSize = true;
            this.LRegistroCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LRegistroCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LRegistroCliente.Location = new System.Drawing.Point(114, 0);
            this.LRegistroCliente.Name = "LRegistroCliente";
            this.LRegistroCliente.Size = new System.Drawing.Size(276, 39);
            this.LRegistroCliente.TabIndex = 1;
            this.LRegistroCliente.Text = "Registrar Cliente";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(531, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(648, 621);
            this.dataGridView1.TabIndex = 4;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(528, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(651, 621);
            this.dataGridView2.TabIndex = 5;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
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
            // errorProvider5
            // 
            this.errorProvider5.ContainerControl = this;
            // 
            // errorProvider6
            // 
            this.errorProvider6.ContainerControl = this;
            // 
            // errorProvider7
            // 
            this.errorProvider7.ContainerControl = this;
            // 
            // errorProvider8
            // 
            this.errorProvider8.ContainerControl = this;
            // 
            // errorProvider9
            // 
            this.errorProvider9.ContainerControl = this;
            // 
            // RegistrarClienteUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.PFormulario);
            this.Name = "RegistrarClienteUserControl";
            this.Size = new System.Drawing.Size(1182, 660);
            this.PFormulario.ResumeLayout(false);
            this.PFormulario.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider9)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PFormulario;
        private System.Windows.Forms.TextBox TProvincia;
        private System.Windows.Forms.Label LCodigoPostal;
        private System.Windows.Forms.Label LProvincia;
        private System.Windows.Forms.TextBox TCodigoPostal;
        private System.Windows.Forms.TextBox TCalleNro;
        private System.Windows.Forms.Label LCiudad;
        private System.Windows.Forms.Label LCalleNro;
        private System.Windows.Forms.TextBox TCiudad;
        private System.Windows.Forms.Label LDireccionCompleta;
        private System.Windows.Forms.Label LInformacionContacto;
        private System.Windows.Forms.TextBox TCorreo;
        private System.Windows.Forms.Label LTelefono;
        private System.Windows.Forms.Label LCorreo;
        private System.Windows.Forms.TextBox TTelefono;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TApellido;
        private System.Windows.Forms.Label LNombre;
        private System.Windows.Forms.TextBox TNombre;
        private System.Windows.Forms.Label LApellido;
        private System.Windows.Forms.Label LGenero;
        private System.Windows.Forms.Label LInformacionPersonal;
        private System.Windows.Forms.Label LDni;
        private System.Windows.Forms.TextBox TDni;
        private System.Windows.Forms.Label LRegistroCliente;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.RadioButton RBOtro;
        private System.Windows.Forms.RadioButton RBFemenino;
        private System.Windows.Forms.RadioButton RBMasculino;
        private FontAwesome.Sharp.IconButton BtnRegistrar;
        private FontAwesome.Sharp.IconButton BtnCancelar;
        private FontAwesome.Sharp.IconButton BtnLimpiar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider4;
        private System.Windows.Forms.ErrorProvider errorProvider5;
        private System.Windows.Forms.ErrorProvider errorProvider6;
        private System.Windows.Forms.ErrorProvider errorProvider7;
        private System.Windows.Forms.ErrorProvider errorProvider8;
        private System.Windows.Forms.ErrorProvider errorProvider9;
        private System.Windows.Forms.ComboBox CBEstado;
        private System.Windows.Forms.Label LEstado;
    }
}

namespace CapaPresentacion.Administrador
{
    partial class AgregarNuevaCompra
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.LRegistrarComprar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TNroOrden = new System.Windows.Forms.TextBox();
            this.TProveedor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.IBtnBuscarProveedores = new FontAwesome.Sharp.IconButton();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnBuscarCodProducto = new FontAwesome.Sharp.IconButton();
            this.TCodProducto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TProducto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TPrecioCompra = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TPrecioVenta = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.NUDCantidad = new System.Windows.Forms.NumericUpDown();
            this.dgvCompras = new System.Windows.Forms.DataGridView();
            this.TTotalPagar = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.BtnRegistrar = new FontAwesome.Sharp.IconButton();
            this.btnAgregar = new FontAwesome.Sharp.IconButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.idProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPrecioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CSubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.NUDCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // LRegistrarComprar
            // 
            this.LRegistrarComprar.AutoSize = true;
            this.LRegistrarComprar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LRegistrarComprar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LRegistrarComprar.Location = new System.Drawing.Point(12, 9);
            this.LRegistrarComprar.Name = "LRegistrarComprar";
            this.LRegistrarComprar.Size = new System.Drawing.Size(237, 31);
            this.LRegistrarComprar.TabIndex = 0;
            this.LRegistrarComprar.Text = "Registrar Comprar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(48, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nro de Orden";
            // 
            // TNroOrden
            // 
            this.TNroOrden.Location = new System.Drawing.Point(52, 111);
            this.TNroOrden.Name = "TNroOrden";
            this.TNroOrden.Size = new System.Drawing.Size(100, 20);
            this.TNroOrden.TabIndex = 2;
            this.TNroOrden.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TNroOrden_KeyPress);
            this.TNroOrden.Validating += new System.ComponentModel.CancelEventHandler(this.TNroOrden_Validating);
            // 
            // TProveedor
            // 
            this.TProveedor.Location = new System.Drawing.Point(226, 111);
            this.TProveedor.Name = "TProveedor";
            this.TProveedor.ReadOnly = true;
            this.TProveedor.Size = new System.Drawing.Size(108, 20);
            this.TProveedor.TabIndex = 4;
            this.TProveedor.Validating += new System.ComponentModel.CancelEventHandler(this.TProveedor_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(222, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Proveedor";
            // 
            // IBtnBuscarProveedores
            // 
            this.IBtnBuscarProveedores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.IBtnBuscarProveedores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IBtnBuscarProveedores.FlatAppearance.BorderSize = 0;
            this.IBtnBuscarProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IBtnBuscarProveedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.IBtnBuscarProveedores.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.IBtnBuscarProveedores.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.IBtnBuscarProveedores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IBtnBuscarProveedores.IconSize = 32;
            this.IBtnBuscarProveedores.Location = new System.Drawing.Point(340, 108);
            this.IBtnBuscarProveedores.Name = "IBtnBuscarProveedores";
            this.IBtnBuscarProveedores.Size = new System.Drawing.Size(24, 25);
            this.IBtnBuscarProveedores.TabIndex = 5;
            this.IBtnBuscarProveedores.UseVisualStyleBackColor = false;
            this.IBtnBuscarProveedores.Click += new System.EventHandler(this.IBtnBuscarProveedores_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.Location = new System.Drawing.Point(426, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Fecha";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(430, 113);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(199, 20);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label4.Location = new System.Drawing.Point(36, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Información de la compra";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label5.Location = new System.Drawing.Point(36, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(183, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Información de Producto";
            // 
            // BtnBuscarCodProducto
            // 
            this.BtnBuscarCodProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.BtnBuscarCodProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBuscarCodProducto.FlatAppearance.BorderSize = 0;
            this.BtnBuscarCodProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscarCodProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.BtnBuscarCodProducto.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.BtnBuscarCodProducto.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnBuscarCodProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnBuscarCodProducto.IconSize = 32;
            this.BtnBuscarCodProducto.Location = new System.Drawing.Point(200, 224);
            this.BtnBuscarCodProducto.Name = "BtnBuscarCodProducto";
            this.BtnBuscarCodProducto.Size = new System.Drawing.Size(24, 25);
            this.BtnBuscarCodProducto.TabIndex = 12;
            this.BtnBuscarCodProducto.UseVisualStyleBackColor = false;
            this.BtnBuscarCodProducto.Click += new System.EventHandler(this.BtnBuscarCodProducto_Click);
            // 
            // TCodProducto
            // 
            this.TCodProducto.Location = new System.Drawing.Point(52, 228);
            this.TCodProducto.Name = "TCodProducto";
            this.TCodProducto.ReadOnly = true;
            this.TCodProducto.Size = new System.Drawing.Size(137, 20);
            this.TCodProducto.TabIndex = 11;
            this.TCodProducto.Validating += new System.ComponentModel.CancelEventHandler(this.TCodProducto_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label6.Location = new System.Drawing.Point(48, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Cod. Producto";
            // 
            // TProducto
            // 
            this.TProducto.Location = new System.Drawing.Point(243, 228);
            this.TProducto.Name = "TProducto";
            this.TProducto.ReadOnly = true;
            this.TProducto.Size = new System.Drawing.Size(137, 20);
            this.TProducto.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label7.Location = new System.Drawing.Point(239, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Producto";
            // 
            // TPrecioCompra
            // 
            this.TPrecioCompra.Location = new System.Drawing.Point(419, 229);
            this.TPrecioCompra.Name = "TPrecioCompra";
            this.TPrecioCompra.Size = new System.Drawing.Size(100, 20);
            this.TPrecioCompra.TabIndex = 16;
            this.TPrecioCompra.TextChanged += new System.EventHandler(this.TPrecioCompra_TextChanged);
            this.TPrecioCompra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TPrecioCompra_KeyPress);
            this.TPrecioCompra.Leave += new System.EventHandler(this.TPrecioCompra_Leave);
            this.TPrecioCompra.Validating += new System.ComponentModel.CancelEventHandler(this.TPrecioCompra_Validating);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label8.Location = new System.Drawing.Point(415, 206);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Prec. Compra";
            // 
            // TPrecioVenta
            // 
            this.TPrecioVenta.Location = new System.Drawing.Point(565, 229);
            this.TPrecioVenta.Name = "TPrecioVenta";
            this.TPrecioVenta.Size = new System.Drawing.Size(100, 20);
            this.TPrecioVenta.TabIndex = 18;
            this.TPrecioVenta.TextChanged += new System.EventHandler(this.TPrecioVenta_TextChanged);
            this.TPrecioVenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TPrecioVenta_KeyPress);
            this.TPrecioVenta.Leave += new System.EventHandler(this.TPrecioVenta_Leave);
            this.TPrecioVenta.Validating += new System.ComponentModel.CancelEventHandler(this.TPrecioVenta_Validating);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label9.Location = new System.Drawing.Point(561, 206);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "Prec. Venta";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label10.Location = new System.Drawing.Point(698, 205);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 20);
            this.label10.TabIndex = 19;
            this.label10.Text = "Cantidad";
            // 
            // NUDCantidad
            // 
            this.NUDCantidad.Location = new System.Drawing.Point(702, 229);
            this.NUDCantidad.Name = "NUDCantidad";
            this.NUDCantidad.Size = new System.Drawing.Size(69, 20);
            this.NUDCantidad.TabIndex = 21;
            // 
            // dgvCompras
            // 
            this.dgvCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProducto,
            this.codProducto,
            this.CProducto,
            this.precioVenta,
            this.CPrecioCompra,
            this.CCantidad,
            this.CSubTotal,
            this.btnEliminar});
            this.dgvCompras.Location = new System.Drawing.Point(52, 267);
            this.dgvCompras.Name = "dgvCompras";
            this.dgvCompras.Size = new System.Drawing.Size(801, 266);
            this.dgvCompras.TabIndex = 22;
            this.dgvCompras.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCompras_CellClick);
            // 
            // TTotalPagar
            // 
            this.TTotalPagar.Location = new System.Drawing.Point(891, 464);
            this.TTotalPagar.Name = "TTotalPagar";
            this.TTotalPagar.ReadOnly = true;
            this.TTotalPagar.Size = new System.Drawing.Size(114, 20);
            this.TTotalPagar.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label11.Location = new System.Drawing.Point(887, 432);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 20);
            this.label11.TabIndex = 23;
            this.label11.Text = "Total:";
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
            this.BtnRegistrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnRegistrar.IconChar = FontAwesome.Sharp.IconChar.Tag;
            this.BtnRegistrar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnRegistrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnRegistrar.IconSize = 32;
            this.BtnRegistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRegistrar.Location = new System.Drawing.Point(891, 514);
            this.BtnRegistrar.Name = "BtnRegistrar";
            this.BtnRegistrar.Size = new System.Drawing.Size(114, 33);
            this.BtnRegistrar.TabIndex = 25;
            this.BtnRegistrar.Text = "Registrar";
            this.BtnRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnRegistrar.UseVisualStyleBackColor = true;
            this.BtnRegistrar.Click += new System.EventHandler(this.BtnRegistrar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnAgregar.FlatAppearance.BorderSize = 2;
            this.btnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAgregar.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAgregar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregar.IconSize = 32;
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(891, 217);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(114, 33);
            this.btnAgregar.TabIndex = 26;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // idProducto
            // 
            this.idProducto.HeaderText = "ID Producto";
            this.idProducto.Name = "idProducto";
            this.idProducto.Visible = false;
            // 
            // codProducto
            // 
            this.codProducto.HeaderText = "Cod. Producto";
            this.codProducto.Name = "codProducto";
            // 
            // CProducto
            // 
            this.CProducto.HeaderText = "Producto";
            this.CProducto.Name = "CProducto";
            this.CProducto.Width = 170;
            // 
            // precioVenta
            // 
            this.precioVenta.HeaderText = "Precio Venta";
            this.precioVenta.Name = "precioVenta";
            this.precioVenta.Visible = false;
            // 
            // CPrecioCompra
            // 
            this.CPrecioCompra.HeaderText = "Precio Compra";
            this.CPrecioCompra.Name = "CPrecioCompra";
            this.CPrecioCompra.Width = 170;
            // 
            // CCantidad
            // 
            this.CCantidad.HeaderText = "Cantidad";
            this.CCantidad.Name = "CCantidad";
            this.CCantidad.Width = 160;
            // 
            // CSubTotal
            // 
            this.CSubTotal.HeaderText = "Sub Total";
            this.CSubTotal.Name = "CSubTotal";
            this.CSubTotal.Width = 160;
            // 
            // btnEliminar
            // 
            this.btnEliminar.HeaderText = "Eliminar";
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.ToolTipText = "Eliminar";
            // 
            // AgregarNuevaCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(1042, 575);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.BtnRegistrar);
            this.Controls.Add(this.TTotalPagar);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dgvCompras);
            this.Controls.Add(this.NUDCantidad);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TPrecioVenta);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TPrecioCompra);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TProducto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BtnBuscarCodProducto);
            this.Controls.Add(this.TCodProducto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.IBtnBuscarProveedores);
            this.Controls.Add(this.TProveedor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TNroOrden);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LRegistrarComprar);
            this.Name = "AgregarNuevaCompra";
            this.Text = "AgregarNuevaCompra";
            this.Load += new System.EventHandler(this.AgregarNuevaCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NUDCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LRegistrarComprar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TNroOrden;
        private System.Windows.Forms.TextBox TProveedor;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton IBtnBuscarProveedores;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private FontAwesome.Sharp.IconButton BtnBuscarCodProducto;
        private System.Windows.Forms.TextBox TCodProducto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TProducto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TPrecioCompra;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TPrecioVenta;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown NUDCantidad;
        private System.Windows.Forms.DataGridView dgvCompras;
        private System.Windows.Forms.TextBox TTotalPagar;
        private System.Windows.Forms.Label label11;
        private FontAwesome.Sharp.IconButton BtnRegistrar;
        private FontAwesome.Sharp.IconButton btnAgregar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn codProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn CProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPrecioCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn CSubTotal;
        private System.Windows.Forms.DataGridViewButtonColumn btnEliminar;
    }
}
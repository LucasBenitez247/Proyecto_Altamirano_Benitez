namespace CapaPresentacion.Vendedor
{
    partial class VentasVendedorUserControl
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
            this.CBCategoria = new System.Windows.Forms.ComboBox();
            this.PProductos = new System.Windows.Forms.Panel();
            this.PCarrito = new System.Windows.Forms.Panel();
            this.TTotal = new System.Windows.Forms.TextBox();
            this.BRegistrarVenta = new FontAwesome.Sharp.IconButton();
            this.LTotal = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.LCarrito = new System.Windows.Forms.Label();
            this.PCliente = new System.Windows.Forms.Panel();
            this.PBuscarCliente = new System.Windows.Forms.Panel();
            this.TBuscarCliente = new System.Windows.Forms.TextBox();
            this.IBtnBuscarClientes = new FontAwesome.Sharp.IconButton();
            this.label3 = new System.Windows.Forms.Label();
            this.TDireccion = new System.Windows.Forms.TextBox();
            this.TApellido = new System.Windows.Forms.TextBox();
            this.LNombre = new System.Windows.Forms.Label();
            this.TNombre = new System.Windows.Forms.TextBox();
            this.LApellido = new System.Windows.Forms.Label();
            this.LDni = new System.Windows.Forms.Label();
            this.TDni = new System.Windows.Forms.TextBox();
            this.LCliente = new System.Windows.Forms.Label();
            this.PBuscarProductos = new System.Windows.Forms.Panel();
            this.TBuscarProductos = new System.Windows.Forms.TextBox();
            this.IBtnBuscarProductos = new FontAwesome.Sharp.IconButton();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.CProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPrecioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CSubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NUDCantidad = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.TPrecioVenta = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TProducto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnBuscarCodProducto = new FontAwesome.Sharp.IconButton();
            this.TCodProducto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CSubTotal1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.PProductos.SuspendLayout();
            this.PCarrito.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.PCliente.SuspendLayout();
            this.PBuscarCliente.SuspendLayout();
            this.PBuscarProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // CBCategoria
            // 
            this.CBCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CBCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CBCategoria.FormattingEnabled = true;
            this.CBCategoria.Items.AddRange(new object[] {
            "Remeras",
            "Gorras",
            "Buzos",
            "Autitos"});
            this.CBCategoria.Location = new System.Drawing.Point(39, 68);
            this.CBCategoria.Name = "CBCategoria";
            this.CBCategoria.Size = new System.Drawing.Size(123, 21);
            this.CBCategoria.TabIndex = 2;
            this.CBCategoria.Text = "Categoria";
            // 
            // PProductos
            // 
            this.PProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PProductos.Controls.Add(this.NUDCantidad);
            this.PProductos.Controls.Add(this.label10);
            this.PProductos.Controls.Add(this.TPrecioVenta);
            this.PProductos.Controls.Add(this.label9);
            this.PProductos.Controls.Add(this.TProducto);
            this.PProductos.Controls.Add(this.label7);
            this.PProductos.Controls.Add(this.BtnBuscarCodProducto);
            this.PProductos.Controls.Add(this.TCodProducto);
            this.PProductos.Controls.Add(this.label6);
            this.PProductos.Controls.Add(this.dataGridView2);
            this.PProductos.Location = new System.Drawing.Point(26, 106);
            this.PProductos.Name = "PProductos";
            this.PProductos.Size = new System.Drawing.Size(599, 505);
            this.PProductos.TabIndex = 4;
            // 
            // PCarrito
            // 
            this.PCarrito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PCarrito.Controls.Add(this.TTotal);
            this.PCarrito.Controls.Add(this.BRegistrarVenta);
            this.PCarrito.Controls.Add(this.LTotal);
            this.PCarrito.Controls.Add(this.dataGridView1);
            this.PCarrito.Controls.Add(this.LCarrito);
            this.PCarrito.Location = new System.Drawing.Point(639, 175);
            this.PCarrito.Name = "PCarrito";
            this.PCarrito.Size = new System.Drawing.Size(559, 436);
            this.PCarrito.TabIndex = 5;
            // 
            // TTotal
            // 
            this.TTotal.Location = new System.Drawing.Point(94, 310);
            this.TTotal.Name = "TTotal";
            this.TTotal.Size = new System.Drawing.Size(96, 20);
            this.TTotal.TabIndex = 18;
            // 
            // BRegistrarVenta
            // 
            this.BRegistrarVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BRegistrarVenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BRegistrarVenta.FlatAppearance.BorderSize = 0;
            this.BRegistrarVenta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BRegistrarVenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.BRegistrarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BRegistrarVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BRegistrarVenta.ForeColor = System.Drawing.Color.Silver;
            this.BRegistrarVenta.IconChar = FontAwesome.Sharp.IconChar.CartShopping;
            this.BRegistrarVenta.IconColor = System.Drawing.Color.Silver;
            this.BRegistrarVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BRegistrarVenta.IconSize = 32;
            this.BRegistrarVenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BRegistrarVenta.Location = new System.Drawing.Point(202, 373);
            this.BRegistrarVenta.Name = "BRegistrarVenta";
            this.BRegistrarVenta.Size = new System.Drawing.Size(197, 43);
            this.BRegistrarVenta.TabIndex = 4;
            this.BRegistrarVenta.Text = "Registrar Venta";
            this.BRegistrarVenta.UseVisualStyleBackColor = false;
            this.BRegistrarVenta.Click += new System.EventHandler(this.BRegistrarVenta_Click);
            // 
            // LTotal
            // 
            this.LTotal.AutoSize = true;
            this.LTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTotal.Location = new System.Drawing.Point(16, 310);
            this.LTotal.Name = "LTotal";
            this.LTotal.Size = new System.Drawing.Size(72, 25);
            this.LTotal.TabIndex = 2;
            this.LTotal.Text = "Total:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CNombre,
            this.CCodigo,
            this.CPrecio,
            this.CCantidad,
            this.CSubTotal1,
            this.CEliminar});
            this.dataGridView1.Location = new System.Drawing.Point(3, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(541, 230);
            this.dataGridView1.TabIndex = 1;
            // 
            // LCarrito
            // 
            this.LCarrito.AutoSize = true;
            this.LCarrito.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCarrito.Location = new System.Drawing.Point(3, 0);
            this.LCarrito.Name = "LCarrito";
            this.LCarrito.Size = new System.Drawing.Size(103, 31);
            this.LCarrito.TabIndex = 0;
            this.LCarrito.Text = "Carrito";
            // 
            // PCliente
            // 
            this.PCliente.Controls.Add(this.PBuscarCliente);
            this.PCliente.Controls.Add(this.label3);
            this.PCliente.Controls.Add(this.TDireccion);
            this.PCliente.Controls.Add(this.TApellido);
            this.PCliente.Controls.Add(this.LNombre);
            this.PCliente.Controls.Add(this.TNombre);
            this.PCliente.Controls.Add(this.LApellido);
            this.PCliente.Controls.Add(this.LDni);
            this.PCliente.Controls.Add(this.TDni);
            this.PCliente.Location = new System.Drawing.Point(639, 35);
            this.PCliente.Name = "PCliente";
            this.PCliente.Size = new System.Drawing.Size(559, 137);
            this.PCliente.TabIndex = 6;
            // 
            // PBuscarCliente
            // 
            this.PBuscarCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PBuscarCliente.Controls.Add(this.TBuscarCliente);
            this.PBuscarCliente.Controls.Add(this.IBtnBuscarClientes);
            this.PBuscarCliente.Location = new System.Drawing.Point(7, 3);
            this.PBuscarCliente.Name = "PBuscarCliente";
            this.PBuscarCliente.Size = new System.Drawing.Size(244, 29);
            this.PBuscarCliente.TabIndex = 20;
            // 
            // TBuscarCliente
            // 
            this.TBuscarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TBuscarCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBuscarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBuscarCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TBuscarCliente.Location = new System.Drawing.Point(7, 3);
            this.TBuscarCliente.Name = "TBuscarCliente";
            this.TBuscarCliente.Size = new System.Drawing.Size(193, 19);
            this.TBuscarCliente.TabIndex = 2;
            this.TBuscarCliente.Text = "Buscar Cliente...";
            // 
            // IBtnBuscarClientes
            // 
            this.IBtnBuscarClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.IBtnBuscarClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IBtnBuscarClientes.FlatAppearance.BorderSize = 0;
            this.IBtnBuscarClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IBtnBuscarClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.IBtnBuscarClientes.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.IBtnBuscarClientes.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.IBtnBuscarClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IBtnBuscarClientes.IconSize = 32;
            this.IBtnBuscarClientes.Location = new System.Drawing.Point(206, 2);
            this.IBtnBuscarClientes.Name = "IBtnBuscarClientes";
            this.IBtnBuscarClientes.Size = new System.Drawing.Size(24, 25);
            this.IBtnBuscarClientes.TabIndex = 3;
            this.IBtnBuscarClientes.UseVisualStyleBackColor = false;
            this.IBtnBuscarClientes.Click += new System.EventHandler(this.IBtnBuscarClientes_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.Location = new System.Drawing.Point(268, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Dirección:";
            // 
            // TDireccion
            // 
            this.TDireccion.Location = new System.Drawing.Point(353, 92);
            this.TDireccion.Name = "TDireccion";
            this.TDireccion.Size = new System.Drawing.Size(157, 20);
            this.TDireccion.TabIndex = 19;
            // 
            // TApellido
            // 
            this.TApellido.Location = new System.Drawing.Point(353, 61);
            this.TApellido.Name = "TApellido";
            this.TApellido.Size = new System.Drawing.Size(157, 20);
            this.TApellido.TabIndex = 15;
            // 
            // LNombre
            // 
            this.LNombre.AutoSize = true;
            this.LNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LNombre.Location = new System.Drawing.Point(19, 55);
            this.LNombre.Name = "LNombre";
            this.LNombre.Size = new System.Drawing.Size(69, 20);
            this.LNombre.TabIndex = 12;
            this.LNombre.Text = "Nombre:";
            // 
            // TNombre
            // 
            this.TNombre.Location = new System.Drawing.Point(94, 57);
            this.TNombre.Name = "TNombre";
            this.TNombre.Size = new System.Drawing.Size(157, 20);
            this.TNombre.TabIndex = 13;
            // 
            // LApellido
            // 
            this.LApellido.AutoSize = true;
            this.LApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LApellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LApellido.Location = new System.Drawing.Point(278, 59);
            this.LApellido.Name = "LApellido";
            this.LApellido.Size = new System.Drawing.Size(69, 20);
            this.LApellido.TabIndex = 14;
            this.LApellido.Text = "Apellido:";
            // 
            // LDni
            // 
            this.LDni.AutoSize = true;
            this.LDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDni.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LDni.Location = new System.Drawing.Point(37, 92);
            this.LDni.Name = "LDni";
            this.LDni.Size = new System.Drawing.Size(41, 20);
            this.LDni.TabIndex = 16;
            this.LDni.Text = "DNI:";
            // 
            // TDni
            // 
            this.TDni.Location = new System.Drawing.Point(94, 94);
            this.TDni.Name = "TDni";
            this.TDni.Size = new System.Drawing.Size(157, 20);
            this.TDni.TabIndex = 17;
            // 
            // LCliente
            // 
            this.LCliente.AutoSize = true;
            this.LCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCliente.Location = new System.Drawing.Point(637, 0);
            this.LCliente.Name = "LCliente";
            this.LCliente.Size = new System.Drawing.Size(86, 25);
            this.LCliente.TabIndex = 7;
            this.LCliente.Text = "Cliente";
            // 
            // PBuscarProductos
            // 
            this.PBuscarProductos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PBuscarProductos.Controls.Add(this.TBuscarProductos);
            this.PBuscarProductos.Controls.Add(this.IBtnBuscarProductos);
            this.PBuscarProductos.Location = new System.Drawing.Point(29, 16);
            this.PBuscarProductos.Name = "PBuscarProductos";
            this.PBuscarProductos.Size = new System.Drawing.Size(244, 29);
            this.PBuscarProductos.TabIndex = 8;
            // 
            // TBuscarProductos
            // 
            this.TBuscarProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TBuscarProductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBuscarProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBuscarProductos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TBuscarProductos.Location = new System.Drawing.Point(7, 3);
            this.TBuscarProductos.Name = "TBuscarProductos";
            this.TBuscarProductos.Size = new System.Drawing.Size(193, 19);
            this.TBuscarProductos.TabIndex = 2;
            this.TBuscarProductos.Text = "Buscar productos...";
            // 
            // IBtnBuscarProductos
            // 
            this.IBtnBuscarProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.IBtnBuscarProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IBtnBuscarProductos.FlatAppearance.BorderSize = 0;
            this.IBtnBuscarProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IBtnBuscarProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.IBtnBuscarProductos.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.IBtnBuscarProductos.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.IBtnBuscarProductos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IBtnBuscarProductos.IconSize = 32;
            this.IBtnBuscarProductos.Location = new System.Drawing.Point(206, 2);
            this.IBtnBuscarProductos.Name = "IBtnBuscarProductos";
            this.IBtnBuscarProductos.Size = new System.Drawing.Size(24, 25);
            this.IBtnBuscarProductos.TabIndex = 3;
            this.IBtnBuscarProductos.UseVisualStyleBackColor = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CProducto,
            this.CPrecioCompra,
            this.dataGridViewTextBoxColumn1,
            this.CSubTotal});
            this.dataGridView2.Location = new System.Drawing.Point(3, 101);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(593, 266);
            this.dataGridView2.TabIndex = 23;
            // 
            // CProducto
            // 
            this.CProducto.HeaderText = "Producto";
            this.CProducto.Name = "CProducto";
            // 
            // CPrecioCompra
            // 
            this.CPrecioCompra.HeaderText = "Precio Compra";
            this.CPrecioCompra.Name = "CPrecioCompra";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Cantidad";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // CSubTotal
            // 
            this.CSubTotal.HeaderText = "Sub Total";
            this.CSubTotal.Name = "CSubTotal";
            this.CSubTotal.Width = 160;
            // 
            // NUDCantidad
            // 
            this.NUDCantidad.Location = new System.Drawing.Point(504, 47);
            this.NUDCantidad.Name = "NUDCantidad";
            this.NUDCantidad.Size = new System.Drawing.Size(69, 20);
            this.NUDCantidad.TabIndex = 34;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label10.Location = new System.Drawing.Point(500, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 20);
            this.label10.TabIndex = 33;
            this.label10.Text = "Cantidad";
            // 
            // TPrecioVenta
            // 
            this.TPrecioVenta.Location = new System.Drawing.Point(376, 46);
            this.TPrecioVenta.Name = "TPrecioVenta";
            this.TPrecioVenta.Size = new System.Drawing.Size(100, 20);
            this.TPrecioVenta.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label9.Location = new System.Drawing.Point(372, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 20);
            this.label9.TabIndex = 31;
            this.label9.Text = "Prec. Venta";
            // 
            // TProducto
            // 
            this.TProducto.Location = new System.Drawing.Point(210, 45);
            this.TProducto.Name = "TProducto";
            this.TProducto.Size = new System.Drawing.Size(137, 20);
            this.TProducto.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label7.Location = new System.Drawing.Point(206, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 20);
            this.label7.TabIndex = 27;
            this.label7.Text = "Producto";
            // 
            // BtnBuscarCodProducto
            // 
            this.BtnBuscarCodProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnBuscarCodProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBuscarCodProducto.FlatAppearance.BorderSize = 0;
            this.BtnBuscarCodProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscarCodProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.BtnBuscarCodProducto.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.BtnBuscarCodProducto.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnBuscarCodProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnBuscarCodProducto.IconSize = 32;
            this.BtnBuscarCodProducto.Location = new System.Drawing.Point(154, 41);
            this.BtnBuscarCodProducto.Name = "BtnBuscarCodProducto";
            this.BtnBuscarCodProducto.Size = new System.Drawing.Size(24, 25);
            this.BtnBuscarCodProducto.TabIndex = 26;
            this.BtnBuscarCodProducto.UseVisualStyleBackColor = false;
            // 
            // TCodProducto
            // 
            this.TCodProducto.Location = new System.Drawing.Point(11, 45);
            this.TCodProducto.Name = "TCodProducto";
            this.TCodProducto.Size = new System.Drawing.Size(137, 20);
            this.TCodProducto.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label6.Location = new System.Drawing.Point(7, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 20);
            this.label6.TabIndex = 24;
            this.label6.Text = "Cod. Producto";
            // 
            // CNombre
            // 
            this.CNombre.HeaderText = "Nombre";
            this.CNombre.Name = "CNombre";
            this.CNombre.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CNombre.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // CCodigo
            // 
            this.CCodigo.HeaderText = "Código";
            this.CCodigo.Name = "CCodigo";
            // 
            // CPrecio
            // 
            this.CPrecio.HeaderText = "Precio Unitario";
            this.CPrecio.Name = "CPrecio";
            this.CPrecio.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CPrecio.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // CCantidad
            // 
            this.CCantidad.HeaderText = "Cantidad";
            this.CCantidad.Name = "CCantidad";
            this.CCantidad.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CCantidad.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // CSubTotal1
            // 
            this.CSubTotal1.HeaderText = "Sub-Total";
            this.CSubTotal1.Name = "CSubTotal1";
            // 
            // CEliminar
            // 
            this.CEliminar.HeaderText = "Eliminar";
            this.CEliminar.Name = "CEliminar";
            this.CEliminar.Text = "Eliminar";
            // 
            // VentasVendedorUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.PBuscarProductos);
            this.Controls.Add(this.LCliente);
            this.Controls.Add(this.PCliente);
            this.Controls.Add(this.PCarrito);
            this.Controls.Add(this.PProductos);
            this.Controls.Add(this.CBCategoria);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Name = "VentasVendedorUserControl";
            this.Size = new System.Drawing.Size(1201, 660);
            this.PProductos.ResumeLayout(false);
            this.PProductos.PerformLayout();
            this.PCarrito.ResumeLayout(false);
            this.PCarrito.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.PCliente.ResumeLayout(false);
            this.PCliente.PerformLayout();
            this.PBuscarCliente.ResumeLayout(false);
            this.PBuscarCliente.PerformLayout();
            this.PBuscarProductos.ResumeLayout(false);
            this.PBuscarProductos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox CBCategoria;
        private System.Windows.Forms.Panel PProductos;
        private System.Windows.Forms.Panel PCarrito;
        private System.Windows.Forms.Label LCarrito;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label LTotal;
        private FontAwesome.Sharp.IconButton BRegistrarVenta;
        private System.Windows.Forms.Panel PCliente;
        private System.Windows.Forms.Label LCliente;
        private System.Windows.Forms.TextBox TApellido;
        private System.Windows.Forms.Label LNombre;
        private System.Windows.Forms.TextBox TNombre;
        private System.Windows.Forms.Label LApellido;
        private System.Windows.Forms.Label LDni;
        private System.Windows.Forms.TextBox TDni;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TDireccion;
        private System.Windows.Forms.TextBox TTotal;
        private System.Windows.Forms.Panel PBuscarProductos;
        private System.Windows.Forms.TextBox TBuscarProductos;
        private FontAwesome.Sharp.IconButton IBtnBuscarProductos;
        private System.Windows.Forms.Panel PBuscarCliente;
        private System.Windows.Forms.TextBox TBuscarCliente;
        private FontAwesome.Sharp.IconButton IBtnBuscarClientes;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn CProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPrecioCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CSubTotal;
        private System.Windows.Forms.NumericUpDown NUDCantidad;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TPrecioVenta;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TProducto;
        private System.Windows.Forms.Label label7;
        private FontAwesome.Sharp.IconButton BtnBuscarCodProducto;
        private System.Windows.Forms.TextBox TCodProducto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn CSubTotal1;
        private System.Windows.Forms.DataGridViewButtonColumn CEliminar;
    }
}

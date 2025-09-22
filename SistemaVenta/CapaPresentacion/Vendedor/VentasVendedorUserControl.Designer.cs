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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.CBCategoria = new System.Windows.Forms.ComboBox();
            this.PProductos = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.DWCNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DWCPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DWCStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DWCAgregar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.PCarrito = new System.Windows.Forms.Panel();
            this.TBTotal = new System.Windows.Forms.TextBox();
            this.BRegistrarVenta = new FontAwesome.Sharp.IconButton();
            this.LTotal = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPrecioi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
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
            this.PProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.PCarrito.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.PCliente.SuspendLayout();
            this.PBuscarCliente.SuspendLayout();
            this.PBuscarProductos.SuspendLayout();
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
            this.PProductos.Controls.Add(this.dataGridView2);
            this.PProductos.Location = new System.Drawing.Point(26, 106);
            this.PProductos.Name = "PProductos";
            this.PProductos.Size = new System.Drawing.Size(599, 505);
            this.PProductos.TabIndex = 4;
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DWCNombre,
            this.DWCPrecio,
            this.DWCStock,
            this.DWCAgregar});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView2.GridColor = System.Drawing.Color.Silver;
            this.dataGridView2.Location = new System.Drawing.Point(14, 3);
            this.dataGridView2.Name = "dataGridView2";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView2.Size = new System.Drawing.Size(593, 499);
            this.dataGridView2.TabIndex = 2;
            // 
            // DWCNombre
            // 
            this.DWCNombre.HeaderText = "Nombre";
            this.DWCNombre.Name = "DWCNombre";
            this.DWCNombre.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DWCNombre.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.DWCNombre.Width = 130;
            // 
            // DWCPrecio
            // 
            this.DWCPrecio.HeaderText = "Precio";
            this.DWCPrecio.Name = "DWCPrecio";
            this.DWCPrecio.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DWCPrecio.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.DWCPrecio.Width = 130;
            // 
            // DWCStock
            // 
            this.DWCStock.HeaderText = "Stock";
            this.DWCStock.Name = "DWCStock";
            this.DWCStock.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DWCStock.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.DWCStock.Width = 130;
            // 
            // DWCAgregar
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.DWCAgregar.DefaultCellStyle = dataGridViewCellStyle2;
            this.DWCAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DWCAgregar.HeaderText = "Agregar";
            this.DWCAgregar.Name = "DWCAgregar";
            this.DWCAgregar.Text = "Agregar";
            this.DWCAgregar.UseColumnTextForButtonValue = true;
            this.DWCAgregar.Width = 130;
            // 
            // PCarrito
            // 
            this.PCarrito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PCarrito.Controls.Add(this.TBTotal);
            this.PCarrito.Controls.Add(this.BRegistrarVenta);
            this.PCarrito.Controls.Add(this.LTotal);
            this.PCarrito.Controls.Add(this.dataGridView1);
            this.PCarrito.Controls.Add(this.LCarrito);
            this.PCarrito.Location = new System.Drawing.Point(639, 175);
            this.PCarrito.Name = "PCarrito";
            this.PCarrito.Size = new System.Drawing.Size(559, 436);
            this.PCarrito.TabIndex = 5;
            // 
            // TBTotal
            // 
            this.TBTotal.Location = new System.Drawing.Point(94, 310);
            this.TBTotal.Name = "TBTotal";
            this.TBTotal.Size = new System.Drawing.Size(96, 20);
            this.TBTotal.TabIndex = 18;
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
            this.CPrecioi,
            this.CCantidad,
            this.CEliminar});
            this.dataGridView1.Location = new System.Drawing.Point(3, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(541, 230);
            this.dataGridView1.TabIndex = 1;
            // 
            // CNombre
            // 
            this.CNombre.HeaderText = "Nombre";
            this.CNombre.Name = "CNombre";
            this.CNombre.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CNombre.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // CPrecioi
            // 
            this.CPrecioi.HeaderText = "Precio";
            this.CPrecioi.Name = "CPrecioi";
            this.CPrecioi.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CPrecioi.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // CCantidad
            // 
            this.CCantidad.HeaderText = "Cantidad";
            this.CCantidad.Name = "CCantidad";
            this.CCantidad.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CCantidad.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // CEliminar
            // 
            this.CEliminar.HeaderText = "Eliminar";
            this.CEliminar.Name = "CEliminar";
            this.CEliminar.Text = "Eliminar";
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
            this.Load += new System.EventHandler(this.VentasVendedorUserControl_Load);
            this.PProductos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.PCarrito.ResumeLayout(false);
            this.PCarrito.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.PCliente.ResumeLayout(false);
            this.PCliente.PerformLayout();
            this.PBuscarCliente.ResumeLayout(false);
            this.PBuscarCliente.PerformLayout();
            this.PBuscarProductos.ResumeLayout(false);
            this.PBuscarProductos.PerformLayout();
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
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox TApellido;
        private System.Windows.Forms.Label LNombre;
        private System.Windows.Forms.TextBox TNombre;
        private System.Windows.Forms.Label LApellido;
        private System.Windows.Forms.Label LDni;
        private System.Windows.Forms.TextBox TDni;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TDireccion;
        private System.Windows.Forms.TextBox TBTotal;
        private System.Windows.Forms.Panel PBuscarProductos;
        private System.Windows.Forms.TextBox TBuscarProductos;
        private FontAwesome.Sharp.IconButton IBtnBuscarProductos;
        private System.Windows.Forms.Panel PBuscarCliente;
        private System.Windows.Forms.TextBox TBuscarCliente;
        private FontAwesome.Sharp.IconButton IBtnBuscarClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPrecioi;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCantidad;
        private System.Windows.Forms.DataGridViewButtonColumn CEliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn DWCNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn DWCPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn DWCStock;
        private System.Windows.Forms.DataGridViewButtonColumn DWCAgregar;
    }
}

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
            this.PCliente = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.TDireccion = new System.Windows.Forms.TextBox();
            this.PBuscarCliente = new System.Windows.Forms.Panel();
            this.TBuscarCliente = new System.Windows.Forms.TextBox();
            this.IBtnBuscarClientes = new FontAwesome.Sharp.IconButton();
            this.TApellido = new System.Windows.Forms.TextBox();
            this.LCliente = new System.Windows.Forms.Label();
            this.LNombre = new System.Windows.Forms.Label();
            this.TNombre = new System.Windows.Forms.TextBox();
            this.LApellido = new System.Windows.Forms.Label();
            this.LDni = new System.Windows.Forms.Label();
            this.TDni = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CBTipo_Documento = new System.Windows.Forms.ComboBox();
            this.DTPFecha_venta = new System.Windows.Forms.DateTimePicker();
            this.LFecha = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TCodProducto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TProducto = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TPrecioVenta = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CSubTotal1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label10 = new System.Windows.Forms.Label();
            this.IBtnBuscarProductos = new FontAwesome.Sharp.IconButton();
            this.BRegistrarVenta = new FontAwesome.Sharp.IconButton();
            this.NUDCantidad = new System.Windows.Forms.NumericUpDown();
            this.LTotal = new System.Windows.Forms.Label();
            this.TTotal = new System.Windows.Forms.TextBox();
            this.PProductos = new System.Windows.Forms.Panel();
            this.BtnAgregar = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TCambio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TPagarCon = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PCliente.SuspendLayout();
            this.PBuscarCliente.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDCantidad)).BeginInit();
            this.PProductos.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // PCliente
            // 
            this.PCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.PCliente.Controls.Add(this.label3);
            this.PCliente.Controls.Add(this.TDireccion);
            this.PCliente.Controls.Add(this.PBuscarCliente);
            this.PCliente.Controls.Add(this.TApellido);
            this.PCliente.Controls.Add(this.LCliente);
            this.PCliente.Controls.Add(this.LNombre);
            this.PCliente.Controls.Add(this.TNombre);
            this.PCliente.Controls.Add(this.LApellido);
            this.PCliente.Controls.Add(this.LDni);
            this.PCliente.Controls.Add(this.TDni);
            this.PCliente.Location = new System.Drawing.Point(619, 3);
            this.PCliente.Name = "PCliente";
            this.PCliente.Size = new System.Drawing.Size(568, 126);
            this.PCliente.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.Location = new System.Drawing.Point(265, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Dirección:";
            // 
            // TDireccion
            // 
            this.TDireccion.Location = new System.Drawing.Point(350, 84);
            this.TDireccion.Name = "TDireccion";
            this.TDireccion.Size = new System.Drawing.Size(157, 20);
            this.TDireccion.TabIndex = 19;
            // 
            // PBuscarCliente
            // 
            this.PBuscarCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PBuscarCliente.Controls.Add(this.TBuscarCliente);
            this.PBuscarCliente.Controls.Add(this.IBtnBuscarClientes);
            this.PBuscarCliente.Location = new System.Drawing.Point(297, 4);
            this.PBuscarCliente.Name = "PBuscarCliente";
            this.PBuscarCliente.Size = new System.Drawing.Size(244, 29);
            this.PBuscarCliente.TabIndex = 20;
            // 
            // TBuscarCliente
            // 
            this.TBuscarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
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
            this.IBtnBuscarClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
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
            // TApellido
            // 
            this.TApellido.Location = new System.Drawing.Point(350, 53);
            this.TApellido.Name = "TApellido";
            this.TApellido.Size = new System.Drawing.Size(157, 20);
            this.TApellido.TabIndex = 15;
            // 
            // LCliente
            // 
            this.LCliente.AutoSize = true;
            this.LCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCliente.Location = new System.Drawing.Point(16, 4);
            this.LCliente.Name = "LCliente";
            this.LCliente.Size = new System.Drawing.Size(222, 24);
            this.LCliente.TabIndex = 7;
            this.LCliente.Text = "Informacion del cliente";
            // 
            // LNombre
            // 
            this.LNombre.AutoSize = true;
            this.LNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LNombre.Location = new System.Drawing.Point(16, 47);
            this.LNombre.Name = "LNombre";
            this.LNombre.Size = new System.Drawing.Size(69, 20);
            this.LNombre.TabIndex = 12;
            this.LNombre.Text = "Nombre:";
            // 
            // TNombre
            // 
            this.TNombre.Location = new System.Drawing.Point(91, 49);
            this.TNombre.Name = "TNombre";
            this.TNombre.Size = new System.Drawing.Size(157, 20);
            this.TNombre.TabIndex = 13;
            // 
            // LApellido
            // 
            this.LApellido.AutoSize = true;
            this.LApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LApellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LApellido.Location = new System.Drawing.Point(275, 51);
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
            this.LDni.Location = new System.Drawing.Point(34, 84);
            this.LDni.Name = "LDni";
            this.LDni.Size = new System.Drawing.Size(41, 20);
            this.LDni.TabIndex = 16;
            this.LDni.Text = "DNI:";
            // 
            // TDni
            // 
            this.TDni.Location = new System.Drawing.Point(91, 86);
            this.TDni.Name = "TDni";
            this.TDni.Size = new System.Drawing.Size(157, 20);
            this.TDni.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 24);
            this.label1.TabIndex = 21;
            this.label1.Text = "Informacion del la venta";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panel1.Controls.Add(this.CBTipo_Documento);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.DTPFecha_venta);
            this.panel1.Controls.Add(this.LFecha);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(16, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(597, 126);
            this.panel1.TabIndex = 22;
            // 
            // CBTipo_Documento
            // 
            this.CBTipo_Documento.FormattingEnabled = true;
            this.CBTipo_Documento.Items.AddRange(new object[] {
            "Boleta"});
            this.CBTipo_Documento.Location = new System.Drawing.Point(290, 72);
            this.CBTipo_Documento.Name = "CBTipo_Documento";
            this.CBTipo_Documento.Size = new System.Drawing.Size(195, 21);
            this.CBTipo_Documento.TabIndex = 16;
            // 
            // DTPFecha_venta
            // 
            this.DTPFecha_venta.Location = new System.Drawing.Point(20, 69);
            this.DTPFecha_venta.Name = "DTPFecha_venta";
            this.DTPFecha_venta.Size = new System.Drawing.Size(200, 20);
            this.DTPFecha_venta.TabIndex = 15;
            // 
            // LFecha
            // 
            this.LFecha.AutoSize = true;
            this.LFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LFecha.Location = new System.Drawing.Point(16, 46);
            this.LFecha.Name = "LFecha";
            this.LFecha.Size = new System.Drawing.Size(58, 20);
            this.LFecha.TabIndex = 12;
            this.LFecha.Text = "Fecha:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label5.Location = new System.Drawing.Point(286, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Tipo de Documento:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label6.Location = new System.Drawing.Point(27, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 20);
            this.label6.TabIndex = 24;
            this.label6.Text = "Cod. Producto";
            // 
            // TCodProducto
            // 
            this.TCodProducto.Location = new System.Drawing.Point(31, 51);
            this.TCodProducto.Name = "TCodProducto";
            this.TCodProducto.Size = new System.Drawing.Size(137, 20);
            this.TCodProducto.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label7.Location = new System.Drawing.Point(226, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 20);
            this.label7.TabIndex = 27;
            this.label7.Text = "Producto";
            // 
            // TProducto
            // 
            this.TProducto.Location = new System.Drawing.Point(230, 51);
            this.TProducto.Name = "TProducto";
            this.TProducto.Size = new System.Drawing.Size(137, 20);
            this.TProducto.TabIndex = 28;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label9.Location = new System.Drawing.Point(392, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 20);
            this.label9.TabIndex = 31;
            this.label9.Text = "Prec. Venta";
            // 
            // TPrecioVenta
            // 
            this.TPrecioVenta.Location = new System.Drawing.Point(396, 52);
            this.TPrecioVenta.Name = "TPrecioVenta";
            this.TPrecioVenta.Size = new System.Drawing.Size(100, 20);
            this.TPrecioVenta.TabIndex = 32;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CNombre,
            this.CCodigo,
            this.CPrecio,
            this.CCantidad,
            this.CSubTotal1,
            this.CEliminar});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(26, 121);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(639, 230);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellMouseEnter);
            this.dataGridView1.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellMouseLeave);
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
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label10.Location = new System.Drawing.Point(520, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 20);
            this.label10.TabIndex = 33;
            this.label10.Text = "Cantidad";
            // 
            // IBtnBuscarProductos
            // 
            this.IBtnBuscarProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.IBtnBuscarProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IBtnBuscarProductos.FlatAppearance.BorderSize = 0;
            this.IBtnBuscarProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IBtnBuscarProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.IBtnBuscarProductos.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.IBtnBuscarProductos.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.IBtnBuscarProductos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IBtnBuscarProductos.IconSize = 32;
            this.IBtnBuscarProductos.Location = new System.Drawing.Point(174, 48);
            this.IBtnBuscarProductos.Name = "IBtnBuscarProductos";
            this.IBtnBuscarProductos.Size = new System.Drawing.Size(24, 25);
            this.IBtnBuscarProductos.TabIndex = 3;
            this.IBtnBuscarProductos.UseVisualStyleBackColor = false;
            this.IBtnBuscarProductos.Click += new System.EventHandler(this.IBtnBuscarProductos_Click);
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
            this.BRegistrarVenta.Location = new System.Drawing.Point(63, 398);
            this.BRegistrarVenta.Name = "BRegistrarVenta";
            this.BRegistrarVenta.Size = new System.Drawing.Size(197, 43);
            this.BRegistrarVenta.TabIndex = 4;
            this.BRegistrarVenta.Text = "Registrar Venta";
            this.BRegistrarVenta.UseVisualStyleBackColor = false;
            this.BRegistrarVenta.Click += new System.EventHandler(this.BRegistrarVenta_Click);
            // 
            // NUDCantidad
            // 
            this.NUDCantidad.Location = new System.Drawing.Point(524, 53);
            this.NUDCantidad.Name = "NUDCantidad";
            this.NUDCantidad.Size = new System.Drawing.Size(69, 20);
            this.NUDCantidad.TabIndex = 34;
            // 
            // LTotal
            // 
            this.LTotal.AutoSize = true;
            this.LTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTotal.Location = new System.Drawing.Point(99, 83);
            this.LTotal.Name = "LTotal";
            this.LTotal.Size = new System.Drawing.Size(121, 20);
            this.LTotal.TabIndex = 2;
            this.LTotal.Text = "Total a Pagar:";
            // 
            // TTotal
            // 
            this.TTotal.Location = new System.Drawing.Point(103, 121);
            this.TTotal.Name = "TTotal";
            this.TTotal.Size = new System.Drawing.Size(117, 20);
            this.TTotal.TabIndex = 18;
            // 
            // PProductos
            // 
            this.PProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.PProductos.Controls.Add(this.BtnAgregar);
            this.PProductos.Controls.Add(this.NUDCantidad);
            this.PProductos.Controls.Add(this.IBtnBuscarProductos);
            this.PProductos.Controls.Add(this.label10);
            this.PProductos.Controls.Add(this.dataGridView1);
            this.PProductos.Controls.Add(this.TPrecioVenta);
            this.PProductos.Controls.Add(this.label9);
            this.PProductos.Controls.Add(this.TProducto);
            this.PProductos.Controls.Add(this.label7);
            this.PProductos.Controls.Add(this.TCodProducto);
            this.PProductos.Controls.Add(this.label6);
            this.PProductos.Location = new System.Drawing.Point(16, 135);
            this.PProductos.Name = "PProductos";
            this.PProductos.Size = new System.Drawing.Size(844, 505);
            this.PProductos.TabIndex = 4;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BtnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAgregar.FlatAppearance.BorderSize = 0;
            this.BtnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.ForeColor = System.Drawing.Color.Silver;
            this.BtnAgregar.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.BtnAgregar.IconColor = System.Drawing.Color.Silver;
            this.BtnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnAgregar.IconSize = 32;
            this.BtnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAgregar.Location = new System.Drawing.Point(696, 20);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(122, 53);
            this.BtnAgregar.TabIndex = 35;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panel2.Controls.Add(this.TCambio);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.BRegistrarVenta);
            this.panel2.Controls.Add(this.TPagarCon);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.TTotal);
            this.panel2.Controls.Add(this.LTotal);
            this.panel2.Location = new System.Drawing.Point(866, 135);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(321, 502);
            this.panel2.TabIndex = 23;
            // 
            // TCambio
            // 
            this.TCambio.Location = new System.Drawing.Point(104, 297);
            this.TCambio.Name = "TCambio";
            this.TCambio.Size = new System.Drawing.Size(117, 20);
            this.TCambio.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(100, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Cambio:";
            // 
            // TPagarCon
            // 
            this.TPagarCon.Location = new System.Drawing.Point(103, 208);
            this.TPagarCon.Name = "TPagarCon";
            this.TPagarCon.Size = new System.Drawing.Size(117, 20);
            this.TPagarCon.TabIndex = 20;
            this.TPagarCon.TextChanged += new System.EventHandler(this.TPagarCon_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(99, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = " Pagar con:";
            // 
            // VentasVendedorUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PCliente);
            this.Controls.Add(this.PProductos);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Name = "VentasVendedorUserControl";
            this.Size = new System.Drawing.Size(1201, 660);
            this.Load += new System.EventHandler(this.VentasVendedorUserControl_Load);
            this.PCliente.ResumeLayout(false);
            this.PCliente.PerformLayout();
            this.PBuscarCliente.ResumeLayout(false);
            this.PBuscarCliente.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDCantidad)).EndInit();
            this.PProductos.ResumeLayout(false);
            this.PProductos.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
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
        private System.Windows.Forms.Panel PBuscarCliente;
        private System.Windows.Forms.TextBox TBuscarCliente;
        private FontAwesome.Sharp.IconButton IBtnBuscarClientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LFecha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker DTPFecha_venta;
        private System.Windows.Forms.ComboBox CBTipo_Documento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TCodProducto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TProducto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TPrecioVenta;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn CSubTotal1;
        private System.Windows.Forms.DataGridViewButtonColumn CEliminar;
        private System.Windows.Forms.Label label10;
        private FontAwesome.Sharp.IconButton IBtnBuscarProductos;
        private FontAwesome.Sharp.IconButton BRegistrarVenta;
        private System.Windows.Forms.NumericUpDown NUDCantidad;
        private System.Windows.Forms.Label LTotal;
        private System.Windows.Forms.TextBox TTotal;
        private System.Windows.Forms.Panel PProductos;
        private FontAwesome.Sharp.IconButton BtnAgregar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox TCambio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TPagarCon;
        private System.Windows.Forms.Label label2;
    }
}

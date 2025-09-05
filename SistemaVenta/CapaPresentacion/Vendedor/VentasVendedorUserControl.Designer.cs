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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.DWCImagen = new System.Windows.Forms.DataGridViewImageColumn();
            this.DWCNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DWCPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DWCStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DWCAgregar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.PCarrito = new System.Windows.Forms.Panel();
            this.BRegistrarVenta = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CImagen = new System.Windows.Forms.DataGridViewImageColumn();
            this.CNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPrecioi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.LCarrito = new System.Windows.Forms.Label();
            this.PCliente = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.TApellido = new System.Windows.Forms.TextBox();
            this.LNombre = new System.Windows.Forms.Label();
            this.TNombre = new System.Windows.Forms.TextBox();
            this.LApellido = new System.Windows.Forms.Label();
            this.LDni = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.BtnBuscarCliente = new FontAwesome.Sharp.IconButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TBTotal = new System.Windows.Forms.TextBox();
            this.PBuscarProductos = new System.Windows.Forms.Panel();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.PProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.PCarrito.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.PCliente.SuspendLayout();
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
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DWCImagen,
            this.DWCNombre,
            this.DWCPrecio,
            this.DWCStock,
            this.DWCAgregar});
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(593, 230);
            this.dataGridView2.TabIndex = 2;
            // 
            // DWCImagen
            // 
            this.DWCImagen.HeaderText = "Imagen";
            this.DWCImagen.Name = "DWCImagen";
            // 
            // DWCNombre
            // 
            this.DWCNombre.HeaderText = "Nombre";
            this.DWCNombre.Name = "DWCNombre";
            this.DWCNombre.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DWCNombre.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // DWCPrecio
            // 
            this.DWCPrecio.HeaderText = "Precio";
            this.DWCPrecio.Name = "DWCPrecio";
            this.DWCPrecio.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DWCPrecio.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // DWCStock
            // 
            this.DWCStock.HeaderText = "Stock";
            this.DWCStock.Name = "DWCStock";
            this.DWCStock.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DWCStock.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // DWCAgregar
            // 
            this.DWCAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DWCAgregar.HeaderText = "Agregar";
            this.DWCAgregar.Name = "DWCAgregar";
            this.DWCAgregar.Text = "Agregar";
            this.DWCAgregar.UseColumnTextForButtonValue = true;
            // 
            // PCarrito
            // 
            this.PCarrito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PCarrito.Controls.Add(this.TBTotal);
            this.PCarrito.Controls.Add(this.BRegistrarVenta);
            this.PCarrito.Controls.Add(this.label1);
            this.PCarrito.Controls.Add(this.dataGridView1);
            this.PCarrito.Controls.Add(this.LCarrito);
            this.PCarrito.Location = new System.Drawing.Point(639, 175);
            this.PCarrito.Name = "PCarrito";
            this.PCarrito.Size = new System.Drawing.Size(559, 436);
            this.PCarrito.TabIndex = 5;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 310);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Total:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CImagen,
            this.CNombre,
            this.CPrecioi,
            this.CCantidad,
            this.CEliminar});
            this.dataGridView1.Location = new System.Drawing.Point(3, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(541, 230);
            this.dataGridView1.TabIndex = 1;
            // 
            // CImagen
            // 
            this.CImagen.HeaderText = "Imagen";
            this.CImagen.Name = "CImagen";
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
            this.PCliente.Controls.Add(this.label3);
            this.PCliente.Controls.Add(this.textBox3);
            this.PCliente.Controls.Add(this.TApellido);
            this.PCliente.Controls.Add(this.LNombre);
            this.PCliente.Controls.Add(this.TNombre);
            this.PCliente.Controls.Add(this.LApellido);
            this.PCliente.Controls.Add(this.LDni);
            this.PCliente.Controls.Add(this.textBox2);
            this.PCliente.Controls.Add(this.BtnBuscarCliente);
            this.PCliente.Controls.Add(this.textBox1);
            this.PCliente.Location = new System.Drawing.Point(639, 35);
            this.PCliente.Name = "PCliente";
            this.PCliente.Size = new System.Drawing.Size(559, 137);
            this.PCliente.TabIndex = 6;
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
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(353, 92);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(157, 20);
            this.textBox3.TabIndex = 19;
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
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(94, 94);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(157, 20);
            this.textBox2.TabIndex = 17;
            // 
            // BtnBuscarCliente
            // 
            this.BtnBuscarCliente.BackColor = System.Drawing.Color.Transparent;
            this.BtnBuscarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBuscarCliente.FlatAppearance.BorderSize = 0;
            this.BtnBuscarCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.BtnBuscarCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnBuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.BtnBuscarCliente.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.BtnBuscarCliente.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnBuscarCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnBuscarCliente.IconSize = 32;
            this.BtnBuscarCliente.Location = new System.Drawing.Point(293, 5);
            this.BtnBuscarCliente.Name = "BtnBuscarCliente";
            this.BtnBuscarCliente.Size = new System.Drawing.Size(25, 26);
            this.BtnBuscarCliente.TabIndex = 2;
            this.BtnBuscarCliente.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox1.Location = new System.Drawing.Point(18, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(269, 26);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Ingrese Documento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(637, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Cliente";
            // 
            // TBTotal
            // 
            this.TBTotal.Location = new System.Drawing.Point(94, 310);
            this.TBTotal.Name = "TBTotal";
            this.TBTotal.Size = new System.Drawing.Size(96, 20);
            this.TBTotal.TabIndex = 18;
            // 
            // PBuscarProductos
            // 
            this.PBuscarProductos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PBuscarProductos.Controls.Add(this.textBox4);
            this.PBuscarProductos.Controls.Add(this.iconButton1);
            this.PBuscarProductos.Location = new System.Drawing.Point(39, 21);
            this.PBuscarProductos.Name = "PBuscarProductos";
            this.PBuscarProductos.Size = new System.Drawing.Size(244, 29);
            this.PBuscarProductos.TabIndex = 8;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox4.Location = new System.Drawing.Point(7, 3);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(193, 19);
            this.textBox4.TabIndex = 2;
            this.textBox4.Text = "Buscar productos...";
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.iconButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.iconButton1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 32;
            this.iconButton1.Location = new System.Drawing.Point(206, 2);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(24, 25);
            this.iconButton1.TabIndex = 3;
            this.iconButton1.UseVisualStyleBackColor = false;
            // 
            // VentasVendedorUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.PBuscarProductos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PCliente);
            this.Controls.Add(this.PCarrito);
            this.Controls.Add(this.PProductos);
            this.Controls.Add(this.CBCategoria);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Name = "VentasVendedorUserControl";
            this.Size = new System.Drawing.Size(1201, 660);
            this.PProductos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.PCarrito.ResumeLayout(false);
            this.PCarrito.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.PCliente.ResumeLayout(false);
            this.PCliente.PerformLayout();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewImageColumn CImagen;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPrecioi;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCantidad;
        private System.Windows.Forms.DataGridViewButtonColumn CEliminar;
        private FontAwesome.Sharp.IconButton BRegistrarVenta;
        private System.Windows.Forms.Panel PCliente;
        private FontAwesome.Sharp.IconButton BtnBuscarCliente;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox TApellido;
        private System.Windows.Forms.Label LNombre;
        private System.Windows.Forms.TextBox TNombre;
        private System.Windows.Forms.Label LApellido;
        private System.Windows.Forms.Label LDni;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.DataGridViewImageColumn DWCImagen;
        private System.Windows.Forms.DataGridViewTextBoxColumn DWCNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn DWCPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn DWCStock;
        private System.Windows.Forms.DataGridViewButtonColumn DWCAgregar;
        private System.Windows.Forms.TextBox TBTotal;
        private System.Windows.Forms.Panel PBuscarProductos;
        private System.Windows.Forms.TextBox textBox4;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}

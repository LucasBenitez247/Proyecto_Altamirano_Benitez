namespace CapaPresentacion.Administrador
{
    partial class ComprasUserControlAdministrador
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
            this.LCompras = new System.Windows.Forms.Label();
            this.dgvCompras = new System.Windows.Forms.DataGridView();
            this.BtnNuevaCompra = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.IBtnBuscar = new FontAwesome.Sharp.IconButton();
            this.TBuscar = new System.Windows.Forms.TextBox();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.cboBuscarPor = new System.Windows.Forms.ComboBox();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.FechaFin = new System.Windows.Forms.Label();
            this.LFechaInicio = new System.Windows.Forms.Label();
            this.LbuscarPor = new System.Windows.Forms.Label();
            this.LReporteVentas = new System.Windows.Forms.Label();
            this.CFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPrecioTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCodProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPrecioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompras)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // LCompras
            // 
            this.LCompras.AutoSize = true;
            this.LCompras.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCompras.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LCompras.Location = new System.Drawing.Point(48, 0);
            this.LCompras.Name = "LCompras";
            this.LCompras.Size = new System.Drawing.Size(169, 42);
            this.LCompras.TabIndex = 0;
            this.LCompras.Text = "Compras";
            // 
            // dgvCompras
            // 
            this.dgvCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CFecha,
            this.CCodigo,
            this.cPrecioTotal,
            this.CUsuario,
            this.CProveedor,
            this.cCodProducto,
            this.cNombreProducto,
            this.cCategoria,
            this.cCantidad,
            this.cPrecioCompra});
            this.dgvCompras.Location = new System.Drawing.Point(26, 271);
            this.dgvCompras.Name = "dgvCompras";
            this.dgvCompras.Size = new System.Drawing.Size(1167, 275);
            this.dgvCompras.TabIndex = 1;
            this.dgvCompras.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // BtnNuevaCompra
            // 
            this.BtnNuevaCompra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNuevaCompra.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BtnNuevaCompra.FlatAppearance.BorderSize = 2;
            this.BtnNuevaCompra.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnNuevaCompra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.BtnNuevaCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNuevaCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNuevaCompra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnNuevaCompra.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.BtnNuevaCompra.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnNuevaCompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnNuevaCompra.IconSize = 32;
            this.BtnNuevaCompra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnNuevaCompra.Location = new System.Drawing.Point(905, 89);
            this.BtnNuevaCompra.Name = "BtnNuevaCompra";
            this.BtnNuevaCompra.Size = new System.Drawing.Size(223, 35);
            this.BtnNuevaCompra.TabIndex = 14;
            this.BtnNuevaCompra.Text = "Agregar nueva compra";
            this.BtnNuevaCompra.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnNuevaCompra.UseCompatibleTextRendering = true;
            this.BtnNuevaCompra.UseVisualStyleBackColor = true;
            this.BtnNuevaCompra.Click += new System.EventHandler(this.BtnNuevaCompra_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.panel2.Controls.Add(this.iconButton1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.IBtnBuscar);
            this.panel2.Controls.Add(this.TBuscar);
            this.panel2.Controls.Add(this.dtpFechaInicio);
            this.panel2.Controls.Add(this.cboBuscarPor);
            this.panel2.Controls.Add(this.dtpFechaFin);
            this.panel2.Controls.Add(this.FechaFin);
            this.panel2.Controls.Add(this.dgvCompras);
            this.panel2.Controls.Add(this.LFechaInicio);
            this.panel2.Controls.Add(this.LbuscarPor);
            this.panel2.Controls.Add(this.LReporteVentas);
            this.panel2.Location = new System.Drawing.Point(3, 152);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1243, 782);
            this.panel2.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(264, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Buscar por Fecha:";
            // 
            // IBtnBuscar
            // 
            this.IBtnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IBtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IBtnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IBtnBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.IBtnBuscar.IconChar = FontAwesome.Sharp.IconChar.Sistrix;
            this.IBtnBuscar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.IBtnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IBtnBuscar.IconSize = 24;
            this.IBtnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IBtnBuscar.Location = new System.Drawing.Point(768, 202);
            this.IBtnBuscar.Name = "IBtnBuscar";
            this.IBtnBuscar.Size = new System.Drawing.Size(93, 27);
            this.IBtnBuscar.TabIndex = 6;
            this.IBtnBuscar.Text = "Buscar";
            this.IBtnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.IBtnBuscar.UseVisualStyleBackColor = true;
            this.IBtnBuscar.Click += new System.EventHandler(this.IBtnBuscar_Click);
            // 
            // TBuscar
            // 
            this.TBuscar.Location = new System.Drawing.Point(515, 207);
            this.TBuscar.Name = "TBuscar";
            this.TBuscar.Size = new System.Drawing.Size(212, 20);
            this.TBuscar.TabIndex = 8;
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Location = new System.Drawing.Point(361, 129);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(132, 20);
            this.dtpFechaInicio.TabIndex = 5;
            // 
            // cboBuscarPor
            // 
            this.cboBuscarPor.FormattingEnabled = true;
            this.cboBuscarPor.Items.AddRange(new object[] {
            "Todos",
            "Proveedor",
            "Usuario",
            "Nro. Orden",
            "Producto",
            "Total Compra"});
            this.cboBuscarPor.Location = new System.Drawing.Point(361, 207);
            this.cboBuscarPor.Name = "cboBuscarPor";
            this.cboBuscarPor.Size = new System.Drawing.Size(121, 21);
            this.cboBuscarPor.TabIndex = 7;
            this.cboBuscarPor.SelectedIndexChanged += new System.EventHandler(this.cboBuscarPor_SelectedIndexChanged);
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Location = new System.Drawing.Point(592, 128);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(135, 20);
            this.dtpFechaFin.TabIndex = 5;
            // 
            // FechaFin
            // 
            this.FechaFin.AutoSize = true;
            this.FechaFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaFin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.FechaFin.Location = new System.Drawing.Point(512, 128);
            this.FechaFin.Name = "FechaFin";
            this.FechaFin.Size = new System.Drawing.Size(74, 17);
            this.FechaFin.TabIndex = 2;
            this.FechaFin.Text = "Fecha Fin:";
            // 
            // LFechaInicio
            // 
            this.LFechaInicio.AutoSize = true;
            this.LFechaInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LFechaInicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LFechaInicio.Location = new System.Drawing.Point(264, 128);
            this.LFechaInicio.Name = "LFechaInicio";
            this.LFechaInicio.Size = new System.Drawing.Size(87, 17);
            this.LFechaInicio.TabIndex = 1;
            this.LFechaInicio.Text = "Fecha Inicio:";
            // 
            // LbuscarPor
            // 
            this.LbuscarPor.AutoSize = true;
            this.LbuscarPor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbuscarPor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LbuscarPor.Location = new System.Drawing.Point(264, 213);
            this.LbuscarPor.Name = "LbuscarPor";
            this.LbuscarPor.Size = new System.Drawing.Size(81, 17);
            this.LbuscarPor.TabIndex = 1;
            this.LbuscarPor.Text = "Buscar por:";
            // 
            // LReporteVentas
            // 
            this.LReporteVentas.AutoSize = true;
            this.LReporteVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LReporteVentas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LReporteVentas.Location = new System.Drawing.Point(20, 16);
            this.LReporteVentas.Name = "LReporteVentas";
            this.LReporteVentas.Size = new System.Drawing.Size(265, 31);
            this.LReporteVentas.TabIndex = 0;
            this.LReporteVentas.Text = "Reporte de Compras";
            // 
            // CFecha
            // 
            this.CFecha.HeaderText = "Fecha de Compra";
            this.CFecha.Name = "CFecha";
            this.CFecha.Width = 150;
            // 
            // CCodigo
            // 
            this.CCodigo.HeaderText = "Nro. Orden";
            this.CCodigo.Name = "CCodigo";
            this.CCodigo.Width = 150;
            // 
            // cPrecioTotal
            // 
            this.cPrecioTotal.HeaderText = "Total Compra";
            this.cPrecioTotal.Name = "cPrecioTotal";
            this.cPrecioTotal.Width = 125;
            // 
            // CUsuario
            // 
            this.CUsuario.HeaderText = "Usuario";
            this.CUsuario.Name = "CUsuario";
            // 
            // CProveedor
            // 
            this.CProveedor.HeaderText = "Proveedor";
            this.CProveedor.Name = "CProveedor";
            this.CProveedor.Width = 125;
            // 
            // cCodProducto
            // 
            this.cCodProducto.HeaderText = "Cod. producto";
            this.cCodProducto.Name = "cCodProducto";
            // 
            // cNombreProducto
            // 
            this.cNombreProducto.HeaderText = "Nombre producto";
            this.cNombreProducto.Name = "cNombreProducto";
            // 
            // cCategoria
            // 
            this.cCategoria.HeaderText = "Categoría";
            this.cCategoria.Name = "cCategoria";
            // 
            // cCantidad
            // 
            this.cCantidad.HeaderText = "Cantidad";
            this.cCantidad.Name = "cCantidad";
            this.cCantidad.Width = 75;
            // 
            // cPrecioCompra
            // 
            this.cPrecioCompra.HeaderText = "Precio Compra";
            this.cPrecioCompra.Name = "cPrecioCompra";
            // 
            // iconButton1
            // 
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 30;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(1032, 213);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(114, 28);
            this.iconButton1.TabIndex = 10;
            this.iconButton1.Text = "Exportar Excel";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // ComprasUserControlAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.BtnNuevaCompra);
            this.Controls.Add(this.LCompras);
            this.Name = "ComprasUserControlAdministrador";
            this.Size = new System.Drawing.Size(1372, 949);
            this.Load += new System.EventHandler(this.ComprasUserControlAdministrador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompras)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LCompras;
        private System.Windows.Forms.DataGridView dgvCompras;
        private FontAwesome.Sharp.IconButton BtnNuevaCompra;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox TBuscar;
        private System.Windows.Forms.ComboBox cboBuscarPor;
        private System.Windows.Forms.Label LbuscarPor;
        private FontAwesome.Sharp.IconButton IBtnBuscar;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.Label FechaFin;
        private System.Windows.Forms.Label LFechaInicio;
        private System.Windows.Forms.Label LReporteVentas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPrecioTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn CProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCodProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPrecioCompra;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}

namespace CapaPresentacion.Administrador
{
    partial class ReporteComprasUserControlAdministrador
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvReporteCompras = new System.Windows.Forms.DataGridView();
            this.TBuscar = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.IBtnBuscar2 = new FontAwesome.Sharp.IconButton();
            this.LbuscarPor = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.IBtnBuscar = new FontAwesome.Sharp.IconButton();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.FechaFin = new System.Windows.Forms.Label();
            this.LFechaInicio = new System.Windows.Forms.Label();
            this.LReporteVentas = new System.Windows.Forms.Label();
            this.CFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPrecioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPrecioLinea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporteCompras)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.panel2.Controls.Add(this.dgvReporteCompras);
            this.panel2.Controls.Add(this.TBuscar);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.IBtnBuscar2);
            this.panel2.Controls.Add(this.LbuscarPor);
            this.panel2.Location = new System.Drawing.Point(12, 156);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1042, 437);
            this.panel2.TabIndex = 5;
            // 
            // dgvReporteCompras
            // 
            this.dgvReporteCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReporteCompras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CFecha,
            this.cProveedor,
            this.cPrecioUnitario,
            this.cProducto,
            this.CCliente,
            this.cPrecioLinea});
            this.dgvReporteCompras.Location = new System.Drawing.Point(88, 108);
            this.dgvReporteCompras.Name = "dgvReporteCompras";
            this.dgvReporteCompras.Size = new System.Drawing.Size(844, 154);
            this.dgvReporteCompras.TabIndex = 9;
            // 
            // TBuscar
            // 
            this.TBuscar.Location = new System.Drawing.Point(400, 66);
            this.TBuscar.Name = "TBuscar";
            this.TBuscar.Size = new System.Drawing.Size(165, 20);
            this.TBuscar.TabIndex = 8;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Fecha",
            "Proveedor"});
            this.comboBox1.Location = new System.Drawing.Point(223, 65);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 7;
            // 
            // IBtnBuscar2
            // 
            this.IBtnBuscar2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IBtnBuscar2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IBtnBuscar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IBtnBuscar2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.IBtnBuscar2.IconChar = FontAwesome.Sharp.IconChar.Sistrix;
            this.IBtnBuscar2.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.IBtnBuscar2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IBtnBuscar2.IconSize = 24;
            this.IBtnBuscar2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IBtnBuscar2.Location = new System.Drawing.Point(590, 63);
            this.IBtnBuscar2.Name = "IBtnBuscar2";
            this.IBtnBuscar2.Size = new System.Drawing.Size(93, 27);
            this.IBtnBuscar2.TabIndex = 6;
            this.IBtnBuscar2.Text = "Buscar";
            this.IBtnBuscar2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.IBtnBuscar2.UseVisualStyleBackColor = true;
            // 
            // LbuscarPor
            // 
            this.LbuscarPor.AutoSize = true;
            this.LbuscarPor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbuscarPor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LbuscarPor.Location = new System.Drawing.Point(124, 69);
            this.LbuscarPor.Name = "LbuscarPor";
            this.LbuscarPor.Size = new System.Drawing.Size(81, 17);
            this.LbuscarPor.TabIndex = 1;
            this.LbuscarPor.Text = "Buscar por:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.panel1.Controls.Add(this.IBtnBuscar);
            this.panel1.Controls.Add(this.dateTimePicker2);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.FechaFin);
            this.panel1.Controls.Add(this.LFechaInicio);
            this.panel1.Controls.Add(this.LReporteVentas);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1042, 122);
            this.panel1.TabIndex = 4;
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
            this.IBtnBuscar.Location = new System.Drawing.Point(590, 55);
            this.IBtnBuscar.Name = "IBtnBuscar";
            this.IBtnBuscar.Size = new System.Drawing.Size(93, 27);
            this.IBtnBuscar.TabIndex = 6;
            this.IBtnBuscar.Text = "Buscar";
            this.IBtnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.IBtnBuscar.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(195, 61);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(132, 20);
            this.dateTimePicker2.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(430, 61);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(135, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // FechaFin
            // 
            this.FechaFin.AutoSize = true;
            this.FechaFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaFin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.FechaFin.Location = new System.Drawing.Point(350, 61);
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
            this.LFechaInicio.Location = new System.Drawing.Point(106, 61);
            this.LFechaInicio.Name = "LFechaInicio";
            this.LFechaInicio.Size = new System.Drawing.Size(87, 17);
            this.LFechaInicio.TabIndex = 1;
            this.LFechaInicio.Text = "Fecha Inicio:";
            // 
            // LReporteVentas
            // 
            this.LReporteVentas.AutoSize = true;
            this.LReporteVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LReporteVentas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LReporteVentas.Location = new System.Drawing.Point(3, 0);
            this.LReporteVentas.Name = "LReporteVentas";
            this.LReporteVentas.Size = new System.Drawing.Size(265, 31);
            this.LReporteVentas.TabIndex = 0;
            this.LReporteVentas.Text = "Reporte de Compras";
            // 
            // CFecha
            // 
            this.CFecha.HeaderText = "Fecha";
            this.CFecha.Name = "CFecha";
            this.CFecha.Width = 150;
            // 
            // cProveedor
            // 
            this.cProveedor.HeaderText = "Proveedor";
            this.cProveedor.Name = "cProveedor";
            // 
            // cPrecioUnitario
            // 
            this.cPrecioUnitario.HeaderText = "Precio unitario";
            this.cPrecioUnitario.Name = "cPrecioUnitario";
            this.cPrecioUnitario.Width = 150;
            // 
            // cProducto
            // 
            this.cProducto.HeaderText = "Producto";
            this.cProducto.Name = "cProducto";
            this.cProducto.Width = 150;
            // 
            // CCliente
            // 
            this.CCliente.HeaderText = "Cantidad";
            this.CCliente.Name = "CCliente";
            this.CCliente.Width = 150;
            // 
            // cPrecioLinea
            // 
            this.cPrecioLinea.HeaderText = "Precio Linea";
            this.cPrecioLinea.Name = "cPrecioLinea";
            // 
            // ReporteComprasUserControlAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ReporteComprasUserControlAdministrador";
            this.Size = new System.Drawing.Size(1078, 552);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporteCompras)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvReporteCompras;
        private System.Windows.Forms.TextBox TBuscar;
        private System.Windows.Forms.ComboBox comboBox1;
        private FontAwesome.Sharp.IconButton IBtnBuscar2;
        private System.Windows.Forms.Label LbuscarPor;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton IBtnBuscar;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label FechaFin;
        private System.Windows.Forms.Label LFechaInicio;
        private System.Windows.Forms.Label LReporteVentas;
        private System.Windows.Forms.DataGridViewTextBoxColumn CFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn cProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPrecioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn cProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPrecioLinea;
    }
}

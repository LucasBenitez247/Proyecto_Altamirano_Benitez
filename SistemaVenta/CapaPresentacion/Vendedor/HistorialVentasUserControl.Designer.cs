namespace CapaPresentacion.Vendedor
{
    partial class HistorialVentasUserControl
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
            this.LHistorialVenta = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IBtnBuscar = new FontAwesome.Sharp.IconButton();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.FechaFin = new System.Windows.Forms.Label();
            this.LFechaInicio = new System.Windows.Forms.Label();
            this.PBuscarCliente = new System.Windows.Forms.Panel();
            this.TBuscarCliente = new System.Windows.Forms.TextBox();
            this.IBtnBuscarClientes = new FontAwesome.Sharp.IconButton();
            this.CFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CVendedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CMetodoPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CDetalle = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.PBuscarCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // LHistorialVenta
            // 
            this.LHistorialVenta.AutoSize = true;
            this.LHistorialVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LHistorialVenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LHistorialVenta.Location = new System.Drawing.Point(345, 16);
            this.LHistorialVenta.Name = "LHistorialVenta";
            this.LHistorialVenta.Size = new System.Drawing.Size(339, 31);
            this.LHistorialVenta.TabIndex = 0;
            this.LHistorialVenta.Text = "HISTORIAL DE VENTAS";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CFecha,
            this.CVendedor,
            this.CCliente,
            this.CTotal,
            this.CMetodoPago,
            this.CDetalle});
            this.dataGridView1.Location = new System.Drawing.Point(204, 135);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(646, 542);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // IBtnBuscar
            // 
            this.IBtnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IBtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IBtnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IBtnBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.IBtnBuscar.IconChar = FontAwesome.Sharp.IconChar.Sistrix;
            this.IBtnBuscar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.IBtnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IBtnBuscar.IconSize = 24;
            this.IBtnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IBtnBuscar.Location = new System.Drawing.Point(868, 81);
            this.IBtnBuscar.Name = "IBtnBuscar";
            this.IBtnBuscar.Size = new System.Drawing.Size(80, 27);
            this.IBtnBuscar.TabIndex = 11;
            this.IBtnBuscar.Text = "Buscar";
            this.IBtnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.IBtnBuscar.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(480, 81);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(132, 20);
            this.dateTimePicker2.TabIndex = 9;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(715, 85);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(135, 20);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // FechaFin
            // 
            this.FechaFin.AutoSize = true;
            this.FechaFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaFin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.FechaFin.Location = new System.Drawing.Point(635, 85);
            this.FechaFin.Name = "FechaFin";
            this.FechaFin.Size = new System.Drawing.Size(74, 17);
            this.FechaFin.TabIndex = 8;
            this.FechaFin.Text = "Fecha Fin:";
            // 
            // LFechaInicio
            // 
            this.LFechaInicio.AutoSize = true;
            this.LFechaInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LFechaInicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LFechaInicio.Location = new System.Drawing.Point(391, 81);
            this.LFechaInicio.Name = "LFechaInicio";
            this.LFechaInicio.Size = new System.Drawing.Size(87, 17);
            this.LFechaInicio.TabIndex = 7;
            this.LFechaInicio.Text = "Fecha Inicio:";
            // 
            // PBuscarCliente
            // 
            this.PBuscarCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PBuscarCliente.Controls.Add(this.TBuscarCliente);
            this.PBuscarCliente.Controls.Add(this.IBtnBuscarClientes);
            this.PBuscarCliente.Location = new System.Drawing.Point(204, 77);
            this.PBuscarCliente.Name = "PBuscarCliente";
            this.PBuscarCliente.Size = new System.Drawing.Size(165, 25);
            this.PBuscarCliente.TabIndex = 21;
            // 
            // TBuscarCliente
            // 
            this.TBuscarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TBuscarCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBuscarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBuscarCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TBuscarCliente.Location = new System.Drawing.Point(3, 3);
            this.TBuscarCliente.Name = "TBuscarCliente";
            this.TBuscarCliente.Size = new System.Drawing.Size(126, 15);
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
            this.IBtnBuscarClientes.Location = new System.Drawing.Point(135, 2);
            this.IBtnBuscarClientes.Name = "IBtnBuscarClientes";
            this.IBtnBuscarClientes.Size = new System.Drawing.Size(24, 25);
            this.IBtnBuscarClientes.TabIndex = 3;
            this.IBtnBuscarClientes.UseVisualStyleBackColor = false;
            // 
            // CFecha
            // 
            this.CFecha.HeaderText = "Fecha";
            this.CFecha.Name = "CFecha";
            // 
            // CVendedor
            // 
            this.CVendedor.HeaderText = "Vendedor";
            this.CVendedor.Name = "CVendedor";
            // 
            // CCliente
            // 
            this.CCliente.HeaderText = "Cliente";
            this.CCliente.Name = "CCliente";
            // 
            // CTotal
            // 
            this.CTotal.HeaderText = "Total";
            this.CTotal.Name = "CTotal";
            // 
            // CMetodoPago
            // 
            this.CMetodoPago.HeaderText = "Metodo de Pago";
            this.CMetodoPago.Name = "CMetodoPago";
            // 
            // CDetalle
            // 
            this.CDetalle.HeaderText = "Detalle";
            this.CDetalle.Name = "CDetalle";
            this.CDetalle.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CDetalle.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.CDetalle.Text = "Detalle";
            this.CDetalle.UseColumnTextForButtonValue = true;
            // 
            // HistorialVentasUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.PBuscarCliente);
            this.Controls.Add(this.IBtnBuscar);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.FechaFin);
            this.Controls.Add(this.LFechaInicio);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.LHistorialVenta);
            this.Name = "HistorialVentasUserControl";
            this.Size = new System.Drawing.Size(1201, 660);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.PBuscarCliente.ResumeLayout(false);
            this.PBuscarCliente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LHistorialVenta;
        private System.Windows.Forms.DataGridView dataGridView1;
        private FontAwesome.Sharp.IconButton IBtnBuscar;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label FechaFin;
        private System.Windows.Forms.Label LFechaInicio;
        private System.Windows.Forms.Panel PBuscarCliente;
        private System.Windows.Forms.TextBox TBuscarCliente;
        private FontAwesome.Sharp.IconButton IBtnBuscarClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn CFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn CVendedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn CTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn CMetodoPago;
        private System.Windows.Forms.DataGridViewButtonColumn CDetalle;
    }
}

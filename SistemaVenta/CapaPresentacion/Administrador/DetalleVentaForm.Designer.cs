namespace CapaPresentacion.Administrador
{
    partial class DetalleVentaForm
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
            this.txtApellidoCliente = new System.Windows.Forms.TextBox();
            this.LApellido = new System.Windows.Forms.Label();
            this.TTipoDocumento = new System.Windows.Forms.TextBox();
            this.LTipoDocumento = new System.Windows.Forms.Label();
            this.dgvDetalle = new System.Windows.Forms.DataGridView();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TDni = new System.Windows.Forms.TextBox();
            this.LInfoCliente = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TFecha = new System.Windows.Forms.TextBox();
            this.LInfoVenta = new System.Windows.Forms.Label();
            this.LFecha = new System.Windows.Forms.Label();
            this.LDetalleVenta = new System.Windows.Forms.Label();
            this.txtVendedor = new System.Windows.Forms.TextBox();
            this.lblVendedor = new System.Windows.Forms.Label();
            this.CProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CSubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // txtApellidoCliente
            // 
            this.txtApellidoCliente.Location = new System.Drawing.Point(433, 192);
            this.txtApellidoCliente.Name = "txtApellidoCliente";
            this.txtApellidoCliente.ReadOnly = true;
            this.txtApellidoCliente.Size = new System.Drawing.Size(100, 20);
            this.txtApellidoCliente.TabIndex = 44;
            // 
            // LApellido
            // 
            this.LApellido.AutoSize = true;
            this.LApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LApellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LApellido.Location = new System.Drawing.Point(430, 173);
            this.LApellido.Name = "LApellido";
            this.LApellido.Size = new System.Drawing.Size(60, 16);
            this.LApellido.TabIndex = 43;
            this.LApellido.Text = "Apellido:";
            // 
            // TTipoDocumento
            // 
            this.TTipoDocumento.Location = new System.Drawing.Point(266, 104);
            this.TTipoDocumento.Name = "TTipoDocumento";
            this.TTipoDocumento.ReadOnly = true;
            this.TTipoDocumento.Size = new System.Drawing.Size(100, 20);
            this.TTipoDocumento.TabIndex = 42;
            // 
            // LTipoDocumento
            // 
            this.LTipoDocumento.AutoSize = true;
            this.LTipoDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTipoDocumento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LTipoDocumento.Location = new System.Drawing.Point(263, 85);
            this.LTipoDocumento.Name = "LTipoDocumento";
            this.LTipoDocumento.Size = new System.Drawing.Size(110, 16);
            this.LTipoDocumento.TabIndex = 41;
            this.LTipoDocumento.Text = "Tipo Documento:";
            // 
            // dgvDetalle
            // 
            this.dgvDetalle.AllowUserToAddRows = false;
            this.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CProducto,
            this.CCantidad,
            this.CPrecio,
            this.CSubTotal});
            this.dgvDetalle.Location = new System.Drawing.Point(62, 255);
            this.dgvDetalle.Name = "dgvDetalle";
            this.dgvDetalle.Size = new System.Drawing.Size(526, 235);
            this.dgvDetalle.TabIndex = 39;
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(266, 192);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.ReadOnly = true;
            this.txtNombreCliente.Size = new System.Drawing.Size(100, 20);
            this.txtNombreCliente.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(263, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 37;
            this.label1.Text = "Nombre:";
            // 
            // TDni
            // 
            this.TDni.Location = new System.Drawing.Point(83, 192);
            this.TDni.Name = "TDni";
            this.TDni.ReadOnly = true;
            this.TDni.Size = new System.Drawing.Size(100, 20);
            this.TDni.TabIndex = 36;
            // 
            // LInfoCliente
            // 
            this.LInfoCliente.AutoSize = true;
            this.LInfoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LInfoCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LInfoCliente.Location = new System.Drawing.Point(74, 143);
            this.LInfoCliente.Name = "LInfoCliente";
            this.LInfoCliente.Size = new System.Drawing.Size(186, 18);
            this.LInfoCliente.TabIndex = 35;
            this.LInfoCliente.Text = "Información del Cliente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(80, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 16);
            this.label2.TabIndex = 34;
            this.label2.Text = "DNI:";
            // 
            // TFecha
            // 
            this.TFecha.Location = new System.Drawing.Point(81, 104);
            this.TFecha.Name = "TFecha";
            this.TFecha.ReadOnly = true;
            this.TFecha.Size = new System.Drawing.Size(100, 20);
            this.TFecha.TabIndex = 33;
            // 
            // LInfoVenta
            // 
            this.LInfoVenta.AutoSize = true;
            this.LInfoVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LInfoVenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LInfoVenta.Location = new System.Drawing.Point(78, 59);
            this.LInfoVenta.Name = "LInfoVenta";
            this.LInfoVenta.Size = new System.Drawing.Size(190, 18);
            this.LInfoVenta.TabIndex = 32;
            this.LInfoVenta.Text = "Información de la Venta:";
            // 
            // LFecha
            // 
            this.LFecha.AutoSize = true;
            this.LFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LFecha.Location = new System.Drawing.Point(78, 85);
            this.LFecha.Name = "LFecha";
            this.LFecha.Size = new System.Drawing.Size(48, 16);
            this.LFecha.TabIndex = 31;
            this.LFecha.Text = "Fecha:";
            // 
            // LDetalleVenta
            // 
            this.LDetalleVenta.AutoSize = true;
            this.LDetalleVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDetalleVenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LDetalleVenta.Location = new System.Drawing.Point(71, 16);
            this.LDetalleVenta.Name = "LDetalleVenta";
            this.LDetalleVenta.Size = new System.Drawing.Size(189, 33);
            this.LDetalleVenta.TabIndex = 30;
            this.LDetalleVenta.Text = "Detalle Venta";
            // 
            // txtVendedor
            // 
            this.txtVendedor.Location = new System.Drawing.Point(433, 104);
            this.txtVendedor.Name = "txtVendedor";
            this.txtVendedor.ReadOnly = true;
            this.txtVendedor.Size = new System.Drawing.Size(100, 20);
            this.txtVendedor.TabIndex = 45;
            // 
            // lblVendedor
            // 
            this.lblVendedor.AutoSize = true;
            this.lblVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVendedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblVendedor.Location = new System.Drawing.Point(430, 85);
            this.lblVendedor.Name = "lblVendedor";
            this.lblVendedor.Size = new System.Drawing.Size(70, 16);
            this.lblVendedor.TabIndex = 46;
            this.lblVendedor.Text = "Vendedor:";
            // 
            // CProducto
            // 
            this.CProducto.HeaderText = "Producto";
            this.CProducto.Name = "CProducto";
            this.CProducto.Width = 120;
            // 
            // CCantidad
            // 
            this.CCantidad.HeaderText = "Cantidad";
            this.CCantidad.Name = "CCantidad";
            this.CCantidad.Width = 120;
            // 
            // CPrecio
            // 
            this.CPrecio.HeaderText = "Precio";
            this.CPrecio.Name = "CPrecio";
            this.CPrecio.Width = 120;
            // 
            // CSubTotal
            // 
            this.CSubTotal.HeaderText = "Sub-Total";
            this.CSubTotal.Name = "CSubTotal";
            this.CSubTotal.Width = 120;
            // 
            // DetalleVentaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(804, 505);
            this.Controls.Add(this.lblVendedor);
            this.Controls.Add(this.txtVendedor);
            this.Controls.Add(this.txtApellidoCliente);
            this.Controls.Add(this.LApellido);
            this.Controls.Add(this.TTipoDocumento);
            this.Controls.Add(this.LTipoDocumento);
            this.Controls.Add(this.dgvDetalle);
            this.Controls.Add(this.txtNombreCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TDni);
            this.Controls.Add(this.LInfoCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TFecha);
            this.Controls.Add(this.LInfoVenta);
            this.Controls.Add(this.LFecha);
            this.Controls.Add(this.LDetalleVenta);
            this.Name = "DetalleVentaForm";
            this.Text = "DetalleVentaForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtApellidoCliente;
        private System.Windows.Forms.Label LApellido;
        private System.Windows.Forms.TextBox TTipoDocumento;
        private System.Windows.Forms.Label LTipoDocumento;
        private System.Windows.Forms.DataGridView dgvDetalle;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TDni;
        private System.Windows.Forms.Label LInfoCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TFecha;
        private System.Windows.Forms.Label LInfoVenta;
        private System.Windows.Forms.Label LFecha;
        private System.Windows.Forms.Label LDetalleVenta;
        private System.Windows.Forms.TextBox txtVendedor;
        private System.Windows.Forms.Label lblVendedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn CProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn CSubTotal;
    }
}
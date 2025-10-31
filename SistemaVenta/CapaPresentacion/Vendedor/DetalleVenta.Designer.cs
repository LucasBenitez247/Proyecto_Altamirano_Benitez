namespace CapaPresentacion.Vendedor
{
    partial class DetalleVenta
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
            this.LDetalleVenta = new System.Windows.Forms.Label();
            this.LFecha = new System.Windows.Forms.Label();
            this.LInfoVenta = new System.Windows.Forms.Label();
            this.TFecha = new System.Windows.Forms.TextBox();
            this.TDni = new System.Windows.Forms.TextBox();
            this.LInfoCliente = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CSubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnImprimir = new FontAwesome.Sharp.IconButton();
            this.TTipoDocumento = new System.Windows.Forms.TextBox();
            this.LTipoDocumento = new System.Windows.Forms.Label();
            this.TApellido = new System.Windows.Forms.TextBox();
            this.LApellido = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // LDetalleVenta
            // 
            this.LDetalleVenta.AutoSize = true;
            this.LDetalleVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDetalleVenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LDetalleVenta.Location = new System.Drawing.Point(21, 9);
            this.LDetalleVenta.Name = "LDetalleVenta";
            this.LDetalleVenta.Size = new System.Drawing.Size(189, 33);
            this.LDetalleVenta.TabIndex = 0;
            this.LDetalleVenta.Text = "Detalle Venta";
            // 
            // LFecha
            // 
            this.LFecha.AutoSize = true;
            this.LFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LFecha.Location = new System.Drawing.Point(28, 78);
            this.LFecha.Name = "LFecha";
            this.LFecha.Size = new System.Drawing.Size(48, 16);
            this.LFecha.TabIndex = 1;
            this.LFecha.Text = "Fecha:";
            // 
            // LInfoVenta
            // 
            this.LInfoVenta.AutoSize = true;
            this.LInfoVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LInfoVenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LInfoVenta.Location = new System.Drawing.Point(28, 52);
            this.LInfoVenta.Name = "LInfoVenta";
            this.LInfoVenta.Size = new System.Drawing.Size(190, 18);
            this.LInfoVenta.TabIndex = 2;
            this.LInfoVenta.Text = "Información de la Venta:";
            // 
            // TFecha
            // 
            this.TFecha.Location = new System.Drawing.Point(31, 97);
            this.TFecha.Name = "TFecha";
            this.TFecha.Size = new System.Drawing.Size(100, 20);
            this.TFecha.TabIndex = 3;
            // 
            // TDni
            // 
            this.TDni.Location = new System.Drawing.Point(33, 185);
            this.TDni.Name = "TDni";
            this.TDni.Size = new System.Drawing.Size(100, 20);
            this.TDni.TabIndex = 6;
            // 
            // LInfoCliente
            // 
            this.LInfoCliente.AutoSize = true;
            this.LInfoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LInfoCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LInfoCliente.Location = new System.Drawing.Point(24, 136);
            this.LInfoCliente.Name = "LInfoCliente";
            this.LInfoCliente.Size = new System.Drawing.Size(186, 18);
            this.LInfoCliente.TabIndex = 5;
            this.LInfoCliente.Text = "Información del Cliente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(30, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "DNI:";
            // 
            // TNombre
            // 
            this.TNombre.Location = new System.Drawing.Point(216, 185);
            this.TNombre.Name = "TNombre";
            this.TNombre.Size = new System.Drawing.Size(100, 20);
            this.TNombre.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(213, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nombre:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CProducto,
            this.CPrecio,
            this.CCantidad,
            this.CSubTotal});
            this.dataGridView1.Location = new System.Drawing.Point(12, 248);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(526, 235);
            this.dataGridView1.TabIndex = 9;
            // 
            // CProducto
            // 
            this.CProducto.HeaderText = "Producto";
            this.CProducto.Name = "CProducto";
            this.CProducto.Width = 120;
            // 
            // CPrecio
            // 
            this.CPrecio.HeaderText = "Precio";
            this.CPrecio.Name = "CPrecio";
            this.CPrecio.Width = 120;
            // 
            // CCantidad
            // 
            this.CCantidad.HeaderText = "Cantidad";
            this.CCantidad.Name = "CCantidad";
            this.CCantidad.Width = 120;
            // 
            // CSubTotal
            // 
            this.CSubTotal.HeaderText = "Sub-Total";
            this.CSubTotal.Name = "CSubTotal";
            this.CSubTotal.Width = 120;
            // 
            // BtnImprimir
            // 
            this.BtnImprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnImprimir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BtnImprimir.FlatAppearance.BorderSize = 2;
            this.BtnImprimir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnImprimir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.BtnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnImprimir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnImprimir.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.BtnImprimir.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnImprimir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnImprimir.IconSize = 32;
            this.BtnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnImprimir.Location = new System.Drawing.Point(584, 450);
            this.BtnImprimir.Name = "BtnImprimir";
            this.BtnImprimir.Size = new System.Drawing.Size(105, 33);
            this.BtnImprimir.TabIndex = 25;
            this.BtnImprimir.Text = "Imprimir";
            this.BtnImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnImprimir.UseVisualStyleBackColor = true;
            // 
            // TTipoDocumento
            // 
            this.TTipoDocumento.Location = new System.Drawing.Point(216, 97);
            this.TTipoDocumento.Name = "TTipoDocumento";
            this.TTipoDocumento.Size = new System.Drawing.Size(100, 20);
            this.TTipoDocumento.TabIndex = 27;
            // 
            // LTipoDocumento
            // 
            this.LTipoDocumento.AutoSize = true;
            this.LTipoDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTipoDocumento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LTipoDocumento.Location = new System.Drawing.Point(213, 78);
            this.LTipoDocumento.Name = "LTipoDocumento";
            this.LTipoDocumento.Size = new System.Drawing.Size(110, 16);
            this.LTipoDocumento.TabIndex = 26;
            this.LTipoDocumento.Text = "Tipo Documento:";
            // 
            // TApellido
            // 
            this.TApellido.Location = new System.Drawing.Point(383, 185);
            this.TApellido.Name = "TApellido";
            this.TApellido.Size = new System.Drawing.Size(100, 20);
            this.TApellido.TabIndex = 29;
            // 
            // LApellido
            // 
            this.LApellido.AutoSize = true;
            this.LApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LApellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LApellido.Location = new System.Drawing.Point(380, 166);
            this.LApellido.Name = "LApellido";
            this.LApellido.Size = new System.Drawing.Size(60, 16);
            this.LApellido.TabIndex = 28;
            this.LApellido.Text = "Apellido:";
            // 
            // DetalleVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(717, 501);
            this.Controls.Add(this.TApellido);
            this.Controls.Add(this.LApellido);
            this.Controls.Add(this.TTipoDocumento);
            this.Controls.Add(this.LTipoDocumento);
            this.Controls.Add(this.BtnImprimir);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.TNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TDni);
            this.Controls.Add(this.LInfoCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TFecha);
            this.Controls.Add(this.LInfoVenta);
            this.Controls.Add(this.LFecha);
            this.Controls.Add(this.LDetalleVenta);
            this.Name = "DetalleVenta";
            this.Text = "DetalleVenta";
            this.Load += new System.EventHandler(this.DetalleVenta_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LDetalleVenta;
        private System.Windows.Forms.Label LFecha;
        private System.Windows.Forms.Label LInfoVenta;
        private System.Windows.Forms.TextBox TFecha;
        private System.Windows.Forms.TextBox TDni;
        private System.Windows.Forms.Label LInfoCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn CSubTotal;
        private FontAwesome.Sharp.IconButton BtnImprimir;
        private System.Windows.Forms.TextBox TTipoDocumento;
        private System.Windows.Forms.Label LTipoDocumento;
        private System.Windows.Forms.TextBox TApellido;
        private System.Windows.Forms.Label LApellido;
    }
}
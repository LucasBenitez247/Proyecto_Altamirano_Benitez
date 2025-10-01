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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.PBuscarProductos = new System.Windows.Forms.Panel();
            this.TBBuscar = new System.Windows.Forms.TextBox();
            this.BtnBuscar = new FontAwesome.Sharp.IconButton();
            this.BtnNuevaCompra = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.PBuscarProductos.SuspendLayout();
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
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CCodigo,
            this.CProveedor,
            this.CFecha,
            this.CEstado,
            this.CEliminar});
            this.dataGridView1.Location = new System.Drawing.Point(74, 146);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(996, 449);
            this.dataGridView1.TabIndex = 1;
            // 
            // CCodigo
            // 
            this.CCodigo.HeaderText = "Código";
            this.CCodigo.Name = "CCodigo";
            this.CCodigo.Width = 150;
            // 
            // CProveedor
            // 
            this.CProveedor.HeaderText = "Proveedor";
            this.CProveedor.Name = "CProveedor";
            this.CProveedor.Width = 150;
            // 
            // CFecha
            // 
            this.CFecha.HeaderText = "Fecha";
            this.CFecha.Name = "CFecha";
            this.CFecha.Width = 150;
            // 
            // CEstado
            // 
            this.CEstado.HeaderText = "Estado";
            this.CEstado.Name = "CEstado";
            this.CEstado.Width = 150;
            // 
            // CEliminar
            // 
            this.CEliminar.HeaderText = "Eliminar";
            this.CEliminar.Name = "CEliminar";
            this.CEliminar.Width = 150;
            // 
            // PBuscarProductos
            // 
            this.PBuscarProductos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PBuscarProductos.Controls.Add(this.TBBuscar);
            this.PBuscarProductos.Controls.Add(this.BtnBuscar);
            this.PBuscarProductos.Location = new System.Drawing.Point(74, 70);
            this.PBuscarProductos.Name = "PBuscarProductos";
            this.PBuscarProductos.Size = new System.Drawing.Size(244, 29);
            this.PBuscarProductos.TabIndex = 7;
            // 
            // TBBuscar
            // 
            this.TBBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.TBBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TBBuscar.Location = new System.Drawing.Point(7, 3);
            this.TBBuscar.Name = "TBBuscar";
            this.TBBuscar.Size = new System.Drawing.Size(193, 19);
            this.TBBuscar.TabIndex = 2;
            this.TBBuscar.Text = "Buscar compra...";
            this.TBBuscar.Click += new System.EventHandler(this.TBBuscar_Click);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.BtnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBuscar.FlatAppearance.BorderSize = 0;
            this.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.BtnBuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.BtnBuscar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnBuscar.IconSize = 32;
            this.BtnBuscar.Location = new System.Drawing.Point(206, 2);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(24, 25);
            this.BtnBuscar.TabIndex = 3;
            this.BtnBuscar.UseVisualStyleBackColor = false;
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
            this.BtnNuevaCompra.Location = new System.Drawing.Point(847, 92);
            this.BtnNuevaCompra.Name = "BtnNuevaCompra";
            this.BtnNuevaCompra.Size = new System.Drawing.Size(223, 35);
            this.BtnNuevaCompra.TabIndex = 14;
            this.BtnNuevaCompra.Text = "Agregar nuervas compra";
            this.BtnNuevaCompra.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnNuevaCompra.UseCompatibleTextRendering = true;
            this.BtnNuevaCompra.UseVisualStyleBackColor = true;
            this.BtnNuevaCompra.Click += new System.EventHandler(this.BtnNuevaCompra_Click);
            // 
            // ComprasUserControlAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.Controls.Add(this.BtnNuevaCompra);
            this.Controls.Add(this.PBuscarProductos);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.LCompras);
            this.Name = "ComprasUserControlAdministrador";
            this.Size = new System.Drawing.Size(1190, 660);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.PBuscarProductos.ResumeLayout(false);
            this.PBuscarProductos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LCompras;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn CFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn CEstado;
        private System.Windows.Forms.DataGridViewButtonColumn CEliminar;
        private System.Windows.Forms.Panel PBuscarProductos;
        private System.Windows.Forms.TextBox TBBuscar;
        private FontAwesome.Sharp.IconButton BtnBuscar;
        private FontAwesome.Sharp.IconButton BtnNuevaCompra;
    }
}

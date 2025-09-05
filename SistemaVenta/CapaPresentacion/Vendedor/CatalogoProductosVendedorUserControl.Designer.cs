namespace CapaPresentacion.Vendedor
{
    partial class CatalogoProductosVendedorUserControl
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
            this.DGCatalogoProductos = new System.Windows.Forms.DataGridView();
            this.CImagen = new System.Windows.Forms.DataGridViewImageColumn();
            this.CNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.TBBuscar = new System.Windows.Forms.TextBox();
            this.BtnBuscar = new FontAwesome.Sharp.IconButton();
            this.LBucarPor = new System.Windows.Forms.Label();
            this.CBBuscarPor = new System.Windows.Forms.ComboBox();
            this.PBuscarProductos = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.DGCatalogoProductos)).BeginInit();
            this.PBuscarProductos.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGCatalogoProductos
            // 
            this.DGCatalogoProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGCatalogoProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CImagen,
            this.CNombre,
            this.CDescripcion,
            this.CCategoria,
            this.CPrecio,
            this.CStock});
            this.DGCatalogoProductos.Location = new System.Drawing.Point(88, 168);
            this.DGCatalogoProductos.Name = "DGCatalogoProductos";
            this.DGCatalogoProductos.Size = new System.Drawing.Size(924, 150);
            this.DGCatalogoProductos.TabIndex = 0;
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
            // 
            // CDescripcion
            // 
            this.CDescripcion.HeaderText = "Descripción";
            this.CDescripcion.Name = "CDescripcion";
            // 
            // CCategoria
            // 
            this.CCategoria.HeaderText = "Categoria";
            this.CCategoria.Name = "CCategoria";
            // 
            // CPrecio
            // 
            this.CPrecio.HeaderText = "Precio";
            this.CPrecio.Name = "CPrecio";
            // 
            // CStock
            // 
            this.CStock.HeaderText = "Stock";
            this.CStock.Name = "CStock";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(277, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Catalogo de Productos";
            // 
            // TBBuscar
            // 
            this.TBBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TBBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TBBuscar.Location = new System.Drawing.Point(7, 3);
            this.TBBuscar.Name = "TBBuscar";
            this.TBBuscar.Size = new System.Drawing.Size(193, 19);
            this.TBBuscar.TabIndex = 2;
            this.TBBuscar.Text = "Buscar productos...";
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
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
            // LBucarPor
            // 
            this.LBucarPor.AutoSize = true;
            this.LBucarPor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBucarPor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LBucarPor.Location = new System.Drawing.Point(452, 91);
            this.LBucarPor.Name = "LBucarPor";
            this.LBucarPor.Size = new System.Drawing.Size(106, 24);
            this.LBucarPor.TabIndex = 4;
            this.LBucarPor.Text = "Buscar por:";
            // 
            // CBBuscarPor
            // 
            this.CBBuscarPor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CBBuscarPor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CBBuscarPor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CBBuscarPor.FormattingEnabled = true;
            this.CBBuscarPor.Items.AddRange(new object[] {
            "Nombre",
            "Categoria"});
            this.CBBuscarPor.Location = new System.Drawing.Point(564, 96);
            this.CBBuscarPor.Name = "CBBuscarPor";
            this.CBBuscarPor.Size = new System.Drawing.Size(121, 21);
            this.CBBuscarPor.TabIndex = 5;
            this.CBBuscarPor.Text = "Buscar por:";
            // 
            // PBuscarProductos
            // 
            this.PBuscarProductos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PBuscarProductos.Controls.Add(this.TBBuscar);
            this.PBuscarProductos.Controls.Add(this.BtnBuscar);
            this.PBuscarProductos.Location = new System.Drawing.Point(88, 96);
            this.PBuscarProductos.Name = "PBuscarProductos";
            this.PBuscarProductos.Size = new System.Drawing.Size(244, 29);
            this.PBuscarProductos.TabIndex = 6;
            // 
            // CatalogoProductosVendedorUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.PBuscarProductos);
            this.Controls.Add(this.CBBuscarPor);
            this.Controls.Add(this.LBucarPor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGCatalogoProductos);
            this.Name = "CatalogoProductosVendedorUserControl";
            this.Size = new System.Drawing.Size(1201, 660);
            ((System.ComponentModel.ISupportInitialize)(this.DGCatalogoProductos)).EndInit();
            this.PBuscarProductos.ResumeLayout(false);
            this.PBuscarProductos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGCatalogoProductos;
        private System.Windows.Forms.DataGridViewImageColumn CImagen;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn CStock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBBuscar;
        private FontAwesome.Sharp.IconButton BtnBuscar;
        private System.Windows.Forms.Label LBucarPor;
        private System.Windows.Forms.ComboBox CBBuscarPor;
        private System.Windows.Forms.Panel PBuscarProductos;
    }
}

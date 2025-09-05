namespace CapaPresentacion.Vendedor
{
    partial class ControlBotonProdcutos
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.LTitulo = new System.Windows.Forms.Label();
            this.LPrecio = new System.Windows.Forms.Label();
            this.BCarrito = new FontAwesome.Sharp.IconButton();
            this.PBProducto = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.BCarrito);
            this.panel1.Controls.Add(this.PBProducto);
            this.panel1.Controls.Add(this.LPrecio);
            this.panel1.Controls.Add(this.LTitulo);
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(205, 281);
            this.panel1.TabIndex = 0;
            // 
            // LTitulo
            // 
            this.LTitulo.AutoSize = true;
            this.LTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LTitulo.Location = new System.Drawing.Point(12, 0);
            this.LTitulo.Name = "LTitulo";
            this.LTitulo.Size = new System.Drawing.Size(177, 20);
            this.LTitulo.TabIndex = 1;
            this.LTitulo.Text = "Nombre del Producto";
            // 
            // LPrecio
            // 
            this.LPrecio.AutoSize = true;
            this.LPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LPrecio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LPrecio.Location = new System.Drawing.Point(20, 191);
            this.LPrecio.Name = "LPrecio";
            this.LPrecio.Size = new System.Drawing.Size(66, 20);
            this.LPrecio.TabIndex = 2;
            this.LPrecio.Text = "$ Precio";
            // 
            // BCarrito
            // 
            this.BCarrito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BCarrito.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BCarrito.FlatAppearance.BorderSize = 0;
            this.BCarrito.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BCarrito.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BCarrito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BCarrito.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BCarrito.ForeColor = System.Drawing.Color.White;
            this.BCarrito.IconChar = FontAwesome.Sharp.IconChar.CartShopping;
            this.BCarrito.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BCarrito.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BCarrito.IconSize = 32;
            this.BCarrito.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BCarrito.Location = new System.Drawing.Point(16, 223);
            this.BCarrito.Name = "BCarrito";
            this.BCarrito.Size = new System.Drawing.Size(161, 45);
            this.BCarrito.TabIndex = 3;
            this.BCarrito.Text = "Añadir al Carrito";
            this.BCarrito.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BCarrito.UseVisualStyleBackColor = false;
            // 
            // PBProducto
            // 
            this.PBProducto.Location = new System.Drawing.Point(7, 23);
            this.PBProducto.Name = "PBProducto";
            this.PBProducto.Size = new System.Drawing.Size(182, 150);
            this.PBProducto.TabIndex = 0;
            this.PBProducto.TabStop = false;
            // 
            // ControlBotonProdcutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Name = "ControlBotonProdcutos";
            this.Size = new System.Drawing.Size(205, 281);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBProducto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LPrecio;
        private System.Windows.Forms.Label LTitulo;
        private System.Windows.Forms.PictureBox PBProducto;
        private FontAwesome.Sharp.IconButton BCarrito;
    }
}

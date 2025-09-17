namespace CapaPresentacion.Admin
{
    partial class AgregarProductos
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
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.lblNombreProducto = new System.Windows.Forms.Label();
            this.txtDescripcionProductos = new System.Windows.Forms.TextBox();
            this.lblTipoProducto = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboCategoría = new System.Windows.Forms.ComboBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.cboTipoProducto = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtRutaImagen = new System.Windows.Forms.TextBox();
            this.btnSeleccionarImagen = new System.Windows.Forms.Button();
            this.picImagen = new System.Windows.Forms.PictureBox();
            this.btnAgregarProductos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Location = new System.Drawing.Point(218, 56);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(221, 20);
            this.txtNombreProducto.TabIndex = 0;
            // 
            // lblNombreProducto
            // 
            this.lblNombreProducto.AutoSize = true;
            this.lblNombreProducto.Location = new System.Drawing.Point(97, 59);
            this.lblNombreProducto.Name = "lblNombreProducto";
            this.lblNombreProducto.Size = new System.Drawing.Size(90, 13);
            this.lblNombreProducto.TabIndex = 1;
            this.lblNombreProducto.Text = "Nombre Producto";
            // 
            // txtDescripcionProductos
            // 
            this.txtDescripcionProductos.Location = new System.Drawing.Point(218, 255);
            this.txtDescripcionProductos.Multiline = true;
            this.txtDescripcionProductos.Name = "txtDescripcionProductos";
            this.txtDescripcionProductos.Size = new System.Drawing.Size(262, 84);
            this.txtDescripcionProductos.TabIndex = 2;
            // 
            // lblTipoProducto
            // 
            this.lblTipoProducto.AutoSize = true;
            this.lblTipoProducto.Location = new System.Drawing.Point(97, 140);
            this.lblTipoProducto.Name = "lblTipoProducto";
            this.lblTipoProducto.Size = new System.Drawing.Size(88, 13);
            this.lblTipoProducto.TabIndex = 3;
            this.lblTipoProducto.Text = "Tipo de producto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Categoría";
            // 
            // cboCategoría
            // 
            this.cboCategoría.FormattingEnabled = true;
            this.cboCategoría.Items.AddRange(new object[] {
            "comboBox1.Items.Add(\"Camisetas\");",
            "comboBox1.Items.Add(\"Pantalones\");",
            "comboBox1.Items.Add(\"Jueguetes coleccionables\");",
            "comboBox1.Items.Add(\"Gorras\");"});
            this.cboCategoría.Location = new System.Drawing.Point(218, 99);
            this.cboCategoría.Name = "cboCategoría";
            this.cboCategoría.Size = new System.Drawing.Size(154, 21);
            this.cboCategoría.TabIndex = 5;
            this.cboCategoría.SelectedIndexChanged += new System.EventHandler(this.cboCategoría_SelectedIndexChanged);
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(104, 258);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 6;
            this.lblDescripcion.Text = "Descripción";
            // 
            // cboTipoProducto
            // 
            this.cboTipoProducto.FormattingEnabled = true;
            this.cboTipoProducto.Items.AddRange(new object[] {
            "comboBox1.Items.Add(\"Camisetas\");",
            "comboBox1.Items.Add(\"Pantalones\");",
            "comboBox1.Items.Add(\"Jueguetes coleccionables\");",
            "comboBox1.Items.Add(\"Gorras\");"});
            this.cboTipoProducto.Location = new System.Drawing.Point(218, 137);
            this.cboTipoProducto.Name = "cboTipoProducto";
            this.cboTipoProducto.Size = new System.Drawing.Size(154, 21);
            this.cboTipoProducto.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Imagen";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtRutaImagen
            // 
            this.txtRutaImagen.Location = new System.Drawing.Point(218, 176);
            this.txtRutaImagen.Name = "txtRutaImagen";
            this.txtRutaImagen.ReadOnly = true;
            this.txtRutaImagen.Size = new System.Drawing.Size(262, 20);
            this.txtRutaImagen.TabIndex = 9;
            // 
            // btnSeleccionarImagen
            // 
            this.btnSeleccionarImagen.Location = new System.Drawing.Point(359, 213);
            this.btnSeleccionarImagen.Name = "btnSeleccionarImagen";
            this.btnSeleccionarImagen.Size = new System.Drawing.Size(121, 23);
            this.btnSeleccionarImagen.TabIndex = 10;
            this.btnSeleccionarImagen.Text = "Seleccionar Imagen";
            this.btnSeleccionarImagen.UseVisualStyleBackColor = true;
            this.btnSeleccionarImagen.Click += new System.EventHandler(this.btnSeleccionarImagen_Click);
            // 
            // picImagen
            // 
            this.picImagen.Location = new System.Drawing.Point(534, 56);
            this.picImagen.Name = "picImagen";
            this.picImagen.Size = new System.Drawing.Size(149, 121);
            this.picImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picImagen.TabIndex = 11;
            this.picImagen.TabStop = false;
            this.picImagen.Click += new System.EventHandler(this.picImagen_Click);
            // 
            // btnAgregarProductos
            // 
            this.btnAgregarProductos.Location = new System.Drawing.Point(571, 353);
            this.btnAgregarProductos.Name = "btnAgregarProductos";
            this.btnAgregarProductos.Size = new System.Drawing.Size(112, 44);
            this.btnAgregarProductos.TabIndex = 12;
            this.btnAgregarProductos.Text = "Agregar productos";
            this.btnAgregarProductos.UseVisualStyleBackColor = true;
            this.btnAgregarProductos.Click += new System.EventHandler(this.btnAgregarProductos_Click);
            // 
            // AgregarProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Controls.Add(this.btnAgregarProductos);
            this.Controls.Add(this.picImagen);
            this.Controls.Add(this.btnSeleccionarImagen);
            this.Controls.Add(this.txtRutaImagen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboTipoProducto);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.cboCategoría);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTipoProducto);
            this.Controls.Add(this.txtDescripcionProductos);
            this.Controls.Add(this.lblNombreProducto);
            this.Controls.Add(this.txtNombreProducto);
            this.Name = "AgregarProductos";
            this.Size = new System.Drawing.Size(718, 420);
            ((System.ComponentModel.ISupportInitialize)(this.picImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.Label lblNombreProducto;
        private System.Windows.Forms.TextBox txtDescripcionProductos;
        private System.Windows.Forms.Label lblTipoProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboCategoría;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.ComboBox cboTipoProducto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtRutaImagen;
        private System.Windows.Forms.Button btnSeleccionarImagen;
        private System.Windows.Forms.PictureBox picImagen;
        private System.Windows.Forms.Button btnAgregarProductos;
    }
}

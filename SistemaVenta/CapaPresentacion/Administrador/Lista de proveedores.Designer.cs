namespace CapaPresentacion.Administrador
{
    partial class Lista_de_proveedores
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.CNroDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CRazonSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCiudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CNroDocumento,
            this.CRazonSocial,
            this.CTelefono,
            this.CCiudad,
            this.CEliminar});
            this.dataGridView2.Location = new System.Drawing.Point(0, 2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(667, 448);
            this.dataGridView2.TabIndex = 7;
            // 
            // CNroDocumento
            // 
            this.CNroDocumento.HeaderText = "Nro Documento";
            this.CNroDocumento.Name = "CNroDocumento";
            this.CNroDocumento.Width = 140;
            // 
            // CRazonSocial
            // 
            this.CRazonSocial.HeaderText = "Razón Social";
            this.CRazonSocial.Name = "CRazonSocial";
            this.CRazonSocial.Width = 140;
            // 
            // CTelefono
            // 
            this.CTelefono.HeaderText = "Teléfono";
            this.CTelefono.Name = "CTelefono";
            this.CTelefono.Width = 140;
            // 
            // CCiudad
            // 
            this.CCiudad.HeaderText = "Estado";
            this.CCiudad.Name = "CCiudad";
            // 
            // CEliminar
            // 
            this.CEliminar.HeaderText = "Eliminar";
            this.CEliminar.Name = "CEliminar";
            // 
            // Lista_de_proveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 450);
            this.Controls.Add(this.dataGridView2);
            this.Name = "Lista_de_proveedores";
            this.Text = "Lista_de_proveedores";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNroDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn CRazonSocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn CTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCiudad;
        private System.Windows.Forms.DataGridViewButtonColumn CEliminar;
    }
}
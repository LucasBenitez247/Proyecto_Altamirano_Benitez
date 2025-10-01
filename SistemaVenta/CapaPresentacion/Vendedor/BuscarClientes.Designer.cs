namespace CapaPresentacion.Vendedor
{
    partial class BuscarClientes
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
            this.LListClientes = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TBuscarCliente = new System.Windows.Forms.TextBox();
            this.IBtnBuscarCliente = new FontAwesome.Sharp.IconButton();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.CNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CDNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCorreo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CDireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCiudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PProvincia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCodigo_Postal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // LListClientes
            // 
            this.LListClientes.AutoSize = true;
            this.LListClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LListClientes.ForeColor = System.Drawing.Color.Black;
            this.LListClientes.Location = new System.Drawing.Point(269, 9);
            this.LListClientes.Name = "LListClientes";
            this.LListClientes.Size = new System.Drawing.Size(232, 31);
            this.LListClientes.TabIndex = 25;
            this.LListClientes.Text = "Lista de Clientes";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.TBuscarCliente);
            this.panel1.Controls.Add(this.IBtnBuscarCliente);
            this.panel1.Location = new System.Drawing.Point(12, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(244, 29);
            this.panel1.TabIndex = 24;
            // 
            // TBuscarCliente
            // 
            this.TBuscarCliente.BackColor = System.Drawing.Color.White;
            this.TBuscarCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBuscarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBuscarCliente.ForeColor = System.Drawing.Color.Black;
            this.TBuscarCliente.Location = new System.Drawing.Point(7, 5);
            this.TBuscarCliente.Name = "TBuscarCliente";
            this.TBuscarCliente.Size = new System.Drawing.Size(193, 19);
            this.TBuscarCliente.TabIndex = 2;
            this.TBuscarCliente.Text = "Buscar Cliente...";
            this.TBuscarCliente.Click += new System.EventHandler(this.TBuscarCliente_Click);
            // 
            // IBtnBuscarCliente
            // 
            this.IBtnBuscarCliente.BackColor = System.Drawing.Color.White;
            this.IBtnBuscarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IBtnBuscarCliente.FlatAppearance.BorderSize = 0;
            this.IBtnBuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IBtnBuscarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.IBtnBuscarCliente.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.IBtnBuscarCliente.IconColor = System.Drawing.Color.Black;
            this.IBtnBuscarCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IBtnBuscarCliente.IconSize = 32;
            this.IBtnBuscarCliente.Location = new System.Drawing.Point(206, 2);
            this.IBtnBuscarCliente.Name = "IBtnBuscarCliente";
            this.IBtnBuscarCliente.Size = new System.Drawing.Size(24, 25);
            this.IBtnBuscarCliente.TabIndex = 3;
            this.IBtnBuscarCliente.UseVisualStyleBackColor = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CNombre,
            this.CApellido,
            this.CDNI,
            this.CCorreo,
            this.CTelefono,
            this.CDireccion,
            this.CCiudad,
            this.PProvincia,
            this.CCodigo_Postal,
            this.CEliminar});
            this.dataGridView2.Location = new System.Drawing.Point(12, 78);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(776, 402);
            this.dataGridView2.TabIndex = 23;
            // 
            // CNombre
            // 
            this.CNombre.HeaderText = "Nombre";
            this.CNombre.Name = "CNombre";
            // 
            // CApellido
            // 
            this.CApellido.HeaderText = "Apellido";
            this.CApellido.Name = "CApellido";
            // 
            // CDNI
            // 
            this.CDNI.HeaderText = "DNI";
            this.CDNI.Name = "CDNI";
            // 
            // CCorreo
            // 
            this.CCorreo.HeaderText = "Correo";
            this.CCorreo.Name = "CCorreo";
            // 
            // CTelefono
            // 
            this.CTelefono.HeaderText = "Teléfono";
            this.CTelefono.Name = "CTelefono";
            // 
            // CDireccion
            // 
            this.CDireccion.HeaderText = "Dirección(Calle y Nro)";
            this.CDireccion.Name = "CDireccion";
            // 
            // CCiudad
            // 
            this.CCiudad.HeaderText = "Ciudad";
            this.CCiudad.Name = "CCiudad";
            // 
            // PProvincia
            // 
            this.PProvincia.HeaderText = "Provincia";
            this.PProvincia.Name = "PProvincia";
            // 
            // CCodigo_Postal
            // 
            this.CCodigo_Postal.HeaderText = "Código Postal";
            this.CCodigo_Postal.Name = "CCodigo_Postal";
            // 
            // CEliminar
            // 
            this.CEliminar.HeaderText = "Eliminar";
            this.CEliminar.Name = "CEliminar";
            // 
            // BuscarClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 512);
            this.Controls.Add(this.LListClientes);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "BuscarClientes";
            this.Text = "Lista de clientes";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LListClientes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TBuscarCliente;
        private FontAwesome.Sharp.IconButton IBtnBuscarCliente;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn CApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCorreo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDireccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCiudad;
        private System.Windows.Forms.DataGridViewTextBoxColumn PProvincia;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCodigo_Postal;
        private System.Windows.Forms.DataGridViewButtonColumn CEliminar;
    }
}
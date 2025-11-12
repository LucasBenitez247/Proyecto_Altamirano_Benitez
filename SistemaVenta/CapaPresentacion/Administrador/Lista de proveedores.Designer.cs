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
            this.pnlListaProveedores = new System.Windows.Forms.Panel();
            this.pnlBuscarPor = new System.Windows.Forms.Panel();
            this.txtBuscador = new System.Windows.Forms.TextBox();
            this.cboBuscarPor = new System.Windows.Forms.ComboBox();
            this.lblBuscarPor = new System.Windows.Forms.Label();
            this.dgvProveedores = new System.Windows.Forms.DataGridView();
            this.idProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CDni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CRazonSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSeleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlListaProveedores.SuspendLayout();
            this.pnlBuscarPor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlListaProveedores
            // 
            this.pnlListaProveedores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.pnlListaProveedores.Controls.Add(this.pnlBuscarPor);
            this.pnlListaProveedores.Controls.Add(this.dgvProveedores);
            this.pnlListaProveedores.Controls.Add(this.label1);
            this.pnlListaProveedores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlListaProveedores.Location = new System.Drawing.Point(0, 0);
            this.pnlListaProveedores.Name = "pnlListaProveedores";
            this.pnlListaProveedores.Size = new System.Drawing.Size(517, 450);
            this.pnlListaProveedores.TabIndex = 7;
            // 
            // pnlBuscarPor
            // 
            this.pnlBuscarPor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlBuscarPor.Controls.Add(this.txtBuscador);
            this.pnlBuscarPor.Controls.Add(this.cboBuscarPor);
            this.pnlBuscarPor.Controls.Add(this.lblBuscarPor);
            this.pnlBuscarPor.Location = new System.Drawing.Point(12, 91);
            this.pnlBuscarPor.Name = "pnlBuscarPor";
            this.pnlBuscarPor.Size = new System.Drawing.Size(480, 80);
            this.pnlBuscarPor.TabIndex = 8;
            // 
            // txtBuscador
            // 
            this.txtBuscador.Location = new System.Drawing.Point(244, 29);
            this.txtBuscador.Name = "txtBuscador";
            this.txtBuscador.Size = new System.Drawing.Size(215, 20);
            this.txtBuscador.TabIndex = 9;
            // 
            // cboBuscarPor
            // 
            this.cboBuscarPor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBuscarPor.FormattingEnabled = true;
            this.cboBuscarPor.Items.AddRange(new object[] {
            "Número de Documento",
            "Razón Social"});
            this.cboBuscarPor.Location = new System.Drawing.Point(133, 29);
            this.cboBuscarPor.Name = "cboBuscarPor";
            this.cboBuscarPor.Size = new System.Drawing.Size(94, 21);
            this.cboBuscarPor.TabIndex = 3;
            // 
            // lblBuscarPor
            // 
            this.lblBuscarPor.AutoSize = true;
            this.lblBuscarPor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarPor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblBuscarPor.Location = new System.Drawing.Point(26, 32);
            this.lblBuscarPor.Name = "lblBuscarPor";
            this.lblBuscarPor.Size = new System.Drawing.Size(85, 18);
            this.lblBuscarPor.TabIndex = 2;
            this.lblBuscarPor.Text = "Buscar por:";
            // 
            // dgvProveedores
            // 
            this.dgvProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProveedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProveedor,
            this.CDni,
            this.CRazonSocial,
            this.btnSeleccionar});
            this.dgvProveedores.Location = new System.Drawing.Point(12, 197);
            this.dgvProveedores.Name = "dgvProveedores";
            this.dgvProveedores.Size = new System.Drawing.Size(480, 253);
            this.dgvProveedores.TabIndex = 7;
            this.dgvProveedores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProveedores_CellClick);
            this.dgvProveedores.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProveedores_CellDoubleClick);
            // 
            // idProveedor
            // 
            this.idProveedor.HeaderText = "ID";
            this.idProveedor.Name = "idProveedor";
            this.idProveedor.Visible = false;
            this.idProveedor.Width = 70;
            // 
            // CDni
            // 
            this.CDni.HeaderText = "DNI";
            this.CDni.Name = "CDni";
            // 
            // CRazonSocial
            // 
            this.CRazonSocial.HeaderText = "Razón Social";
            this.CRazonSocial.Name = "CRazonSocial";
            this.CRazonSocial.Width = 150;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.HeaderText = "Selección";
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseColumnTextForButtonValue = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(140, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lista de Proveedores";
            // 
            // Lista_de_proveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 450);
            this.Controls.Add(this.pnlListaProveedores);
            this.Name = "Lista_de_proveedores";
            this.Text = "Lista_de_proveedores";
            this.Load += new System.EventHandler(this.Lista_de_proveedores_Load);
            this.pnlListaProveedores.ResumeLayout(false);
            this.pnlListaProveedores.PerformLayout();
            this.pnlBuscarPor.ResumeLayout(false);
            this.pnlBuscarPor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlListaProveedores;
        private System.Windows.Forms.Panel pnlBuscarPor;
        private System.Windows.Forms.TextBox txtBuscador;
        private System.Windows.Forms.ComboBox cboBuscarPor;
        private System.Windows.Forms.Label lblBuscarPor;
        private System.Windows.Forms.DataGridView dgvProveedores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDni;
        private System.Windows.Forms.DataGridViewTextBoxColumn CRazonSocial;
        private System.Windows.Forms.DataGridViewButtonColumn btnSeleccionar;
    }
}
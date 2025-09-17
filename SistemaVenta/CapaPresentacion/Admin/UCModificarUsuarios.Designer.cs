namespace Administrador
{
    partial class UCModificarUsuarios
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
            this.lEliminarUsuario = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lNombreUsuario = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgvListaUsuarios = new System.Windows.Forms.DataGridView();
            this.cNombreUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCuil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDomicilio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cRol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // lEliminarUsuario
            // 
            this.lEliminarUsuario.AutoSize = true;
            this.lEliminarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lEliminarUsuario.Location = new System.Drawing.Point(176, 47);
            this.lEliminarUsuario.Name = "lEliminarUsuario";
            this.lEliminarUsuario.Size = new System.Drawing.Size(213, 29);
            this.lEliminarUsuario.TabIndex = 9;
            this.lEliminarUsuario.Text = "Modificar Usuarios";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(181, 108);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(364, 20);
            this.textBox1.TabIndex = 10;
            // 
            // lNombreUsuario
            // 
            this.lNombreUsuario.AutoSize = true;
            this.lNombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNombreUsuario.Location = new System.Drawing.Point(26, 110);
            this.lNombreUsuario.Name = "lNombreUsuario";
            this.lNombreUsuario.Size = new System.Drawing.Size(138, 18);
            this.lNombreUsuario.TabIndex = 11;
            this.lNombreUsuario.Text = "Nombre de Usuario";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(470, 168);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 12;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // dgvListaUsuarios
            // 
            this.dgvListaUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cNombreUsuario,
            this.cCuil,
            this.cNombre,
            this.cApellido,
            this.cDomicilio,
            this.cRol});
            this.dgvListaUsuarios.Location = new System.Drawing.Point(29, 238);
            this.dgvListaUsuarios.Name = "dgvListaUsuarios";
            this.dgvListaUsuarios.Size = new System.Drawing.Size(706, 220);
            this.dgvListaUsuarios.TabIndex = 13;
            // 
            // cNombreUsuario
            // 
            this.cNombreUsuario.HeaderText = "Nombre de Usuario";
            this.cNombreUsuario.Name = "cNombreUsuario";
            // 
            // cCuil
            // 
            this.cCuil.HeaderText = "CUIL";
            this.cCuil.Name = "cCuil";
            // 
            // cNombre
            // 
            this.cNombre.HeaderText = "Nombre";
            this.cNombre.Name = "cNombre";
            // 
            // cApellido
            // 
            this.cApellido.HeaderText = "Apellido";
            this.cApellido.Name = "cApellido";
            // 
            // cDomicilio
            // 
            this.cDomicilio.HeaderText = "Domicilio";
            this.cDomicilio.Name = "cDomicilio";
            // 
            // cRol
            // 
            this.cRol.HeaderText = "Rol";
            this.cRol.Name = "cRol";
            // 
            // UCModificarUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvListaUsuarios);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lNombreUsuario);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lEliminarUsuario);
            this.Name = "UCModificarUsuarios";
            this.Size = new System.Drawing.Size(592, 383);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lEliminarUsuario;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lNombreUsuario;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgvListaUsuarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNombreUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCuil;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn cApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDomicilio;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRol;
    }
}

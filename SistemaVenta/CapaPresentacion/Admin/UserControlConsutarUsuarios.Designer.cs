namespace Administrador
{
    partial class UserControlConsutarUsuarios
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgvListaUsuarios = new System.Windows.Forms.DataGridView();
            this.cNombreUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCuil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDomicilio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cRol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lApellido = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // lEliminarUsuario
            // 
            this.lEliminarUsuario.AutoSize = true;
            this.lEliminarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lEliminarUsuario.Location = new System.Drawing.Point(188, 38);
            this.lEliminarUsuario.Name = "lEliminarUsuario";
            this.lEliminarUsuario.Size = new System.Drawing.Size(216, 29);
            this.lEliminarUsuario.TabIndex = 8;
            this.lEliminarUsuario.Text = "Consultar Usuarios";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(134, 110);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(364, 20);
            this.txtNombre.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nombre";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(423, 201);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 11;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.button1_Click);
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
            this.dgvListaUsuarios.Location = new System.Drawing.Point(-10, 244);
            this.dgvListaUsuarios.Name = "dgvListaUsuarios";
            this.dgvListaUsuarios.Size = new System.Drawing.Size(679, 145);
            this.dgvListaUsuarios.TabIndex = 12;
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
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(134, 158);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(364, 20);
            this.txtApellido.TabIndex = 13;
            // 
            // lApellido
            // 
            this.lApellido.AutoSize = true;
            this.lApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lApellido.Location = new System.Drawing.Point(55, 157);
            this.lApellido.Name = "lApellido";
            this.lApellido.Size = new System.Drawing.Size(59, 18);
            this.lApellido.TabIndex = 14;
            this.lApellido.Text = "Apellido";
            // 
            // UserControlConsutarUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lApellido);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.dgvListaUsuarios);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lEliminarUsuario);
            this.Name = "UserControlConsutarUsuarios";
            this.Size = new System.Drawing.Size(642, 356);
            this.Load += new System.EventHandler(this.UserControlConsutarUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lEliminarUsuario;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgvListaUsuarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNombreUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCuil;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn cApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDomicilio;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRol;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lApellido;
    }
}

namespace CapaPresentacion
{
    partial class Login
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
            this.BtnVendedor = new System.Windows.Forms.Button();
            this.BtnDueñoNegocio = new System.Windows.Forms.Button();
            this.BtnAdministrador = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnVendedor
            // 
            this.BtnVendedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnVendedor.FlatAppearance.BorderSize = 0;
            this.BtnVendedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVendedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnVendedor.Location = new System.Drawing.Point(252, 69);
            this.BtnVendedor.Name = "BtnVendedor";
            this.BtnVendedor.Size = new System.Drawing.Size(182, 51);
            this.BtnVendedor.TabIndex = 0;
            this.BtnVendedor.Text = "Vendedor";
            this.BtnVendedor.UseVisualStyleBackColor = false;
            this.BtnVendedor.Click += new System.EventHandler(this.BtnVendedor_Click);
            // 
            // BtnDueñoNegocio
            // 
            this.BtnDueñoNegocio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnDueñoNegocio.FlatAppearance.BorderSize = 0;
            this.BtnDueñoNegocio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDueñoNegocio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDueñoNegocio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnDueñoNegocio.Location = new System.Drawing.Point(252, 261);
            this.BtnDueñoNegocio.Name = "BtnDueñoNegocio";
            this.BtnDueñoNegocio.Size = new System.Drawing.Size(182, 51);
            this.BtnDueñoNegocio.TabIndex = 1;
            this.BtnDueñoNegocio.Text = "Dueño de Negocio";
            this.BtnDueñoNegocio.UseVisualStyleBackColor = false;
            // 
            // BtnAdministrador
            // 
            this.BtnAdministrador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnAdministrador.FlatAppearance.BorderSize = 0;
            this.BtnAdministrador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdministrador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdministrador.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnAdministrador.Location = new System.Drawing.Point(252, 163);
            this.BtnAdministrador.Name = "BtnAdministrador";
            this.BtnAdministrador.Size = new System.Drawing.Size(182, 51);
            this.BtnAdministrador.TabIndex = 2;
            this.BtnAdministrador.Text = "Administrador";
            this.BtnAdministrador.UseVisualStyleBackColor = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnAdministrador);
            this.Controls.Add(this.BtnDueñoNegocio);
            this.Controls.Add(this.BtnVendedor);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnVendedor;
        private System.Windows.Forms.Button BtnDueñoNegocio;
        private System.Windows.Forms.Button BtnAdministrador;
    }
}
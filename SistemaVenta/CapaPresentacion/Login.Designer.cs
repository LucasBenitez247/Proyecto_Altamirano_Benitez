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
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnIniciarSesion = new System.Windows.Forms.Button();
            this.LLogin = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.LContraseña = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.LUsuario = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnVendedor
            // 
            this.BtnVendedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnVendedor.FlatAppearance.BorderSize = 0;
            this.BtnVendedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVendedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnVendedor.Location = new System.Drawing.Point(50, 342);
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
            this.BtnDueñoNegocio.Location = new System.Drawing.Point(302, 342);
            this.BtnDueñoNegocio.Name = "BtnDueñoNegocio";
            this.BtnDueñoNegocio.Size = new System.Drawing.Size(182, 51);
            this.BtnDueñoNegocio.TabIndex = 1;
            this.BtnDueñoNegocio.Text = "Dueño de Negocio";
            this.BtnDueñoNegocio.UseVisualStyleBackColor = false;
            this.BtnDueñoNegocio.Click += new System.EventHandler(this.BtnDueñoNegocio_Click);
            // 
            // BtnAdministrador
            // 
            this.BtnAdministrador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnAdministrador.FlatAppearance.BorderSize = 0;
            this.BtnAdministrador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdministrador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdministrador.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnAdministrador.Location = new System.Drawing.Point(581, 342);
            this.BtnAdministrador.Name = "BtnAdministrador";
            this.BtnAdministrador.Size = new System.Drawing.Size(182, 51);
            this.BtnAdministrador.TabIndex = 2;
            this.BtnAdministrador.Text = "Administrador";
            this.BtnAdministrador.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.BtnIniciarSesion);
            this.panel1.Controls.Add(this.LLogin);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.LContraseña);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.LUsuario);
            this.panel1.Location = new System.Drawing.Point(143, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(484, 285);
            this.panel1.TabIndex = 3;
            // 
            // BtnIniciarSesion
            // 
            this.BtnIniciarSesion.BackColor = System.Drawing.Color.Navy;
            this.BtnIniciarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnIniciarSesion.FlatAppearance.BorderSize = 0;
            this.BtnIniciarSesion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnIniciarSesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BtnIniciarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnIniciarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIniciarSesion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnIniciarSesion.Location = new System.Drawing.Point(159, 220);
            this.BtnIniciarSesion.Name = "BtnIniciarSesion";
            this.BtnIniciarSesion.Size = new System.Drawing.Size(182, 51);
            this.BtnIniciarSesion.TabIndex = 5;
            this.BtnIniciarSesion.Text = "Iniciar Sesión";
            this.BtnIniciarSesion.UseVisualStyleBackColor = false;
            // 
            // LLogin
            // 
            this.LLogin.AutoSize = true;
            this.LLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LLogin.Location = new System.Drawing.Point(189, 13);
            this.LLogin.Name = "LLogin";
            this.LLogin.Size = new System.Drawing.Size(80, 31);
            this.LLogin.TabIndex = 4;
            this.LLogin.Text = "Login";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(94, 172);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(291, 20);
            this.textBox2.TabIndex = 3;
            // 
            // LContraseña
            // 
            this.LContraseña.AutoSize = true;
            this.LContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LContraseña.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LContraseña.Location = new System.Drawing.Point(90, 140);
            this.LContraseña.Name = "LContraseña";
            this.LContraseña.Size = new System.Drawing.Size(96, 20);
            this.LContraseña.TabIndex = 2;
            this.LContraseña.Text = "Contraseña:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(94, 100);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(291, 20);
            this.textBox1.TabIndex = 1;
            // 
            // LUsuario
            // 
            this.LUsuario.AutoSize = true;
            this.LUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LUsuario.Location = new System.Drawing.Point(90, 67);
            this.LUsuario.Name = "LUsuario";
            this.LUsuario.Size = new System.Drawing.Size(224, 20);
            this.LUsuario.TabIndex = 0;
            this.LUsuario.Text = "Ingrese su nombre de usuario:";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnAdministrador);
            this.Controls.Add(this.BtnDueñoNegocio);
            this.Controls.Add(this.BtnVendedor);
            this.Name = "Login";
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnVendedor;
        private System.Windows.Forms.Button BtnDueñoNegocio;
        private System.Windows.Forms.Button BtnAdministrador;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LUsuario;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label LContraseña;
        private System.Windows.Forms.Button BtnIniciarSesion;
        private System.Windows.Forms.Label LLogin;
        private System.Windows.Forms.TextBox textBox2;
    }
}
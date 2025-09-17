namespace CapaPresentacion.Admin
{
    partial class formGestionUsuarios
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
            this.panelOpciones = new System.Windows.Forms.Panel();
            this.btnAgregarUsuario = new System.Windows.Forms.Button();
            this.btnModificarUsuarios = new System.Windows.Forms.Button();
            this.btnVerUsuarios = new System.Windows.Forms.Button();
            this.btnEliminarUsuario = new System.Windows.Forms.Button();
            this.panelinfo = new System.Windows.Forms.Panel();
            this.panelOpciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelOpciones
            // 
            this.panelOpciones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelOpciones.BackColor = System.Drawing.Color.Gray;
            this.panelOpciones.Controls.Add(this.btnAgregarUsuario);
            this.panelOpciones.Controls.Add(this.btnModificarUsuarios);
            this.panelOpciones.Controls.Add(this.btnVerUsuarios);
            this.panelOpciones.Controls.Add(this.btnEliminarUsuario);
            this.panelOpciones.Location = new System.Drawing.Point(0, 0);
            this.panelOpciones.Name = "panelOpciones";
            this.panelOpciones.Size = new System.Drawing.Size(274, 450);
            this.panelOpciones.TabIndex = 1;
            this.panelOpciones.Paint += new System.Windows.Forms.PaintEventHandler(this.panelOpciones_Paint);
            // 
            // btnAgregarUsuario
            // 
            this.btnAgregarUsuario.BackColor = System.Drawing.Color.DarkGray;
            this.btnAgregarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarUsuario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAgregarUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarUsuario.Location = new System.Drawing.Point(38, 71);
            this.btnAgregarUsuario.Margin = new System.Windows.Forms.Padding(0);
            this.btnAgregarUsuario.Name = "btnAgregarUsuario";
            this.btnAgregarUsuario.Size = new System.Drawing.Size(161, 66);
            this.btnAgregarUsuario.TabIndex = 15;
            this.btnAgregarUsuario.Text = "Agregar usuario";
            this.btnAgregarUsuario.UseVisualStyleBackColor = false;
            this.btnAgregarUsuario.Click += new System.EventHandler(this.btnAgregarUsuario_Click);
            this.btnAgregarUsuario.MouseEnter += new System.EventHandler(this.btnAgregarUsuario_MouseEnter);
            this.btnAgregarUsuario.MouseLeave += new System.EventHandler(this.btnAgregarUsuario_MouseLeave);
            // 
            // btnModificarUsuarios
            // 
            this.btnModificarUsuarios.BackColor = System.Drawing.Color.DarkGray;
            this.btnModificarUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModificarUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarUsuarios.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnModificarUsuarios.Location = new System.Drawing.Point(38, 343);
            this.btnModificarUsuarios.Margin = new System.Windows.Forms.Padding(0);
            this.btnModificarUsuarios.Name = "btnModificarUsuarios";
            this.btnModificarUsuarios.Size = new System.Drawing.Size(161, 66);
            this.btnModificarUsuarios.TabIndex = 10;
            this.btnModificarUsuarios.Text = "Modificar usuarios";
            this.btnModificarUsuarios.UseVisualStyleBackColor = false;
            this.btnModificarUsuarios.Click += new System.EventHandler(this.btnProductros_Click);
            this.btnModificarUsuarios.MouseEnter += new System.EventHandler(this.btnModificarUsuarios_MouseEnter);
            this.btnModificarUsuarios.MouseLeave += new System.EventHandler(this.btnModificarUsuarios_MouseLeave);
            // 
            // btnVerUsuarios
            // 
            this.btnVerUsuarios.BackColor = System.Drawing.Color.DarkGray;
            this.btnVerUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVerUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerUsuarios.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnVerUsuarios.Location = new System.Drawing.Point(38, 252);
            this.btnVerUsuarios.Margin = new System.Windows.Forms.Padding(0);
            this.btnVerUsuarios.Name = "btnVerUsuarios";
            this.btnVerUsuarios.Size = new System.Drawing.Size(161, 60);
            this.btnVerUsuarios.TabIndex = 9;
            this.btnVerUsuarios.Text = "Consultar usuarios";
            this.btnVerUsuarios.UseVisualStyleBackColor = false;
            this.btnVerUsuarios.Click += new System.EventHandler(this.btnVerUsuarios_Click);
            this.btnVerUsuarios.MouseEnter += new System.EventHandler(this.btnVerUsuarios_MouseEnter);
            this.btnVerUsuarios.MouseLeave += new System.EventHandler(this.btnVerUsuarios_MouseLeave);
            // 
            // btnEliminarUsuario
            // 
            this.btnEliminarUsuario.BackColor = System.Drawing.Color.DarkGray;
            this.btnEliminarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarUsuario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEliminarUsuario.Location = new System.Drawing.Point(38, 161);
            this.btnEliminarUsuario.Margin = new System.Windows.Forms.Padding(0);
            this.btnEliminarUsuario.Name = "btnEliminarUsuario";
            this.btnEliminarUsuario.Size = new System.Drawing.Size(161, 61);
            this.btnEliminarUsuario.TabIndex = 8;
            this.btnEliminarUsuario.Text = "Eliminar usuario";
            this.btnEliminarUsuario.UseVisualStyleBackColor = false;
            this.btnEliminarUsuario.Click += new System.EventHandler(this.btnEliminarUsuario_Click);
            this.btnEliminarUsuario.MouseEnter += new System.EventHandler(this.btnEliminarUsuario_MouseEnter);
            this.btnEliminarUsuario.MouseLeave += new System.EventHandler(this.btnEliminarUsuario_MouseLeave);
            // 
            // panelinfo
            // 
            this.panelinfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelinfo.Location = new System.Drawing.Point(280, 2);
            this.panelinfo.Name = "panelinfo";
            this.panelinfo.Size = new System.Drawing.Size(508, 361);
            this.panelinfo.TabIndex = 2;
            // 
            // formGestionUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelinfo);
            this.Controls.Add(this.panelOpciones);
            this.Name = "formGestionUsuarios";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.formGestionUsuarios_Load);
            this.panelOpciones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelOpciones;
        private System.Windows.Forms.Button btnAgregarUsuario;
        private System.Windows.Forms.Button btnModificarUsuarios;
        private System.Windows.Forms.Button btnVerUsuarios;
        private System.Windows.Forms.Button btnEliminarUsuario;
        private System.Windows.Forms.Panel panelinfo;
    }
}
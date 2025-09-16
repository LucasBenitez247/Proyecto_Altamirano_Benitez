namespace CapaPresentacion.Dueño_de_Negocio
{
    partial class PerfilDueñoNegocio
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PerfilDueñoNegocio));
            this.PContenedor = new System.Windows.Forms.Panel();
            this.LblHora = new System.Windows.Forms.Label();
            this.LblFecha = new System.Windows.Forms.Label();
            this.FechaHora = new System.Windows.Forms.Timer(this.components);
            this.BtnSalir = new FontAwesome.Sharp.IconButton();
            this.BtnInicio = new FontAwesome.Sharp.IconButton();
            this.BtnInventario = new FontAwesome.Sharp.IconButton();
            this.BtnReportes = new FontAwesome.Sharp.IconButton();
            this.BtnEstadistica = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PContenedor
            // 
            this.PContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.PContenedor.Controls.Add(this.LblHora);
            this.PContenedor.Controls.Add(this.LblFecha);
            this.PContenedor.Location = new System.Drawing.Point(168, 75);
            this.PContenedor.Name = "PContenedor";
            this.PContenedor.Size = new System.Drawing.Size(1190, 660);
            this.PContenedor.TabIndex = 11;
            // 
            // LblHora
            // 
            this.LblHora.AutoSize = true;
            this.LblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LblHora.Location = new System.Drawing.Point(315, 91);
            this.LblHora.Name = "LblHora";
            this.LblHora.Size = new System.Drawing.Size(212, 91);
            this.LblHora.TabIndex = 1;
            this.LblHora.Text = "Hora";
            // 
            // LblFecha
            // 
            this.LblFecha.AutoSize = true;
            this.LblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LblFecha.Location = new System.Drawing.Point(265, 191);
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.Size = new System.Drawing.Size(131, 46);
            this.LblFecha.TabIndex = 0;
            this.LblFecha.Text = "Fecha";
            // 
            // FechaHora
            // 
            this.FechaHora.Enabled = true;
            this.FechaHora.Tick += new System.EventHandler(this.FechaHora_Tick);
            // 
            // BtnSalir
            // 
            this.BtnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSalir.FlatAppearance.BorderSize = 0;
            this.BtnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnSalir.IconChar = FontAwesome.Sharp.IconChar.SignOut;
            this.BtnSalir.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnSalir.IconSize = 32;
            this.BtnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSalir.Location = new System.Drawing.Point(1243, 12);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(115, 57);
            this.BtnSalir.TabIndex = 12;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // BtnInicio
            // 
            this.BtnInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnInicio.FlatAppearance.BorderSize = 0;
            this.BtnInicio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtnInicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.BtnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnInicio.IconChar = FontAwesome.Sharp.IconChar.HomeLg;
            this.BtnInicio.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnInicio.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnInicio.IconSize = 32;
            this.BtnInicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnInicio.Location = new System.Drawing.Point(0, 80);
            this.BtnInicio.Name = "BtnInicio";
            this.BtnInicio.Size = new System.Drawing.Size(162, 57);
            this.BtnInicio.TabIndex = 6;
            this.BtnInicio.Text = "Inicio";
            this.BtnInicio.UseCompatibleTextRendering = true;
            this.BtnInicio.UseVisualStyleBackColor = true;
            this.BtnInicio.Click += new System.EventHandler(this.BtnInicio_Click);
            // 
            // BtnInventario
            // 
            this.BtnInventario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnInventario.FlatAppearance.BorderSize = 0;
            this.BtnInventario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtnInventario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.BtnInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInventario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnInventario.IconChar = FontAwesome.Sharp.IconChar.Warehouse;
            this.BtnInventario.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnInventario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnInventario.IconSize = 32;
            this.BtnInventario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnInventario.Location = new System.Drawing.Point(1, 269);
            this.BtnInventario.Name = "BtnInventario";
            this.BtnInventario.Size = new System.Drawing.Size(161, 57);
            this.BtnInventario.TabIndex = 9;
            this.BtnInventario.Text = "Inventario";
            this.BtnInventario.UseCompatibleTextRendering = true;
            this.BtnInventario.UseVisualStyleBackColor = true;
            this.BtnInventario.Click += new System.EventHandler(this.BtnInventario_Click);
            // 
            // BtnReportes
            // 
            this.BtnReportes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnReportes.FlatAppearance.BorderSize = 0;
            this.BtnReportes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtnReportes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.BtnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReportes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnReportes.IconChar = FontAwesome.Sharp.IconChar.ClipboardList;
            this.BtnReportes.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnReportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnReportes.IconSize = 32;
            this.BtnReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnReportes.Location = new System.Drawing.Point(1, 143);
            this.BtnReportes.Name = "BtnReportes";
            this.BtnReportes.Size = new System.Drawing.Size(161, 57);
            this.BtnReportes.TabIndex = 7;
            this.BtnReportes.Text = "Reportes";
            this.BtnReportes.UseCompatibleTextRendering = true;
            this.BtnReportes.UseVisualStyleBackColor = true;
            this.BtnReportes.Click += new System.EventHandler(this.BtnReportes_Click);
            // 
            // BtnEstadistica
            // 
            this.BtnEstadistica.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEstadistica.FlatAppearance.BorderSize = 0;
            this.BtnEstadistica.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtnEstadistica.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.BtnEstadistica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEstadistica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEstadistica.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnEstadistica.IconChar = FontAwesome.Sharp.IconChar.ChartColumn;
            this.BtnEstadistica.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnEstadistica.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnEstadistica.IconSize = 32;
            this.BtnEstadistica.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEstadistica.Location = new System.Drawing.Point(0, 206);
            this.BtnEstadistica.Name = "BtnEstadistica";
            this.BtnEstadistica.Size = new System.Drawing.Size(162, 57);
            this.BtnEstadistica.TabIndex = 8;
            this.BtnEstadistica.Text = "Estadistica";
            this.BtnEstadistica.UseCompatibleTextRendering = true;
            this.BtnEstadistica.UseVisualStyleBackColor = true;
            this.BtnEstadistica.Click += new System.EventHandler(this.BtnEstadistica_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(162, 74);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // PerfilDueñoNegocio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.PContenedor);
            this.Controls.Add(this.BtnInicio);
            this.Controls.Add(this.BtnInventario);
            this.Controls.Add(this.BtnReportes);
            this.Controls.Add(this.BtnEstadistica);
            this.Controls.Add(this.pictureBox1);
            this.Name = "PerfilDueñoNegocio";
            this.Text = "PerfilDueñoNegocio";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.PContenedor.ResumeLayout(false);
            this.PContenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton BtnInicio;
        private FontAwesome.Sharp.IconButton BtnInventario;
        private FontAwesome.Sharp.IconButton BtnReportes;
        private FontAwesome.Sharp.IconButton BtnEstadistica;
        private System.Windows.Forms.Panel PContenedor;
        private System.Windows.Forms.Label LblHora;
        private System.Windows.Forms.Label LblFecha;
        private FontAwesome.Sharp.IconButton BtnSalir;
        private System.Windows.Forms.Timer FechaHora;
    }
}
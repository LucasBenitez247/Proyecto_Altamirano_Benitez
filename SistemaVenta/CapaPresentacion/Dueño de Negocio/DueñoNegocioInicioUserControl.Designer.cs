namespace CapaPresentacion.Dueño_de_Negocio
{
    partial class DueñoNegocioInicioUserControl
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
            this.components = new System.ComponentModel.Container();
            this.LblHora = new System.Windows.Forms.Label();
            this.LblFecha = new System.Windows.Forms.Label();
            this.FechaHora = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // LblHora
            // 
            this.LblHora.AutoSize = true;
            this.LblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LblHora.Location = new System.Drawing.Point(315, 91);
            this.LblHora.Name = "LblHora";
            this.LblHora.Size = new System.Drawing.Size(212, 91);
            this.LblHora.TabIndex = 3;
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
            this.LblFecha.TabIndex = 2;
            this.LblFecha.Text = "Fecha";
            // 
            // FechaHora
            // 
            this.FechaHora.Enabled = true;
            this.FechaHora.Tick += new System.EventHandler(this.FechaHora_Tick);
            // 
            // DueñoNegocioInicioUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.Controls.Add(this.LblHora);
            this.Controls.Add(this.LblFecha);
            this.Name = "DueñoNegocioInicioUserControl";
            this.Size = new System.Drawing.Size(1201, 660);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblHora;
        private System.Windows.Forms.Label LblFecha;
        private System.Windows.Forms.Timer FechaHora;
    }
}

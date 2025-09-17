namespace Administrador
{
    partial class Productos
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
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.lblGestionProductos = new System.Windows.Forms.Label();
            this.panelFiltro = new System.Windows.Forms.Panel();
            this.btnAgregarProductos = new System.Windows.Forms.Button();
            this.btnModificarProductos = new System.Windows.Forms.Button();
            this.btnConsultarProductos = new System.Windows.Forms.Button();
            this.btnEliminarProductos = new System.Windows.Forms.Button();
            this.panelSuperior.SuspendLayout();
            this.panelFiltro.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelSuperior.Controls.Add(this.lblGestionProductos);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(800, 115);
            this.panelSuperior.TabIndex = 0;
            // 
            // lblGestionProductos
            // 
            this.lblGestionProductos.AutoSize = true;
            this.lblGestionProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestionProductos.Location = new System.Drawing.Point(269, 40);
            this.lblGestionProductos.Name = "lblGestionProductos";
            this.lblGestionProductos.Size = new System.Drawing.Size(272, 31);
            this.lblGestionProductos.TabIndex = 0;
            this.lblGestionProductos.Text = "Gestión de productos";
            // 
            // panelFiltro
            // 
            this.panelFiltro.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelFiltro.Controls.Add(this.btnEliminarProductos);
            this.panelFiltro.Controls.Add(this.btnConsultarProductos);
            this.panelFiltro.Controls.Add(this.btnModificarProductos);
            this.panelFiltro.Controls.Add(this.btnAgregarProductos);
            this.panelFiltro.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelFiltro.Location = new System.Drawing.Point(0, 115);
            this.panelFiltro.Name = "panelFiltro";
            this.panelFiltro.Size = new System.Drawing.Size(212, 335);
            this.panelFiltro.TabIndex = 1;
            // 
            // btnAgregarProductos
            // 
            this.btnAgregarProductos.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnAgregarProductos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAgregarProductos.Location = new System.Drawing.Point(27, 19);
            this.btnAgregarProductos.Name = "btnAgregarProductos";
            this.btnAgregarProductos.Size = new System.Drawing.Size(158, 52);
            this.btnAgregarProductos.TabIndex = 0;
            this.btnAgregarProductos.Text = "Registrar productos";
            this.btnAgregarProductos.UseVisualStyleBackColor = false;
            // 
            // btnModificarProductos
            // 
            this.btnModificarProductos.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnModificarProductos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnModificarProductos.Location = new System.Drawing.Point(27, 86);
            this.btnModificarProductos.Name = "btnModificarProductos";
            this.btnModificarProductos.Size = new System.Drawing.Size(158, 52);
            this.btnModificarProductos.TabIndex = 1;
            this.btnModificarProductos.Text = "Modificar productos";
            this.btnModificarProductos.UseVisualStyleBackColor = false;
            // 
            // btnConsultarProductos
            // 
            this.btnConsultarProductos.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnConsultarProductos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnConsultarProductos.Location = new System.Drawing.Point(27, 159);
            this.btnConsultarProductos.Name = "btnConsultarProductos";
            this.btnConsultarProductos.Size = new System.Drawing.Size(158, 52);
            this.btnConsultarProductos.TabIndex = 2;
            this.btnConsultarProductos.Text = "Consultar productos";
            this.btnConsultarProductos.UseVisualStyleBackColor = false;
            // 
            // btnEliminarProductos
            // 
            this.btnEliminarProductos.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnEliminarProductos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEliminarProductos.Location = new System.Drawing.Point(27, 233);
            this.btnEliminarProductos.Name = "btnEliminarProductos";
            this.btnEliminarProductos.Size = new System.Drawing.Size(158, 52);
            this.btnEliminarProductos.TabIndex = 3;
            this.btnEliminarProductos.Text = "Eliminar productos";
            this.btnEliminarProductos.UseVisualStyleBackColor = false;
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelFiltro);
            this.Controls.Add(this.panelSuperior);
            this.Name = "Productos";
            this.Text = "Productos";
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            this.panelFiltro.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.Label lblGestionProductos;
        private System.Windows.Forms.Panel panelFiltro;
        private System.Windows.Forms.Button btnAgregarProductos;
        private System.Windows.Forms.Button btnEliminarProductos;
        private System.Windows.Forms.Button btnConsultarProductos;
        private System.Windows.Forms.Button btnModificarProductos;
    }
}
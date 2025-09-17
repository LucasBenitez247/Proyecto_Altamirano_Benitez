namespace CapaPresentacion
{
    partial class Form1
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelOpciones = new System.Windows.Forms.Panel();
            this.btnInicio = new System.Windows.Forms.Button();
            this.btnReportes = new System.Windows.Forms.Button();
            this.btnReclamos = new System.Windows.Forms.Button();
            this.btnVentas = new System.Windows.Forms.Button();
            this.btnInventario = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.btnPermisosYRoles = new System.Windows.Forms.Button();
            this.btnGestionUsuarios = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lCantUsuariosActivos = new System.Windows.Forms.Label();
            this.lUsuariosActivos = new System.Windows.Forms.Label();
            this.lInicio = new System.Windows.Forms.Label();
            this.panelOpciones.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelOpciones
            // 
            this.panelOpciones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelOpciones.BackColor = System.Drawing.Color.Gray;
            this.panelOpciones.Controls.Add(this.btnInicio);
            this.panelOpciones.Controls.Add(this.btnReportes);
            this.panelOpciones.Controls.Add(this.btnReclamos);
            this.panelOpciones.Controls.Add(this.btnVentas);
            this.panelOpciones.Controls.Add(this.btnInventario);
            this.panelOpciones.Controls.Add(this.btnProductos);
            this.panelOpciones.Controls.Add(this.btnPermisosYRoles);
            this.panelOpciones.Controls.Add(this.btnGestionUsuarios);
            this.panelOpciones.Location = new System.Drawing.Point(2, -2);
            this.panelOpciones.Name = "panelOpciones";
            this.panelOpciones.Size = new System.Drawing.Size(241, 738);
            this.panelOpciones.TabIndex = 0;
            // 
            // btnInicio
            // 
            this.btnInicio.BackColor = System.Drawing.Color.DarkGray;
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnInicio.Location = new System.Drawing.Point(38, 65);
            this.btnInicio.Margin = new System.Windows.Forms.Padding(0);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(161, 31);
            this.btnInicio.TabIndex = 15;
            this.btnInicio.Text = "Inicio";
            this.btnInicio.UseVisualStyleBackColor = false;
            // 
            // btnReportes
            // 
            this.btnReportes.BackColor = System.Drawing.Color.DarkGray;
            this.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnReportes.Location = new System.Drawing.Point(38, 369);
            this.btnReportes.Margin = new System.Windows.Forms.Padding(0);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(161, 31);
            this.btnReportes.TabIndex = 14;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.UseVisualStyleBackColor = false;
            this.btnReportes.MouseEnter += new System.EventHandler(this.btnReportes_MouseEnter);
            this.btnReportes.MouseLeave += new System.EventHandler(this.btnReportes_MouseLeave);
            // 
            // btnReclamos
            // 
            this.btnReclamos.BackColor = System.Drawing.Color.DarkGray;
            this.btnReclamos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReclamos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReclamos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnReclamos.Location = new System.Drawing.Point(38, 325);
            this.btnReclamos.Margin = new System.Windows.Forms.Padding(0);
            this.btnReclamos.Name = "btnReclamos";
            this.btnReclamos.Size = new System.Drawing.Size(161, 31);
            this.btnReclamos.TabIndex = 13;
            this.btnReclamos.Text = "Reclamos";
            this.btnReclamos.UseVisualStyleBackColor = false;
            this.btnReclamos.MouseEnter += new System.EventHandler(this.btnReclamos_MouseEnter);
            this.btnReclamos.MouseLeave += new System.EventHandler(this.btnReclamos_MouseLeave);
            // 
            // btnVentas
            // 
            this.btnVentas.BackColor = System.Drawing.Color.DarkGray;
            this.btnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnVentas.Location = new System.Drawing.Point(38, 285);
            this.btnVentas.Margin = new System.Windows.Forms.Padding(0);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(161, 31);
            this.btnVentas.TabIndex = 12;
            this.btnVentas.Text = "Ventas";
            this.btnVentas.UseVisualStyleBackColor = false;
            this.btnVentas.MouseEnter += new System.EventHandler(this.btnVentas_MouseEnter);
            this.btnVentas.MouseLeave += new System.EventHandler(this.btnVentas_MouseLeave);
            // 
            // btnInventario
            // 
            this.btnInventario.BackColor = System.Drawing.Color.DarkGray;
            this.btnInventario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnInventario.Location = new System.Drawing.Point(38, 239);
            this.btnInventario.Margin = new System.Windows.Forms.Padding(0);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Size = new System.Drawing.Size(161, 31);
            this.btnInventario.TabIndex = 11;
            this.btnInventario.Text = "Inventario";
            this.btnInventario.UseVisualStyleBackColor = false;
            this.btnInventario.MouseEnter += new System.EventHandler(this.btnInventario_MouseEnter);
            this.btnInventario.MouseLeave += new System.EventHandler(this.btnInventario_MouseLeave);
            // 
            // btnProductos
            // 
            this.btnProductos.BackColor = System.Drawing.Color.DarkGray;
            this.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnProductos.Location = new System.Drawing.Point(38, 195);
            this.btnProductos.Margin = new System.Windows.Forms.Padding(0);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(161, 31);
            this.btnProductos.TabIndex = 10;
            this.btnProductos.Text = "Productos";
            this.btnProductos.UseVisualStyleBackColor = false;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            this.btnProductos.MouseEnter += new System.EventHandler(this.btnProductros_MouseEnter);
            this.btnProductos.MouseLeave += new System.EventHandler(this.btnProductros_MouseLeave);
            // 
            // btnPermisosYRoles
            // 
            this.btnPermisosYRoles.BackColor = System.Drawing.Color.DarkGray;
            this.btnPermisosYRoles.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPermisosYRoles.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPermisosYRoles.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPermisosYRoles.Location = new System.Drawing.Point(38, 153);
            this.btnPermisosYRoles.Margin = new System.Windows.Forms.Padding(0);
            this.btnPermisosYRoles.Name = "btnPermisosYRoles";
            this.btnPermisosYRoles.Size = new System.Drawing.Size(161, 31);
            this.btnPermisosYRoles.TabIndex = 9;
            this.btnPermisosYRoles.Text = "Permisos y Roles";
            this.btnPermisosYRoles.UseVisualStyleBackColor = false;
            this.btnPermisosYRoles.Click += new System.EventHandler(this.btnPermisosYRoles_Click);
            this.btnPermisosYRoles.MouseEnter += new System.EventHandler(this.btnPermisosYRoles_MouseEnter);
            this.btnPermisosYRoles.MouseLeave += new System.EventHandler(this.btnPermisosYRoles_MouseLeave);
            // 
            // btnGestionUsuarios
            // 
            this.btnGestionUsuarios.BackColor = System.Drawing.Color.DarkGray;
            this.btnGestionUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGestionUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionUsuarios.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGestionUsuarios.Location = new System.Drawing.Point(38, 112);
            this.btnGestionUsuarios.Margin = new System.Windows.Forms.Padding(0);
            this.btnGestionUsuarios.Name = "btnGestionUsuarios";
            this.btnGestionUsuarios.Size = new System.Drawing.Size(161, 31);
            this.btnGestionUsuarios.TabIndex = 8;
            this.btnGestionUsuarios.Text = "Gestión de Usuarios";
            this.btnGestionUsuarios.UseVisualStyleBackColor = false;
            this.btnGestionUsuarios.Click += new System.EventHandler(this.btnGestionUsuarios_Click);
            this.btnGestionUsuarios.MouseEnter += new System.EventHandler(this.btnGestionUsuarios_MouseEnter);
            this.btnGestionUsuarios.MouseLeave += new System.EventHandler(this.btnGestionUsuarios_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.chart1);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lInicio);
            this.panel1.Location = new System.Drawing.Point(238, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 827);
            this.panel1.TabIndex = 1;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(42, 236);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Ventas";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(742, 260);
            this.chart1.TabIndex = 4;
            this.chart1.Text = "chart1";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label4);
            this.panel4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel4.Location = new System.Drawing.Point(556, 86);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(228, 137);
            this.panel4.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(103, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 31);
            this.label3.TabIndex = 1;
            this.label3.Text = "$0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(49, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ventas del día";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel3.Location = new System.Drawing.Point(301, 86);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(228, 137);
            this.panel3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(103, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Stock Crítico";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.lCantUsuariosActivos);
            this.panel2.Controls.Add(this.lUsuariosActivos);
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(42, 85);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(228, 137);
            this.panel2.TabIndex = 1;
            // 
            // lCantUsuariosActivos
            // 
            this.lCantUsuariosActivos.AutoSize = true;
            this.lCantUsuariosActivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCantUsuariosActivos.Location = new System.Drawing.Point(103, 65);
            this.lCantUsuariosActivos.Name = "lCantUsuariosActivos";
            this.lCantUsuariosActivos.Size = new System.Drawing.Size(29, 31);
            this.lCantUsuariosActivos.TabIndex = 1;
            this.lCantUsuariosActivos.Text = "0";
            // 
            // lUsuariosActivos
            // 
            this.lUsuariosActivos.AutoSize = true;
            this.lUsuariosActivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lUsuariosActivos.Location = new System.Drawing.Point(32, 24);
            this.lUsuariosActivos.Name = "lUsuariosActivos";
            this.lUsuariosActivos.Size = new System.Drawing.Size(173, 25);
            this.lUsuariosActivos.TabIndex = 0;
            this.lUsuariosActivos.Text = "Usuarios Activos";
            // 
            // lInicio
            // 
            this.lInicio.AutoSize = true;
            this.lInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lInicio.Location = new System.Drawing.Point(36, 35);
            this.lInicio.Name = "lInicio";
            this.lInicio.Size = new System.Drawing.Size(62, 25);
            this.lInicio.TabIndex = 0;
            this.lInicio.Text = "Inicio";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 740);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelOpciones);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelOpciones.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelOpciones;
        private System.Windows.Forms.Button btnGestionUsuarios;
        private System.Windows.Forms.Button btnPermisosYRoles;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Button btnInventario;
        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Button btnReclamos;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lInicio;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lUsuariosActivos;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lCantUsuariosActivos;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}


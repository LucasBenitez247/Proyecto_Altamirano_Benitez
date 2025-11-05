namespace CapaPresentacion.Dueño_de_Negocio
{
    partial class DueñoNegocioEstadisticasUserControl
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.LblReportes = new System.Windows.Forms.Label();
            this.VentasPorMes = new System.Windows.Forms.Label();
            this.LblEstadistica = new System.Windows.Forms.Label();
            this.LblProductosMasVendidos = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.LblClientesFrecuentes = new System.Windows.Forms.Label();
            this.LBClientesFrecuentes = new System.Windows.Forms.ListBox();
            this.PResportes = new System.Windows.Forms.Panel();
            this.PEstadistica = new System.Windows.Forms.Panel();
            this.PClientesFrecuentes = new System.Windows.Forms.Panel();
            this.BtnBuscar = new FontAwesome.Sharp.IconButton();
            this.DtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.DtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.FechaFin = new System.Windows.Forms.Label();
            this.LFechaInicio = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.PResportes.SuspendLayout();
            this.PEstadistica.SuspendLayout();
            this.PClientesFrecuentes.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblReportes
            // 
            this.LblReportes.AutoSize = true;
            this.LblReportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblReportes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LblReportes.Location = new System.Drawing.Point(3, 4);
            this.LblReportes.Name = "LblReportes";
            this.LblReportes.Size = new System.Drawing.Size(155, 39);
            this.LblReportes.TabIndex = 0;
            this.LblReportes.Text = "Reportes";
            // 
            // VentasPorMes
            // 
            this.VentasPorMes.AutoSize = true;
            this.VentasPorMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VentasPorMes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.VentasPorMes.Location = new System.Drawing.Point(50, 43);
            this.VentasPorMes.Name = "VentasPorMes";
            this.VentasPorMes.Size = new System.Drawing.Size(149, 25);
            this.VentasPorMes.TabIndex = 1;
            this.VentasPorMes.Text = "Ventas por mes";
            // 
            // LblEstadistica
            // 
            this.LblEstadistica.AutoSize = true;
            this.LblEstadistica.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEstadistica.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LblEstadistica.Location = new System.Drawing.Point(3, 3);
            this.LblEstadistica.Name = "LblEstadistica";
            this.LblEstadistica.Size = new System.Drawing.Size(182, 39);
            this.LblEstadistica.TabIndex = 2;
            this.LblEstadistica.Text = "Estadistica";
            // 
            // LblProductosMasVendidos
            // 
            this.LblProductosMasVendidos.AutoSize = true;
            this.LblProductosMasVendidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProductosMasVendidos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LblProductosMasVendidos.Location = new System.Drawing.Point(50, 42);
            this.LblProductosMasVendidos.Name = "LblProductosMasVendidos";
            this.LblProductosMasVendidos.Size = new System.Drawing.Size(226, 25);
            this.LblProductosMasVendidos.TabIndex = 3;
            this.LblProductosMasVendidos.Text = "Productos más vendidos";
            // 
            // chart1
            // 
            chartArea5.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chart1.Legends.Add(legend5);
            this.chart1.Location = new System.Drawing.Point(24, 70);
            this.chart1.Name = "chart1";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chart1.Series.Add(series5);
            this.chart1.Size = new System.Drawing.Size(463, 212);
            this.chart1.TabIndex = 4;
            this.chart1.Text = "chart1";
            // 
            // chart2
            // 
            chartArea6.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chart2.Legends.Add(legend6);
            this.chart2.Location = new System.Drawing.Point(24, 71);
            this.chart2.Name = "chart2";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.chart2.Series.Add(series6);
            this.chart2.Size = new System.Drawing.Size(463, 212);
            this.chart2.TabIndex = 5;
            this.chart2.Text = "chart2";
            // 
            // LblClientesFrecuentes
            // 
            this.LblClientesFrecuentes.AutoSize = true;
            this.LblClientesFrecuentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblClientesFrecuentes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LblClientesFrecuentes.Location = new System.Drawing.Point(25, 4);
            this.LblClientesFrecuentes.Name = "LblClientesFrecuentes";
            this.LblClientesFrecuentes.Size = new System.Drawing.Size(179, 25);
            this.LblClientesFrecuentes.TabIndex = 6;
            this.LblClientesFrecuentes.Text = "Clientes frecuentes";
            // 
            // LBClientesFrecuentes
            // 
            this.LBClientesFrecuentes.FormattingEnabled = true;
            this.LBClientesFrecuentes.Location = new System.Drawing.Point(30, 32);
            this.LBClientesFrecuentes.Name = "LBClientesFrecuentes";
            this.LBClientesFrecuentes.Size = new System.Drawing.Size(184, 251);
            this.LBClientesFrecuentes.TabIndex = 7;
            // 
            // PResportes
            // 
            this.PResportes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.PResportes.Controls.Add(this.chart2);
            this.PResportes.Controls.Add(this.LblReportes);
            this.PResportes.Controls.Add(this.VentasPorMes);
            this.PResportes.Location = new System.Drawing.Point(21, 65);
            this.PResportes.Name = "PResportes";
            this.PResportes.Size = new System.Drawing.Size(510, 293);
            this.PResportes.TabIndex = 8;
            // 
            // PEstadistica
            // 
            this.PEstadistica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.PEstadistica.Controls.Add(this.chart1);
            this.PEstadistica.Controls.Add(this.LblEstadistica);
            this.PEstadistica.Controls.Add(this.LblProductosMasVendidos);
            this.PEstadistica.Location = new System.Drawing.Point(21, 364);
            this.PEstadistica.Name = "PEstadistica";
            this.PEstadistica.Size = new System.Drawing.Size(510, 293);
            this.PEstadistica.TabIndex = 9;
            // 
            // PClientesFrecuentes
            // 
            this.PClientesFrecuentes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.PClientesFrecuentes.Controls.Add(this.LBClientesFrecuentes);
            this.PClientesFrecuentes.Controls.Add(this.LblClientesFrecuentes);
            this.PClientesFrecuentes.Location = new System.Drawing.Point(639, 65);
            this.PClientesFrecuentes.Name = "PClientesFrecuentes";
            this.PClientesFrecuentes.Size = new System.Drawing.Size(247, 293);
            this.PClientesFrecuentes.TabIndex = 10;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnBuscar.IconChar = FontAwesome.Sharp.IconChar.Sistrix;
            this.BtnBuscar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnBuscar.IconSize = 24;
            this.BtnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBuscar.Location = new System.Drawing.Point(548, 21);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(80, 28);
            this.BtnBuscar.TabIndex = 16;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // DtpFechaInicio
            // 
            this.DtpFechaInicio.Location = new System.Drawing.Point(165, 27);
            this.DtpFechaInicio.Name = "DtpFechaInicio";
            this.DtpFechaInicio.Size = new System.Drawing.Size(132, 20);
            this.DtpFechaInicio.TabIndex = 14;
            // 
            // DtpFechaFin
            // 
            this.DtpFechaFin.Location = new System.Drawing.Point(396, 27);
            this.DtpFechaFin.Name = "DtpFechaFin";
            this.DtpFechaFin.Size = new System.Drawing.Size(135, 20);
            this.DtpFechaFin.TabIndex = 15;
            // 
            // FechaFin
            // 
            this.FechaFin.AutoSize = true;
            this.FechaFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaFin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.FechaFin.Location = new System.Drawing.Point(316, 27);
            this.FechaFin.Name = "FechaFin";
            this.FechaFin.Size = new System.Drawing.Size(74, 17);
            this.FechaFin.TabIndex = 13;
            this.FechaFin.Text = "Fecha Fin:";
            // 
            // LFechaInicio
            // 
            this.LFechaInicio.AutoSize = true;
            this.LFechaInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LFechaInicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LFechaInicio.Location = new System.Drawing.Point(76, 27);
            this.LFechaInicio.Name = "LFechaInicio";
            this.LFechaInicio.Size = new System.Drawing.Size(87, 17);
            this.LFechaInicio.TabIndex = 12;
            this.LFechaInicio.Text = "Fecha Inicio:";
            // 
            // DueñoNegocioEstadisticasUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.DtpFechaInicio);
            this.Controls.Add(this.DtpFechaFin);
            this.Controls.Add(this.FechaFin);
            this.Controls.Add(this.LFechaInicio);
            this.Controls.Add(this.PClientesFrecuentes);
            this.Controls.Add(this.PEstadistica);
            this.Controls.Add(this.PResportes);
            this.Name = "DueñoNegocioEstadisticasUserControl";
            this.Size = new System.Drawing.Size(1201, 660);
            this.Load += new System.EventHandler(this.DueñoNegocioEstadisticasUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.PResportes.ResumeLayout(false);
            this.PResportes.PerformLayout();
            this.PEstadistica.ResumeLayout(false);
            this.PEstadistica.PerformLayout();
            this.PClientesFrecuentes.ResumeLayout(false);
            this.PClientesFrecuentes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblReportes;
        private System.Windows.Forms.Label VentasPorMes;
        private System.Windows.Forms.Label LblEstadistica;
        private System.Windows.Forms.Label LblProductosMasVendidos;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Label LblClientesFrecuentes;
        private System.Windows.Forms.ListBox LBClientesFrecuentes;
        private System.Windows.Forms.Panel PResportes;
        private System.Windows.Forms.Panel PEstadistica;
        private System.Windows.Forms.Panel PClientesFrecuentes;
        private FontAwesome.Sharp.IconButton BtnBuscar;
        private System.Windows.Forms.DateTimePicker DtpFechaInicio;
        private System.Windows.Forms.DateTimePicker DtpFechaFin;
        private System.Windows.Forms.Label FechaFin;
        private System.Windows.Forms.Label LFechaInicio;
    }
}

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
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // LblReportes
            // 
            this.LblReportes.AutoSize = true;
            this.LblReportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblReportes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LblReportes.Location = new System.Drawing.Point(29, 0);
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
            this.VentasPorMes.Location = new System.Drawing.Point(62, 50);
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
            this.LblEstadistica.Location = new System.Drawing.Point(29, 328);
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
            this.LblProductosMasVendidos.Location = new System.Drawing.Point(62, 378);
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
            this.chart1.Location = new System.Drawing.Point(36, 406);
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
            this.chart2.Location = new System.Drawing.Point(36, 78);
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
            this.LblClientesFrecuentes.Location = new System.Drawing.Point(659, 67);
            this.LblClientesFrecuentes.Name = "LblClientesFrecuentes";
            this.LblClientesFrecuentes.Size = new System.Drawing.Size(179, 25);
            this.LblClientesFrecuentes.TabIndex = 6;
            this.LblClientesFrecuentes.Text = "Clientes frecuentes";
            // 
            // LBClientesFrecuentes
            // 
            this.LBClientesFrecuentes.FormattingEnabled = true;
            this.LBClientesFrecuentes.Location = new System.Drawing.Point(664, 95);
            this.LBClientesFrecuentes.Name = "LBClientesFrecuentes";
            this.LBClientesFrecuentes.Size = new System.Drawing.Size(184, 173);
            this.LBClientesFrecuentes.TabIndex = 7;
            // 
            // DueñoNegocioEstadisticasUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.Controls.Add(this.LBClientesFrecuentes);
            this.Controls.Add(this.LblClientesFrecuentes);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.LblProductosMasVendidos);
            this.Controls.Add(this.LblEstadistica);
            this.Controls.Add(this.VentasPorMes);
            this.Controls.Add(this.LblReportes);
            this.Name = "DueñoNegocioEstadisticasUserControl";
            this.Size = new System.Drawing.Size(1201, 660);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
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
    }
}

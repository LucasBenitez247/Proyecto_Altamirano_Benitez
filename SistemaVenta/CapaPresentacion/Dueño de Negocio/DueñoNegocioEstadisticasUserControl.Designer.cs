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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.LblReportes.Location = new System.Drawing.Point(17, 15);
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
            this.VentasPorMes.Location = new System.Drawing.Point(50, 65);
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
            this.LblEstadistica.Location = new System.Drawing.Point(17, 8);
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
            this.LblProductosMasVendidos.Location = new System.Drawing.Point(50, 58);
            this.LblProductosMasVendidos.Name = "LblProductosMasVendidos";
            this.LblProductosMasVendidos.Size = new System.Drawing.Size(226, 25);
            this.LblProductosMasVendidos.TabIndex = 3;
            this.LblProductosMasVendidos.Text = "Productos más vendidos";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(24, 86);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(463, 212);
            this.chart1.TabIndex = 4;
            this.chart1.Text = "chart1";
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(24, 93);
            this.chart2.Name = "chart2";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(463, 212);
            this.chart2.TabIndex = 5;
            this.chart2.Text = "chart2";
            // 
            // LblClientesFrecuentes
            // 
            this.LblClientesFrecuentes.AutoSize = true;
            this.LblClientesFrecuentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblClientesFrecuentes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LblClientesFrecuentes.Location = new System.Drawing.Point(25, 15);
            this.LblClientesFrecuentes.Name = "LblClientesFrecuentes";
            this.LblClientesFrecuentes.Size = new System.Drawing.Size(179, 25);
            this.LblClientesFrecuentes.TabIndex = 6;
            this.LblClientesFrecuentes.Text = "Clientes frecuentes";
            // 
            // LBClientesFrecuentes
            // 
            this.LBClientesFrecuentes.FormattingEnabled = true;
            this.LBClientesFrecuentes.Location = new System.Drawing.Point(30, 54);
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
            this.PResportes.Location = new System.Drawing.Point(21, 3);
            this.PResportes.Name = "PResportes";
            this.PResportes.Size = new System.Drawing.Size(510, 322);
            this.PResportes.TabIndex = 8;
            // 
            // PEstadistica
            // 
            this.PEstadistica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.PEstadistica.Controls.Add(this.chart1);
            this.PEstadistica.Controls.Add(this.LblEstadistica);
            this.PEstadistica.Controls.Add(this.LblProductosMasVendidos);
            this.PEstadistica.Location = new System.Drawing.Point(21, 331);
            this.PEstadistica.Name = "PEstadistica";
            this.PEstadistica.Size = new System.Drawing.Size(510, 314);
            this.PEstadistica.TabIndex = 9;
            // 
            // PClientesFrecuentes
            // 
            this.PClientesFrecuentes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.PClientesFrecuentes.Controls.Add(this.LBClientesFrecuentes);
            this.PClientesFrecuentes.Controls.Add(this.LblClientesFrecuentes);
            this.PClientesFrecuentes.Location = new System.Drawing.Point(630, 3);
            this.PClientesFrecuentes.Name = "PClientesFrecuentes";
            this.PClientesFrecuentes.Size = new System.Drawing.Size(247, 322);
            this.PClientesFrecuentes.TabIndex = 10;
            // 
            // DueñoNegocioEstadisticasUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.Controls.Add(this.PClientesFrecuentes);
            this.Controls.Add(this.PEstadistica);
            this.Controls.Add(this.PResportes);
            this.Name = "DueñoNegocioEstadisticasUserControl";
            this.Size = new System.Drawing.Size(1201, 660);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.PResportes.ResumeLayout(false);
            this.PResportes.PerformLayout();
            this.PEstadistica.ResumeLayout(false);
            this.PEstadistica.PerformLayout();
            this.PClientesFrecuentes.ResumeLayout(false);
            this.PClientesFrecuentes.PerformLayout();
            this.ResumeLayout(false);

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
    }
}

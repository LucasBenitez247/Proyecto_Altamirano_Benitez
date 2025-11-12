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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.VentasPorMes = new System.Windows.Forms.Label();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.LblClientesFrecuentes = new System.Windows.Forms.Label();
            this.LBClientesFrecuentes = new System.Windows.Forms.ListBox();
            this.PResportes = new System.Windows.Forms.Panel();
            this.PClientesFrecuentes = new System.Windows.Forms.Panel();
            this.BtnBuscar = new FontAwesome.Sharp.IconButton();
            this.DtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.DtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.FechaFin = new System.Windows.Forms.Label();
            this.LFechaInicio = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CDiasVentas = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.PResportes.SuspendLayout();
            this.PClientesFrecuentes.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CDiasVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // VentasPorMes
            // 
            this.VentasPorMes.AutoSize = true;
            this.VentasPorMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VentasPorMes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.VentasPorMes.Location = new System.Drawing.Point(5, 4);
            this.VentasPorMes.Name = "VentasPorMes";
            this.VentasPorMes.Size = new System.Drawing.Size(149, 25);
            this.VentasPorMes.TabIndex = 1;
            this.VentasPorMes.Text = "Ventas por mes";
            // 
            // chart2
            // 
            chartArea3.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart2.Legends.Add(legend3);
            this.chart2.Location = new System.Drawing.Point(24, 32);
            this.chart2.Name = "chart2";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            series3.YValuesPerPoint = 6;
            this.chart2.Series.Add(series3);
            this.chart2.Size = new System.Drawing.Size(1071, 268);
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
            this.LBClientesFrecuentes.Location = new System.Drawing.Point(30, 28);
            this.LBClientesFrecuentes.Name = "LBClientesFrecuentes";
            this.LBClientesFrecuentes.Size = new System.Drawing.Size(184, 251);
            this.LBClientesFrecuentes.TabIndex = 7;
            // 
            // PResportes
            // 
            this.PResportes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.PResportes.Controls.Add(this.chart2);
            this.PResportes.Controls.Add(this.VentasPorMes);
            this.PResportes.Location = new System.Drawing.Point(21, 354);
            this.PResportes.Name = "PResportes";
            this.PResportes.Size = new System.Drawing.Size(1128, 303);
            this.PResportes.TabIndex = 8;
            // 
            // PClientesFrecuentes
            // 
            this.PClientesFrecuentes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.PClientesFrecuentes.Controls.Add(this.LBClientesFrecuentes);
            this.PClientesFrecuentes.Controls.Add(this.LblClientesFrecuentes);
            this.PClientesFrecuentes.Location = new System.Drawing.Point(890, 55);
            this.PClientesFrecuentes.Name = "PClientesFrecuentes";
            this.PClientesFrecuentes.Size = new System.Drawing.Size(259, 293);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.panel1.Controls.Add(this.CDiasVentas);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(21, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(810, 293);
            this.panel1.TabIndex = 17;
            // 
            // CDiasVentas
            // 
            chartArea4.Name = "ChartArea1";
            this.CDiasVentas.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.CDiasVentas.Legends.Add(legend4);
            this.CDiasVentas.Location = new System.Drawing.Point(24, 32);
            this.CDiasVentas.Name = "CDiasVentas";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.CDiasVentas.Series.Add(series4);
            this.CDiasVentas.Size = new System.Drawing.Size(751, 251);
            this.CDiasVentas.TabIndex = 5;
            this.CDiasVentas.Text = "chart3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(19, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dias que más se venden";
            // 
            // DueñoNegocioEstadisticasUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.DtpFechaInicio);
            this.Controls.Add(this.DtpFechaFin);
            this.Controls.Add(this.FechaFin);
            this.Controls.Add(this.LFechaInicio);
            this.Controls.Add(this.PClientesFrecuentes);
            this.Controls.Add(this.PResportes);
            this.Name = "DueñoNegocioEstadisticasUserControl";
            this.Size = new System.Drawing.Size(1201, 660);
            this.Load += new System.EventHandler(this.DueñoNegocioEstadisticasUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.PResportes.ResumeLayout(false);
            this.PResportes.PerformLayout();
            this.PClientesFrecuentes.ResumeLayout(false);
            this.PClientesFrecuentes.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CDiasVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label VentasPorMes;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Label LblClientesFrecuentes;
        private System.Windows.Forms.ListBox LBClientesFrecuentes;
        private System.Windows.Forms.Panel PResportes;
        private System.Windows.Forms.Panel PClientesFrecuentes;
        private FontAwesome.Sharp.IconButton BtnBuscar;
        private System.Windows.Forms.DateTimePicker DtpFechaInicio;
        private System.Windows.Forms.DateTimePicker DtpFechaFin;
        private System.Windows.Forms.Label FechaFin;
        private System.Windows.Forms.Label LFechaInicio;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart CDiasVentas;
        private System.Windows.Forms.Label label1;
    }
}

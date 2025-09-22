namespace CapaPresentacion.Dueño_de_Negocio
{
    partial class DueñoNegocioInventarioUserControl
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
            this.PTotalProductos = new System.Windows.Forms.Panel();
            this.TTotalProductos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.PEstadistica = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.TStock = new System.Windows.Forms.TextBox();
            this.PStock = new System.Windows.Forms.Panel();
            this.IBtnBuscar = new FontAwesome.Sharp.IconButton();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.FechaFin = new System.Windows.Forms.Label();
            this.LFechaInicio = new System.Windows.Forms.Label();
            this.PTotalProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.PEstadistica.SuspendLayout();
            this.PStock.SuspendLayout();
            this.SuspendLayout();
            // 
            // PTotalProductos
            // 
            this.PTotalProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.PTotalProductos.Controls.Add(this.TTotalProductos);
            this.PTotalProductos.Controls.Add(this.label1);
            this.PTotalProductos.Location = new System.Drawing.Point(181, 72);
            this.PTotalProductos.Name = "PTotalProductos";
            this.PTotalProductos.Size = new System.Drawing.Size(232, 134);
            this.PTotalProductos.TabIndex = 0;
            // 
            // TTotalProductos
            // 
            this.TTotalProductos.Location = new System.Drawing.Point(41, 49);
            this.TTotalProductos.Name = "TTotalProductos";
            this.TTotalProductos.Size = new System.Drawing.Size(100, 20);
            this.TTotalProductos.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(17, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Producto más vendido";
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(16, 48);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(557, 263);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Estadisticas de Inventario";
            // 
            // PEstadistica
            // 
            this.PEstadistica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.PEstadistica.Controls.Add(this.chart1);
            this.PEstadistica.Controls.Add(this.label2);
            this.PEstadistica.Location = new System.Drawing.Point(181, 247);
            this.PEstadistica.Name = "PEstadistica";
            this.PEstadistica.Size = new System.Drawing.Size(587, 325);
            this.PEstadistica.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.Location = new System.Drawing.Point(90, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Stock";
            // 
            // TStock
            // 
            this.TStock.Location = new System.Drawing.Point(65, 49);
            this.TStock.Name = "TStock";
            this.TStock.Size = new System.Drawing.Size(100, 20);
            this.TStock.TabIndex = 5;
            // 
            // PStock
            // 
            this.PStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.PStock.Controls.Add(this.TStock);
            this.PStock.Controls.Add(this.label3);
            this.PStock.Location = new System.Drawing.Point(536, 72);
            this.PStock.Name = "PStock";
            this.PStock.Size = new System.Drawing.Size(232, 134);
            this.PStock.TabIndex = 5;
            // 
            // IBtnBuscar
            // 
            this.IBtnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IBtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IBtnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IBtnBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.IBtnBuscar.IconChar = FontAwesome.Sharp.IconChar.Sistrix;
            this.IBtnBuscar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.IBtnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IBtnBuscar.IconSize = 24;
            this.IBtnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IBtnBuscar.Location = new System.Drawing.Point(668, 20);
            this.IBtnBuscar.Name = "IBtnBuscar";
            this.IBtnBuscar.Size = new System.Drawing.Size(93, 27);
            this.IBtnBuscar.TabIndex = 11;
            this.IBtnBuscar.Text = "Buscar";
            this.IBtnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.IBtnBuscar.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(280, 20);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(135, 20);
            this.dateTimePicker2.TabIndex = 9;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(515, 24);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(135, 20);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // FechaFin
            // 
            this.FechaFin.AutoSize = true;
            this.FechaFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaFin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.FechaFin.Location = new System.Drawing.Point(435, 24);
            this.FechaFin.Name = "FechaFin";
            this.FechaFin.Size = new System.Drawing.Size(74, 17);
            this.FechaFin.TabIndex = 8;
            this.FechaFin.Text = "Fecha Fin:";
            // 
            // LFechaInicio
            // 
            this.LFechaInicio.AutoSize = true;
            this.LFechaInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LFechaInicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LFechaInicio.Location = new System.Drawing.Point(191, 20);
            this.LFechaInicio.Name = "LFechaInicio";
            this.LFechaInicio.Size = new System.Drawing.Size(87, 17);
            this.LFechaInicio.TabIndex = 7;
            this.LFechaInicio.Text = "Fecha Inicio:";
            // 
            // DueñoNegocioInventarioUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.Controls.Add(this.IBtnBuscar);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.FechaFin);
            this.Controls.Add(this.LFechaInicio);
            this.Controls.Add(this.PEstadistica);
            this.Controls.Add(this.PStock);
            this.Controls.Add(this.PTotalProductos);
            this.Name = "DueñoNegocioInventarioUserControl";
            this.Size = new System.Drawing.Size(1201, 660);
            this.PTotalProductos.ResumeLayout(false);
            this.PTotalProductos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.PEstadistica.ResumeLayout(false);
            this.PEstadistica.PerformLayout();
            this.PStock.ResumeLayout(false);
            this.PStock.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PTotalProductos;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TTotalProductos;
        private System.Windows.Forms.Panel PEstadistica;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TStock;
        private System.Windows.Forms.Panel PStock;
        private FontAwesome.Sharp.IconButton IBtnBuscar;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label FechaFin;
        private System.Windows.Forms.Label LFechaInicio;
    }
}

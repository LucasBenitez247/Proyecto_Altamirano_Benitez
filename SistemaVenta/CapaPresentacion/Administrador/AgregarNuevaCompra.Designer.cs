namespace CapaPresentacion.Administrador
{
    partial class AgregarNuevaCompra
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
            this.TCantidad = new System.Windows.Forms.TextBox();
            this.LCantidad = new System.Windows.Forms.Label();
            this.TNombre = new System.Windows.Forms.TextBox();
            this.LNombre = new System.Windows.Forms.Label();
            this.LCategoria = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnRegistrar = new FontAwesome.Sharp.IconButton();
            this.BtnLimpiar = new FontAwesome.Sharp.IconButton();
            this.CBCategoria = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // TCantidad
            // 
            this.TCantidad.Location = new System.Drawing.Point(98, 155);
            this.TCantidad.Name = "TCantidad";
            this.TCantidad.Size = new System.Drawing.Size(291, 20);
            this.TCantidad.TabIndex = 12;
            // 
            // LCantidad
            // 
            this.LCantidad.AutoSize = true;
            this.LCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCantidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LCantidad.Location = new System.Drawing.Point(94, 123);
            this.LCantidad.Name = "LCantidad";
            this.LCantidad.Size = new System.Drawing.Size(77, 20);
            this.LCantidad.TabIndex = 11;
            this.LCantidad.Text = "Cantidad:";
            // 
            // TNombre
            // 
            this.TNombre.Location = new System.Drawing.Point(98, 83);
            this.TNombre.Name = "TNombre";
            this.TNombre.Size = new System.Drawing.Size(291, 20);
            this.TNombre.TabIndex = 10;
            // 
            // LNombre
            // 
            this.LNombre.AutoSize = true;
            this.LNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LNombre.Location = new System.Drawing.Point(94, 50);
            this.LNombre.Name = "LNombre";
            this.LNombre.Size = new System.Drawing.Size(65, 20);
            this.LNombre.TabIndex = 9;
            this.LNombre.Text = "Nombre";
            // 
            // LCategoria
            // 
            this.LCategoria.AutoSize = true;
            this.LCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LCategoria.Location = new System.Drawing.Point(94, 255);
            this.LCategoria.Name = "LCategoria";
            this.LCategoria.Size = new System.Drawing.Size(78, 20);
            this.LCategoria.TabIndex = 14;
            this.LCategoria.Text = "Categoria";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(98, 217);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(291, 20);
            this.dateTimePicker1.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(94, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Fecha ingreso:";
            // 
            // BtnRegistrar
            // 
            this.BtnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRegistrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BtnRegistrar.FlatAppearance.BorderSize = 2;
            this.BtnRegistrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnRegistrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.BtnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegistrar.ForeColor = System.Drawing.Color.White;
            this.BtnRegistrar.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.BtnRegistrar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnRegistrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnRegistrar.IconSize = 32;
            this.BtnRegistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRegistrar.Location = new System.Drawing.Point(98, 335);
            this.BtnRegistrar.Name = "BtnRegistrar";
            this.BtnRegistrar.Size = new System.Drawing.Size(118, 33);
            this.BtnRegistrar.TabIndex = 25;
            this.BtnRegistrar.Text = "Registrar";
            this.BtnRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnRegistrar.UseVisualStyleBackColor = true;
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.BtnLimpiar.FlatAppearance.BorderSize = 2;
            this.BtnLimpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpiar.ForeColor = System.Drawing.Color.White;
            this.BtnLimpiar.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.BtnLimpiar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnLimpiar.IconSize = 32;
            this.BtnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnLimpiar.Location = new System.Drawing.Point(284, 335);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(105, 33);
            this.BtnLimpiar.TabIndex = 26;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // CBCategoria
            // 
            this.CBCategoria.BackColor = System.Drawing.Color.White;
            this.CBCategoria.ForeColor = System.Drawing.Color.Black;
            this.CBCategoria.FormattingEnabled = true;
            this.CBCategoria.Items.AddRange(new object[] {
            "Fecha",
            "Cliente",
            "Vendedor"});
            this.CBCategoria.Location = new System.Drawing.Point(98, 278);
            this.CBCategoria.Name = "CBCategoria";
            this.CBCategoria.Size = new System.Drawing.Size(291, 21);
            this.CBCategoria.TabIndex = 13;
            // 
            // AgregarNuevaCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(536, 435);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.BtnRegistrar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.LCategoria);
            this.Controls.Add(this.CBCategoria);
            this.Controls.Add(this.TCantidad);
            this.Controls.Add(this.LCantidad);
            this.Controls.Add(this.TNombre);
            this.Controls.Add(this.LNombre);
            this.Name = "AgregarNuevaCompra";
            this.Text = "AgregarNuevaCompra";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TCantidad;
        private System.Windows.Forms.Label LCantidad;
        private System.Windows.Forms.TextBox TNombre;
        private System.Windows.Forms.Label LNombre;
        private System.Windows.Forms.Label LCategoria;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton BtnRegistrar;
        private FontAwesome.Sharp.IconButton BtnLimpiar;
        private System.Windows.Forms.ComboBox CBCategoria;
    }
}
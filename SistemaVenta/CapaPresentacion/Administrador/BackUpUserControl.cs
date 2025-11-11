using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace CapaPresentacion.Administrador
{
    public partial class BackUpUserControl : UserControl
    {
        private readonly CN_Backup negocio = new CN_Backup();
        public BackUpUserControl()
        {
            InitializeComponent();
        }

        

      

        private void btnBackup_Click(object sender, EventArgs e)
        {
            
            

        }

        private void BackUpUserControl_Load(object sender, EventArgs e)
        {
            cboBasesDeDatos.Items.Clear();
            var bases = negocio.ListarBasesDeDatos();
            cboBasesDeDatos.Items.AddRange(bases.ToArray());
        }

        private void BtnInicio_Click(object sender, EventArgs e)
        {
            if (cboBasesDeDatos.SelectedItem == null)
            {
                MessageBox.Show("Seleccione una base de datos.");
                return;
            }

            using (SaveFileDialog dialogo = new SaveFileDialog())
            {
                string nombreBD = cboBasesDeDatos.SelectedItem.ToString();

                dialogo.Title = "Guardar archivo de backup";
                dialogo.Filter = "Archivo de respaldo (*.bak)|*.bak";

                // Ruta sugerida
                dialogo.InitialDirectory = @"C:\SQLBackups"; // ← carpeta inicial
                dialogo.FileName = $"{nombreBD}_{DateTime.Now:yyyyMMdd_HHmmss}.bak"; // ← nombre sugerido

                if (dialogo.ShowDialog() == DialogResult.OK)
                {
                    string ruta = dialogo.FileName;

                    try
                    {
                        negocio.EjecutarBackup(nombreBD, ruta);
                        MessageBox.Show($"Backup realizado correctamente en:\n{ruta}");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al realizar el backup: " + ex.Message);
                    }
                }
            }

        }
    }
}

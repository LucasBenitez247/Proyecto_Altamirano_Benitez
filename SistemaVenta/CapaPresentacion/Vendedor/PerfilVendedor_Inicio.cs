using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class PerfilVendedor_Inicio : Form
    {
        public PerfilVendedor_Inicio()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit(); // cierra toda la aplicación
        }

        private void PerfilVendedor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S) // Detecta Ctrl + S
            {
                Application.Exit(); 
            }
        }
    }
}

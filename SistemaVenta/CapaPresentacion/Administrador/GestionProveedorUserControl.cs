using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Administrador
{
    public partial class GestionProveedorUserControl : UserControl
    {
        public GestionProveedorUserControl()
        {
            InitializeComponent();
        }

        private void TBBuscar_Click(object sender, EventArgs e)
        {
            if(TBBuscar.Text == "Buscar Proveedor...")
            {
                TBBuscar.Text = "";
                return;
            }
        }
    }
}

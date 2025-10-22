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
    public partial class AltaProductosUserControlAdministrador : UserControl
    {
        public AltaProductosUserControlAdministrador()
        {
            InitializeComponent();
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombreProducto.Clear();
            txtDescripcionProducto.Clear();
            txtPrecio.Clear();
            txtStock.Clear();
            cboEstado.SelectedIndex = -1;
            cboCategoria.SelectedIndex = -1;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            
        }
    }
}

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
    public partial class ComprasUserControlAdministrador : UserControl
    {
        public ComprasUserControlAdministrador()
        {
            InitializeComponent();
        }

        private void BtnNuevaCompra_Click(object sender, EventArgs e)
        {
            AgregarNuevaCompra agregarCompraForm = new AgregarNuevaCompra();
            agregarCompraForm.ShowDialog();

        }
    }
}

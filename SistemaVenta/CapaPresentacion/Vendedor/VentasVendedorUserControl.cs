using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Vendedor
{
    public partial class VentasVendedorUserControl : UserControl
    {
        public VentasVendedorUserControl()
        {
            InitializeComponent();
        }

       
        private void IBtnBuscarClientes_Click(object sender, EventArgs e)
        {
            BuscarClientes buscarClientes = new BuscarClientes();
            buscarClientes.ShowDialog();
        }
    }
}

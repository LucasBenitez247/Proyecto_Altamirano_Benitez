using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Vendedor
{
    public partial class BuscarClientes : Form
    {
        public BuscarClientes()
        {
            InitializeComponent();
        }

        private void TBuscarCliente_Click(object sender, EventArgs e)
        {
            if(TBuscarCliente.Text == "Buscar Cliente...")
            {
                TBuscarCliente.Text = "";
                return;
            }
        }
    }
}

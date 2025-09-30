using CapaEntidad;
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

        private void BRegistrarVenta_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TNombre.Text) ||
                string.IsNullOrWhiteSpace(TApellido.Text) ||
                string.IsNullOrWhiteSpace(TDni.Text) ||
                string.IsNullOrWhiteSpace(TDireccion.Text) ||   
                string.IsNullOrWhiteSpace(TTotal.Text)
                )
            {
                MessageBox.Show("Complete todos los campos.");
                return;
            }
        }
    }
}

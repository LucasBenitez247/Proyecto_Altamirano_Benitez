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
    public partial class AgregarNuevaCompra : Form
    {
        public AgregarNuevaCompra()
        {
            InitializeComponent();
        }

        

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TNroOrden.Text) ||
               string.IsNullOrWhiteSpace(TProveedor.Text) ||
               string.IsNullOrWhiteSpace(TCodProducto.Text) ||
               string.IsNullOrWhiteSpace(TProducto.Text) ||
                string.IsNullOrWhiteSpace(TPrecioCompra.Text) ||
                string.IsNullOrWhiteSpace(TPrecioVenta.Text) ||
                string.IsNullOrWhiteSpace(NUDCantidad.Text)
              )
            {
                MessageBox.Show("Complete todos los campos.");
                return;
            }
        }

        private void IBtnBuscarProveedores_Click(object sender, EventArgs e)
        {
            Lista_de_proveedores lista_De_Proveedores = new Lista_de_proveedores();
            lista_De_Proveedores.ShowDialog();
        }

        private void TNroOrden_Validating(object sender, CancelEventArgs e)
        {

        }
    }
}

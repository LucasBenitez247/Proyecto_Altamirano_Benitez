using CapaEntidad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

        private void TBuscarProductos_Click(object sender, EventArgs e)
        {
            if (TBuscarProductos.Text == "Buscar productos...")
            {
                TBuscarProductos.Text = "";
                return;
            }
        }

        private void TBuscarCliente_Click(object sender, EventArgs e)
        {
            if (TBuscarCliente.Text == "Buscar Cliente...")
            {
                TBuscarCliente.Text = "";
                return;
            }
        }


        private void TNombre_Validating(object sender, CancelEventArgs e)
        {

        }

        private void TNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; // Bloquea la tecla
            }
        }

        private void TApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; // Bloquea la tecla
            }
        }

        private void TNombre_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TNombre.Text))
            {
                errorProvider1.SetError(TNombre, "El campo no puede estar vacío");
            }
            else
            {
                errorProvider1.SetError(TNombre, "");
            }
        }

        private void TApellido_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TApellido.Text))
            {
                errorProvider1.SetError(TApellido, "El campo no puede estar vacío");
            }
            else
            {
                errorProvider1.SetError(TApellido, "");
            }
        }

        private void TDni_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TDni.Text))
            {
                errorProvider1.SetError(TDni, "El campo no puede estar vacío");
            }
            else
            {
                errorProvider1.SetError(TDni, "");
            }
        }

        private void TDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo dígitos y teclas de control (como Backspace)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Bloquea la tecla
            }
        }

        private void TDireccion_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TDireccion.Text))
            {
                errorProvider1.SetError(TDireccion, "El campo no puede estar vacío");
            }
            else
            {
                errorProvider1.SetError(TDireccion, "");
            }
        }
    }
}

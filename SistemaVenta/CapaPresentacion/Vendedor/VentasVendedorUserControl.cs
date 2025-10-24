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
            using (BuscarClientes buscarClientes = new BuscarClientes())
            {
                //  Suscribe el método local al evento del otro formulario 
                buscarClientes.ClienteSeleccionado += FormBusqueda_ClienteSeleccionado;

                // Mostrar el formulario como un diálogo modal
                buscarClientes.ShowDialog(this);

                // (Opcional pero recomendado) Desuscribirse después de que se cierre
                buscarClientes.ClienteSeleccionado -= FormBusqueda_ClienteSeleccionado;
            }
        }
        // 4. Este es el método que se ejecutará cuando se seleccione un cliente en el otro form
        private void FormBusqueda_ClienteSeleccionado(object sender, Cliente cliente)
        {
            if (cliente != null)
            {
                // Actualiza los TextBox en ESTE UserControl con los datos recibidos
                TNombre.Text = cliente.Nombre_cliente;
                TApellido.Text = cliente.Apellido_cliente;
                TDni.Text = cliente.Dni_cliente;
                TDireccion.Text = cliente.Direccion_cliente;
                // Actualiza aquí los demás TextBox que necesites
            }
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

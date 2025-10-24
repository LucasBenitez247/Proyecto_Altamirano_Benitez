using CapaEntidad;
using CapaNegocio;
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

        public event EventHandler<Cliente> ClienteSeleccionado;
        public BuscarClientes()
        {
            InitializeComponent();
            CargarClientes();
        }
        private void CargarClientes()
        {
            List<Cliente> listaClientes = new CN_Cliente().Listar();
            dataGridViewClientes.DataSource = listaClientes;
            // Cambia los encabezados de las columnas
            if (dataGridViewClientes.Columns["Id_cliente"] != null)
                dataGridViewClientes.Columns["Id_cliente"].HeaderText = "ID Cliente";
            if (dataGridViewClientes.Columns["Nombre_cliente"] != null)
                dataGridViewClientes.Columns["Nombre_cliente"].HeaderText = "Nombre";
            if (dataGridViewClientes.Columns["Apellido_cliente"] != null)
                dataGridViewClientes.Columns["Apellido_cliente"].HeaderText = "Apellido";
            if (dataGridViewClientes.Columns["Dni_cliente"] != null)
                dataGridViewClientes.Columns["Dni_cliente"].HeaderText = "DNI";
            if (dataGridViewClientes.Columns["Genero_cliente"] != null)
                dataGridViewClientes.Columns["Genero_cliente"].HeaderText = "Género";
            if (dataGridViewClientes.Columns["Correo_cliente"] != null)
                dataGridViewClientes.Columns["Correo_cliente"].HeaderText = "Correo";
            if (dataGridViewClientes.Columns["Telefono_cliente"] != null)
                dataGridViewClientes.Columns["Telefono_cliente"].HeaderText = "Teléfono";
            if (dataGridViewClientes.Columns["Direccion_cliente"] != null)
                dataGridViewClientes.Columns["Direccion_cliente"].HeaderText = "Dirección";
            if (dataGridViewClientes.Columns["Ciudad_cliente"] != null)
                dataGridViewClientes.Columns["Ciudad_cliente"].HeaderText = "Ciudad";
            if (dataGridViewClientes.Columns["Provincia_cliente"] != null)
                dataGridViewClientes.Columns["Provincia_cliente"].HeaderText = "Provincia";
            if (dataGridViewClientes.Columns["Cod_postal_cliente"] != null)
                dataGridViewClientes.Columns["Cod_postal_cliente"].HeaderText = "Código Postal";
            if (dataGridViewClientes.Columns["Estado_cliente"] != null)
                dataGridViewClientes.Columns["Estado_cliente"].HeaderText = "Estado";
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
                DataGridViewRow fila = dataGridViewClientes.Rows[e.RowIndex];

                // Crea un objeto Cliente con los datos de la fila seleccionada
                Cliente clienteSeleccionado = new Cliente
                {
                    
                    Id_cliente = Convert.ToInt32(fila.Cells["Id_cliente"].Value ?? 0), 
                    Nombre_cliente = fila.Cells["Nombre_cliente"].Value?.ToString() ?? "", 
                    Apellido_cliente = fila.Cells["Apellido_cliente"].Value?.ToString() ?? "",
                    Dni_cliente = fila.Cells["Dni_cliente"].Value?.ToString() ?? "",
                    Direccion_cliente = fila.Cells["Direccion_cliente"].Value?.ToString() ?? ""
                    
                };

                // Dispara el evento, pasando el cliente seleccionado
                OnClienteSeleccionado(clienteSeleccionado);

                // Cierra este formulario
                this.Close();
            }

        }
        protected virtual void OnClienteSeleccionado(Cliente cliente)
        {
            ClienteSeleccionado?.Invoke(this, cliente);
        }
    }
}

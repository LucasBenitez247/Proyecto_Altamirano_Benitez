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

        // Lista global para guardar los clientes
        private List<Cliente> listaClientesGlobal;
        public BuscarClientes()
        {
            InitializeComponent();
            CargarClientes();

           // Conectar los eventos del TextBox
            this.TBuscarCliente.Enter += new System.EventHandler(this.TBuscarCliente_Enter);
            this.TBuscarCliente.Leave += new System.EventHandler(this.TBuscarCliente_Leave);
            this.TBuscarCliente.TextChanged += new System.EventHandler(this.TBuscarCliente_TextChanged);

            // Mejorar el placeholder 
            TBuscarCliente.ForeColor = Color.Gray;
        }
        private void CargarClientes()
        {
            // 1. Carga la lista desde la BD a la variable global
            listaClientesGlobal = new CN_Cliente().Listar();

            // 2. Asigna la lista completa al DataGridView
            dataGridViewClientes.DataSource = listaClientesGlobal;

            // 3. Formatea las columnas
            FormatearColumnas();
        }
        private void FormatearColumnas()
        {
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
                // Obtener el cliente de la lista filtrada
                // Obtenemos el cliente directamente del DataSource actual de la grilla
                Cliente clienteSeleccionado = (dataGridViewClientes.Rows[e.RowIndex].DataBoundItem as Cliente);

                if (clienteSeleccionado != null)
                {
                    // Dispara el evento, pasando el cliente seleccionado
                    OnClienteSeleccionado(clienteSeleccionado);
                    this.Close();
                }
            }

        }
        protected virtual void OnClienteSeleccionado(Cliente cliente)
        {
            ClienteSeleccionado?.Invoke(this, cliente);
        }

        private void TBuscarCliente_TextChanged(object sender, EventArgs e)
        {
            string textoBusqueda = TBuscarCliente.Text.ToLower().Trim();

            // No filtrar si el texto es el placeholder
            if (textoBusqueda == "buscar cliente...")
            {
                return;
            }

            // Filtrar por Nombre, Apellido o DNI
            List<Cliente> clientesFiltrados = listaClientesGlobal.Where(c =>
                c.Nombre_cliente.ToLower().Contains(textoBusqueda) ||
                c.Apellido_cliente.ToLower().Contains(textoBusqueda) ||
                c.Dni_cliente.Contains(textoBusqueda) // DNI no necesita ToLower
            ).ToList();

            // Actualizar el DataSource
            dataGridViewClientes.DataSource = clientesFiltrados;

            // Re-aplicar formato de cabeceras (se pierde al cambiar el DataSource)
            FormatearColumnas();
        }

        private void TBuscarCliente_Enter(object sender, EventArgs e)
        {
            if (TBuscarCliente.Text == "Buscar Cliente...")
            {
                TBuscarCliente.Text = "";
                TBuscarCliente.ForeColor = Color.Black;
            }
        }

        private void TBuscarCliente_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TBuscarCliente.Text))
            {
                TBuscarCliente.Text = "Buscar Cliente...";
                TBuscarCliente.ForeColor = Color.Gray;

                // Mostrar todos los clientes de nuevo
                dataGridViewClientes.DataSource = listaClientesGlobal;
                FormatearColumnas();
            }
        }
    }
}

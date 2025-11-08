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
    public partial class VerListaClientesUserControl : UserControl
    {

        private List<Cliente> listaClientesGlobal;
        public VerListaClientesUserControl()
        {
            InitializeComponent();

            dataGridView2.AllowUserToAddRows = false;
            TBuscarCliente.ForeColor = Color.Gray;

            CargarClientes();

            this.TBuscarCliente.Enter += new System.EventHandler(this.TBuscarCliente_Enter);
            this.TBuscarCliente.Leave += new System.EventHandler(this.TBuscarCliente_Leave);
            this.TBuscarCliente.TextChanged += new System.EventHandler(this.TBuscarCliente_TextChanged);

            // Conectar el botón de búsqueda
            this.IBtnBuscarCliente.Click += new System.EventHandler(this.TBuscarCliente_TextChanged);
        }
        private void CargarClientes()
        {
            // Carga la lista global
            listaClientesGlobal = new CN_Cliente().Listar();

            // Asigna la lista completa al DataSource
            dataGridView2.DataSource = listaClientesGlobal;

            // Formatea las columnas
            FormatearColumnas();
        }

        private void FormatearColumnas()
        {
            // Cambia los encabezados de las columnas
            if (dataGridView2.Columns["Id_cliente"] != null)
                dataGridView2.Columns["Id_cliente"].HeaderText = "ID Cliente";
            if (dataGridView2.Columns["Nombre_cliente"] != null)
                dataGridView2.Columns["Nombre_cliente"].HeaderText = "Nombre";
            if (dataGridView2.Columns["Apellido_cliente"] != null)
                dataGridView2.Columns["Apellido_cliente"].HeaderText = "Apellido";
            if (dataGridView2.Columns["Dni_cliente"] != null)
                dataGridView2.Columns["Dni_cliente"].HeaderText = "DNI";
            if (dataGridView2.Columns["Genero_cliente"] != null)
                dataGridView2.Columns["Genero_cliente"].HeaderText = "Género";
            if (dataGridView2.Columns["Correo_cliente"] != null)
                dataGridView2.Columns["Correo_cliente"].HeaderText = "Correo";
            if (dataGridView2.Columns["Telefono_cliente"] != null)
                dataGridView2.Columns["Telefono_cliente"].HeaderText = "Teléfono";
            if (dataGridView2.Columns["Direccion_cliente"] != null)
                dataGridView2.Columns["Direccion_cliente"].HeaderText = "Dirección";
            if (dataGridView2.Columns["Ciudad_cliente"] != null)
                dataGridView2.Columns["Ciudad_cliente"].HeaderText = "Ciudad";
            if (dataGridView2.Columns["Provincia_cliente"] != null)
                dataGridView2.Columns["Provincia_cliente"].HeaderText = "Provincia";
            if (dataGridView2.Columns["Cod_postal_cliente"] != null)
                dataGridView2.Columns["Cod_postal_cliente"].HeaderText = "Código Postal";
            if (dataGridView2.Columns["Estado_cliente"] != null)
                dataGridView2.Columns["Estado_cliente"].HeaderText = "Estado";
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
                c.Dni_cliente.StartsWith(textoBusqueda) 
            ).ToList();

            // Actualizar el DataSource
            dataGridView2.DataSource = clientesFiltrados;

            // Re-aplicar formato
            FormatearColumnas();
        }

        private void TBuscarCliente_Enter(object sender, EventArgs e)
        {
            if (TBuscarCliente.Text == "Buscar Cliente...")
            {
                TBuscarCliente.Text = "";
                TBuscarCliente.ForeColor = Color.FromArgb(224, 224, 224); // Color de texto normal
            }
        }

        private void TBuscarCliente_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TBuscarCliente.Text))
            {
                TBuscarCliente.Text = "Buscar Cliente...";
                TBuscarCliente.ForeColor = Color.Gray;

                // Mostrar todos los clientes de nuevo
                dataGridView2.DataSource = listaClientesGlobal;
                FormatearColumnas();
            }
        }
    }
}

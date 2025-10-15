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
        public VerListaClientesUserControl()
        {
            InitializeComponent();
            CargarClientes();
        }
        private void CargarClientes()
        {
            List<Cliente> listaClientes = new CN_Cliente().Listar();
            dataGridView2.DataSource = listaClientes;
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
    }
}

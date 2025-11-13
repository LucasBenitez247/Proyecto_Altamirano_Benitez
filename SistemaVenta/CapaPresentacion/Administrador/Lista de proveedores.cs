using CapaEntidad;
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
    public partial class Lista_de_proveedores : Form
    {
        public event Action<Proveedor> IdSeleccionado;
        List<Proveedor> listaProveedores = new List<Proveedor>();
        public Lista_de_proveedores()
        {
            InitializeComponent();
        }

        private void Lista_de_proveedores_Load(object sender, EventArgs e)
        {
            cargarProveedores();
        }

        private void cargarProveedores()
        {
            CapaNegocio.CN_Proveedor cnProveedor = new CapaNegocio.CN_Proveedor();
            listaProveedores = cnProveedor.Listar();
            mostrarProveedores(listaProveedores);
        }

        private void mostrarProveedores(List<Proveedor> proveedores)
        {
            dgvProveedores.Rows.Clear();

            foreach (Proveedor proveedor in proveedores)
            {
                dgvProveedores.Rows.Add(
                    proveedor.Id_proveedor,
                    proveedor.Nro_documento_proveedor,
                    proveedor.Razon_social
                );
            }
        }

        private void txtBuscador_TextChanged(object sender, EventArgs e)
        {
            string texto = txtBuscador.Text.Trim().ToLower();
            string criterio = cboBuscarPor.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(texto) || string.IsNullOrEmpty(criterio))
            {
                mostrarProveedores(listaProveedores);
                return;
            }

            List<Proveedor> filtrados;

            if (criterio == "Razón Social")
            {
                filtrados = listaProveedores
                    .Where(p => p.Razon_social.ToLower().Contains(texto))
                    .ToList();
            }
            else // Nro Documento
            {
                filtrados = listaProveedores
                    .Where(p => p.Nro_documento_proveedor.ToString().StartsWith(texto))
                    .ToList();
            }

            mostrarProveedores(filtrados);
        }

        private void dgvProveedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
           
        }

        private void dgvProveedores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Obtener el valor de la fila seleccionada
                var valorCelda = dgvProveedores.Rows[e.RowIndex].Cells["idProveedor"].Value?.ToString();
                if (int.TryParse(valorCelda, out int id))
                {
                    Proveedor proveedorSeleccionado = listaProveedores.FirstOrDefault(p => p.Id_proveedor == id);
                    IdSeleccionado?.Invoke(proveedorSeleccionado);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al obtener el ID del proveedor seleccionado.");
                }
            }
        }

        // Seguir con la implementación
        // seleccionar el proveedor y retornarlo a la formulario que lo llamó es decir Compras.


    }
}

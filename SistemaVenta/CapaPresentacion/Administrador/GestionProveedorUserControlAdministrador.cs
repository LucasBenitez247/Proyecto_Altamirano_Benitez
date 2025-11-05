using CapaEntidad;
using CapaNegocio;
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

namespace CapaPresentacion.Administrador
{
    public partial class GestionProveedorUserControlAdministrador : UserControl
    {
        private List<Proveedor> listaProveedores = new List<Proveedor>();

        public GestionProveedorUserControlAdministrador()
        {
            InitializeComponent();
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            // Validaciones básicas
            if (string.IsNullOrWhiteSpace(TRazonSocial.Text) ||
                string.IsNullOrWhiteSpace(TNroDocumento.Text) ||
                string.IsNullOrWhiteSpace(TCorreo.Text) ||
                string.IsNullOrWhiteSpace(TTelefono.Text))
            {
                MessageBox.Show("Complete todos los campos.");
                return;
            }

            if(cboEstado.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un estado.");
                return;
            }

            // Crear instancia de Proveedor
            Proveedor nuevoProveedor = CrearProveedor();

            try
            {
                CapaNegocio.CN_Proveedor cnProveedor = new CapaNegocio.CN_Proveedor();
                bool resultado = cnProveedor.Registrar(nuevoProveedor);
                if (resultado)
                {
                    MessageBox.Show("Proveedor registrado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("No se pudo registrar el proveedor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error técnico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            cargarProveedores(); // Actualizar la lista de proveedores
        }

        public Proveedor CrearProveedor()
        {
            Proveedor nuevoProveedor = new Proveedor
            {
                Razon_social = TRazonSocial.Text.Trim(),
                Nro_documento_proveedor = int.Parse(TNroDocumento.Text.Trim()),
                Correo = TCorreo.Text.Trim(),
                Telefono = TTelefono.Text.Trim(),
                Estado_proveedor = cboEstado.SelectedItem.ToString() == "Activo" ? 1 : 0
            };
            return nuevoProveedor;
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            TRazonSocial.Clear();
            TNroDocumento.Clear();
            TCorreo.Clear();
            TTelefono.Clear();
            cboEstado.SelectedIndex = 1;
        }

        private void TNroDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                errorProvider1.SetError(TNroDocumento, "Solo puede ingresar números");
                e.Handled = true;
            }
            else
            {
                errorProvider1.SetError(TNroDocumento, "");
            }
        }

        private void TRazonSocial_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void TCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            string correo = TCorreo.Text;
            string patron = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            if (!Regex.IsMatch(correo, patron))
            {
                errorProvider3.SetError(TCorreo, "Formato de correo inválido");
                // e.Cancel = false;   //  No bloquea, solo muestra error
            }
            else
            {
                errorProvider3.SetError(TCorreo, "");
            }
        }

        private void TTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                errorProvider4.SetError(TTelefono, "Solo puede ingresar números");
                e.Handled = true;
            }
            else
            {
                errorProvider4.SetError(TTelefono, "");
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            
        }

        private void GestionProveedorUserControlAdministrador_Load(object sender, EventArgs e)
        {
            
            inicializarControles();
            cargarProveedores();
        }

        private void inicializarControles()
        {
            // Configurar DataGridView para que las columnas Modificar y Eliminar muestren texto
            dgvProveedores.Columns["CModificar"].DefaultCellStyle.NullValue = "Modificar";
            dgvProveedores.Columns["CEliminar"].DefaultCellStyle.NullValue = "Eliminar";
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
                    proveedor.Razon_social,
                    proveedor.Correo,
                    proveedor.Telefono,
                    proveedor.Estado_proveedor == 1 ? "Activo" : "Inactivo"
                );
            }
        }


        private void dgvProveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvProveedores.Columns[e.ColumnIndex].Name == "CModificar" && e.RowIndex >= 0)
            {
                
                // Lógica para modificar el proveedor
                int idProveedor = Convert.ToInt32(dgvProveedores.Rows[e.RowIndex].Cells["idProveedor"].Value);

                Proveedor proveedor = new Proveedor()
                {
                    Id_proveedor = idProveedor,
                    Nro_documento_proveedor = Convert.ToInt32(dgvProveedores.Rows[e.RowIndex].Cells["CDni"].Value),
                    Razon_social = dgvProveedores.Rows[e.RowIndex].Cells["CRazonSocial"].Value.ToString(),
                    Correo = dgvProveedores.Rows[e.RowIndex].Cells["cCorreo"].Value.ToString(),
                    Telefono = dgvProveedores.Rows[e.RowIndex].Cells["CTelefono"].Value.ToString(),
                    Estado_proveedor = dgvProveedores.Rows[e.RowIndex].Cells["CEstado"].Value.ToString() == "Activo" ? 1 : 0
                };
                // Abrir el formulario de modificación
                ModificarProveedorFormAdministrador modificarForm = new ModificarProveedorFormAdministrador(proveedor);
                modificarForm.ShowDialog();
                // Recargar la lista de proveedores después de la modificación
                cargarProveedores();

            }
            else if(dgvProveedores.Columns[e.ColumnIndex].Name == "CEliminar" && e.RowIndex >= 0)
            {
                // Lógica para eliminar el proveedor
                string RazonSocial = dgvProveedores.Rows[e.RowIndex].Cells["CRazonSocial"].Value.ToString();
                int idProveedor = Convert.ToInt32(dgvProveedores.Rows[e.RowIndex].Cells["idProveedor"].Value);
                DialogResult result = MessageBox.Show($"¿Estás seguro de eliminar al proveedor:  {RazonSocial}?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(result == DialogResult.Yes)
                {
                    CapaNegocio.CN_Proveedor cnProveedor = new CapaNegocio.CN_Proveedor();
                    bool eliminado = cnProveedor.Eliminar(idProveedor);
                    if(eliminado)
                    {
                        MessageBox.Show($"El proveedor {RazonSocial} fue eliminado exitosamente.");
                        cargarProveedores(); // Actualizar la lista después de eliminar
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar el proveedor.");
                    }
                }
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

        

    }
}
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
    public partial class ModificarProveedorFormAdministrador : Form
    {
        Proveedor proveedor;
        public ModificarProveedorFormAdministrador(Proveedor p_proveedor)
        {
            proveedor = p_proveedor;
            InitializeComponent();

            // Cargar datos del proveedor en los campos del formulario
            cargarCampos();
        }

        public void cargarCampos()
        {
            // Asignar los valores del proveedor a los controles del formulario
            
            txtNroDocumento.Text = proveedor.Nro_documento_proveedor.ToString();
            txtRazonSocial.Text = proveedor.Razon_social;
            txtCorreo.Text = proveedor.Correo;
            txtTelefono.Text = proveedor.Telefono;
            // Configurar el estado del proveedor en el ComboBox
            if (proveedor.Estado_proveedor == 1)
            {
                cboEstado.SelectedItem = "Activo";
            }
            else
            {
                cboEstado.SelectedItem = "Inactivo";
            }
        }

        private bool validarCampos()
        {
            // Validar que todos los campos estén completos
            if (string.IsNullOrWhiteSpace(txtNroDocumento.Text) ||
                    string.IsNullOrWhiteSpace(txtRazonSocial.Text) ||
                        string.IsNullOrWhiteSpace(txtTelefono.Text) ||
                           string.IsNullOrWhiteSpace(txtCorreo.Text))

            {
                MessageBox.Show("Falta completar campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            } else {
                return true;
            }
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            if(!validarCampos())
            {
                return;
            } else
            {
                Proveedor proveedorModificado = new Proveedor();
                proveedorModificado.Id_proveedor = proveedor.Id_proveedor;
                proveedorModificado.Nro_documento_proveedor = Convert.ToInt32( txtNroDocumento.Text.Trim() );
                proveedorModificado.Razon_social = txtRazonSocial.Text.Trim();
                proveedorModificado.Correo = txtCorreo.Text.Trim();
                proveedorModificado.Telefono = txtTelefono.Text.Trim();
                proveedorModificado.Estado_proveedor = (cboEstado.SelectedItem.ToString() == "Activo") ? 1 : 0;
                try
                {
                    CapaNegocio.CN_Proveedor cnProveedor = new CapaNegocio.CN_Proveedor();
                    bool resultado = cnProveedor.Modificar(proveedorModificado);
                    if (resultado)
                    {
                        MessageBox.Show("Proveedor modificado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                        
                    }
                    else
                    {
                        MessageBox.Show("No se pudo modificar el proveedor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error técnico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            txtCorreo.Clear();
            txtRazonSocial.Clear();
            txtTelefono.Clear();
            cboEstado.SelectedIndex = -1;
        }
    }
}

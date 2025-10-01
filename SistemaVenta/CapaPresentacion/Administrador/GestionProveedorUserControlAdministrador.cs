using CapaEntidad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                errorProvider2.SetError(TRazonSocial, "Solo puede ingresar letras y espacios");
                e.Handled = true;
            }
            else
            {
                errorProvider2.SetError(TRazonSocial, "");
            }
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
    }
}

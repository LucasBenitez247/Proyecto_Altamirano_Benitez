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
    public partial class GestionProductosUserControlAdministrador : UserControl
    {
        public GestionProductosUserControlAdministrador()
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
            comboBox2.SelectedIndex = -1;
        }

        private void TNroDocumento_Validating(object sender, CancelEventArgs e)
        {

        }

        private void TCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            string correo = TCorreo.Text;
            string patron = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            if (!Regex.IsMatch(correo, patron))
            {
                errorProvider1.SetError(TCorreo, "Formato de correo inválido");
                // e.Cancel = false;   //  No bloquea, solo muestra error
            }
            else
            {
                errorProvider1.SetError(TCorreo, "");
            }
        }

        private void TCorreo_TextChanged(object sender, EventArgs e)
        {

        }

        private void TNroDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Bloquea la entrada no numérica
            }
        }

        private void TTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Bloquea la entrada no numérica
            }
        }
    }
}

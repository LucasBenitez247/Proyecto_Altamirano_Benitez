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
using System.Data.SqlClient;

namespace CapaPresentacion.Vendedor
{
    public partial class RegistrarClienteUserControl : UserControl
    {
        public RegistrarClienteUserControl()
        {
            InitializeComponent();
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            TNombre.Clear();
            TApellido.Clear();
            TDni.Clear();
            TCorreo.Clear();
            TTelefono.Clear();
            TCalleNro.Clear();
            TCiudad.Clear();
            TProvincia.Clear();
            TCodigoPostal.Clear();
        }

        private void TNombre_TextChanged(object sender, EventArgs e)
        {
            if (TNombre.Text.Length > 0)
            {
                var palabras = TNombre.Text.Split(' ');
                for (int i = 0; i < palabras.Length; i++)
                {
                    if (palabras[i].Length > 0)
                    {
                        palabras[i] = char.ToUpper(palabras[i][0]) + palabras[i].Substring(1).ToLower();
                    }
                }
                int pos = TNombre.SelectionStart;
                TNombre.Text = string.Join(" ", palabras);
                TNombre.SelectionStart = pos;
            }
        }

        private void TApellido_TextChanged(object sender, EventArgs e)
        {
            if (TApellido.Text.Length > 0)
            {
                string apellido = TApellido.Text;
                apellido = char.ToUpper(apellido[0]) + apellido.Substring(1).ToLower();

                int pos = TApellido.SelectionStart;
                TApellido.Text = apellido;
                TApellido.SelectionStart = pos;
            }
        }

        private void TNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                errorProvider1.SetError(TNombre, "Solo puede ingresar letras y espacios");
                e.Handled = true;
            }
            else
            {
                errorProvider1.SetError(TNombre, "");
            }
        }

        private void TApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                errorProvider2.SetError(TApellido, "Solo puede ingresar letras y espacios");
                e.Handled = true;
            }
            else
            {
                errorProvider2.SetError(TApellido, "");
            }
        }

        private void TDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                errorProvider3.SetError(TDni, "Solo puede ingresar números");
                e.Handled = true;
            }
            else
            {
                errorProvider3.SetError(TDni, "");
            }
        }

        private void TCorreo_Validating(object sender, CancelEventArgs e)
        {
            string correo = TCorreo.Text;
            string patron = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            if (!Regex.IsMatch(correo, patron))
            {
                errorProvider4.SetError(TCorreo, "Formato de correo inválido");
                // e.Cancel = false;   //  No bloquea, solo muestra error
            }
            else
            {
                errorProvider4.SetError(TCorreo, "");
            }
        }

        private void TTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                errorProvider5.SetError(TTelefono, "Solo puede ingresar números");
                e.Handled = true;
            }
            else
            {
                errorProvider5.SetError(TTelefono, "");
            }
        }

        private void TCalleNro_Leave(object sender, EventArgs e)
        {
            string direccion = TCalleNro.Text.Trim();

            // Regex: al menos una letra, puede contener letras, números, espacios, guiones y º°
            string patron = @"^[a-zA-ZÁÉÍÓÚÑáéíóúñ0-9\s\-\.º°]+$";

            if (string.IsNullOrWhiteSpace(direccion))
            {
                errorProvider6.SetError(TCalleNro, "La dirección no puede estar vacía");
            }
            else if (!Regex.IsMatch(direccion, patron))
            {
                errorProvider6.SetError(TCalleNro, "Ingrese una dirección válida (solo letras y números)");
            }
            else
            {
                errorProvider6.SetError(TCalleNro, "");
            }
        }

        private void TCiudad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                errorProvider7.SetError(TCiudad, "Solo puede ingresar letras y espacios");
                e.Handled = true;
            }
            else
            {
                errorProvider7.SetError(TCiudad, "");
            }
        }

        private void TProvincia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                errorProvider8.SetError(TProvincia, "Solo puede ingresar letras y espacios");
                e.Handled = true;
            }
            else
            {
                errorProvider8.SetError(TProvincia, "");
            }
        }

        private void TCodigoPostal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                errorProvider9.SetError(TCodigoPostal, "Solo puede ingresar números");
                e.Handled = true;
            }
            else
            {
                errorProvider9.SetError(TCodigoPostal, "");
            }
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            // Validaciones básicas
            if (string.IsNullOrWhiteSpace(TNombre.Text) ||
                string.IsNullOrWhiteSpace(TApellido.Text) ||
                string.IsNullOrWhiteSpace(TDni.Text) ||
                string.IsNullOrWhiteSpace(TCorreo.Text) ||
                string.IsNullOrWhiteSpace(TTelefono.Text) ||
                string.IsNullOrWhiteSpace(TCalleNro.Text) ||
                string.IsNullOrWhiteSpace(TCiudad.Text) ||
                string.IsNullOrWhiteSpace(TProvincia.Text) ||
                string.IsNullOrWhiteSpace(TCodigoPostal.Text) 
               )
            {
                MessageBox.Show("Complete todos los campos.");
                return;
            }
        }
    }

}

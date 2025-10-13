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


namespace CapaPresentacion.Vendedor
{
    public partial class RegistrarClienteUserControl : UserControl
    {
        private int idClienteSeleccionado = 0;
        public RegistrarClienteUserControl()
        {
            InitializeComponent();
            CargarClientes();
            
        }
        private void LimpiarCampos()
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
            RBMasculino.Checked = false;
            RBFemenino.Checked = false;
            RBOtro.Checked = false;
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
        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
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
                string.IsNullOrWhiteSpace(TCorreo.Text))
            {
                MessageBox.Show("Complete todos los campos obligatorios.");
                return;
            }

            string genero = RBMasculino.Checked ? "Masculino" :
                            RBFemenino.Checked ? "Femenino" :
                            RBOtro.Checked ? "Otro" : "";

            int codPostal = int.TryParse(TCodigoPostal.Text, out int cp) ? cp : 0;

            Cliente cliente = new Cliente()
            {
                Id_cliente = idClienteSeleccionado,
                Nombre_cliente = TNombre.Text.Trim(),
                Apellido_cliente = TApellido.Text.Trim(),
                Dni_cliente = TDni.Text.Trim(),
                Genero_cliente = genero,
                Correo_cliente = TCorreo.Text.Trim(),
                Telefono_cliente = TTelefono.Text.Trim(),
                Direccion_cliente = TCalleNro.Text.Trim(),
                Ciudad_cliente = TCiudad.Text.Trim(),
                Provincia_cliente = TProvincia.Text.Trim(),
                Cod_postal_cliente = codPostal,
                Estado_cliente = 1 // Activo por defecto
            };

            bool resultado = false;

            if (idClienteSeleccionado == 0)
            {
                string resultadoStr = new CN_Cliente().Registrar(cliente);
                if (resultadoStr == "OK")
                {
                    MessageBox.Show("Cliente registrado con éxito");
                    resultado = true;
                }
                else
                {
                    MessageBox.Show("Error al registrar el cliente: " + resultadoStr);
                    resultado = false;
                }
            }
            else
            {
                resultado = new CN_Cliente().Modificar(cliente);
                if (resultado) MessageBox.Show("Cliente modificado con éxito");
            }

            if (resultado)
            {
                LimpiarCampos();
                CargarClientes();
                idClienteSeleccionado = 0;
            }
            else
            {
                MessageBox.Show("Error al guardar el cliente");
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dataGridView2.Rows[e.RowIndex];

                TNombre.Text = fila.Cells["Nombre_cliente"].Value?.ToString();
                TApellido.Text = fila.Cells["Apellido_cliente"].Value?.ToString();
                TDni.Text = fila.Cells["Dni_cliente"].Value?.ToString();
                TCorreo.Text = fila.Cells["Correo_cliente"].Value?.ToString();
                TTelefono.Text = fila.Cells["Telefono_cliente"].Value?.ToString();
                TCalleNro.Text = fila.Cells["Direccion_cliente"].Value?.ToString();
                TCiudad.Text = fila.Cells["Ciudad_cliente"].Value?.ToString();
                TProvincia.Text = fila.Cells["Provincia_cliente"].Value?.ToString();
                TCodigoPostal.Text = fila.Cells["Cod_postal_cliente"].Value?.ToString();
            }
        }
    }

}

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
        }
    }
}

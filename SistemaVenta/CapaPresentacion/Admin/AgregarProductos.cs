using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Admin
{
    public partial class AgregarProductos : UserControl
    {
        public AgregarProductos()
        {
            InitializeComponent();
        }

        private void cboCategoría_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboTipoProducto.Items.Clear();
            if (cboCategoría.SelectedItem.ToString() == "Camisetas")
            {
                cboTipoProducto.Items.Add("Camisetas");
                cboTipoProducto.Items.Add("Remeras");
                cboTipoProducto.Items.Add("Chaqueta");
            }
            else if (cboCategoría.SelectedItem.ToString() == "Pantalones")
            {
                cboTipoProducto.Items.Add("Shorts");
                cboTipoProducto.Items.Add("Pantalón");
            }
            else if (cboCategoría.SelectedItem.ToString() == "Juguetes Coleccionables")
            {
                cboTipoProducto.Items.Add("Carros");
                cboTipoProducto.Items.Add("Llaveros");
                cboTipoProducto.Items.Add("Muñecos");
            }
            else if (cboCategoría.SelectedItem.ToString() == "Gorras")
            {
                cboTipoProducto.Items.Add("Gorras");
            }
        }

        private void btnSeleccionarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Seleccionar imagen";
            ofd.Filter = "Imágenes|*.jpg;*.png";

            if(ofd.ShowDialog() == DialogResult.OK)
            {
                txtRutaImagen.Text = ofd.FileName;
                picImagen.Image = new Bitmap(ofd.FileName);
            }
        }

        private void picImagen_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarProductos_Click(object sender, EventArgs e)
        {

        }
    }
}

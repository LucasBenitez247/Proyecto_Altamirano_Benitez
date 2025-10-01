using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Dueño_de_Negocio
{
    public partial class DueñoNegocioReportesUserControl : UserControl
    {
        public DueñoNegocioReportesUserControl()
        {
            InitializeComponent();
        }

        private void IBtnBuscar2_Click(object sender, EventArgs e)
        {
            ValidarComboBox();
            if (string.IsNullOrWhiteSpace(TBuscar.Text))
            {
                MessageBox.Show("Ingrese un término de búsqueda.");
                return;
            }
        }

        private void ValidarComboBox()
        {
            if (comboBox1.SelectedIndex == -1)
            {
                errorProvider1.SetError(comboBox1, "Debe seleccionar una opción");
            }
            else
            {
                errorProvider1.SetError(comboBox1, "");
            }
        }
    }
     
    }

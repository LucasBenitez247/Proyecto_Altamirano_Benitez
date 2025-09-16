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
    public partial class DueñoNegocioInicioUserControl : UserControl
    {
        public DueñoNegocioInicioUserControl()
        {
            InitializeComponent();
        }

        private void FechaHora_Tick(object sender, EventArgs e)
        {
            LblHora.Text = DateTime.Now.ToLongTimeString();
            LblFecha.Text = DateTime.Now.ToLongDateString();
        }
    }
}

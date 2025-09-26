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
    public partial class InicioUserControlAdministrador : UserControl
    {
        public InicioUserControlAdministrador()
        {
            InitializeComponent();
        }

        private void FechaHora_Tick(object sender, EventArgs e)
        {
            LblFecha.Text = DateTime.Now.ToLongDateString();
            LblHora.Text = DateTime.Now.ToLongTimeString();
        }
    }
}

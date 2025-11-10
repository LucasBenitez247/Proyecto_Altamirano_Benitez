using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Compra
    {
        private CD_Compra datos = new CD_Compra();

        public bool ExisteNroOrden(int nroOrden)
        {
            return datos.ExisteNroOrden(nroOrden);
        }
    }
}

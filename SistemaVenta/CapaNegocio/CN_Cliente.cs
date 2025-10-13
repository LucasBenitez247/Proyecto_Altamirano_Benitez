using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Cliente
    {
        private CD_Cliente objCapaDatos = new CD_Cliente();

        public string Registrar(Cliente cliente)
        {
            try
            {
                bool resultado = objCapaDatos.Registrar(cliente);
                return resultado ? "Cliente guardado correctamente" : "No se pudo guardar el cliente";
            }
            catch (Exception ex)
            {
                return "Error al guardar el cliente: " + ex.Message;
            }
        }

        public List<Cliente> Listar()
        {
            return objCapaDatos.Listar();
        }

        public bool Modificar(Cliente c)
        {
            return objCapaDatos.Modificar(c);
        }

    }
}
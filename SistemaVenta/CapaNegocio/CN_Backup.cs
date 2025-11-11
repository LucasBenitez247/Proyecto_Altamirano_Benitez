using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Backup
    {
        private readonly CD_Backup datos = new CD_Backup();

        public List<string> ListarBasesDeDatos()
        {
            return datos.ObtenerBasesDeDatos();
        }

        public void EjecutarBackup(string nombreBD, string rutaDestino)
        {
            if (string.IsNullOrEmpty(nombreBD))
                throw new Exception("Debe seleccionar una base de datos.");

            if (string.IsNullOrEmpty(rutaDestino))
                throw new Exception("Debe seleccionar una carpeta de destino.");

            datos.RealizarBackup(nombreBD, rutaDestino);
        }
    }

}

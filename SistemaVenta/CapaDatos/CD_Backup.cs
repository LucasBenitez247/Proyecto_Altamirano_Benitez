using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Backup
    {
        Conexion conexion = new Conexion();
        public void RealizarBackup(string nombreBD, string rutaDestino)
        {
            using (SqlConnection oconexion = conexion.CrearConexion())
            {
                oconexion.Open();
                string query = $"BACKUP DATABASE [{nombreBD}] TO DISK = '{rutaDestino}' WITH FORMAT";
                SqlCommand cmd = new SqlCommand(query, oconexion);
                cmd.ExecuteNonQuery();
            }
        }

        public List<string> ObtenerBasesDeDatos()
        {
            List<string> lista = new List<string>();
            using (SqlConnection oconexion = conexion.CrearConexion())
            {
                oconexion.Open();
                SqlCommand cmd = new SqlCommand("SELECT name FROM sys.databases WHERE database_id > 4", oconexion);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    lista.Add(reader["name"].ToString());
                }
            }
            return lista;
        }
    }

}

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CapaDatos
{
    
    public class Conexion
    {
        private readonly string cadena;

        public Conexion()
        {
            cadena = ConfigurationManager.ConnectionStrings["ConexionBD"].ToString();
        }
        public SqlConnection CrearConexion()
        {
            return new SqlConnection(cadena);
        }

        public bool ProbarConexion()
        {
            try
            {
                using (SqlConnection conn = CrearConexion())
                {
                    conn.Open();
                    Console.WriteLine("Conexión exitosa.");
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al conectar: " + ex.Message);
                return false;
            }
        }



    }

}

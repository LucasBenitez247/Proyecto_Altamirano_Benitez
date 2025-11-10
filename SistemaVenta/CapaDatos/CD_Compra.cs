using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using CapaEntidad;
namespace CapaDatos
{
    public class CD_Compra
    {
        Conexion conexion = new Conexion();
        public bool ExisteNroOrden(int nroOrden)
        {
            
                using (SqlConnection oconexion = conexion.CrearConexion())
                {
                    string query = "SELECT COUNT(*) FROM Compra WHERE Nro_orden = @nroOrden";
                    SqlCommand cmd = new SqlCommand(query, oconexion);
                    cmd.Parameters.AddWithValue("@nroOrden", nroOrden);

                    oconexion.Open();
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
           
        }

    }
}

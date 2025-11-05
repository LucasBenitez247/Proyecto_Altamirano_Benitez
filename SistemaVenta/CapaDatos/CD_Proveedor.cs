using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaDatos
{
    public class CD_Proveedor
    {
        public List<Proveedor> Listar()
        {
            List<Proveedor> lista = new List<Proveedor>();
            Conexion conexion = new Conexion();

            try
            {
                using (SqlConnection oconexion = conexion.CrearConexion())
                {
                    string query = @"SELECT Id_proveedor, 
                                    Nro_Documento_proveedor, 
                                    Razon_Social, 
                                    Estado_proveedor, 
                                   Correo_electronico, 
                                    Telefono 
                             FROM Proveedor";

                    SqlCommand cmd = new SqlCommand(query, oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Proveedor()
                            {
                                Id_proveedor = Convert.ToInt32(dr["Id_proveedor"]),
                                Nro_documento_proveedor = Convert.ToInt32(dr["Nro_Documento_proveedor"]),
                                Razon_social = dr["Razon_Social"].ToString(),
                                Estado_proveedor = Convert.ToInt32(dr["Estado_proveedor"]),
                                Correo = dr["Correo_electronico"].ToString(),
                                Telefono = dr["Telefono"].ToString(),
                            });
                        }
                    }
                }
            }
            catch (Exception)
            {
                lista = new List<Proveedor>();
            }

            return lista;
        }

        public bool Registrar(Proveedor obj)
        {
            bool respuesta = false;

            try
            {
                using (SqlConnection oconexion = new Conexion().CrearConexion())
                {
                    string query = @"INSERT INTO Proveedor
                                    (Nro_Documento_proveedor, Razon_Social, Estado_proveedor, Correo_electronico, Telefono)
                                    VALUES (@Nro_Documento_proveedor, @Razon_Social, @Estado_proveedor, @Correo_electronico, @Telefono)";

                    SqlCommand cmd = new SqlCommand(query, oconexion);
                    cmd.Parameters.AddWithValue("@Nro_Documento_proveedor", obj.Nro_documento_proveedor);
                    cmd.Parameters.AddWithValue("@Razon_Social", obj.Razon_social);
                    cmd.Parameters.AddWithValue("@Correo_electronico", obj.Correo);
                    cmd.Parameters.AddWithValue("@Telefono", obj.Telefono);
                    cmd.Parameters.AddWithValue("@Estado_proveedor", obj.Estado_proveedor);

                    oconexion.Open();
                    respuesta = cmd.ExecuteNonQuery() > 0; // true si insertó
                }
            }
            catch (Exception ex)
            {
                // Guardar el error para debug
                Console.WriteLine("Error al Registrar el Proveedor: " + ex.Message);
                respuesta = false;
            }

            return respuesta;
        }

        // Implementación del método Eliminar
        public bool Eliminar(int Id_proveedor)
        {
            bool respuesta = false;

            try
            {
                using (SqlConnection oconexion = new Conexion().CrearConexion())
                {
                    string query = "DELETE FROM Proveedor WHERE Id_proveedor = @Id";
                    SqlCommand cmd = new SqlCommand(query, oconexion);
                    cmd.Parameters.AddWithValue("@Id", Id_proveedor);
                    oconexion.Open();
                    // Consulta el número de filas afectadas por la eliminación
                    int filasAfectadas = cmd.ExecuteNonQuery();
                    respuesta = filasAfectadas > 0;
                }
            } catch (SqlException ex)
            {
                MessageBox.Show("Error de SQL: " + ex.Message, "Error SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // Guardar el error para debug
                Console.WriteLine("Error al Eliminar al Proveedor: " + ex.Message);
                respuesta = false;
            }

            return respuesta;
        }

        public bool Modificar(Proveedor p)
        {
            bool respuesta = false;

            try
            {
                using (SqlConnection oconexion = new Conexion().CrearConexion())
                {
                    string query = @"UPDATE Proveedor 
                             SET Nro_Documento_proveedor = @NroDocumento,
                                 Razon_Social = @RazonSocial,
                                 Estado_proveedor = @Estado,
                                 Correo_electronico = @Correo,
                                 Telefono = @Telefono
                             WHERE Id_proveedor = @Id";

                    SqlCommand cmd = new SqlCommand(query, oconexion);
                    cmd.Parameters.AddWithValue("@Id", p.Id_proveedor);
                    cmd.Parameters.AddWithValue("@NroDocumento", p.Nro_documento_proveedor);
                    cmd.Parameters.AddWithValue("@RazonSocial", p.Razon_social);
                    cmd.Parameters.AddWithValue("@Estado", p.Estado_proveedor);
                    cmd.Parameters.AddWithValue("@Correo", p.Correo);
                    cmd.Parameters.AddWithValue("@Telefono", p.Telefono);

                    oconexion.Open();
                    /* Consulta el número de filas afectadas por la actualización */
                    int filasAfectadas = cmd.ExecuteNonQuery();
                    respuesta = filasAfectadas > 0;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error de SQL: " + ex.Message, "Error SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al Modificar al Proveedor: " + ex.Message);
                respuesta = false;
            }

            return respuesta;

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;
namespace CapaDatos
{
    public class CD_Usuario
    {
        public List<Usuario> Listar()
        {
            List<Usuario> lista = new List<Usuario>();
            Conexion conexion = new Conexion();

            try
            {
                using (SqlConnection oconexion = conexion.CrearConexion())
                {
                    string query = @"SELECT id_usuario, 
                                    nombre, 
                                    apellido, 
                                    correo, 
                                   '' AS telefono_usuario, 
                                    contrasenia, 
                                    id_perfil, 
                                    estado_usuario 
                             FROM usuarios";

                    SqlCommand cmd = new SqlCommand(query, oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Usuario()
                            {
                                Id_usuario = Convert.ToInt32(dr["id_usuario"]),
                                Nombre_usuario = dr["nombre"].ToString(),
                                Apellido_usuario = dr["apellido"].ToString(),
                                Mail_usuario = dr["correo"].ToString(),
                                //Telefono_usuario = dr["telefono_usuario"].ToString(),
                                Contrasenia_usuario = dr["contrasenia"].ToString(),
                                Id_perfil = Convert.ToInt32(dr["id_perfil"]),
                                Estado_usuario = Convert.ToInt32(dr["estado_usuario"])
                             
                            });
                        }
                    }
                }
            }
            catch (Exception)
            {
                lista = new List<Usuario>();
            }

            return lista;
        }

        public bool Registrar(Usuario obj)
        {
            bool respuesta = false;

            try
            {
                using (SqlConnection oconexion = new Conexion().CrearConexion())
                {
                    string query = @"INSERT INTO usuarios
                                    (nombre, apellido, correo, contrasenia, id_perfil, estado_usuario)
                                    VALUES (@nombre, @apellido, @correo, @contrasenia, @id_perfil, @estado_usuario)";

                    SqlCommand cmd = new SqlCommand(query, oconexion);
                    cmd.Parameters.AddWithValue("@nombre", obj.Nombre_usuario);
                    cmd.Parameters.AddWithValue("@apellido", obj.Apellido_usuario);
                    cmd.Parameters.AddWithValue("@correo", obj.Mail_usuario);
                    cmd.Parameters.AddWithValue("@contrasenia", obj.Contrasenia_usuario);
                    cmd.Parameters.AddWithValue("@id_perfil", obj.Id_perfil);
                    cmd.Parameters.AddWithValue("@estado_usuario", obj.Estado_usuario);

                    oconexion.Open();
                    respuesta = cmd.ExecuteNonQuery() > 0; // true si insertó
                }
            }
            catch (Exception ex)
            {
                // Guardar el error para debug
                Console.WriteLine("Error en Registrar Usuario: " + ex.Message);
                respuesta = false;
            }

            return respuesta;
        }

        // Implementación del método Eliminar
        public bool Eliminar(int idUsuario)
        {
            bool respuesta = false;

            try
            {
                using (SqlConnection oconexion = new Conexion().CrearConexion())
                {
                    string query = "DELETE FROM Usuarios WHERE Id_usuario = @Id";
                    SqlCommand cmd = new SqlCommand(query, oconexion);
                    cmd.Parameters.AddWithValue("@Id", idUsuario);
                    oconexion.Open();
                    int filasAfectadas = cmd.ExecuteNonQuery();
                    respuesta = filasAfectadas > 0;
                }
            }
            catch (Exception ex)
            {
                // Guardar el error para debug
                Console.WriteLine("Error en Eliminar Usuario: " + ex.Message);
                respuesta = false;
            }

            return respuesta;
        }
    }
}

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
                    string query = @"SELECT Id_usuario, 
                                    Nombre_usuario, 
                                    Apellido_usuario, 
                                    Mail_usuario, 
                                    Telefono_usuario, 
                                    Contrasenia_usuario, 
                                    Id_perfil, 
                                    Estado_usuario 
                             FROM Usuario";

                    SqlCommand cmd = new SqlCommand(query, oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Usuario()
                            {
                                Id_usuario = Convert.ToInt32(dr["Id_usuario"]),
                                Nombre_usuario = dr["Nombre_usuario"].ToString(),
                                Apellido_usuario = dr["Apellido_usuario"].ToString(),
                                Mail_usuario = dr["Mail_usuario"].ToString(),
                                Telefono_usuario = dr["Telefono_usuario"].ToString(),
                                Contrasenia_usuario = dr["Contrasenia_usuario"].ToString(),
                                Id_perfil = Convert.ToInt32(dr["Id_perfil"]),
                                Estado_usuario = Convert.ToInt32(dr["Estado_usuario"])
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
    }
}

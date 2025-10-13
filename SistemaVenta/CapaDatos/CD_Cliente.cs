using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using CapaEntidad;


namespace CapaDatos
{
    public class CD_Cliente
    {
        public List<Cliente> Listar()
        {
            List<Cliente> lista = new List<Cliente>();
            Conexion conexion = new Conexion();

            try
            {
                using (SqlConnection oconexion = conexion.CrearConexion())
                {
                    string query = @"SELECT Id_cliente, Nombre_cliente, Apellido_cliente, Dni_cliente, Genero_cliente, Correo_cliente, Telefono_cliente, Direccion_cliente, Ciudad_cliente, Provincia_cliente, Cod_postal_cliente, Estado_cliente FROM Clientes";
                    SqlCommand cmd = new SqlCommand(query, oconexion);
                    oconexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Cliente()
                            {
                                Id_cliente = dr["Id_cliente"] != DBNull.Value ? Convert.ToInt32(dr["Id_cliente"]) : 0,
                                Nombre_cliente = dr["Nombre_cliente"] != DBNull.Value ? dr["Nombre_cliente"].ToString() : "",
                                Apellido_cliente = dr["Apellido_cliente"] != DBNull.Value ? dr["Apellido_cliente"].ToString() : "",
                                Dni_cliente = dr["Dni_cliente"] != DBNull.Value ? dr["Dni_cliente"].ToString() : "",
                                Genero_cliente = dr["Genero_cliente"] != DBNull.Value ? dr["Genero_cliente"].ToString() : "",
                                Correo_cliente = dr["Correo_cliente"] != DBNull.Value ? dr["Correo_cliente"].ToString() : "",
                                Telefono_cliente = dr["Telefono_cliente"] != DBNull.Value ? dr["Telefono_cliente"].ToString() : "",
                                Direccion_cliente = dr["Direccion_cliente"] != DBNull.Value ? dr["Direccion_cliente"].ToString() : "",
                                Ciudad_cliente = dr["Ciudad_cliente"] != DBNull.Value ? dr["Ciudad_cliente"].ToString() : "",
                                Provincia_cliente = dr["Provincia_cliente"] != DBNull.Value ? dr["Provincia_cliente"].ToString() : "",
                                Cod_postal_cliente = dr["Cod_postal_cliente"] != DBNull.Value ? Convert.ToInt32(dr["Cod_postal_cliente"]) : 0,
                                Estado_cliente = dr["Estado_cliente"] != DBNull.Value ? Convert.ToInt32(dr["Estado_cliente"]) : 0
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al listar clientes: " + ex.Message);
                lista = new List<Cliente>();
            }
            return lista;
        }

        public bool Registrar(Cliente obj)
        {
            bool respuesta = false;
            try
            {
                using (SqlConnection oconexion = new Conexion().CrearConexion())
                {
                    string query = @"INSERT INTO Clientes 
                ( Nombre_cliente, Apellido_cliente, Dni_cliente, Genero_cliente, Correo_cliente, Telefono_cliente, Direccion_cliente, Ciudad_cliente, Provincia_cliente, Cod_postal_cliente, Estado_cliente)
                VALUES (@nombre, @apellido, @dni, @genero, @correo, @telefono, @direccion, @ciudad, @provincia, @cod_postal, @estado_cliente)";
                    SqlCommand cmd = new SqlCommand(query, oconexion);
                    cmd.Parameters.AddWithValue("@nombre", obj.Nombre_cliente);
                    cmd.Parameters.AddWithValue("@apellido", obj.Apellido_cliente);
                    cmd.Parameters.AddWithValue("@dni", obj.Dni_cliente);
                    cmd.Parameters.AddWithValue("@genero", obj.Genero_cliente);
                    cmd.Parameters.AddWithValue("@correo", obj.Correo_cliente);
                    cmd.Parameters.AddWithValue("@telefono", obj.Telefono_cliente);
                    cmd.Parameters.AddWithValue("@direccion", obj.Direccion_cliente);
                    cmd.Parameters.AddWithValue("@ciudad", obj.Ciudad_cliente);
                    cmd.Parameters.AddWithValue("@provincia", obj.Provincia_cliente);
                    cmd.Parameters.AddWithValue("@cod_postal", obj.Cod_postal_cliente);
                    cmd.Parameters.AddWithValue("@estado_cliente", obj.Estado_cliente);
                    oconexion.Open();
                    respuesta = cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en Registrar Cliente: " + ex.Message); // <-- Esto te mostrará el error real
                respuesta = false;
            }
            return respuesta;
        }

        public bool Modificar(Cliente c)
        {
            bool respuesta = false;
            try
            {
                using (SqlConnection oconexion = new Conexion().CrearConexion())
                {
                    string query = @"UPDATE clientes SET 
                        Nombre = @nombre,
                        Apellido = @apellido,
                        Dni = @dni,
                        Genero = @genero,
                        Correo = @correo,
                        Telefono = @telefono,
                        Direccion = @direccion,
                        Ciudad = @ciudad,
                        Provincia = @provincia,
                        Cod_postal = @cod_postal,
                        Estado_cliente = @estado_cliente
                        WHERE Id_cliente = @id_cliente";
                    SqlCommand cmd = new SqlCommand(query, oconexion);
                    cmd.Parameters.AddWithValue("@id_cliente", c.Id_cliente);
                    cmd.Parameters.AddWithValue("@nombre", c.Nombre_cliente);
                    cmd.Parameters.AddWithValue("@apellido", c.Apellido_cliente);
                    cmd.Parameters.AddWithValue("@dni", c.Dni_cliente);
                    cmd.Parameters.AddWithValue("@genero", c.Genero_cliente);
                    cmd.Parameters.AddWithValue("@correo", c.Correo_cliente);
                    cmd.Parameters.AddWithValue("@telefono", c.Telefono_cliente);
                    cmd.Parameters.AddWithValue("@direccion", c.Direccion_cliente);
                    cmd.Parameters.AddWithValue("@ciudad", c.Ciudad_cliente);
                    cmd.Parameters.AddWithValue("@provincia", c.Provincia_cliente);
                    cmd.Parameters.AddWithValue("@cod_postal", c.Cod_postal_cliente);
                    cmd.Parameters.AddWithValue("@estado_cliente", c.Estado_cliente);
                    oconexion.Open();
                    respuesta = cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en Modificar Cliente: " + ex.Message);
                respuesta = false;
            }
            return respuesta;
        }
    }
}
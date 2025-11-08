using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace CapaDatos
{
    public class CD_Producto
    {
        public void insertarProducto(Producto producto)
        {
            try
            {


                using (SqlConnection oconexion = new Conexion().CrearConexion())
                {

                    if (producto.Talle_producto > 0)
                    {
                        bool talleExiste = ObtenerTalles().Any(t => t.Id_talle_producto == producto.Talle_producto);
                        if (!talleExiste)
                            throw new Exception("El talle especificado no existe en la base de datos.");
                    }

                    if (CodigoProductoExiste(producto.Codigo_producto))
                        throw new Exception("El código de producto ya existe en la base de datos.");



                    string query = "INSERT INTO Producto (Codigo_producto, Nombre_producto, Descripcion_producto, Precio_producto, Id_estado_producto, Stock_producto, Id_categoria, Id_Talle_producto) " +
                                   "VALUES (@Codigo_producto, @Nombre_producto, @Descripcion_producto, @Precio_producto, @Estado_producto, @Stock_producto, @Id_categoria, @Id_Talle_producto)";

                    SqlCommand cmd = new SqlCommand(query, oconexion);
                    cmd.Parameters.AddWithValue("@Codigo_producto", producto.Codigo_producto);
                    cmd.Parameters.AddWithValue("@Nombre_producto", producto.Nombre_producto);
                    cmd.Parameters.AddWithValue("@Descripcion_producto", producto.Descripcion_producto);
                    cmd.Parameters.AddWithValue("@Precio_producto", producto.Precio_producto);
                    cmd.Parameters.AddWithValue("@Stock_producto", producto.Stock_producto);
                    cmd.Parameters.AddWithValue("@Id_categoria", producto.Categoria_producto);
                    cmd.Parameters.AddWithValue("@Estado_producto", producto.Estado_producto);
                    object talleParam = producto.Talle_producto > 0
                    ? (object)producto.Talle_producto
                    : DBNull.Value;

                    cmd.Parameters.AddWithValue("@Id_Talle_producto", talleParam);


                    oconexion.Open();

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar producto: " + ex.Message);
            }

        }

        /** Metodo para obtener las categorias de productos desde la base de datos
        **/
        public List<Categoria_producto> categoriaProducto()
        {
            List<Categoria_producto> lista = new List<Categoria_producto>();
            using (SqlConnection oconexion = new Conexion().CrearConexion())
            {

                string query = "SELECT Id_categoria, Descripcion_categoria FROM Categoria_Producto";
                SqlCommand cmd = new SqlCommand(query, oconexion);
                cmd.CommandType = System.Data.CommandType.Text;

                oconexion.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    lista.Add(new Categoria_producto()
                    {
                        Id_categoria = Convert.ToInt32(reader["Id_categoria"]),
                        Descripcion_categoria = reader["Descripcion_categoria"].ToString()
                    });
                }

            }
            return lista;
        }

        public List<Producto> productos()
        {
            List<Producto> lista = new List<Producto>();
            using (SqlConnection oconexion = new Conexion().CrearConexion())
            {
                string query = "SELECT Id_Producto, Codigo_producto, Nombre_producto, Descripcion_producto, Precio_producto, Id_estado_producto, Stock_producto, Id_categoria, Id_Talle_producto FROM Producto";


                SqlCommand cmd = new SqlCommand(query, oconexion);
                cmd.CommandType = System.Data.CommandType.Text;
                oconexion.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Producto producto = new Producto();
                    producto.Id_producto = Convert.ToInt32(reader["Id_producto"]);
                    producto.Codigo_producto = reader["Codigo_producto"].ToString();
                    producto.Nombre_producto = reader["Nombre_producto"].ToString();
                    producto.Descripcion_producto = reader["Descripcion_producto"].ToString();
                    producto.Precio_producto = Convert.ToDecimal(reader["Precio_producto"]);
                    producto.Estado_producto = Convert.ToInt32(reader["Id_estado_producto"]);
                    producto.Stock_producto = Convert.ToInt32(reader["Stock_producto"]);
                    producto.Categoria_producto = Convert.ToInt32(reader["Id_categoria"]);

                    if (reader["Id_Talle_producto"] != DBNull.Value)
                        producto.Talle_producto = Convert.ToInt32(reader["Id_Talle_producto"]);
                    else
                        producto.Talle_producto = 0; // o null si usás int? en la clase Producto

                    lista.Add(producto);
                }

            }
            return lista;
        }

        public List<Estado_producto> ObtenerEstados()
        {
            List<Estado_producto> lista = new List<Estado_producto>();
            using (SqlConnection oconexion = new Conexion().CrearConexion())
            {
                string query = "SELECT Id_estado_producto, Descripcion_estado_producto FROM Estado_producto";
                SqlCommand cmd = new SqlCommand(query, oconexion);
                cmd.CommandType = System.Data.CommandType.Text;
                oconexion.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    lista.Add(new Estado_producto()
                    {
                        Id_estado_producto = Convert.ToInt32(reader["Id_estado_producto"]),
                        Descripcion_estado_producto = reader["Descripcion_estado_producto"].ToString()
                    });
                }
            }
            return lista;


        }

        public List<Talle_producto> ObtenerTalles()
        {
            List<Talle_producto> lista = new List<Talle_producto>();
            using (SqlConnection oconexion = new Conexion().CrearConexion())
            {
                string query = "SELECT Id_talle_producto, Descripcion_Talle_producto, Tipo_talle FROM Talle_producto";
                SqlCommand cmd = new SqlCommand(query, oconexion);
                cmd.CommandType = System.Data.CommandType.Text;
                oconexion.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    lista.Add(new Talle_producto()
                    {
                        Id_talle_producto = Convert.ToInt32(reader["Id_talle_producto"]),
                        Descripcion_talle = reader["Descripcion_talle_producto"].ToString(),
                        Tipo_talle = reader["Tipo_talle"].ToString()
                    });
                }
            }
            return lista;
        }

        public bool editarProducto(Producto producto)
        {
            try
            {
                using (SqlConnection oconexion = new Conexion().CrearConexion())
                {
                    // Validar que el Id_producto sea válido
                    if (producto.Id_producto <= 0)
                        throw new Exception("El Id_producto no es válido.");

                    // Validar que el talle exista si se proporciona uno
                    if (producto.Talle_producto > 0)
                    {
                        bool talleExiste = ObtenerTalles().Any(t => t.Id_talle_producto == producto.Talle_producto);
                        if (!talleExiste)
                            throw new Exception("El talle especificado no existe en la base de datos.");
                    }




                    string query = "UPDATE Producto SET Codigo_producto = @Codigo_producto, Nombre_producto = @Nombre_producto, Descripcion_producto = @Descripcion_producto, " +
               "Id_estado_producto = @Estado_producto, Id_categoria = @Id_categoria, Id_Talle_producto = @Id_Talle_producto " +
               "WHERE Id_Producto = @Id_producto";

                    SqlCommand cmd = new SqlCommand(query, oconexion);
                    cmd.Parameters.AddWithValue("@Codigo_producto", producto.Codigo_producto);
                    cmd.Parameters.AddWithValue("@Nombre_producto", producto.Nombre_producto);
                    cmd.Parameters.AddWithValue("@Descripcion_producto", producto.Descripcion_producto);
                    cmd.Parameters.AddWithValue("@Id_categoria", producto.Categoria_producto);
                    cmd.Parameters.AddWithValue("@Estado_producto", producto.Estado_producto);
                    cmd.Parameters.AddWithValue("@Id_producto", producto.Id_producto);

                    // Manejar el parámetro del talle, permitiendo NULL si no se proporciona
                    object talleParam = producto.Talle_producto > 0
                    ? (object)producto.Talle_producto
                    : DBNull.Value;
                    // Asignar el parámetro
                    cmd.Parameters.AddWithValue("@Id_Talle_producto", talleParam);

                    oconexion.Open();
                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar producto: " + ex.Message);
            }
        }

        public bool eliminarProducto(string codProducto)
        {
            try
            {
                using (SqlConnection oconexion = new Conexion().CrearConexion())
                {
                    string query = "UPDATE Producto SET Id_estado_producto = 2 WHERE Codigo_producto = @Codigo_producto";
                    SqlCommand cmd = new SqlCommand(query, oconexion);
                    cmd.Parameters.AddWithValue("@Codigo_producto", codProducto);
                    oconexion.Open();
                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar producto: " + ex.Message);
            }
        }

        private bool CodigoProductoExiste(string codigo)
        {
            using (SqlConnection oconexion = new Conexion().CrearConexion())
            {
                string query = "SELECT COUNT(*) FROM Producto WHERE Codigo_producto = @Codigo_producto";
                SqlCommand cmd = new SqlCommand(query, oconexion);
                cmd.Parameters.AddWithValue("@Codigo_producto", codigo);
                oconexion.Open();
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
        }

    }
}

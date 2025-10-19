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
                    string query = "INSERT INTO Producto (Nombre_producto, Descripcion_producto, Precio_producto, Id_estado_producto, Stock_producto, Id_categoria) " +
                                   "VALUES (@Nombre_producto, @Descripcion_producto, @Precio_producto, @Estado_producto, @Stock_producto, @Id_categoria)";

                    SqlCommand cmd = new SqlCommand(query, oconexion);
                    cmd.Parameters.AddWithValue("@Nombre_producto", producto.Nombre_producto);
                    cmd.Parameters.AddWithValue("@Descripcion_producto", producto.Descripcion_producto);
                    cmd.Parameters.AddWithValue("@Precio_producto", producto.Precio_producto);
                    cmd.Parameters.AddWithValue("@Stock_producto", producto.Stock_producto);
                    cmd.Parameters.AddWithValue("@Id_categoria", producto.Categoria_producto);
                    cmd.Parameters.AddWithValue("@Estado_producto", producto.Estado_producto);
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
                string query = "SELECT Id_Producto, Nombre_producto, Descripcion_producto, Precio_producto, Id_estado_producto, Stock_producto, Id_categoria FROM Producto";
                SqlCommand cmd = new SqlCommand(query, oconexion);
                cmd.CommandType = System.Data.CommandType.Text;
                oconexion.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    lista.Add(new Producto()
                    {
                        Id_producto = Convert.ToInt32(reader["Id_producto"]),
                        Nombre_producto = reader["Nombre_producto"].ToString(),
                        Descripcion_producto = reader["Descripcion_producto"].ToString(),
                        Precio_producto = Convert.ToDecimal(reader["Precio_producto"]),
                        Estado_producto = Convert.ToInt32(reader["Id_estado_producto"]),
                        Stock_producto = Convert.ToInt32(reader["Stock_producto"]),
                        Categoria_producto = Convert.ToInt32(reader["Id_categoria"])
                    });
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
    }
}

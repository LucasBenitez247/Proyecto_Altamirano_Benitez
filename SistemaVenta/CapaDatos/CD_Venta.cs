using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Venta
    {
        // Este método registra la venta y sus detalles usando una transacción
        public bool RegistrarVenta(Venta venta, List<Detalle_venta> detalleVenta, out string mensajeError)
        {
            bool respuesta = false;
            mensajeError = string.Empty;

            // Usa la clase Conexion de tu proyecto
            using (SqlConnection oconexion = new Conexion().CrearConexion())
            {
                try
                {
                    oconexion.Open();
                    // Iniciar la transacción
                    using (SqlTransaction transaction = oconexion.BeginTransaction())
                    {
                        // Paso 1: Insertar la Venta y obtener el ID generado
                       
                        string queryVenta = @"INSERT INTO Venta (Id_usuario, Id_cliente, Tipo_documento, Fecha_venta, Total_venta) 
                                            VALUES (@Id_usuario, @Id_cliente, @TipoDocumento, @Fecha_venta, @Total_venta);
                                            SELECT SCOPE_IDENTITY();"; // Obtiene el último ID insertado

                        SqlCommand cmdVenta = new SqlCommand(queryVenta, oconexion, transaction);
                        cmdVenta.Parameters.AddWithValue("@Id_usuario", venta.Id_usuario);
                        cmdVenta.Parameters.AddWithValue("@Id_cliente", venta.Id_cliente);
                        cmdVenta.Parameters.AddWithValue("@TipoDocumento", venta.Tipo_documento); // Coincide con tu Venta.cs
                        cmdVenta.Parameters.AddWithValue("@Fecha_venta", venta.Fecha_venta);       // Coincide con tu Venta.cs
                        cmdVenta.Parameters.AddWithValue("@Total_venta", venta.Total_venta);

                        // Ejecuta y obtiene el nuevo Id_venta
                        int idVentaGenerada = Convert.ToInt32(cmdVenta.ExecuteScalar());

                        // Paso 2 y 3: Insertar Detalles y Actualizar Stock (para cada producto en el carrito)
                        foreach (Detalle_venta detalle in detalleVenta)
                        {
                            // Asigna el ID de la venta al detalle
                            detalle.Id_venta = idVentaGenerada;

                            // Query para insertar el detalle
                           
                            string queryDetalle = @"INSERT INTO Detalle_venta (Id_venta, Id_producto, Precio_unitario, Cantidad) 
                                                  VALUES (@Id_venta, @Id_producto, @Precio_unitario, @Cantidad)";

                            SqlCommand cmdDetalle = new SqlCommand(queryDetalle, oconexion, transaction);
                            cmdDetalle.Parameters.AddWithValue("@Id_venta", detalle.Id_venta);
                            cmdDetalle.Parameters.AddWithValue("@Id_producto", detalle.Id_producto);
                            cmdDetalle.Parameters.AddWithValue("@Precio_unitario", detalle.Precio_unitario);
                            cmdDetalle.Parameters.AddWithValue("@Cantidad", detalle.Cantidad);
                            cmdDetalle.ExecuteNonQuery();

                            // Query para actualizar el stock del producto
                            
                            string queryStock = @"UPDATE Producto SET Stock_producto = Stock_producto - @Cantidad 
                                                WHERE Id_producto = @Id_producto";

                            SqlCommand cmdStock = new SqlCommand(queryStock, oconexion, transaction);
                            cmdStock.Parameters.AddWithValue("@Cantidad", detalle.Cantidad);
                            cmdStock.Parameters.AddWithValue("@Id_producto", detalle.Id_producto);
                            cmdStock.ExecuteNonQuery();
                        }

                        // Si todo salió bien, confirma la transacción
                        transaction.Commit();
                        respuesta = true;
                    }
                }
                catch (Exception ex)
                {
                    // Si algo falla, mensajeError toma el valor de la excepción
                    mensajeError = ex.Message;
                    respuesta = false;
                    // El 'using' se encarga del Rollback si no se hizo Commit
                }
            }
            return respuesta;
        }

        public List<Venta> Listar()
        {
            List<Venta> lista = new List<Venta>();
            Conexion conexion = new Conexion();

            try
            {
                using (SqlConnection oconexion = conexion.CrearConexion())
                {
                    // Unimos Venta con Clientes para obtener el nombre
                    string query = @"
                        SELECT 
                            v.Id_venta,
                            v.Id_cliente,
                            v.Id_usuario,
                            v.Tipo_documento,
                            v.Fecha_venta,
                            v.Total_venta,
                            c.Nombre_cliente,
                            c.Apellido_cliente
                        FROM Venta v
                        INNER JOIN Clientes c ON v.Id_cliente = c.Id_cliente
                        ORDER BY v.Fecha_venta DESC"; // Ordenar por más recientes

                    SqlCommand cmd = new SqlCommand(query, oconexion);
                    oconexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Venta()
                            {
                                Id_venta = Convert.ToInt32(dr["Id_venta"]),
                                Id_cliente = Convert.ToInt32(dr["Id_cliente"]),
                                Id_usuario = Convert.ToInt32(dr["Id_usuario"]),
                                Tipo_documento = dr["Tipo_documento"].ToString(),
                                Fecha_venta = Convert.ToDateTime(dr["Fecha_venta"]),
                                Total_venta = Convert.ToDecimal(dr["Total_venta"]),
                                // Llenamos las propiedades adicionales
                                Nombre_cliente = dr["Nombre_cliente"].ToString(),
                                Apellido_cliente = dr["Apellido_cliente"].ToString()
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Registra el error (en un entorno real, usarías un logger)
                Console.WriteLine("Error al listar ventas: " + ex.Message);
                lista = new List<Venta>(); // Devuelve lista vacía en caso de error
            }
            return lista;
        }
    }
}


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

                        //Inserta Detalles y Actualizar Stock (para cada producto en el carrito)
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
                            c.Apellido_cliente,
                            c.Dni_cliente
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
                                // Propiedades adicionales
                                Nombre_cliente = dr["Nombre_cliente"].ToString(),
                                Apellido_cliente = dr["Apellido_cliente"].ToString(),
                                Dni_cliente = dr["Dni_cliente"].ToString()

                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                
                Console.WriteLine("Error al listar ventas: " + ex.Message);
                lista = new List<Venta>(); // Devuelve lista vacía en caso de error
            }
            return lista;
        }
        public List<Detalle_venta> ObtenerDetallesVenta(int idVenta)
        {
            List<Detalle_venta> lista = new List<Detalle_venta>();
            Conexion conexion = new Conexion();

            try
            {
                using (SqlConnection oconexion = conexion.CrearConexion())
                {
                    string query = @"
                        SELECT 
                            p.Nombre_producto,
                            dv.Precio_unitario,
                            dv.Cantidad
                        FROM Detalle_venta dv
                        INNER JOIN Producto p ON dv.Id_producto = p.Id_producto
                        WHERE dv.Id_venta = @idVenta";

                    SqlCommand cmd = new SqlCommand(query, oconexion);
                    cmd.Parameters.AddWithValue("@idVenta", idVenta);
                    oconexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Detalle_venta()
                            {
                                Nombre_producto = dr["Nombre_producto"].ToString(),
                                Precio_unitario = Convert.ToDecimal(dr["Precio_unitario"]),
                                Cantidad = Convert.ToInt32(dr["Cantidad"])
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener detalles: " + ex.Message);
                lista = new List<Detalle_venta>();
            }
            return lista;
        }

        public List<Venta> ListarReporte(DateTime fechaInicio, DateTime fechaFin)
        {
            List<Venta> lista = new List<Venta>();
            Conexion conexion = new Conexion();

            try
            {
                using (SqlConnection oconexion = conexion.CrearConexion())
                {
                    // Query que une Venta con Clientes y con Usuarios
                    string query = @"
                        SELECT 
                            v.Id_venta, v.Fecha_venta, v.Tipo_documento, v.Total_venta,
                            c.Nombre_cliente, c.Apellido_cliente,
                            c.Dni_cliente,
                            u.nombre AS Nombre_usuario, 
                            u.apellido AS Apellido_usuario
                        FROM Venta v
                        INNER JOIN Clientes c ON v.Id_cliente = c.Id_cliente
                        INNER JOIN usuarios u ON v.Id_usuario = u.id_usuario
                        WHERE v.Fecha_venta BETWEEN @fechaInicio AND @fechaFin
                        ORDER BY v.Fecha_venta DESC";

                    SqlCommand cmd = new SqlCommand(query, oconexion);
                    cmd.Parameters.AddWithValue("@fechaInicio", fechaInicio);
                    cmd.Parameters.AddWithValue("@fechaFin", fechaFin);
                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Venta()
                            {
                                Id_venta = Convert.ToInt32(dr["Id_venta"]),
                                Fecha_venta = Convert.ToDateTime(dr["Fecha_venta"]),
                                Tipo_documento = dr["Tipo_documento"].ToString(),
                                Total_venta = Convert.ToDecimal(dr["Total_venta"]),
                                Nombre_cliente = dr["Nombre_cliente"].ToString(),
                                Apellido_cliente = dr["Apellido_cliente"].ToString(),
                                Dni_cliente = dr["Dni_cliente"].ToString(),
                                Nombre_usuario = dr["Nombre_usuario"].ToString(),
                                Apellido_usuario = dr["Apellido_usuario"].ToString()
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al listar reporte: " + ex.Message);
                lista = new List<Venta>();
            }
            return lista;
        }

        public List<ReporteVentasPorMes> GetVentasPorMes(DateTime fechaInicio, DateTime fechaFin)
        {
            List<ReporteVentasPorMes> lista = new List<ReporteVentasPorMes>();
            using (SqlConnection oconexion = new Conexion().CrearConexion())
            {
                try
                {
                    string query = @"
                        SELECT 
                            FORMAT(Fecha_venta, 'yyyy-MM') as Mes,
                            SUM(Total_venta) as Total
                        FROM Venta
                        WHERE Fecha_venta BETWEEN @fechaInicio AND @fechaFin
                        GROUP BY FORMAT(Fecha_venta, 'yyyy-MM')
                        ORDER BY Mes ASC";

                    SqlCommand cmd = new SqlCommand(query, oconexion);
                    cmd.Parameters.AddWithValue("@fechaInicio", fechaInicio);
                    cmd.Parameters.AddWithValue("@fechaFin", fechaFin);
                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new ReporteVentasPorMes()
                            {
                                Mes = dr["Mes"].ToString(),
                                Total = Convert.ToDecimal(dr["Total"])
                            });
                        }
                    }
                }
                catch (Exception) { lista = new List<ReporteVentasPorMes>(); }
                return lista;
            }
        }

        public List<ReporteVentasPorDia> GetVentasPorDia(DateTime fechaInicio, DateTime fechaFin)
        {
            List<ReporteVentasPorDia> lista = new List<ReporteVentasPorDia>();
            using (SqlConnection oconexion = new Conexion().CrearConexion())
            {
                try
                {
                    // Usamos DATENAME para obtener el nombre del día (ej. 'Lunes')
                    // y DATEPART para ordenarlos correctamente (1=Domingo, 2=Lunes, etc.)
                    string query = @"
                        SELECT 
                            DATENAME(weekday, Fecha_venta) as DiaSemana,
                            SUM(Total_venta) as Total,
                            DATEPART(weekday, Fecha_venta) as DiaNro
                        FROM Venta
                        WHERE Fecha_venta BETWEEN @fechaInicio AND @fechaFin
                        GROUP BY DATENAME(weekday, Fecha_venta), DATEPART(weekday, Fecha_venta)
                        ORDER BY DiaNro ASC";

                    SqlCommand cmd = new SqlCommand(query, oconexion);
                    cmd.Parameters.AddWithValue("@fechaInicio", fechaInicio);
                    cmd.Parameters.AddWithValue("@fechaFin", fechaFin);
                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new ReporteVentasPorDia()
                            {
                                DiaSemana = dr["DiaSemana"].ToString(),
                                TotalVentas = Convert.ToDecimal(dr["Total"])
                            });
                        }
                    }
                }
                catch (Exception) { lista = new List<ReporteVentasPorDia>(); }
                return lista;
            }
        }
    }
}


using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
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

        public List<Compra> ObtenerCompras()
        {
            List<Compra> lista = new List<Compra>();
            using (SqlConnection conn = conexion.CrearConexion())
            {
                string query = @"
            SELECT 
                c.Id_compra, c.Id_usuario, u.nombre, u.apellido, 
                c.Id_proveedor, p.Razon_social AS Nombre_proveedor, 
                p.Nro_Documento_proveedor,
                c.Nro_orden, c.Fecha_compra, c.Total_compra
            FROM Compra c
            JOIN usuarios u ON c.Id_usuario = u.id_usuario
            JOIN Proveedor p ON c.Id_proveedor = p.Id_proveedor";

                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Compra compra = new Compra
                    {
                        Id_compra = Convert.ToInt32(reader["Id_compra"]),
                        Id_usuario = Convert.ToInt32(reader["Id_usuario"]),
                        Nombre_usuario = reader["nombre"].ToString() + " " + reader["apellido"].ToString(),
                        Id_proveedor = Convert.ToInt32(reader["Id_proveedor"]),
                        Nombre_proveedor = reader["Nombre_proveedor"].ToString(),
                        Nro_documento_proveedor = Convert.ToInt32(reader["Nro_Documento_proveedor"]),
                        Nro_orden = Convert.ToInt32(reader["Nro_orden"]),
                        Fecha_compra = Convert.ToDateTime(reader["Fecha_compra"]),
                        Total_compra = Convert.ToSingle(reader["Total_compra"])
                    };
                    lista.Add(compra);
                }
            }
            return lista;
        }


        public List<Detalle_compra> ObtenerDetalleCompra(int idCompra)
        {
            List<Detalle_compra> lista = new List<Detalle_compra>();
            using (SqlConnection conn = conexion.CrearConexion())
            {
                string query = @"
            SELECT 
                dc.Id_detalle_compra,
                dc.Id_compra,
                dc.Id_producto,
                p.Nombre_producto,
                dc.Cantidad,
                dc.Precio_compra
            FROM Detalle_Compra dc
            INNER JOIN Producto p ON dc.Id_producto = p.Id_producto
            WHERE dc.Id_compra = @IdCompra";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IdCompra", idCompra);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Detalle_compra detalle = new Detalle_compra
                    {
                        Id_detalle_compra = Convert.ToInt32(reader["Id_detalle_compra"]),
                        Id_compra = Convert.ToInt32(reader["Id_compra"]),
                        Id_producto = Convert.ToInt32(reader["Id_producto"]),
                        Nombre_producto = reader["Nombre_producto"].ToString(),
                        Cantidad = Convert.ToInt32(reader["Cantidad"]),
                        Precio_compra = Convert.ToSingle(reader["Precio_compra"])
                    };
                    lista.Add(detalle);
                }
            }
            return lista;
        }


        public List<Compra> ObtenerComprasPorFecha(DateTime fechaInicio, DateTime fechaFin)
        {
            List<Compra> lista = new List<Compra>();
            using (SqlConnection conn = conexion.CrearConexion())
            {
                string query = @"
            SELECT c.Id_compra, c.Id_usuario, u.nombre, u.apellido, c.Id_proveedor, p.Razon_social AS Nombre_proveedor,
                   c.Nro_orden, c.Fecha_compra, c.Total_compra
            FROM Compra c
            JOIN usuarios u ON c.Id_usuario = u.id_usuario
            JOIN Proveedor p ON c.Id_proveedor = p.Id_proveedor
            WHERE c.Fecha_compra BETWEEN @fechaInicio AND @fechaFin
            ORDER BY c.Fecha_compra DESC";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@fechaInicio", fechaInicio);
                cmd.Parameters.AddWithValue("@fechaFin", fechaFin);
                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Compra compra = new Compra
                    {
                        Id_compra = Convert.ToInt32(reader["Id_compra"]),
                        Id_usuario = Convert.ToInt32(reader["Id_usuario"]),
                        Nombre_usuario = reader["nombre"].ToString() + " " + reader["apellido"].ToString(),
                        Id_proveedor = Convert.ToInt32(reader["Id_proveedor"]),
                        Nombre_proveedor = reader["Nombre_proveedor"].ToString(),
                        Nro_orden = Convert.ToInt32(reader["Nro_orden"]),
                        Fecha_compra = Convert.ToDateTime(reader["Fecha_compra"]),
                        Total_compra = Convert.ToSingle(reader["Total_compra"])
                    };
                    lista.Add(compra);
                }
            }
            return lista;
        }


        public int InsertarCompra(Compra compra)
        {
            int idCompraGenerado = 0;

            using (SqlConnection conn = conexion.CrearConexion())
            {
                conn.Open();
                SqlTransaction trans = conn.BeginTransaction();

                string query = @"INSERT INTO Compra (Id_usuario, Id_proveedor, Nro_orden, Fecha_compra, Total_compra)
                 VALUES (@IdUsuario, @IdProveedor, @NroOrden, @FechaCompra, @TotalCompra);
                 SELECT SCOPE_IDENTITY();";


                try
                {
                    // Insertar cabecera
                    SqlCommand cmdCompra = new SqlCommand(query, conn, trans);
                    cmdCompra.Parameters.AddWithValue("@IdUsuario", compra.Id_usuario);
                    cmdCompra.Parameters.AddWithValue("@IdProveedor", compra.Id_proveedor);
                    cmdCompra.Parameters.AddWithValue("@NroOrden", compra.Nro_orden);
                    cmdCompra.Parameters.AddWithValue("@FechaCompra", compra.Fecha_compra);
                    cmdCompra.Parameters.AddWithValue("@TotalCompra", compra.Total_compra);


                    idCompraGenerado = Convert.ToInt32(cmdCompra.ExecuteScalar());

                    if (compra.Detalle_compra == null || !compra.Detalle_compra.Any())
                        throw new Exception("La compra no tiene productos.");


                    // Insertar detalles
                    foreach (var detalle in compra.Detalle_compra)
                    {
                        SqlCommand cmdDetalle = new SqlCommand(@"INSERT INTO Detalle_Compra (Id_compra, Id_producto, Cantidad, Precio_compra)
                                                         VALUES (@IdCompra, @IdProducto, @Cantidad, @PrecioCompra)", conn, trans);
                        cmdDetalle.Parameters.AddWithValue("@IdCompra", idCompraGenerado);
                        cmdDetalle.Parameters.AddWithValue("@IdProducto", detalle.Id_producto);
                        cmdDetalle.Parameters.AddWithValue("@Cantidad", detalle.Cantidad);
                        cmdDetalle.Parameters.AddWithValue("@PrecioCompra", detalle.Precio_compra);

                        cmdDetalle.ExecuteNonQuery();
                    }

                    trans.Commit();
                }
                catch
                {
                    trans.Rollback();
                    throw;
                }
            }

            return idCompraGenerado;
        }

        public List<CompraPorCategoria> ObtenerTotalPorCategoria(DateTime fechaInicio, DateTime fechaFin)
        {
            List<CompraPorCategoria> lista = new List<CompraPorCategoria>();

            using (SqlConnection conn = conexion.CrearConexion())
            {
                string query = @"
        SELECT cat.Descripcion_categoria AS Categoria, SUM(dc.Precio_compra) AS TotalCompra
        FROM Compra c
        INNER JOIN Detalle_compra dc ON c.Id_compra = dc.Id_compra
        INNER JOIN Producto p ON dc.Id_producto = p.Id_producto
        INNER JOIN Categoria_producto cat ON p.Id_categoria = cat.Id_categoria
        WHERE c.Fecha_compra BETWEEN @fechaInicio AND @fechaFin
        GROUP BY cat.Descripcion_categoria";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@fechaInicio", fechaInicio);
                cmd.Parameters.AddWithValue("@fechaFin", fechaFin);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    lista.Add(new CompraPorCategoria
                    {
                        Categoria = reader["Categoria"].ToString(),
                        TotalCompra = Convert.ToDecimal(reader["TotalCompra"])
                    });
                }
            }

            return lista;
        }

        public List<GastoMensualCompras> ObtenerGastoMensual(int anio)
        {
            List<GastoMensualCompras> lista = new List<GastoMensualCompras>();

            using (SqlConnection conn = conexion.CrearConexion())
            {
                string query = @"
            SELECT DATENAME(MONTH, c.Fecha_compra) AS Mes,
                   SUM(dc.Precio_compra) AS TotalCompra
            FROM Compra c
            INNER JOIN Detalle_compra dc ON c.Id_compra = dc.Id_compra
            WHERE YEAR(c.Fecha_compra) = @anio
            GROUP BY MONTH(c.Fecha_compra), DATENAME(MONTH, c.Fecha_compra)
            ORDER BY MONTH(c.Fecha_compra)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@anio", anio);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    lista.Add(new GastoMensualCompras
                    {
                        Mes = reader["Mes"].ToString(),
                        TotalCompra = Convert.ToDecimal(reader["TotalCompra"])
                    });
                }
            }

            return lista;
        }

        public ProductoMasVendido ObtenerProductoMasVendido()
        {
            ProductoMasVendido resultado = null;

            using (SqlConnection conn = conexion.CrearConexion())
            {
                string query = @"
            SELECT TOP 1 p.Nombre_producto, SUM(dc.Cantidad) AS TotalVendido, p.Stock_producto as Stock
            FROM Detalle_compra dc
            INNER JOIN Producto p ON dc.Id_producto = p.Id_producto
            GROUP BY p.Nombre_producto, p.Stock_producto
            ORDER BY TotalVendido DESC";

                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    resultado = new ProductoMasVendido
                    {
                        Nombre = reader["Nombre_producto"].ToString(),
                        Stock = Convert.ToInt32(reader["Stock"]),
                        CantidadVendida = Convert.ToInt32(reader["TotalVendido"])
                    };
                }
            }

            return resultado;
        }
        

       



    }
}


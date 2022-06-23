using System;
using System.Data;
using System.Data.SqlClient;

namespace ProbandoMigrar.AccesoADatos
{
    public class AD_PrecioDescuento
    {
        public static DataTable ObtenerPrecioEntradaDesc()
        {
            string cadenaConexion = System.Configuration.ConfigurationSettings.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "select SUM(entrada.precio_unitario) as 'PrecioInicial', (SUM(entrada.precio_unitario)-Ticket.promocion) as 'PrecioFinal', "+
                "Ticket.fechaHoraVenta as 'Fecha' from Ticket " +
                "inner join DetalleTicketEntrada on Ticket.nroTicket = DetalleTicketEntrada.nroTicket " +
                "inner join Entrada on DetalleTicketEntrada.nroEntrada = Entrada.nroEntrada " +
                "group by Ticket.nroTicket, entrada.precio_unitario,Ticket.Promocion,Ticket.fechaHoraVenta";
                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;
                cn.Open();
                cmd.Connection = cn;
                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);
                return tabla;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }
        }

        public static DataTable ObtenerPrecioComboDesc()
        {
            string cadenaConexion = System.Configuration.ConfigurationSettings.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "select SUM((DetalleTicketCombo.cantidad)*Producto.precio) as 'PrecioInicial', "+
                "(SUM((DetalleTicketCombo.cantidad) * Producto.precio) - Ticket.promocion) as 'PrecioFinal',Ticket.fechaHoraVenta as 'Fecha' " +
                "from DetalleTicketCombo " +
                "INNER JOIN Ticket on DetalleTicketCombo.nroTicket = Ticket.nroTicket " +
                "INNER JOIN Producto on DetalleTicketCombo.nroCombo = Producto.idProducto " +
                "group by Ticket.fechaHoraVenta,Ticket.nroTicket,Ticket.promocion " +
                "order by fechaHoraVenta";
                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;
                cn.Open();
                cmd.Connection = cn;
                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);
                return tabla;
            }
            catch (Exception)
            {
                throw;
            }
            finally                                                                                                                               
            {
                cn.Close();
            }
        }

        public static DataTable ObtenerPrecioEntradaDescEntre(DateTime fechaDesde, DateTime fechaHasta)
        {
            string cadenaConexion = System.Configuration.ConfigurationSettings.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "select SUM(entrada.precio_unitario) as 'PrecioInicial', (SUM(entrada.precio_unitario)-Ticket.promocion) as 'PrecioFinal', " +
                "Ticket.fechaHoraVenta as 'Fecha' from Ticket " +
                "inner join DetalleTicketEntrada on Ticket.nroTicket = DetalleTicketEntrada.nroTicket " +
                "inner join Entrada on DetalleTicketEntrada.nroEntrada = Entrada.nroEntrada " +
                "where Entrada.fechaHoraVenta > @fechaDesde and Entrada.fechaHoraVenta <= @fechaHasta " +
                "group by Ticket.nroTicket, entrada.precio_unitario,Ticket.Promocion,Ticket.fechaHoraVenta";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@fechaDesde", fechaDesde);
                cmd.Parameters.AddWithValue("@fechaHasta", fechaHasta);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;
                cn.Open();
                cmd.Connection = cn;
                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);
                return tabla;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }
        }
        public static DataTable ObtenerPrecioComboDescEntre(DateTime fechaDesde, DateTime fechaHasta)
        {
            string cadenaConexion = System.Configuration.ConfigurationSettings.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "select SUM((DetalleTicketCombo.cantidad)*Producto.precio) as 'PrecioInicial', " +
                "(SUM((DetalleTicketCombo.cantidad) * Producto.precio) - Ticket.promocion) as 'PrecioFinal',Ticket.fechaHoraVenta as 'Fecha' " +
                "from DetalleTicketCombo " +
                "INNER JOIN Ticket on DetalleTicketCombo.nroTicket = Ticket.nroTicket " +
                "INNER JOIN Producto on DetalleTicketCombo.nroCombo = Producto.idProducto " +
                "where Entrada.fechaHoraVenta > @fechaDesde and Entrada.fechaHoraVenta <= @fechaHasta " +
                "group by Ticket.fechaHoraVenta,Ticket.nroTicket,Ticket.promocion " +
                "order by fechaHoraVenta";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@fechaDesde", fechaDesde);
                cmd.Parameters.AddWithValue("@fechaHasta", fechaHasta);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;
                cn.Open();
                cmd.Connection = cn;
                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);
                return tabla;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }
        }
    }
}

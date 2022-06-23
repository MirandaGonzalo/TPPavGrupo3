using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using TPG3.Entidades;

namespace TPG3.AccesoADatos
{
    public class AD_Entrada
    {

        public static int GetUltimoNumeroEntrada()
        {
            string cadenaConexion = System.Configuration.ConfigurationSettings.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            int nroEntrada = -1;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "ObtenerUltimoNroEntrada";
                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;
                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null && dr.Read())
                {
                    nroEntrada = int.Parse(dr["nroEntrada"].ToString());
                }
                else
                {
                    nroEntrada = 0;
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }
            return nroEntrada;
        }

        public static bool RegistrarEntrada(Ticket ticket, DateTime fechaHoraFuncion,int sala,List<string> asientosOcupadosNuevos,List<int> listaIdTarifasSeleccionadas,List<float> listaPrecioXTarifaSeleccionadas, int nroEntrada)
        {
            string cadenaConexion = System.Configuration.ConfigurationSettings.AppSettings["CadenaDB"];
            SqlTransaction objTransaccion = null;
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "InsertTicket";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@fechaHora", ticket.fechaHoraVenta);
                cmd.Parameters.AddWithValue("@medioPago", ticket.medioPago);
                cmd.Parameters.AddWithValue("@dniEmpleado", ticket.dniEmpelado);
                cmd.Parameters.AddWithValue("@tipoDocEmpleado", ticket.tipoDocEmpleado);
                cmd.Parameters.AddWithValue("@npromocion", ticket.npromocion);
                cmd.Parameters.AddWithValue("@promocion", ticket.promocion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;
                cn.Open();
                objTransaccion = cn.BeginTransaction("AltaDeTicket");
                cmd.Transaction = objTransaccion;
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();

                for (int i = 0; i < listaIdTarifasSeleccionadas.Count; i++)
                {    
                    string consultaInsertEntrada = "InsertEntrada";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@fechaHoraVenta", ticket.fechaHoraVenta);
                    cmd.Parameters.AddWithValue("@fechaHoraFuncion", fechaHoraFuncion);
                    cmd.Parameters.AddWithValue("@sala", sala);
                    cmd.Parameters.AddWithValue("@letraColumna", asientosOcupadosNuevos[i].Substring(0,1));
                    cmd.Parameters.AddWithValue("@numeroFila", int.Parse(asientosOcupadosNuevos[i].Substring(1, asientosOcupadosNuevos[i].Length-1)));
                    cmd.Parameters.AddWithValue("@tarifa", listaIdTarifasSeleccionadas[i]);
                    cmd.Parameters.AddWithValue("@dniEmpleado", ticket.dniEmpelado);
                    cmd.Parameters.AddWithValue("@tipoDocEmpleado", ticket.tipoDocEmpleado);
                    cmd.Parameters.AddWithValue("@precioUnitario", listaPrecioXTarifaSeleccionadas[i]);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = consultaInsertEntrada;
                    cmd.ExecuteNonQuery();

                    string consultaInsertDetalleTicketEntrada = "InsertDetalleTicketEntrada";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@orden", i + 1);
                    cmd.Parameters.AddWithValue("@nroTicket", ticket.nroTicket);
                    cmd.Parameters.AddWithValue("@nroEntrada", nroEntrada + i);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = consultaInsertDetalleTicketEntrada;
                    cmd.ExecuteNonQuery();
                }
                objTransaccion.Commit();
                return true;
            }
            catch (Exception)
            {
                objTransaccion.Rollback();
                return false;
            }
            finally
            {
                cn.Close();
            }
        }

        public static DataTable ObtenerEntradasTicket(int nroTicket)
        {
            string cadenaConexion = System.Configuration.ConfigurationSettings.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "GetEntradasFromTicket";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nroTicket", nroTicket);
                cmd.CommandType = CommandType.StoredProcedure;
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

        public static DataTable ObtenerEntradasReporte()
        {
            string cadenaConexion = System.Configuration.ConfigurationSettings.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "GetEntradasReporte";

                cmd.Parameters.Clear();

                cmd.CommandType = CommandType.StoredProcedure;
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

        public static DataTable ObtenerEntradasReporteMayor(float desde)
        {
            string cadenaConexion = System.Configuration.ConfigurationSettings.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "GetEntradasReportePrecioMayor";

                cmd.Parameters.Clear();
                cmd.Parameters.Add("@desde", desde);
                cmd.CommandType = CommandType.StoredProcedure;
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

        public static DataTable ObtenerEntradasReporteMenor(float desde)
        {
            string cadenaConexion = System.Configuration.ConfigurationSettings.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "GetEntradasReportePrecioMenor";

                cmd.Parameters.Clear();
                cmd.Parameters.Add("@desde", desde);
                cmd.CommandType = CommandType.StoredProcedure;
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
        public static DataTable ObtenerEntradasReporteEntre(float desde, float hasta)
        {
            string cadenaConexion = System.Configuration.ConfigurationSettings.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "GetEntradasReportePrecioEntre";

                cmd.Parameters.Clear();
                cmd.Parameters.Add("@desde", desde);
                cmd.Parameters.Add("@hasta", hasta);
                cmd.CommandType = CommandType.StoredProcedure;
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

        public static DataTable ObtenerEntradasReporteEntreFecha(DateTime desde, DateTime hasta)
        {
            string cadenaConexion = System.Configuration.ConfigurationSettings.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "GetEntradasReporteFechaEntre";

                cmd.Parameters.Clear();
                cmd.Parameters.Add("@desde", desde);
                cmd.Parameters.Add("@hasta", hasta);
                cmd.CommandType = CommandType.StoredProcedure;
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

        public static DataTable ObtenerEntradaEstadisticaMedioPago()
        {
            string cadenaConexion = System.Configuration.ConfigurationSettings.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "GetDatosReporteEntradaMedioPago";

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.StoredProcedure;
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

        public static DataTable ObtenerEntradaEstadisticaSala()
        {
            string cadenaConexion = System.Configuration.ConfigurationSettings.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "GetDatosReporteEntradaSala";

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.StoredProcedure;
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

        public static DataTable ObtenerEntradaEstadisticaPelicula()
        {
            string cadenaConexion = System.Configuration.ConfigurationSettings.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "GetDatosReporteEntradaPelicula";

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.StoredProcedure;
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

        public static DataTable ObtenerEntradaEstadisticaTarifa()
        {
            string cadenaConexion = System.Configuration.ConfigurationSettings.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "GetDatosReporteEntradaTarifa";

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.StoredProcedure;
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

        public static DataTable ObtenerEntradaEstadisticaEntre(DateTime fechaDesde, DateTime fechaHasta)
        {
            string cadenaConexion = System.Configuration.ConfigurationSettings.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "GetDatosReporteEntradaEntre";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@fechaDesde", fechaDesde);
                cmd.Parameters.AddWithValue("@fechaHasta", fechaHasta);
                cmd.CommandType = CommandType.StoredProcedure;
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

        public static DataTable ObtenerEntradasEstadistica()
        {
            string cadenaConexion = System.Configuration.ConfigurationSettings.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "GetDatosReporteDescuento";

                cmd.Parameters.Clear();

                cmd.CommandType = CommandType.StoredProcedure;
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

        public static DataTable ObtenerEntradasEstadisticaEntre(DateTime fechaDesde, DateTime fechahasta)
        {
            string cadenaConexion = System.Configuration.ConfigurationSettings.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "GetDatosReporteDescuentoEntre";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@fechaDesde", fechaDesde);
                cmd.Parameters.AddWithValue("@fechahasta", fechahasta);
                cmd.CommandType = CommandType.StoredProcedure;
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

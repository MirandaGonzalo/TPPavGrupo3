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

        public static bool RegistrarEntrada(DateTime fechaHoraFuncion,int sala,List<string> asientosOcupadosNuevos,List<int> listaIdTarifasSeleccionadas, string promocion, Usuario usuario, int medioPago, int ticket, int entrada)
        {
            string cadenaConexion = System.Configuration.ConfigurationSettings.AppSettings["CadenaDB"];
            SqlTransaction objTransaccion = null;
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "InsertTicket";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@fechaHora", DateTime.Now);
                cmd.Parameters.AddWithValue("@medioPago", medioPago);
                cmd.Parameters.AddWithValue("@dniEmpleado", usuario.dni);
                cmd.Parameters.AddWithValue("@tipoDocEmpleado", usuario.tipoDocumento);
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
                    cmd.Parameters.AddWithValue("@fechaHoraVenta", DateTime.Now);
                    cmd.Parameters.AddWithValue("@fechaHoraFuncion", fechaHoraFuncion);
                    cmd.Parameters.AddWithValue("@sala", sala);
                    cmd.Parameters.AddWithValue("@letraColumna", asientosOcupadosNuevos[i].Substring(0,1));
                    cmd.Parameters.AddWithValue("@numeroFila", int.Parse(asientosOcupadosNuevos[i].Substring(1, asientosOcupadosNuevos[i].Length-1)));
                    cmd.Parameters.AddWithValue("@tarifa", listaIdTarifasSeleccionadas[i]);
                    cmd.Parameters.AddWithValue("@promocion", promocion);
                    cmd.Parameters.AddWithValue("@dniEmpleado", usuario.dni);
                    cmd.Parameters.AddWithValue("@tipoDocEmpleado", usuario.tipoDocumento);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = consultaInsertEntrada;
                    cmd.ExecuteNonQuery();

                    string consultaInsertDetalleTicketEntrada = "InsertDetalleTicketEntrada";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@orden", i + 1);
                    cmd.Parameters.AddWithValue("@nroTicket", ticket);
                    cmd.Parameters.AddWithValue("@nroEntrada", entrada + i);
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

    }
    
}

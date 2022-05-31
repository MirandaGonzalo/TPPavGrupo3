using System.Data;
using System.Data.SqlClient;
using TPG3.Entidades;

namespace TPG3.AccesoADatos
{
    public class AD_Ticket
    {
        public static void RegistrarTicket(Ticket ticket)
        {
            string cadenaConexion = System.Configuration.ConfigurationSettings.AppSettings["CadenaDB"];
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
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;
                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
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
        public static int GetNumeroTicket(Ticket ticket)
        {            
            string cadenaConexion = System.Configuration.ConfigurationSettings.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            int nroTicket = -1;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "GetNumeroTicket";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@fechaHora", ticket.fechaHoraVenta);
                cmd.Parameters.AddWithValue("@medioPago", ticket.medioPago);
                cmd.Parameters.AddWithValue("@dniEmpleado", ticket.dniEmpelado);
                cmd.Parameters.AddWithValue("@tipoDocEmpleado", ticket.tipoDocEmpleado);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;
                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null && dr.Read())
                {
                    nroTicket = int.Parse(dr["nroTicket"].ToString());
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
            return nroTicket;
        }
    }
}


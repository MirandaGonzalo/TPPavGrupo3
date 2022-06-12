using System.Data;
using System.Data.SqlClient;

namespace TPG3.AccesoADatos
{
    public class AD_Sala
    {
        public static DataTable ObtenerTablaSala()
        {
            string cadenaConexion = System.Configuration.ConfigurationSettings.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "GetDatosSalas";
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

        public static string ObtenerSalaFromTicket(int nroTicket)
        {
            string cadenaConexion = System.Configuration.ConfigurationSettings.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            int sala = 0;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "GetSalaFromTicket";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nroTicket", nroTicket);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;
                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null && dr.Read())
                {
                    sala = int.Parse(dr["sala"].ToString());
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
            return sala.ToString();
        }

    }
}

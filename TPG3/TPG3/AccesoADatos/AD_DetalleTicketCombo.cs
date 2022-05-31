using System.Data;
using System.Data.SqlClient;
using TPG3.Entidades;

namespace TPG3.AccesoADatos
{
    public class AD_DetalleTicketCombo
    {
        public static void AgregarDetalleTicketCombo(DetalleTicketCombo detalle)
        {
            bool resultado = false;
            string cadenaConexion = System.Configuration.ConfigurationSettings.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "InsertDetalleTicketCombo";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@orden", detalle.orden);
                cmd.Parameters.AddWithValue("@nroTicket", detalle.nroTicket);
                cmd.Parameters.AddWithValue("@nroCombo", detalle.nroCombo);
                cmd.Parameters.AddWithValue("@cantidad", detalle.cantidad);
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
    }
}

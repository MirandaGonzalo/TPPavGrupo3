using System.Data;
using System.Data.SqlClient;
using TPG3.Entidades;

namespace TPG3.AccesoADatos
{
    public class AD_Tarjeta
    {
        public static DataTable ObtenerTablaTarjeta()
        {
            string cadenaConexion = System.Configuration.ConfigurationSettings.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "GetDetalleTarjeta";
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


        public static void CargarTarjeta(Tarjeta tarjeta)
        {
            string cadenaConexion = System.Configuration.ConfigurationSettings.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "InsertTarjeta";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombre", tarjeta.nombre);
                cmd.Parameters.AddWithValue("@descripcion", tarjeta.descripcion);
                cmd.Parameters.AddWithValue("@banco", tarjeta.banco);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;
                cn.Open();
                cmd.Connection = cn;
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

        public static void ActualizarTarjeta(Tarjeta tarjeta)
        {
            string cadenaConexion = System.Configuration.ConfigurationSettings.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "ActualizarTarjeta";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombre", tarjeta.nombre);
                cmd.Parameters.AddWithValue("@descripcion", tarjeta.descripcion);
                cmd.Parameters.AddWithValue("@banco", tarjeta.banco);
                cmd.Parameters.AddWithValue("@codTarjeta", tarjeta.codTarjeta);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;
                cn.Open();
                cmd.Connection = cn;
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

        public static void EliminarTarjeta(Tarjeta tarjeta)
        {
            string cadenaConexion = System.Configuration.ConfigurationSettings.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "EliminarTarjeta";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@codTarjeta", tarjeta.codTarjeta);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;
                cn.Open();
                cmd.Connection = cn;
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

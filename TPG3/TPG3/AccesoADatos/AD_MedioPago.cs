using System;
using System.Data;
using System.Data.SqlClient;
using TPG3.Entidades;


namespace TPG3.AccesoADatos
{
    public class AD_MedioPago
    {
        public static DataTable ObtenerTablaMediosPagos()
        {
            string cadenaConexion = System.Configuration.ConfigurationSettings.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "GetDetalleMediosPagos";
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

        public static void RegistrarMedioPago(MedioPago medioPago)
        {
            string cadenaConexion = System.Configuration.ConfigurationSettings.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "RegistrarMedioPago";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombre", medioPago.nombre);
                cmd.Parameters.AddWithValue("@descripcion", medioPago.descripcion);
                cmd.Parameters.AddWithValue("@tarjeta", medioPago.tarjeta);
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

        public static void ActualizarMedioPago(MedioPago medioPago)
        {
            string cadenaConexion = System.Configuration.ConfigurationSettings.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "ActualizarMedioPago";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombre", medioPago.nombre);
                cmd.Parameters.AddWithValue("@descripcion", medioPago.descripcion);
                cmd.Parameters.AddWithValue("@tarjeta", medioPago.tarjeta);
                cmd.Parameters.AddWithValue("@codMedioPago", medioPago.codMedioPago);
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

        public static void EliminarMedioPago(MedioPago medioPago)
        {
            string cadenaConexion = System.Configuration.ConfigurationSettings.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "EliminarMedioPago";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@codMedioPago", medioPago.codMedioPago);
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

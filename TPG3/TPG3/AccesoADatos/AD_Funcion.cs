using System.Data;
using System.Data.SqlClient;
using TPG3.Entidades;

namespace TPG3.AccesoADatos
{
    public class AD_Funcion
    {
        public static DataTable ObtenerTablaFuncion()
        {
            string cadenaConexion = System.Configuration.ConfigurationSettings.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "GetDatosFuncion";

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;
                cn.Open();
                cmd.Connection = cn;

                DataTable tablaFuncion = new DataTable();

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(tablaFuncion);
                return tablaFuncion;
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

        public static void EliminarFuncion(Funcion funcion)
        {
            string cadenaConexion = System.Configuration.ConfigurationSettings.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "EliminarFuncion";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@fechaHora", funcion.fechaHora);
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

        public static void InsertarFuncion(Funcion funcion)
        {
            string cadenaConexion = System.Configuration.ConfigurationSettings.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "InsertFuncion";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@sala", funcion.sala);
                cmd.Parameters.AddWithValue("@pelicula", funcion.pelicula);
                cmd.Parameters.AddWithValue("@estado", funcion.estado);
                cmd.Parameters.AddWithValue("@fechaInicio", funcion.fechaInicio);
                cmd.Parameters.AddWithValue("@fechaFin", funcion.fechaFin);
                cmd.Parameters.AddWithValue("@fechaHora", funcion.fechaHora);
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

        public static void ActualizarFuncion(Funcion funcion, DateTime fechaNueva)
        {
            string cadenaConexion = System.Configuration.ConfigurationSettings.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "ActualizarFuncion";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@sala", funcion.sala);
                cmd.Parameters.AddWithValue("@pelicula", funcion.pelicula);
                cmd.Parameters.AddWithValue("@estado", funcion.estado);
                cmd.Parameters.AddWithValue("@fechaInicio", funcion.fechaInicio);
                cmd.Parameters.AddWithValue("@fechaFin", funcion.fechaFin);
                cmd.Parameters.AddWithValue("@fechaHora", funcion.fechaHora);
                cmd.Parameters.AddWithValue("@fechaHoraNueva", fechaNueva);
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

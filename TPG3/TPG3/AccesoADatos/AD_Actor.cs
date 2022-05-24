using System.Data;
using System.Data.SqlClient;
using TPG3.Entidades;

namespace TPG3.AccesoADatos
{
    public class AD_Actor
    {
        public static DataTable ObtenerTablaActor()
        {
            string cadenaConexion = System.Configuration.ConfigurationSettings.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "GetDatosActor";
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

        public static bool AgregarActorABD(Actor actor)
        {
            bool resultado = false;
            string cadenaConexion = System.Configuration.ConfigurationSettings.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "InsertActor";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombre", actor.Nombre);
                cmd.Parameters.AddWithValue("@apellido", actor.Apellido);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;
                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                resultado = true;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }

            return resultado;
        }

        public static bool ActualizarActor(Actor r)
        {
            bool resultado = false;
            string cadenaConexion = System.Configuration.ConfigurationSettings.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "ActualizarActor";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombre", r.Nombre);
                cmd.Parameters.AddWithValue("@apellido", r.Apellido);
                cmd.Parameters.AddWithValue("@codActor", r.CodActor);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;
                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                resultado = true;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                cn.Close();
            }
            return resultado;
        }

        public static bool EliminarActor(Actor r)
        {
            bool resultado = false;
            string cadenaConexion = System.Configuration.ConfigurationSettings.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "EliminarActor";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@codActor", r.CodActor);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                resultado = true;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                cn.Close();
            }

            return resultado;
        }

        public static Actor ObtenerActor(int codActor)
        {
            Actor r = new Actor();
            string cadenaConexion = System.Configuration.ConfigurationSettings.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "GetActor";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@codActor", codActor);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;
                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr != null && dr.Read())
                {
                    r.Nombre = dr["nombre"].ToString();
                    r.Apellido = dr["apellido"].ToString();
                    r.CodActor = codActor;
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
            return r;
        }
    }
}

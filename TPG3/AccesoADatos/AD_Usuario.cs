using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using TPG3.Entidades;

namespace TPG3.AccesoADatos
{
    public class AD_Usuario
    {
        public static DataTable ObtenerTablaUsuarios()
        {
            string cadenaConexion = ConfigurationManager.AppSettings["CadenaDB"];

            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "GetDatosUsuarios";
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

        public static void EliminarUsuario(int dni, int tipoDocumento)
        {
            string cadenaConexion = System.Configuration.ConfigurationSettings.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "EliminarUsuario";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@dni", dni);
                cmd.Parameters.AddWithValue("@tipoDocumento", tipoDocumento);
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

        public static Usuario validarUsuario(string nombre, string password)
        {
            Usuario u = new Usuario(-1,"",-1,-1,DateTime.Now,"");
            string cadenaConexion = System.Configuration.ConfigurationSettings.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "ValidarUsuario";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombreUsuario", nombre);
                cmd.Parameters.AddWithValue("@contraseña", password);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;
                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null && dr.Read())
                {
                    u.idUsuario = int.Parse(dr["idUsuario"].ToString());
                    u.nombreUsuario = dr["nombreUsuario"].ToString();
                    u.dni = int.Parse(dr["dni"].ToString());
                    u.tipoDocumento = int.Parse(dr["tipoDocumento"].ToString());
                    u.fechaAlta = DateTime.Parse(dr["fechaAlta"].ToString());
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
            return u;
        }
    }
}

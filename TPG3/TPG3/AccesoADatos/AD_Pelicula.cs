using System.Data;
using System.Data.SqlClient;
using TPG3.Entidades;

namespace TPG3.AccesoADatos
{
    public  class AD_Pelicula
    {
        public static DataTable ObtenerTablaPelicula()
        {
            string cadenaConexion = System.Configuration.ConfigurationSettings.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "GetDetallePeliculas";
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
        public static Peliculas ObtenerPelicula(int codPelicula)
        {
            Peliculas p = new Peliculas();
            string cadenaConexion = System.Configuration.ConfigurationSettings.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "GetPelicula";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@codPelicula", codPelicula);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;
                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null && dr.Read())
                {
                    p.CodPelicula = int.Parse(dr["codPelicula"].ToString());
                    p.Titulo = dr["titulo"].ToString();
                    p.Leyenda = dr["leyenda"].ToString();
                    p.Duracion = dr["duracion"].ToString();
                    p.Sinopsis = dr["sinposis"].ToString();
                    p.Origen = int.Parse(dr["origen"].ToString());
                    p.Calificacion = int.Parse(dr["calificacion"].ToString());
                    p.Formato = int.Parse(dr["formato"].ToString());
                    p.Genero = int.Parse(dr["genero"].ToString());
                    p.Distribuidora = int.Parse(dr["distribuidora"].ToString());
                    p.Idioma = int.Parse(dr["idioma"].ToString());
                    p.AñoEstreno = int.Parse(dr["añoEstreno"].ToString());
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
            return p;
        }

        public static bool AgregarPeliculaABD(Peliculas peli)
        {
            bool resultado = false;
            string cadenaConexion = System.Configuration.ConfigurationSettings.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "InsertPelicula";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@titulo", peli.Titulo);
                cmd.Parameters.AddWithValue("@leyenda", peli.Leyenda);
                cmd.Parameters.AddWithValue("@duracion", peli.Duracion);
                cmd.Parameters.AddWithValue("@sinopsis", peli.Sinopsis);
                cmd.Parameters.AddWithValue("@añoEstreno", peli.AñoEstreno);
                cmd.Parameters.AddWithValue("@origen", peli.Origen);
                cmd.Parameters.AddWithValue("@calificacion", peli.Calificacion);
                cmd.Parameters.AddWithValue("@formato", peli.Formato);
                cmd.Parameters.AddWithValue("@genero", peli.Genero);
                cmd.Parameters.AddWithValue("@distribuidora", peli.Distribuidora);
                cmd.Parameters.AddWithValue("@idioma", peli.Idioma);
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

        public static bool ActualizarPelicula(Peliculas peli)
        {
            bool resultado = false;
            string cadenaConexion = System.Configuration.ConfigurationSettings.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "ActualizarPelicula";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@titulo", peli.Titulo);
                cmd.Parameters.AddWithValue("@leyenda", peli.Leyenda);
                cmd.Parameters.AddWithValue("@duracion", peli.Duracion);
                cmd.Parameters.AddWithValue("@sinopsis", peli.Sinopsis);
                cmd.Parameters.AddWithValue("@añoEstreno", peli.AñoEstreno);
                cmd.Parameters.AddWithValue("@origen", peli.Origen);
                cmd.Parameters.AddWithValue("@calificacion", peli.Calificacion);
                cmd.Parameters.AddWithValue("@formato", peli.Formato);
                cmd.Parameters.AddWithValue("@genero", peli.Genero);
                cmd.Parameters.AddWithValue("@distribuidora", peli.Distribuidora);
                cmd.Parameters.AddWithValue("@idioma", peli.Idioma);
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

        public static bool EliminarPeliculaABD(int codPelicula)
        {
            bool resultado = false;
            string cadenaConexion = System.Configuration.ConfigurationSettings.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "EliminarPelicula";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@codPelicula", codPelicula);
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

        public static DataTable ObtenerPeliculas()
        {
            string cadenaConexion = System.Configuration.ConfigurationSettings.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "GetDatosPeliculas";
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
    }
}

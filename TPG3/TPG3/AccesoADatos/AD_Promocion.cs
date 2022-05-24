using System.Data;
using System.Data.SqlClient;
using TPG3.Entidades;

namespace TPG3.AccesoADatos
{
    public class AD_Promocion
    {
        public static DataTable ObtenerPromocion()
        {
            string cadenaConexion = System.Configuration.ConfigurationSettings.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "GetDatosPromociones";
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

        public static bool cargarPromocion(Promocion promo)
        {
            string cadenaConexion = System.Configuration.ConfigurationSettings.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            SqlCommand cmd = new SqlCommand();
            string consulta = "";
            if (promo.TipoEdicion > 1)
            {
                //Crear
                if (promo.TipoEdicion == 3)
                {
                    consulta = "InsertPromocion";
                }
                //Modificar
                else
                {
                    consulta = "ActualizarPromocion";
                }
                try
                {
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@nombre", promo.nombre);
                    cmd.Parameters.AddWithValue("@descripcion", promo.descripcion);
                    cmd.Parameters.AddWithValue("@valor", promo.valor);
                    cmd.Parameters.AddWithValue("@fechaInicio", promo.fechaInicio);
                    cmd.Parameters.AddWithValue("@fechaFin", promo.fechaFin);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = consulta;
                    cn.Open();
                    cmd.Connection = cn;
                    cmd.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    return false;
                }
                finally
                {
                    cn.Close();
                }
            }
            else
            {
                try
                {
                    consulta = "EliminarPromocion";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@nombre", promo.nombre);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = consulta;
                    cn.Open();
                    cmd.Connection = cn;
                    cmd.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    return false;
                }
                finally
                {
                    cn.Close();
                }
            }
            return true;
        }
    }
}

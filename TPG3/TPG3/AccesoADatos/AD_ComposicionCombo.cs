using System.Data;
using System.Data.SqlClient;
using TPG3.Entidades;

namespace TPG3.AccesoADatos
{
    public class AD_ComposicionCombo
    {
        public static bool eliminarProductoCombo(Producto producto)
        {
            string cadenaConexion = System.Configuration.ConfigurationSettings.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "EliminarProductoCombo";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idProducto", producto.idProducto);
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
            bool result = AD_Producto.eliminarProducto(producto);
            return result;
        }

        public static bool estaEnCombo(Producto producto)
        {
            string cadenaConexion = System.Configuration.ConfigurationSettings.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                var consulta = "EstaEnCombo";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idProducto", producto.idProducto);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;
                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dr = cmd.ExecuteReader();
                bool existe = false;
                if (dr != null && dr.Read())
                {
                    existe = true;
                }
                return existe;
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

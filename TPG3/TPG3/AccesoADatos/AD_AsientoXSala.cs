using System.Data;
using System.Data.SqlClient;
using TPG3.Entidades;

namespace TPG3.AccesoADatos
{
    public class AD_AsientoXSala
    {
        public static List<string> GetAsientos(DateTime fechaHora, int sala) 
        {
            List <string> listaAsientos = new List<string> ();
            string cadenaConexion = System.Configuration.ConfigurationSettings.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "GetAsientosOcupadosFuncion";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@fechaHora", fechaHora);
                cmd.Parameters.AddWithValue("@sala", sala);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;
                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dr = cmd.ExecuteReader();
                string fila;
                string letra;
                string ocupado;
                while (dr.Read())
                {
                    //if (dr != null && dr.Read())
                    //{
                    fila = dr["numeroFila"].ToString();
                    letra = dr["letraColumna"].ToString();
                    ocupado = letra + fila;
                    listaAsientos.Add(ocupado);
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
        return listaAsientos;
        }
    }
}

using System.Data;
using System.Data.SqlClient;
using TPG3.Entidades;

namespace TPG3.AccesoADatos
{
    public class AD_Entrada
    {
        public static bool RegistrarEntrada(DateTime fechaHoraFuncion,int sala,List<string> asientosOcupadosNuevos,List<int> listaIdTarifasSeleccionadas, string promocion, Usuario usuario)
        {
            string cadenaConexion = System.Configuration.ConfigurationSettings.AppSettings["CadenaDB"];
            SqlTransaction objTransaccion = null;
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cn.Open();
                objTransaccion = cn.BeginTransaction("AltaDeEntrada");
                cmd.Transaction = objTransaccion;
                cmd.Connection = cn;

                for (int i = 0; i < listaIdTarifasSeleccionadas.Count; i++)
                {
                    
                    string consultaInsertEntrada = "InsertEntrada";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@fechaHoraVenta", DateTime.Now);
                    cmd.Parameters.AddWithValue("@fechaHoraFuncion", fechaHoraFuncion);
                    cmd.Parameters.AddWithValue("@sala", sala);
                    cmd.Parameters.AddWithValue("@letraColumna", asientosOcupadosNuevos[i].Substring(0,1));
                    cmd.Parameters.AddWithValue("@numeroFila", int.Parse(asientosOcupadosNuevos[i].Substring(1, asientosOcupadosNuevos[i].Length-1)));
                    cmd.Parameters.AddWithValue("@tarifa", listaIdTarifasSeleccionadas[i]);
                    cmd.Parameters.AddWithValue("@promocion", promocion);
                    cmd.Parameters.AddWithValue("@dniEmpleado", usuario.dni);
                    cmd.Parameters.AddWithValue("@tipoDocEmpleado", usuario.tipoDocumento);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = consultaInsertEntrada;

                    cmd.ExecuteNonQuery();
                }
                objTransaccion.Commit();
                return true;
            }
            catch (Exception)
            {
                objTransaccion.Rollback();
                return false;
            }
            finally
            {
                cn.Close();
            }
        }
    }
    
}

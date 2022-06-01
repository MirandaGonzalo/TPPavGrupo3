﻿using System.Data;
using System.Data.SqlClient;
using TPG3.Entidades;

namespace TPG3.AccesoADatos
{
    public class AD_Ticket
    {
        public static int GetUltimoNumeroTicket()
        {
            string cadenaConexion = System.Configuration.ConfigurationSettings.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            int nroTicket = -1;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "ObtenerUltimoNroTicket";
                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;
                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null && dr.Read())
                {
                    nroTicket = int.Parse(dr["nroTicket"].ToString());
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
            return nroTicket;
        }
        public static bool RegistrarTicket(Ticket ticket, List<EditItemCombo> listaCombos)
        {
            string cadenaConexion = System.Configuration.ConfigurationSettings.AppSettings["CadenaDB"];
            SqlTransaction objTransaccion = null;
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "InsertTicket";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@fechaHora", ticket.fechaHoraVenta);
                cmd.Parameters.AddWithValue("@medioPago", ticket.medioPago);
                cmd.Parameters.AddWithValue("@dniEmpleado", ticket.dniEmpelado);
                cmd.Parameters.AddWithValue("@tipoDocEmpleado", ticket.tipoDocEmpleado);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;
                cn.Open();
                objTransaccion = cn.BeginTransaction("AltaDeTicket");
                cmd.Transaction = objTransaccion;
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                
                for (int i = 0; i < listaCombos.Count; i++)
                {
                    string consultaInsertDetalle = "InsertDetalleTicketCombo";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@orden", i + 1);
                    cmd.Parameters.AddWithValue("@nroTicket", ticket.nroTicket);
                    cmd.Parameters.AddWithValue("@nroCombo", listaCombos[i].idProducto);
                    cmd.Parameters.AddWithValue("@cantidad", listaCombos[i].cantidad);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = consultaInsertDetalle;

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


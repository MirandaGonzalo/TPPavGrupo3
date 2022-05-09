using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPG3.Formularios.Promocion
{
    public partial class AltaPromocion : Form
    {
        public AltaPromocion()
        {
            InitializeComponent();
        }

        private void btnCargarPromocion_Click(object sender, EventArgs e)
        {
            //validamos los datos
            bool result = cargarPromocion();
            if (result)
            {
                MessageBox.Show("Promocion cargada con éxito!");
            }
            else
            {
                MessageBox.Show("ha ocurrido un error :(");
            }
        }

        private bool cargarPromocion()
        {
            string cadenaConexion = "Data Source=200.69.137.167,11333;Initial Catalog=BD3K7G03_2022;Persist Security Info=True;User ID=BD3K7G03_2022;Password=PSW03_98074";
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "INSERT INTO Promocion (nombre,descripcion,valor, fechaInicio, fechaFin)" +
                                  "VALUES (@nombre, @descripcion, @valor, @fechaInicio, @fechaFin)";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombre", txtNombre.Text);
                cmd.Parameters.AddWithValue("@descripcion", txtDescripcion.Text);
                cmd.Parameters.AddWithValue("@valor", float.Parse(mtbValor.Text));
                cmd.Parameters.AddWithValue("@fechaInicio", DateTime.Parse(mtbInicio.Text));
                cmd.Parameters.AddWithValue("@fechaFin", DateTime.Parse(mtbFin.Text));
                cmd.CommandType = CommandType.Text;
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
            return true;
        }

        private void btnListado_Click(object sender, EventArgs e)
        {
            Main.main1.btnSubPromocion_Click(sender, e);
        }
    }
}

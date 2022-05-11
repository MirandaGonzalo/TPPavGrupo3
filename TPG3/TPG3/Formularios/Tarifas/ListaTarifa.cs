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

namespace TPG3.Formularios.Tarifas
{
    public partial class ListaTarifa : Form
    {
        public ListaTarifa()
        {
            InitializeComponent();
        }

        private void btnRegistrarTarifa_Click(object sender, EventArgs e)
        {
           Main.main1.btnSubTarifaAltaTarifa(sender, e);
        }

        private void ListaTarifa_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void CargarGrilla()
        {
            try
            {
                gdrListadoTarifa.DataSource = ObtenerTablaTarifa();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener productos");
            }
        }
        public static DataTable ObtenerTablaTarifa()
        {
            string cadenaConexion = "Data Source=200.69.137.167,11333;Initial Catalog=BD3K7G03_2022;Persist Security Info=True;User ID=BD3K7G03_2022;Password=PSW03_98074";
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * FROM Tarifa JOIN Formato ON Tarifa.codFormato=Formato.codFormato";

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                return tabla;
            }

            catch (Exception ex)
            {

                throw;
            }

            finally
            {
                cn.Close();
            }
        }

        private void txtBuscadorDescripcion_TextChanged(object sender, EventArgs e)
        {
            (gdrListadoTarifa.DataSource as DataTable).DefaultView.RowFilter = "Convert(descripcion, 'System.String') LIKE '" + txtBuscadorDescripcion.Text + "%' and Convert(codFormato, 'System.String') LIKE '" + txtBuscadorFormato.Text + "%'";
        }

        private void txtBuscadorFormato_TextChanged(object sender, EventArgs e)
        {
            (gdrListadoTarifa.DataSource as DataTable).DefaultView.RowFilter = "Convert(descripcion, 'System.String') LIKE '" + txtBuscadorDescripcion.Text + "%' and Convert(codFormato, 'System.String') LIKE '" + txtBuscadorFormato.Text + "%'";
        }
    }
}

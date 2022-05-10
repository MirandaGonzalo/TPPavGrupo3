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

namespace TPG3.Formularios.Actores
{
    public partial class ListaActor : Form
    {
        public ListaActor()
        {
            InitializeComponent();
        }

        private void btnRegistrarActualizarActor_Click(object sender, EventArgs e)
        {
            Main.main1.btnSubParticipantesAltaParticipante(sender, e);
        }

        private void ListaActor_Load(object sender, EventArgs e)
        {
            LimpiarCampos();
            CargarGrilla();
        }

        private void LimpiarCampos()
        {
            txtBuscadorNombre.Text = "";
            txtBuscadorApellido.Text = "";
        }

        private void CargarGrilla()
        {
            try
            {
                dtgListadoActor.DataSource = ObtenerTablaActor();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener productos");
            }
        }

        public static DataTable ObtenerTablaActor()
        {
            string cadenaConexion = "Data Source=200.69.137.167,11333;Initial Catalog=BD3K7G03_2022;Persist Security Info=True;User ID=BD3K7G03_2022;Password=PSW03_98074";
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * FROM Actor";

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

        private void txtBuscadorNombre_TextChanged(object sender, EventArgs e)
        {
            (dtgListadoActor.DataSource as DataTable).DefaultView.RowFilter = "Convert(nombre, 'System.String') LIKE '" + txtBuscadorNombre.Text + "%' and Convert(apellido, 'System.String') LIKE '" + txtBuscadorApellido.Text + "%'";

        }

        private void txtBuscadorApellido_TextChanged(object sender, EventArgs e)
        {
            (dtgListadoActor.DataSource as DataTable).DefaultView.RowFilter = "Convert(nombre, 'System.String') LIKE '" + txtBuscadorNombre.Text + "%' and Convert(apellido, 'System.String') LIKE '" + txtBuscadorApellido.Text + "%'";
        }
    }
}

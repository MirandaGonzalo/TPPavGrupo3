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
using TPG3.CapaLogicaNegocio;
using TPG3.Entidades;

namespace TPG3.CapaLogicaNegocio
{
    public partial class FuncionService : Form
    {
        public FuncionService()
        {
            InitializeComponent();
        }

        private void FuncionService_Load(object sender, EventArgs e)
        {
            btnContinuar.Enabled = false;
            CargarGrilla();
        }

      
        private void CargarGrilla()
        {
            try
            {
                int idPelicula = int.Parse(txtIdPeliculaFuncion.Text);
                gdrSeleccionFuncion.DataSource = ObtenerTablaFuncion(idPelicula);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener la película");
            }
        }

        public static DataTable ObtenerTablaFuncion(int idPeli)
        {
            string cadenaConexion = "Data Source=200.69.137.167,11333;Initial Catalog=BD3K7G03_2022;Persist Security Info=True;User ID=BD3K7G03_2022;Password=PSW03_98074";
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = " SELECT f.fechaHora AS 'fechaHora',f.sala AS 'sala',p.titulo AS 'pelicula', f.estado AS 'estado' " +
                                    "FROM Funcion AS f " +
                                    "JOIN Pelicula AS p ON(f.pelicula = p.codPelicula) " +
                                    "WHERE p.codPelicula LIKE @pelicula " +
                                    "AND f.fechaHora >= GETDATE() " +
                                    "AND f.fechaHora <= GETDATE()+7 ";


                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@pelicula", idPeli);
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

        private Funcion ObtenerFuncion(int salaFuncion)
        {
            Funcion f = new Funcion();
            string cadenaConexion = "Data Source=200.69.137.167,11333;Initial Catalog=BD3K7G03_2022;Persist Security Info=True;User ID=BD3K7G03_2022;Password=PSW03_98074";
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = " SELECT f.fechaHora AS 'fechaHora',f.sala AS 'sala',p.titulo AS 'pelicula', f.estado AS 'estado' " +
                                    "FROM Funcion AS f " +
                                    "JOIN Pelicula AS p ON(f.pelicula = p.codPelicula) " +
                                    "WHERE f.sala LIKE @salaFuncion ";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@salaFuncion", salaFuncion);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null && dr.Read())
                {
                    f.fechaHora = DateTime.Parse(dr["fechaHora"].ToString());
                    f.sala = int.Parse(dr["sala"].ToString());
                    f.estado = dr["estado"].ToString();
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

            return f;

        }
        private void CargarCampos(Funcion f)
        {
            txtFechaHora.Text = f.fechaHora.ToString();
            txtSala.Text = f.sala.ToString();
            txtEstado.Text = f.estado.ToString();
        }

        private void gdrSeleccionFuncion_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            btnContinuar.Enabled = true;
            int indice = e.RowIndex;
            DataGridViewRow filaSeleccionada = gdrSeleccionFuncion.Rows[indice];

            int salaFuncion = (int)filaSeleccionada.Cells["Sala"].Value;
            Funcion f = ObtenerFuncion(salaFuncion);
            CargarCampos(f);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Main.main1.btnVolverSeleccionPelicula(sender, e);
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            string formato = txtFormatoPeli.Text;
            //Main.main1.btnSeleccionTarifa(sender, e, formato);
        }
    }
}

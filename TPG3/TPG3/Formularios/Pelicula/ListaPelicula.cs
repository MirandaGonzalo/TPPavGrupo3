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

namespace TPG3.Formularios.Pelicula
{
    public partial class ListaPelicula : Form
    {
        public ListaPelicula()
        {
            InitializeComponent();
        }

        private void btnRegistrarPelícula_Click(object sender, EventArgs e)
        {
            Main.main1.btnSubPeliculaAltaPelicula(sender, e);
        }

        private void ListaPelicula_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void CargarGrilla()
        {
            try
            {
                gdrActualizarPeli.DataSource = ObtenerTablaPelicula();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener la película");
            }
        }

        public static DataTable ObtenerTablaPelicula()
        {
            string cadenaConexion = "Data Source=200.69.137.167,11333;Initial Catalog=BD3K7G03_2022;Persist Security Info=True;User ID=BD3K7G03_2022;Password=PSW03_98074";
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT p.codPelicula,p.titulo,p.duracion,o.nombre as 'origenN',c.abreviatura as 'calif', " +
                "f.descripcion as 'forma', g.descripcion as 'descriG', d.nombreDistribuidora as 'dist', i.descripcion as 'idioma' " +
                "FROM Pelicula AS p JOIN Formato AS f ON(f.codFormato = p.formato) JOIN Calificacion AS c " +
                "ON(c.codCalificacion = p.calificacion) JOIN Genero AS g ON(g.codGenero = p.genero) " +
                "JOIN Origen AS o ON(o.idOrigen = p.origen) JOIN Distribuidora AS d ON(d.idDistribuidora = p.distribuidora) " +
                "JOIN Idioma AS i ON(i.codIdioma = p.idioma) ";
                
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

        private void txtBuscadorTitulo_TextChanged(object sender, EventArgs e)
        {
            (gdrActualizarPeli.DataSource as DataTable).DefaultView.RowFilter = "Convert(titulo, 'System.String') LIKE '" + txtBuscadorTitulo.Text + "%' and Convert(genero, 'System.String') LIKE '" + txtBuscadorGenero.Text + "%'";

        }

        private void txtBuscadorGenero_TextChanged(object sender, EventArgs e)
        {
            (gdrActualizarPeli.DataSource as DataTable).DefaultView.RowFilter = "Convert(titulo, 'System.String') LIKE '" + txtBuscadorTitulo.Text + "%' and Convert(genero, 'System.String') LIKE '" + txtBuscadorGenero.Text + "%'";
        }


    }
}

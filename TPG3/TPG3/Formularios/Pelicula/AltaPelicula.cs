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
using TPG3.Entidades;

namespace TPG3.Formularios.Pelicula
{
    public partial class AltaPelicula : Form
    {
        public AltaPelicula()
        {
            InitializeComponent();
        }

        private void AltaPelicula_Load(object sender, EventArgs e)
        {
            LimpiarCampos();
            CargarComboOrigen();
            CargarComboCalificacion();
            CargarComboFormato();
            CargarComboGenero();
            CargarComboDistribuidora();
            CargarComboIdioma();
            CargarGrilla();
            btnActualizar.Enabled = false;
        }

        private void LimpiarCampos()
        {
            txtTitulo.Text = "";
            txtLeyenda.Text = "";
            txtDuracion.Text = "";
            txtSinopsis.Text = "";
            txtEstreno.Text = "";
        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
        private void CargarComboOrigen()
        {
            try
            {
                cmbOrigen.DataSource = ObtenerOrigen();
                cmbOrigen.DisplayMember = "nombre";
                cmbOrigen.ValueMember = "idOrigen";
                cmbOrigen.SelectedIndex = -1;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el origen de la película");
            }
        }

        public static DataTable ObtenerOrigen()
        {
            string cadenaConexion = "Data Source=200.69.137.167,11333;Initial Catalog=BD3K7G03_2022;Persist Security Info=True;User ID=BD3K7G03_2022;Password=PSW03_98074";
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * FROM Origen";

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
        private void CargarComboCalificacion()
        {
            try
            {
                cmbOrigen.DataSource = ObtenerCalificacion();
                cmbOrigen.DisplayMember = "descripcion";
                cmbOrigen.ValueMember = "codCalificacion";
                cmbOrigen.SelectedIndex = -1;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el origen de la película");
            }
        }
        public static DataTable ObtenerCalificacion()
        {
            string cadenaConexion = "Data Source=200.69.137.167,11333;Initial Catalog=BD3K7G03_2022;Persist Security Info=True;User ID=BD3K7G03_2022;Password=PSW03_98074";
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * FROM Calificacion";

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
        private void CargarComboFormato()
        {
            try
            {
                cmbOrigen.DataSource = ObtenerFormato();
                cmbOrigen.DisplayMember = "descripcion";
                cmbOrigen.ValueMember = "codFormato";
                cmbOrigen.SelectedIndex = -1;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el origen de la película");
            }
        }
        public static DataTable ObtenerFormato()
        {
            string cadenaConexion = "Data Source=200.69.137.167,11333;Initial Catalog=BD3K7G03_2022;Persist Security Info=True;User ID=BD3K7G03_2022;Password=PSW03_98074";
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * FROM Formato";

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
        private void CargarComboGenero()
        {
            try
            {
                cmbOrigen.DataSource = ObtenerGenero();
                cmbOrigen.DisplayMember = "descripcion";
                cmbOrigen.ValueMember = "codGenero";
                cmbOrigen.SelectedIndex = -1;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el origen de la película");
            }
        }
        public static DataTable ObtenerGenero()
        {
            string cadenaConexion = "Data Source=200.69.137.167,11333;Initial Catalog=BD3K7G03_2022;Persist Security Info=True;User ID=BD3K7G03_2022;Password=PSW03_98074";
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * FROM Genero";

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
        private void CargarComboDistribuidora()
        {
            try
            {
                cmbOrigen.DataSource = ObtenerDistribuidora();
                cmbOrigen.DisplayMember = "nombreDistribuidora";
                cmbOrigen.ValueMember = "idDistribuidora";
                cmbOrigen.SelectedIndex = -1;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el origen de la película");
            }
        }
        public static DataTable ObtenerDistribuidora()
        {
            string cadenaConexion = "Data Source=200.69.137.167,11333;Initial Catalog=BD3K7G03_2022;Persist Security Info=True;User ID=BD3K7G03_2022;Password=PSW03_98074";
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * FROM Distribuidora";

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
        private void CargarComboIdioma()
        {
            try
            {
                cmbOrigen.DataSource = ObtenerIdioma();
                cmbOrigen.DisplayMember = "descripcion";
                cmbOrigen.ValueMember = "codIdioma";
                cmbOrigen.SelectedIndex = -1;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el origen de la película");
            }
        }
        public static DataTable ObtenerIdioma()
        {
            string cadenaConexion = "Data Source=200.69.137.167,11333;Initial Catalog=BD3K7G03_2022;Persist Security Info=True;User ID=BD3K7G03_2022;Password=PSW03_98074";
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * FROM Idioma";

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
        private void CargarGrilla()
        {
            try
            {
                gdrConsultarPeli.DataSource = ObtenerTablaPelicula();
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

                string consulta = "SELECT *" +
                                    "FROM Pelicula AS p" +
                                    "JOIN Formato AS f ON(f.codFormato = p.formato)" +
                                    "JOIN Calificacion AS c ON(c.codCalificacion = p.calificacion)" +
                                    "JOIN Genero AS g ON(g.codGenero = p.genero)" +
                                    "JOIN Origen AS o ON(o.idOrigen = p.origen)" +
                                    "JOIN Distribuidora AS d ON(d.idDistribuidora = p.distribuidora)";

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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Peliculas p = ObtenerDatosPelicula();


            bool resultado = AgregarPeliculaABD(p);

            if (resultado)
            {
                MessageBox.Show("Película agregada con éxito");
                LimpiarCampos();
                CargarComboOrigen();
                CargarComboCalificacion();
                CargarComboFormato();
                CargarComboGenero();
                CargarComboDistribuidora();
                CargarComboIdioma();
                CargarGrilla();
            }
            else
            {
                MessageBox.Show("Error al cargar la película");
            }
        }

        private Peliculas ObtenerDatosPelicula()
        {
            Peliculas pelicula = new Peliculas();

            pelicula.Titulo = txtTitulo.Text.Trim();
            pelicula.Leyenda = txtLeyenda.Text.Trim();
            pelicula.Duracion = txtDuracion.Text.Trim();
            pelicula.Sinopsis = txtSinopsis.Text.Trim();
            pelicula.AñoEstreno = DateOnly.Parse(txtEstreno.Text);
            pelicula.Origen = (int)cmbOrigen.SelectedValue;
            pelicula.Calificacion = (int)cmbCalificacion.SelectedValue;
            pelicula.Formato = (int)cmbFormato.SelectedValue;
            pelicula.Genero = (int)cmbGenero.SelectedValue;
            pelicula.Distribuidora = (int)cmbDistribuidora.SelectedValue;
            pelicula.Idioma = (int)cmbIdioma.SelectedValue;

            return pelicula;
        }

        public static bool AgregarPeliculaABD(Peliculas peli)
        {
            bool resultado = false;
            string cadenaConexion = "Data Source=200.69.137.167,11333;Initial Catalog=BD3K7G03_2022;Persist Security Info=True;User ID=BD3K7G03_2022;Password=PSW03_98074";
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "INSERT INTO Pelicula (titulo, leyenda, duracion, sinopsis, añoEstreno, origen, calificacion, formato, genero, distribuidora, idioma) VALUES (@titulo, @leyenda, @duracion, @sinopsis, @añoEstreno, @origen, @calificacion, @formato, @genero, @distribuidora, @idioma)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@titulo", peli.Titulo);
                cmd.Parameters.AddWithValue("@leyenda", peli.Leyenda);
                cmd.Parameters.AddWithValue("@duracion", peli.Duracion);
                cmd.Parameters.AddWithValue("@sinopsis", peli.Sinopsis);
                cmd.Parameters.AddWithValue("@añoEstreno", peli.AñoEstreno);
                cmd.Parameters.AddWithValue("@origen", peli.Origen);
                cmd.Parameters.AddWithValue("@calificacion", peli.Calificacion);
                cmd.Parameters.AddWithValue("@formato", peli.Formato);
                cmd.Parameters.AddWithValue("@genero", peli.Genero);
                cmd.Parameters.AddWithValue("@distribuidora", peli.Distribuidora);
                cmd.Parameters.AddWithValue("@idioma", peli.Idioma);

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;
                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                resultado = true;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }

            return resultado;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Peliculas p = ObtenerDatosPelicula();
            bool resultado = ActualizarPelicula(p);
            if (resultado)
            {
                MessageBox.Show("Película actualizado con éxito");
                LimpiarCampos();
                CargarGrilla();
                CargarComboOrigen();
                CargarComboCalificacion();
                CargarComboFormato();
                CargarComboGenero();
                CargarComboDistribuidora();
                CargarComboIdioma();
            }
            else
            {
                MessageBox.Show("Error al actualizar Película");
            }
        }

        private bool ActualizarPelicula(Peliculas peli)
        {
            bool resultado = false;
            string cadenaConexion = "Data Source=200.69.137.167,11333;Initial Catalog=BD3K7G03_2022;Persist Security Info=True;User ID=BD3K7G03_2022;Password=PSW03_98074";
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "UPDATE Pelicula SET titulo = @titulo, leyenda = @leyenda, duracion = @duracion, sinopsis = @sinopsis, añoEstreno = @añoEstreno, origen = @origen, calificacion = @calificacion, formato = @formato, genero = @genero, distribuidora = @distribuidora, idioma = @idioma WHERE nombre LIKE @nombre";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@titulo", peli.Titulo);
                cmd.Parameters.AddWithValue("@leyenda", peli.Leyenda);
                cmd.Parameters.AddWithValue("@duracion", peli.Duracion);
                cmd.Parameters.AddWithValue("@sinopsis", peli.Sinopsis);
                cmd.Parameters.AddWithValue("@añoEstreno", peli.AñoEstreno);
                cmd.Parameters.AddWithValue("@origen", peli.Origen);
                cmd.Parameters.AddWithValue("@calificacion", peli.Calificacion);
                cmd.Parameters.AddWithValue("@formato", peli.Formato);
                cmd.Parameters.AddWithValue("@genero", peli.Genero);
                cmd.Parameters.AddWithValue("@distribuidora", peli.Distribuidora);
                cmd.Parameters.AddWithValue("@idioma", peli.Idioma);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                resultado = true;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                cn.Close();
            }

            return resultado;
        }

        private void gdrConsultarProd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnActualizar.Enabled = true;
            int indice = e.RowIndex;
            DataGridViewRow filaSeleccionada = gdrConsultarPeli.Rows[indice];

            int codPelicula = (int)filaSeleccionada.Cells["codPelicula"].Value;
            Peliculas p = ObtenerPelicula(codPelicula);
            LimpiarCampos();
            CargarCampos(p);
        }
        private Peliculas ObtenerPelicula(int codPelicula)
        {
            Peliculas p = new Peliculas();
            string cadenaConexion = "Data Source=200.69.137.167,11333;Initial Catalog=BD3K7G03_2022;Persist Security Info=True;User ID=BD3K7G03_2022;Password=PSW03_98074";
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM Pelicula WHERE codPelicula LIKE @codPelicula";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@codPelicula", codPelicula);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null && dr.Read())
                {
                    p.Titulo = dr["titulo"].ToString();
                    p.Leyenda = dr["leyenda"].ToString();
                    p.Duracion = dr["duracion"].ToString();
                    p.Sinopsis = dr["sinopsis"].ToString();
                    p.AñoEstreno = DateOnly.Parse(dr["añoEstreno"].ToString());
                    p.Origen = int.Parse(dr["origen"].ToString());
                    p.Calificacion = int.Parse(dr["calificacion"].ToString());
                    p.Formato = int.Parse(dr["formato"].ToString());
                    p.Genero = int.Parse(dr["genero"].ToString());
                    p.Distribuidora = int.Parse(dr["distribuidora"].ToString());
                    p.Idioma = int.Parse(dr["idioma"].ToString());
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

            return p;

        }

        private void CargarCampos(Peliculas p)
        {
            txtTitulo.Text = p.Titulo;
            txtLeyenda.Text = p.Leyenda;
            txtDuracion.Text = p.Duracion;
            txtSinopsis.Text = p.Sinopsis;
            txtEstreno.Text = p.AñoEstreno.ToString();
            cmbOrigen.SelectedValue = p.Origen;
            cmbCalificacion.SelectedValue = p.Calificacion;
            cmbFormato.SelectedValue = p.Formato;
            cmbGenero.SelectedValue = p.Genero;
            cmbDistribuidora.SelectedValue = p.Distribuidora;
            cmbIdioma.SelectedValue = p.Idioma;
        }






























    }
}

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

namespace TPG3.Formularios.Tarifas
{
    public partial class AltaTarifa : Form
    {
        public AltaTarifa()
        {
            InitializeComponent();
        }

        private void AltaTarifa_Load(object sender, EventArgs e)
        {
            btnActualizar.Enabled = false;
            LimpiarCampos();
            CargarComboCodFormato();
            CargarGrilla();
        }

        private void LimpiarCampos()
        {
            txtDescripcionTarifa.Text = "";
            txtValor.Text = "";
        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void CargarGrilla()
        {
            try
            {
                gdrActualizarTarifa.DataSource = ObtenerTablaTarifa();
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            bool camposCorrectos = validarCamposNoVacios();

            if (camposCorrectos)
            {
                Tarifa t = ObtenerDatosTarifa();

                bool resultado = AgregarTarifaABD(t);

                if (resultado)
                {
                    MessageBox.Show("Actor agregado con éxito");
                    LimpiarCampos();
                    CargarComboCodFormato();
                    CargarGrilla();
                }
                else
                {
                    MessageBox.Show("Error al cargar el actor");
                }
            }
            else
            {
                MessageBox.Show("Datos Incorrectos, Ingrese nuevamente los Datos");
            }
        }
        private Tarifa ObtenerDatosTarifa()
        {
            Tarifa tarifa = new Tarifa();

            tarifa.IdTarifa = int.Parse(txtIdTarifa.Text.Trim());
            tarifa.Descripcion = txtDescripcionTarifa.Text.Trim();
            tarifa.Valor = float.Parse(txtValor.Text.Trim());
            tarifa.CodFormato = (int)cmbFormato.SelectedValue;

            return tarifa;
        }

        public static bool AgregarTarifaABD(Tarifa tarifa)
        {
            bool resultado = false;
            string cadenaConexion = "Data Source=200.69.137.167,11333;Initial Catalog=BD3K7G03_2022;Persist Security Info=True;User ID=BD3K7G03_2022;Password=PSW03_98074";
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "INSERT INTO Tarifa (descripcion, valor, codFormato) VALUES (@descripcion, @valor, @codFormato)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@descripcion", tarifa.Descripcion);
                cmd.Parameters.AddWithValue("@valor", tarifa.Valor);
                cmd.Parameters.AddWithValue("@codFormato", tarifa.CodFormato);
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

        private bool validarCamposNoVacios()
        {
            if (txtDescripcionTarifa.Text.Trim().Equals(""))
            {
                lblError.Visible = true;
                lblError.Text = " El campo descripción de la Tarifa no puede estar vacío.";
                txtDescripcionTarifa.Focus();
                return false;
            }
            if (txtValor.Text.Trim().Equals(""))
            {
                lblError.Visible = true;
                lblError.Text = "El campo Valor no puede estar vacío";
                txtValor.Focus();
                return false;
            }
            return true;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Tarifa t = ObtenerDatosTarifa();
            bool resultado = ActualizarTarifa(t);
            if (resultado)
            {
                MessageBox.Show("Actor actualizado con éxito");
                LimpiarCampos();
                CargarGrilla();
                CargarComboCodFormato();
            }
            else
            {
                MessageBox.Show("Error al actualizar actor");
            }
        }

        private bool ActualizarTarifa(Tarifa t)
        {
            bool resultado = false;
            string cadenaConexion = "Data Source=200.69.137.167,11333;Initial Catalog=BD3K7G03_2022;Persist Security Info=True;User ID=BD3K7G03_2022;Password=PSW03_98074";
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "UPDATE Tarifa SET descripcion = @descripcion, valor = @valor, codFormato = @codFormato WHERE idTarifa = @idTarifa";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@descripcion", t.Descripcion);
                cmd.Parameters.AddWithValue("@valor", t.Valor);
                cmd.Parameters.AddWithValue("@codFormato", t.CodFormato);
                cmd.Parameters.AddWithValue("@idTarifa", t.IdTarifa);
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

        private void gdrActualizarTarifa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnActualizar.Enabled = true;
            int indice = e.RowIndex;
            DataGridViewRow filaSeleccionada = gdrActualizarTarifa.Rows[indice];

            int idTarifa = (int)filaSeleccionada.Cells[0].Value;
            txtIdTarifa.Text = idTarifa.ToString();
            Tarifa t = ObtenerTarifa(idTarifa);
            LimpiarCampos();
            CargarCampos(t);
        }

        private Tarifa ObtenerTarifa(int idTarifa)
        {
            Tarifa t = new Tarifa();
            string cadenaConexion = "Data Source=200.69.137.167,11333;Initial Catalog=BD3K7G03_2022;Persist Security Info=True;User ID=BD3K7G03_2022;Password=PSW03_98074";
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM Tarifa WHERE idTarifa LIKE @idTarifa";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idTarifa", idTarifa);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null && dr.Read())
                {
                    t.Descripcion = dr["descripcion"].ToString();
                    t.Valor = float.Parse(dr["valor"].ToString());
                    t.CodFormato = int.Parse(dr["codFormato"].ToString());
                    t.IdTarifa = idTarifa;
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

            return t;
        }
        private void CargarCampos(Tarifa t)
        {
            txtValor.Text = t.Valor.ToString();
            txtDescripcionTarifa.Text = t.Descripcion;
            cmbFormato.SelectedValue = t.CodFormato;
        }
        private void CargarComboCodFormato()
        {
            try
            {
                cmbFormato.DataSource = ObtenerFormatos();
                cmbFormato.DisplayMember = "descripcion";
                cmbFormato.ValueMember = "codFormato";
                cmbFormato.SelectedIndex = -1;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar combo tipo formato");
            }
        }

        public static DataTable ObtenerFormatos()
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

















    }
}

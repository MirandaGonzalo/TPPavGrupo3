using System.Data;
using TPG3.AccesoADatos;
using TPG3.Entidades;
using System.Data.SqlClient;
namespace TPG3.CapaLogicaNegocio
{
    public partial class Combo : Form
    {
        private List<int> combosSel;
        private List<EditItemCombo> listaCombos;
        public Combo()
        {
            listaCombos = new List<EditItemCombo>();
            combosSel = new List<int>();
            combosSel.Add(-1);
            InitializeComponent();
        }

        private void Combo_Load(object sender, EventArgs e)
        {
            cargarGrilla();
        }

        private void cargarGrilla()
        {
            try
            {
                dgvListaCombos.DataSource = AD_Combo.GetInfoCombos();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void mostrarCombosModificado(int idCombo)
        {
            string cadenaConexion = System.Configuration.ConfigurationSettings.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = (String.Format("select nombre, idProducto, precio from Producto " +
                "where tipoProducto = 1 and idProducto not IN ({0}) ", String.Join(",", combosSel)));

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;
                cn.Open();
                cmd.Connection = cn;
                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);
                dgvListaCombos.DataSource = tabla;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                cn.Close();
            }
        }

        private void mostrarCombosSeleccionados()
        {
            string cadenaConexion = System.Configuration.ConfigurationSettings.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = (String.Format("select nombre, idProducto, precio, 1 as 'cantidad' from Producto " +
                "where idProducto IN ({0}) ", String.Join(",", combosSel)));

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;
                cn.Open();
                cmd.Connection = cn;
                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);
                dgvListaCombosSel.DataSource = tabla;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                cn.Close();
            }
        }

        private void mostrarComponentesCombo(int idCombo)
        {
            string cadenaConexion = System.Configuration.ConfigurationSettings.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "select prod.nombre,cd.cantidad, prod.precio, " +
                "(cd.cantidad * prod.precio) as 'total' from Producto prod INNER JOIN ComposicionDeCombo cd " +
                "on prod.idProducto = cd.idProductoSimple and cd.idProductoCombo = @idCombo ";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idCombo", idCombo);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;
                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);
                dgvDetalleCombo.DataSource = tabla;

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                cn.Close();
            }
        }

        private void cantidadCombos()
        {
            int cantidad = 0;
            for (int rows = 0; rows < dgvListaCombosSel.Rows.Count; rows++)
            {    
                cantidad += int.Parse(dgvListaCombosSel.Rows[rows].Cells[3].Value.ToString());
            }
            lblCantComb.Text = cantidad.ToString();
        }

        private void precioTotalCombos()
        {
            int total = 0;
            int precio = 0;
            int cantidad = 0;
            for (int rows = 0; rows < dgvListaCombosSel.Rows.Count; rows++)
            {
                precio = int.Parse(dgvListaCombosSel.Rows[rows].Cells[2].Value.ToString());
                cantidad = int.Parse(dgvListaCombosSel.Rows[rows].Cells[3].Value.ToString());
                total += precio * cantidad;
            }
            lblPrecioTotal.Text = total.ToString();
        }

        private void dgvListaCombos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var currentRow = dgvListaCombos.CurrentCell.RowIndex;
            DataGridViewRow selectedRow = dgvListaCombos.Rows[currentRow];
            int idCombo = int.Parse(dgvListaCombos.Rows[currentRow].Cells[1].Value.ToString());
            mostrarComponentesCombo(idCombo);
        }

        private void dgvListaCombosSel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var currentRow = dgvListaCombosSel.CurrentCell.RowIndex;
            DataGridViewRow selectedRow = dgvListaCombosSel.Rows[currentRow];
            int idCombo = int.Parse(dgvListaCombosSel.Rows[currentRow].Cells[1].Value.ToString());
            mostrarComponentesCombo(idCombo);            
        }

        //private void dgvListaCombosSel_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        //{
        //    cantidadCombos();
        //    precioTotalCombos();
        //}

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var currentRow = dgvListaCombos.CurrentCell.RowIndex;
            DataGridViewRow selectedRow = dgvListaCombos.Rows[currentRow];
            int idCombo = int.Parse(dgvListaCombos.Rows[currentRow].Cells[1].Value.ToString());
            string nombreCombo = (dgvListaCombos.Rows[currentRow].Cells[0].Value.ToString());
            float precio = float.Parse(dgvListaCombos.Rows[currentRow].Cells[2].Value.ToString());
            combosSel.Add(idCombo);
            mostrarCombosModificado(idCombo);
            dgvListaCombosSel.Rows.Add(nombreCombo, idCombo, precio, 1);
            cantidadCombos();
            precioTotalCombos();
        }

        private void btnProductoNuevo_Click(object sender, EventArgs e)
        {
            var currentRow = dgvListaCombosSel.CurrentCell.RowIndex;
            DataGridViewRow selectedRow = dgvListaCombosSel.Rows[currentRow];
            int idCombo = int.Parse(dgvListaCombosSel.Rows[currentRow].Cells[1].Value.ToString());
            combosSel.Remove(idCombo);
            dgvListaCombosSel.Rows.RemoveAt(currentRow);
            mostrarCombosModificado(idCombo);
            cantidadCombos();
            precioTotalCombos();
        }

        private void btnCargarCombo_Click(object sender, EventArgs e)
        {
            if (dgvListaCombosSel.Rows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar un combo.");
            }
            else
            {
                var confirmResult = MessageBox.Show("Desea comprar estos combos ??",
                "Confirmación!!",MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    for (int rows = 0; rows < dgvListaCombosSel.Rows.Count; rows++)
                    {
                        string nombreCombo = dgvListaCombosSel.Rows[rows].Cells[0].Value.ToString();
                        int idProducto = int.Parse(dgvListaCombosSel.Rows[rows].Cells[1].Value.ToString());
                        float precio = float.Parse(dgvListaCombosSel.Rows[rows].Cells[2].Value.ToString());
                        int cantidad = int.Parse(dgvListaCombosSel.Rows[rows].Cells[3].Value.ToString());
                        EditItemCombo item = new EditItemCombo(idProducto,nombreCombo,cantidad, precio);
                        listaCombos.Add(item);
                    }
                    Main.main1.formPagoCombo(listaCombos);
                }
                
            }
        }
    }
}

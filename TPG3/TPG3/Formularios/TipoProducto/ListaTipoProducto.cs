using System.Data;
using TPG3.AccesoADatos;

namespace TPG3.Formularios.TipoProducto
{
    public partial class ListaTipoProducto : Form
    {
        public ListaTipoProducto()
        {
            InitializeComponent();
        }

        private void ListaTipoProducto_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void CargarGrilla()
        {
            try
            {
                grdBuscadorTipoProd.DataSource = AD_TipoProducto.ObtenerTablaOrigen();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener tipos de productos.");
            }
        }
        private void txtBuscadorTipoProd_TextChanged(object sender, EventArgs e)
        {
            (grdBuscadorTipoProd.DataSource as DataTable).DefaultView.RowFilter = "Convert(nombreTipoProd, 'System.String') LIKE '" + txtBuscadorTipoProd.Text + "%'";
        }
    }
}

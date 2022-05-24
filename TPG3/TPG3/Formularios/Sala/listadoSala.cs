using System.Data;
using TPG3.AccesoADatos;

namespace TPG3.Formularios.Sala
{
    public partial class listadoSala : Form
    {
        public listadoSala()
        {
            InitializeComponent();
        }

        private void listadoSala_Load(object sender, EventArgs e)
        {
            cargarGrilla();
        }
        private void cargarGrilla()
        {
            try
            {
                grdSala.DataSource = AD_Sala.ObtenerTablaSala();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al obtener las salas");
            }
        }

        private void txtBuscadorSala_TextChanged(object sender, EventArgs e)
        {
            (grdSala.DataSource as DataTable).DefaultView.RowFilter = "Convert(numero, 'System.String') LIKE '" + txtBuscadorSala.Text + "%'";
        }
    }
}

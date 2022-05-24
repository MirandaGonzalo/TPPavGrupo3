using System.Data;
using TPG3.AccesoADatos;

namespace TPG3.Formularios.Usuario
{
    public partial class listadoUsuario : Form
    {
        public listadoUsuario()
        {
            InitializeComponent();
        }


        private void listadoUsuario_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }
        private void CargarGrilla()
        {
            try
            {
                dgvUsuarios.DataSource = AD_Usuario.ObtenerTablaUsuarios();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al obtener usuarios");
            }
        }
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            (dgvUsuarios.DataSource as DataTable).DefaultView.RowFilter = "Convert(nombreUsuario, 'System.String') LIKE '" + txtBuscar.Text + "%'";
        }        
    }
}

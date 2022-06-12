using System.Data;
using TPG3.AccesoADatos;


namespace TPG3.Formularios.EntradasVendidas
{
    public partial class ListaEntradas : Form
    {
        public ListaEntradas()
        {
            InitializeComponent();
        }

        private void ListaEntradas_Load(object sender, EventArgs e)
        {
            cargarGrilla();
        }
        private void cargarGrilla()
        {
            try
            {
                gridTicket.DataSource = AD_Ticket.ObtenerTicketsEntradas();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al obtener los listados de origenes.");
            }
        }

        private void btnActualizarCombo_Click(object sender, EventArgs e)
        {
            var currentRow = gridTicket.CurrentCell.RowIndex;
            DataGridViewRow selectedRow = gridTicket.Rows[currentRow];
            int nroTicket = int.Parse(gridTicket.Rows[currentRow].Cells[0].Value.ToString());
            Main.main1.btnDetalleVentaEntradas(nroTicket);
        }
    }
}

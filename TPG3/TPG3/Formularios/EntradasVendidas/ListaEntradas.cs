using System.Data;
using TPG3.AccesoADatos;
using TPG3.Entidades;

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
            int nroTicket = int.Parse(gridTicket.Rows[currentRow].Cells[0].Value.ToString());
            DateTime fechaVenta = DateTime.Parse(gridTicket.Rows[currentRow].Cells[1].Value.ToString());
            int codMedioPago = int.Parse(gridTicket.Rows[currentRow].Cells[2].Value.ToString());           
            string medioPago = (gridTicket.Rows[currentRow].Cells[3].Value.ToString());
            float precio = float.Parse(gridTicket.Rows[currentRow].Cells[4].Value.ToString());
            string empleado = gridTicket.Rows[currentRow].Cells[5].Value.ToString() + " " + (gridTicket.Rows[currentRow].Cells[6].Value.ToString());
            string promo = gridTicket.Rows[currentRow].Cells[7].Value.ToString();
            float valorPromo = float.Parse(gridTicket.Rows[currentRow].Cells[8].Value.ToString());
            Ticket ticket = new Ticket(nroTicket, fechaVenta, codMedioPago, -1, -1, promo, valorPromo);
            ReporteTicket reporte = new ReporteTicket(medioPago, precio,empleado);
            Main.main1.btnDetalleVentaEntradas(ticket, reporte);
        }
    }
}

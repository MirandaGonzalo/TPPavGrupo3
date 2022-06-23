using System;
using System.Data;
using System.Windows.Forms;
using TPG3.AccesoADatos;
using TPG3.Entidades;

namespace TPG3.Formularios.EntradasVendidas
{
    public partial class DetalleVentaEntradas : Form
    {
        Ticket ticket = new Ticket();
        ReporteTicket reporte = new ReporteTicket();
        public DetalleVentaEntradas(Ticket ticket, ReporteTicket reporte)
        {
            this.ticket = ticket;
            this.reporte = reporte;
            InitializeComponent();
        }

        private void DetalleVentaEntradas_Load(object sender, EventArgs e)
        {
            cargarGrilla();
            cargarDatosTicket();
        }

        private void cargarDatosTicket()
        {
            lblSala.Text = AD_Sala.ObtenerSalaFromTicket(ticket.nroTicket);
            lblEmpleado.Text = reporte.empleado;
            lblDescuento.Text = ticket.promocion.ToString();
            lblFechaVenta.Text = ticket.fechaHoraVenta.ToString();
            lblMedio.Text = reporte.medioPago.ToString();
            var totalSinDescuento = obtenerPrecioSinDescuento();
            lblPrecioSinDescuento.Text = totalSinDescuento.ToString();
            lblPrecioFinal.Text = (totalSinDescuento - ticket.promocion).ToString();
        }

        private float obtenerPrecioSinDescuento()
        {
            float total = 0;
            for (int i = 0; i < dgvEntradas.Rows.Count; i++)
            {
                total += float.Parse(dgvEntradas.Rows[i].Cells[4].Value.ToString());
            }

            return total;
        }

        private void cargarGrilla()
        {
            try
            {
                dgvEntradas.DataSource = AD_Entrada.ObtenerEntradasTicket(ticket.nroTicket);
            }
            catch (Exception)
            {
                MessageBox.Show("Error al obtener los listados de origenes.");
            }
        }

        private void btnListaTickets_Click(object sender, EventArgs e)
        {
            Main.main1.btnEntradasVendidas_Click(sender, e);
        }
    }
}

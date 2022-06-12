using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using TPG3.AccesoADatos;
namespace TPG3.Formularios.EntradasVendidas
{
    public partial class DetalleVentaEntradas : Form
    {
        int nroTicket;
        public DetalleVentaEntradas(int ticket)
        {
            this.nroTicket = ticket;
            InitializeComponent();
        }

        private void DetalleVentaEntradas_Load(object sender, EventArgs e)
        {
            cargarGrilla();
            lblSala.Text = AD_Sala.ObtenerSalaFromTicket(nroTicket);
        }

        private void cargarGrilla()
        {
            try
            {
                dataGridView1.DataSource = AD_Entrada.ObtenerEntradasTicket(nroTicket);
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

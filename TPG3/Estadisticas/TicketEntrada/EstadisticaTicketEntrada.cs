using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPG3.AccesoADatos;

namespace ProbandoMigrar.Estadisticas.TicketEntrada
{
    public partial class EstadisticaTicketEntrada : Form
    {
        public EstadisticaTicketEntrada()
        {
            InitializeComponent();
        }

        private void EstadisticaTicketEntrada_Load(object sender, EventArgs e)
        {

            this.rpvEntradas.RefreshReport();
            ReportParameter rp = new ReportParameter("ReportParameter1", " ");
            rpvEntradas.LocalReport.SetParameters(rp);
            rpvEntradas.RefreshReport();
        }

        private void visibleFechas(bool visible)
        {
            mtbDesde.Visible = visible;
            mtbHasta.Visible = visible;
        }

        private void rbSala_CheckedChanged(object sender, EventArgs e)
        {
            visibleFechas(false);
        }

        private void rbTarifa_CheckedChanged(object sender, EventArgs e)
        {
            visibleFechas(false);
        }

        private void rdbMedioPago_CheckedChanged(object sender, EventArgs e)
        {
            visibleFechas(false);
        }

        private void rbPelicula_CheckedChanged(object sender, EventArgs e)
        {
            visibleFechas(false);
        }

        private void rbFechaVenta_CheckedChanged(object sender, EventArgs e)
        {
            visibleFechas(true);
        }

        private void btnBuscarFuncion_Click(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            string alcance = "Alcance: ";
            if (rbSala.Checked)
            {
                table = AD_Entrada.ObtenerEntradaEstadisticaSala();
                alcance += "Entradas vendidas por sala.";
            }
            else
            {
                if (rbTarifa.Checked)
                {
                    table = AD_Entrada.ObtenerEntradaEstadisticaTarifa();
                    alcance += "Tarifas solicitadas durante la venta de entradas.";
                }
                else
                {
                    if (rbMedioPago.Checked)
                    {
                        table = AD_Entrada.ObtenerEntradaEstadisticaMedioPago();
                        alcance += "Medios de Pago solicitados durante la venta de entradas.";
                    }
                    else
                    {
                        if (rbPelicula.Checked)
                        {
                            table = AD_Entrada.ObtenerEntradaEstadisticaPelicula();
                            alcance += "Entradas vendidas por película";
                        }
                        else
                        {
                            var fechaD = mtbDesde.Text;
                            var desde = DateTime.Parse(fechaD);
                            var fechaH = mtbHasta.Text;
                            var hasta = DateTime.Parse(fechaH);
                            table = AD_Entrada.ObtenerEntradaEstadisticaEntre(desde, hasta);
                            alcance += "Entradas vendidas entre el " + fechaD + " y " + fechaH + ".";

                        }
                        //lblAlcanceFuncion.Text = "Listado de todas las funciones entre " + desde.ToString() + " y " + hasta.ToString();
                    }
                }

            }


            ReportDataSource ds = new ReportDataSource("DataSetEstadisticaEntrada", table);
            rpvEntradas.LocalReport.DataSources.Clear();
            rpvEntradas.LocalReport.DataSources.Add(ds);
            ReportParameter rp = new ReportParameter("ReportParameter1", alcance);
            rpvEntradas.LocalReport.SetParameters(rp);
            rpvEntradas.RefreshReport();
        }
    }
}

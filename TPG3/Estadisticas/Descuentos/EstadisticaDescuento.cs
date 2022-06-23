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

namespace ProbandoMigrar.Estadisticas.Descuentos
{
    public partial class EstadisticaDescuento : Form
    {
        public EstadisticaDescuento()
        {
            InitializeComponent();
        }

        private void rdbTodosDescuentos_CheckedChanged(object sender, EventArgs e)
        {
            mtbDesde.Visible = false;
            mtbHasta.Visible = false;
        }

        private void rbPeríodo_CheckedChanged(object sender, EventArgs e)
        {
            mtbDesde.Visible = true;
            mtbHasta.Visible = true;
        }

        private void btnBuscarFuncion_Click(object sender, EventArgs e)
        {
            string alcance = "Alcance: ";
            DataTable table = new DataTable();
            if (rbTodosDescuentos.Checked)
            {
                table = AD_Entrada.ObtenerEntradasEstadistica();
                alcance += " Todos los descuentos aplicados en la venta de Entradas por película.";
            }
            else
            {
                var fechaD = mtbDesde.Text;
                var fechaH = mtbHasta.Text;
                var desde = DateTime.Parse(fechaD);
                var hasta = DateTime.Parse(fechaH);
                table = AD_Entrada.ObtenerEntradasEstadisticaEntre(desde, hasta);
                alcance += " Todos los descuentos aplicados entre el " + desde.ToString() + " y el " + hasta.ToString() + ".";
            }
            ReportDataSource ds = new ReportDataSource("DataSetEstadisticaDescuento", table);
            rpvDescuento.LocalReport.DataSources.Clear();
            rpvDescuento.LocalReport.DataSources.Add(ds);
            //rpvDescuento.RefreshReport();
            ReportParameter rp = new ReportParameter("ReportParameter1", alcance);
            rpvDescuento.LocalReport.SetParameters(rp);
            rpvDescuento.RefreshReport();
        }

        private void EstadisticaDescuento_Load(object sender, EventArgs e)
        {

            this.rpvDescuento.RefreshReport();
            ReportParameter rp = new ReportParameter("ReportParameter1", " ");
            rpvDescuento.LocalReport.SetParameters(rp);
            rpvDescuento.RefreshReport();
        }
    }
}

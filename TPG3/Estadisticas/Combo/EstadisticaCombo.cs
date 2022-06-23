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
namespace ProbandoMigrar.Estadisticas.Combo
{
    public partial class EstadisticaCombo : Form
    {
        public EstadisticaCombo()
        {
            InitializeComponent();
        }

        private void rbCantItems_CheckedChanged(object sender, EventArgs e)
        {
            mtbDesde.Visible = false;
            mtbHasta.Visible = false;
        }

        private void rbComprados_CheckedChanged(object sender, EventArgs e)
        {
            mtbDesde.Visible = false;
            mtbHasta.Visible = false;
        }

        private void rbPeriodoCompra_CheckedChanged(object sender, EventArgs e)
        {
            mtbDesde.Visible = true;
            mtbHasta.Visible = true;
        }

        private void btnBuscarFuncion_Click(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            var alcance = "Alcance: ";
            if (rbCantItems.Checked)
            {
                table = AD_Combo.GetReporteCombos();
                alcance += "Cantidad de items de cada Combo.";
            }
            else
            {
                if (rbComprados.Checked)
                {
                    table = AD_Combo.GetReporteVentaCombos();
                    alcance += "Cantidad de veces que un Combo fue comprado.";
                }
                else
                {
                    var fechaD = mtbDesde.Text;
                    var fechaH = mtbHasta.Text;
                    var desde = DateTime.Parse(fechaD);
                    var hasta = DateTime.Parse(fechaH);
                    table = AD_Combo.GetReporteVentaCombosEntre(desde, hasta);
                    alcance += "Cantidad de Combos comprados entre " + desde.ToString() + " y " + hasta.ToString();
                }
            }
            ReportDataSource ds = new ReportDataSource("DataSetEstadisticaCombo", table);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(ds);
            //reportViewer1.RefreshReport();
            ReportParameter rp = new ReportParameter("ReportParameter1", alcance);
            reportViewer1.LocalReport.SetParameters(rp);
            reportViewer1.RefreshReport();
        }

        private void EstadisticaCombo_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
            ReportParameter rp = new ReportParameter("ReportParameter1", "");
            reportViewer1.LocalReport.SetParameters(rp);
            reportViewer1.RefreshReport();
        }
    }
}



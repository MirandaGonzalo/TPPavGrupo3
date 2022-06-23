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

namespace ProbandoMigrar.Estadisticas.Formato
{
    public partial class EstadisticaFormato : Form
    {
        public EstadisticaFormato()
        {
            InitializeComponent();
        }

        private void EstadisticaFormato_Load(object sender, EventArgs e)
        {

            this.rpvFormato.RefreshReport();
        }

        private void btnBuscarFuncion_Click(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            string alcance = "Alcance: ";
            if (rbCantEntradas.Checked)
            {
                tabla = AD_Formato.ObtenerFormatoReporteCantidad();
                alcance += "Cantidad de entradas vendidas por Formato";
            }
            else
            {
                if (rbRecaudado.Checked)
                {
                    tabla = AD_Formato.ObtenerFormatoReporteRecaudado();
                    alcance += "Cantidad de dinero recaudado por Formato";
                }
                else
                {
                    var desde = mtbDesde.Text;
                    var hasta = mtbHasta.Text;
                    var fechaDesde = DateTime.Parse(desde);
                    var fechaHasta = DateTime.Parse(hasta);
                    tabla = AD_Formato.ObtenerFormatoReporteRecaudadoEntre(fechaDesde, fechaHasta);
                    alcance += "Cantidad de dinero recaudado por Formato entre el " + desde + " y el " + hasta;
                }
            }

            ReportDataSource ds = new ReportDataSource("DataSetEstadisticaFormato", tabla);
            rpvFormato.LocalReport.DataSources.Clear();
            rpvFormato.LocalReport.DataSources.Add(ds);
            ReportParameter rp = new ReportParameter("ReportParameter1", alcance);
            rpvFormato.LocalReport.SetParameters(rp);
            rpvFormato.RefreshReport();
        }

        private void rbCantEntradas_CheckedChanged(object sender, EventArgs e)
        {
            mtbDesde.Visible = false;
            mtbHasta.Visible = false;
        }

        private void rbRecaudado_CheckedChanged(object sender, EventArgs e)
        {
            mtbDesde.Visible = false;
            mtbHasta.Visible = false;
        }

        private void rbRecaudadoPeriodo_CheckedChanged(object sender, EventArgs e)
        {
            mtbDesde.Visible = true;
            mtbHasta.Visible = true;
        }
    }
}

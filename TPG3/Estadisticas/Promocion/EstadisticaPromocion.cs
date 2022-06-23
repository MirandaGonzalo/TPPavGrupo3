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

namespace ProbandoMigrar.Estadisticas.Promocion
{
    public partial class EstadisticaPromocion : Form
    {
        public EstadisticaPromocion()
        {
            InitializeComponent();
        }

        private void rbTodasPromos_CheckedChanged(object sender, EventArgs e)
        {
            mtbDesde.Visible = false;
            mtbHasta.Visible = false;
        }

        private void rbFechaVenta_CheckedChanged(object sender, EventArgs e)
        {
            mtbDesde.Visible = true;
            mtbHasta.Visible = true;
        }

        private void btnBuscarFuncion_Click(object sender, EventArgs e)
        {
            string alcance = "Alcance: ";
            DataTable table = new DataTable();
            if (rbTodasPromos.Checked)
            {
                table = AD_Promocion.ObtenerTablaReportePromocion();
                alcance += " Distribución del uso de Promociones en todas las ventas";
            }
            else
            {
                var fechaD = mtbDesde.Text;
                var fechaH = mtbHasta.Text;
                var desde = DateTime.Parse(fechaD);
                var hasta = DateTime.Parse(fechaH);
                table = AD_Promocion.ObtenerTablaReportePromocionEntre(desde, hasta);
                alcance += " Distribución del uso de Promociones en todas las ventas desde el " + fechaD + " hasta el" + fechaH ;
            }
            ReportDataSource ds = new ReportDataSource("DataSetEstadisticaPromocion", table);
            rpvPromocion.LocalReport.DataSources.Clear();
            rpvPromocion.LocalReport.DataSources.Add(ds);
            ReportParameter rp = new ReportParameter("ReportParameter1", alcance);
            rpvPromocion.LocalReport.SetParameters(rp);
            rpvPromocion.RefreshReport();

        }

        private void EstadisticaPromocion_Load(object sender, EventArgs e)
        {

            this.rpvPromocion.RefreshReport();
            ReportParameter rp = new ReportParameter("ReportParameter1", " ");
            rpvPromocion.LocalReport.SetParameters(rp);
            rpvPromocion.RefreshReport();
        }
    }
}

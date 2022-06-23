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

namespace ProbandoMigrar.Estadisticas.Empleado
{
    public partial class EstadisticaEmpleado : Form
    {
        public EstadisticaEmpleado()
        {
            InitializeComponent();
        }

        private void rbVentasEntradas_CheckedChanged(object sender, EventArgs e)
        {
            mtbDesde.Visible = false;
            mtbHasta.Visible = false;
        }

        private void rbPeríodo_CheckedChanged(object sender, EventArgs e)
        {
            mtbDesde.Visible = false;
            mtbHasta.Visible = false;
        }

        private void rbPeriodoEntradas_CheckedChanged(object sender, EventArgs e)
        {
            mtbDesde.Visible = true;
            mtbHasta.Visible = true;
        }

        private void EstadisticaEmpleado_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
            ReportParameter rp = new ReportParameter("ReportParameter1", "");
            reportViewer1.LocalReport.SetParameters(rp);
            reportViewer1.RefreshReport();
        }

        private void btnBuscarFuncion_Click(object sender, EventArgs e)
        {
            string alcance = "Alcance: ";
            DataTable table = new DataTable();
            if (rbVentasEntradas.Checked)
            {
                table = AD_Empleado.ObtenerReporteEmpleadoVenta();
                alcance += "Porcentaje de ventas realizadas por cada Empleado sobre el total de Ventas realizadas.";
            }
            else
            {
                if (rbTipoDoc.Checked)
                {
                    table = AD_Empleado.ObtenerReporteEmpleadoTipoDoc();
                    alcance += "Tipos de Documentos utilizados por los empleados.";
                }
                else
                {
                    var fechaD = mtbDesde.Text;
                    var fechaH = mtbHasta.Text;
                    var desde = DateTime.Parse(fechaD);
                    var hasta = DateTime.Parse(fechaH);
                    table = AD_Empleado.ObtenerReporteEmpleadoVentaEntre(desde, hasta);
                    alcance += "Empleados que participaron en ventas de Entradas entre el " + desde.ToString() + " y el " + hasta.ToString();
                }
            }
            ReportDataSource ds = new ReportDataSource("DataSetEstadisticaEmpleado", table);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(ds);
            ReportParameter rp = new ReportParameter("ReportParameter1", alcance);
            reportViewer1.LocalReport.SetParameters(rp);
            reportViewer1.RefreshReport();
        }
    }
}

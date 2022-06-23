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

namespace ProbandoMigrar.Reportes.Entrada
{
    public partial class ReporteEntrada : Form
    {
        public ReporteEntrada()
        {
            InitializeComponent();
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            if (rdbTodasEntradas.Checked)
            {
                table = AD_Entrada.ObtenerEntradasReporte();
                txtLeyendaTarifa.Text = "Listado de todas las entradas";
            }
            else
            {
                float desde = -1;
                float hasta = -1;
                if (rdbPrecioUnitario.Checked)
                {
                    desde = float.Parse(mtbDesde.Text);
                    if (rdbMayorQue.Checked)
                    {
                        table = AD_Entrada.ObtenerEntradasReporteMayor(desde);
                        txtLeyendaTarifa.Text = "Listado de todas las entradas con precio mayor a " + desde.ToString();

                    }
                    else
                    {
                        if (rdbMenorQue.Checked)
                        {
                            table = AD_Entrada.ObtenerEntradasReporteMenor(desde);
                            txtLeyendaTarifa.Text = "Listado de todas las entradas con precio menor a " + desde.ToString();
                        }
                        else
                        {
                            hasta = float.Parse(mtbHasta.Text);
                            table = AD_Entrada.ObtenerEntradasReporteEntre(desde, hasta);
                            txtLeyendaTarifa.Text = "Listado de todas las entradas con precio entre " + desde.ToString() + " y " + hasta.ToString();
                        }
                    }

                }
                else
                {
                    DateTime fechaD = DateTime.Parse(mtbFechaDesde.Text);
                    DateTime fechaH = DateTime.Parse(mtbFechaHasta.Text);
                    table = AD_Entrada.ObtenerEntradasReporteEntreFecha(fechaD, fechaH);
                    txtLeyendaTarifa.Text = "Listado de todas las entradas con fecha entre " + fechaD.ToString() + " y " + fechaH.ToString();
                }

            }

            ReportDataSource ds = new ReportDataSource("DataSetEntrada", table);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(ds);
            reportViewer1.RefreshReport();
        }

        private void ReporteEntrada_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void rdbPrecioUnitario_CheckedChanged(object sender, EventArgs e)
        {
            rdbMayorQue.Visible = true;
            rdbEntre.Visible = true;
            rdbMenorQue.Visible = true;
            mtbDesde.Visible = true;
            mtbFechaDesde.Visible = false;
            mtbFechaHasta.Visible = false;
        }

        private void rdbFormato_CheckedChanged(object sender, EventArgs e)
        {
            rdbMayorQue.Visible = false;
            rdbEntre.Visible = false;
            rdbMenorQue.Visible = false;
            mtbDesde.Visible = false;
            mtbHasta.Visible = false;
            mtbFechaDesde.Visible = true;
            mtbFechaHasta.Visible = true;
        }

        private void rdbTodasEntradas_CheckedChanged(object sender, EventArgs e)
        {
            rdbMayorQue.Visible = false;
            rdbEntre.Visible = false;
            rdbMenorQue.Visible = false;
            mtbDesde.Visible = false;
            mtbHasta.Visible = false;
            mtbFechaDesde.Visible = false;
            mtbFechaHasta.Visible = false;
        }

        private void rdbEntre_CheckedChanged(object sender, EventArgs e)
        {
            mtbHasta.Visible = true;
        }

        private void rdbMayorQue_CheckedChanged(object sender, EventArgs e)
        {
            mtbHasta.Visible = false;
        }

        private void rdbMenorQue_CheckedChanged(object sender, EventArgs e)
        {
            mtbHasta.Visible = false;
        }
    }
}

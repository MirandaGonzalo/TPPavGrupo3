using Microsoft.Reporting.WinForms;
using ProbandoMigrar.AccesoADatos;
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

namespace ProbandoMigrar.Estadisticas.PrecioDescuento
{
    public partial class EstadisticaPrecioDescuento : Form
    {
        public EstadisticaPrecioDescuento()
        {
            InitializeComponent();
        }

        private void EstadisticaPrecioDescuento_Load(object sender, EventArgs e)
        {

            this.rpvPrecioDescuento.RefreshReport();
        }

        private void btnBuscarFuncion_Click(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            string alcance = "Alcance: ";
            if (rbEntradas.Checked)
            {
                tabla = AD_PrecioDescuento.ObtenerPrecioEntradaDesc();
                alcance += " Comparación entre el PrecioInicial y el PrecioFinal de la venta de todas las entradas.";
            }
            else
            {

                if (rbCombos.Checked)
                {
                    tabla = AD_PrecioDescuento.ObtenerPrecioComboDesc();
                    alcance += " Comparación entre el PrecioInicial y el PrecioFinal de la venta de todos los combos.";
                }
                else
                {
                    var fechaD = mtbDesde.Text;
                    var fechaH = mtbHasta.Text;
                    var desde = DateTime.Parse(fechaD);
                    var hasta = DateTime.Parse(fechaH);
                    if (rbPeriodoEntrada.Checked)
                    {
                        tabla = AD_PrecioDescuento.ObtenerPrecioEntradaDescEntre(desde, hasta);
                        alcance += " Comparación entre el PrecioInicial y el PrecioFinal de la venta de todas las entradas entre el" + fechaD + " y el " + fechaH;
                    }
                    else
                    {
                        tabla = AD_PrecioDescuento.ObtenerPrecioComboDescEntre(desde, hasta);
                        alcance += " Comparación entre el PrecioInicial y el PrecioFinal de la venta de todos los combos entre el" + fechaD + " y el " + fechaH;
                    }
                }
            }
            ReportDataSource ds = new ReportDataSource("DataSetPrecioDescuento", tabla);
            rpvPrecioDescuento.LocalReport.DataSources.Clear();
            rpvPrecioDescuento.LocalReport.DataSources.Add(ds);
            ReportParameter rp = new ReportParameter("ReportParameter1", alcance);
            rpvPrecioDescuento.LocalReport.SetParameters(rp);
            rpvPrecioDescuento.RefreshReport();
        }

        private void rbEntradas_CheckedChanged(object sender, EventArgs e)
        {
            mtbDesde.Visible = false;
            mtbHasta.Visible = false;
        }

        private void rbCombos_CheckedChanged(object sender, EventArgs e)
        {
            mtbDesde.Visible = false;
            mtbHasta.Visible = false;
        }

        private void rbPeriodoEntrada_CheckedChanged(object sender, EventArgs e)
        {
            mtbDesde.Visible = true;
            mtbHasta.Visible = true;
        }

        private void rbPeriodoCombo_CheckedChanged(object sender, EventArgs e)
        {
            mtbDesde.Visible = true;
            mtbHasta.Visible = true;
        }
    }
}

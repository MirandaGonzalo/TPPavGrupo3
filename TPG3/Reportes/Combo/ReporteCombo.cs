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

namespace ProbandoMigrar.Reportes
{
    public partial class ReporteCombo : Form
    {
        public ReporteCombo()
        {
            InitializeComponent();
        }

        private void ReporteCombo_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            //DataTable table = new DataTable();
            //table = AD_Combo.ObtenerCombo();
            //ReportDataSource ds = new ReportDataSource("DataSetCombo", table);
            //reportViewer1.LocalReport.DataSources.Clear();
            //reportViewer1.LocalReport.DataSources.Add(ds);
            //reportViewer1.RefreshReport();
        }

        private void opcionesFiltros(bool visible)
        {
            rdbMayor.Visible = visible;
            rdbEntre.Visible = visible;
            rdbMenor.Visible = visible;
            mtbDesde.Visible = visible;
        }

        private void rdbTodosCombos_CheckedChanged(object sender, EventArgs e)
        {
            opcionesFiltros(false);
            mtbHasta.Visible = false;
        }

        private void rdbPrecio_CheckedChanged(object sender, EventArgs e)
        {
            opcionesFiltros(true);
            if (rdbEntre.Checked) mtbHasta.Visible = true;
        }

        private void rdbCantItems_CheckedChanged(object sender, EventArgs e)
        {
            opcionesFiltros(true);
            if (rdbEntre.Checked) mtbHasta.Visible = true;
        }

        private void rdbMayor_CheckedChanged(object sender, EventArgs e)
        {
            mtbHasta.Visible = false;
        }

        private void rdbMenor_CheckedChanged(object sender, EventArgs e)
        {
            mtbHasta.Visible = false;
        }

        private void rdbEntre_CheckedChanged(object sender, EventArgs e)
        {
            mtbHasta.Visible = true;
        }

        private void btnBuscarCombo_Click(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            if (rdbTodosCombos.Checked)
            {
                table = AD_Combo.ObtenerCombo();
                txtLeyendaCombo.Text = "Listado de todos los combos";
            }
            else
            {
                float desde = float.Parse(mtbDesde.Text);
                float hasta = -1;
                if (rdbPrecio.Checked)
                {
                    if (rdbMayor.Checked)
                    {
                        table = AD_Combo.ObtenerComboPrecioMayorQue(desde);
                        txtLeyendaCombo.Text = "Listado de todos los combos con precio mayor a " + desde.ToString();
                    }
                    else
                    {
                        if (rdbMenor.Checked)
                        {
                            table = AD_Combo.ObtenerComboPrecioMenorQue(desde);
                            txtLeyendaCombo.Text = "Listado de todos los combos con precio menor a " + desde.ToString();
                        }
                        else
                        {
                            hasta = float.Parse(mtbHasta.Text);
                            table = AD_Combo.ObtenerComboPrecioEntre(desde, hasta);
                            txtLeyendaCombo.Text = "Listado de todos los combos con precio entre " + desde.ToString() + " y " + hasta.ToString();
                        }
                    }
                    
                }
                else
                {
                    if (rdbMayor.Checked)
                    {
                        table = AD_Combo.ObtenerComboCantidadMayorQue(desde);
                        txtLeyendaCombo.Text = "Listado de todos los combos con una cantidad de items mayor a " + desde.ToString();
                    }
                    else
                    {
                        if (rdbMenor.Checked)
                        {
                            table = AD_Combo.ObtenerComboCantidadMenorQue(desde);
                            txtLeyendaCombo.Text = "Listado de todos los combos con una cantidad de items menor a " + desde.ToString();
                        }
                        else
                        {
                            hasta = float.Parse(mtbHasta.Text);
                            table = AD_Combo.ObtenerComboCantidadEntre(desde, hasta);
                            txtLeyendaCombo.Text = "Listado de todos los combos con una cantidad de items mayor entre " + desde.ToString() + " y " + hasta.ToString(); ;
                        }
                    }
                }
            }

            ReportDataSource ds = new ReportDataSource("DataSetCombo", table);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(ds);
            reportViewer1.RefreshReport();
        }
    }
}

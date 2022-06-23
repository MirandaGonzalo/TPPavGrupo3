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

namespace ProbandoMigrar.Reportes.Tarifa
{
    public partial class ReporteTarifa : Form
    {
        public ReporteTarifa()
        {
            InitializeComponent();
        }

        private void ReporteTarifa_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSetFormato.Formato' Puede moverla o quitarla según sea necesario.
            this.formatoTableAdapter.Fill(this.dataSetFormato.Formato);

            //this.rvTarifa.RefreshReport();
            this.rvTarifa.RefreshReport();
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            if (rdbTodosTarifas.Checked)
            {
                table = AD_Tarifa.ObtenerTablaTarifaReporte();
                txtLeyendaTarifa.Text = "Listado de todas las tarifas";                
            }
            else
            {
                float desde = -1;
                float hasta = -1;
                if (rdbPrecio.Checked)
                {
                    desde = float.Parse(mtbDesde.Text);
                    if (rdbMayorQue.Checked)
                    {
                        table = AD_Tarifa.ObtenerTarifaPrecioMayorQue(desde);
                        txtLeyendaTarifa.Text = "Listado de todas las tarifas con precio mayor a " + desde.ToString();

                    }
                    else
                    {
                        if (rdbMenorQue.Checked)
                        {
                            table = AD_Tarifa.ObtenerTarifaPrecioMenorQue(desde);
                            txtLeyendaTarifa.Text = "Listado de todas las tarifas con precio menor a " + desde.ToString();
                        }
                        else
                        {
                            hasta = float.Parse(mtbHasta.Text);
                            table = AD_Tarifa.ObtenerTarifasPrecioEntre(desde, hasta);
                            txtLeyendaTarifa.Text = "Listado de todas las tarifas con precio entre " + desde.ToString() + " y " + hasta.ToString();
                        }
                    }

                }
                else
                {
                    int tipoProd = (int)cbFormato.SelectedValue;
                    string descriT = cbFormato.SelectedText;
                    table = AD_Tarifa.ObtenerTablaReporteFormato(tipoProd);
                    txtLeyendaTarifa.Text = "Listado de todas las tarifas con formato " + descriT;

                }

            }

            ReportDataSource ds = new ReportDataSource("DataSetTarifa", table);
            rvTarifa.LocalReport.DataSources.Clear();
            rvTarifa.LocalReport.DataSources.Add(ds);
            rvTarifa.RefreshReport();
        }

        private void rdbTodosTarifas_CheckedChanged(object sender, EventArgs e)
        {
            rdbMayorQue.Visible = false;
            rdbMenorQue.Visible = false;
            rdbEntre.Visible = false;
            mtbDesde.Visible = false;
            mtbHasta.Visible = false;
            cbFormato.Visible = false;

        }

        private void rdbPrecio_CheckedChanged(object sender, EventArgs e)
        {
            rdbMayorQue.Visible = true;
            rdbMenorQue.Visible = true;
            rdbEntre.Visible = true;
            mtbDesde.Visible = true;
            mtbHasta.Visible = false;
            cbFormato.Visible = false;
        }

        private void rdbMayorQue_CheckedChanged(object sender, EventArgs e)
        {
            mtbHasta.Visible = false;
        }

        private void rdbMenorQue_CheckedChanged(object sender, EventArgs e)
        {
            mtbHasta.Visible = false;
        }

        private void rdbEntre_CheckedChanged(object sender, EventArgs e)
        {
            mtbHasta.Visible = true;
        }

        private void rdbFormato_CheckedChanged(object sender, EventArgs e)
        {
            rdbMayorQue.Visible = false;
            rdbMenorQue.Visible = false;
            rdbEntre.Visible = false;
            mtbDesde.Visible = false;
            mtbHasta.Visible = false;
            cbFormato.Visible = true;
        }
    }
}

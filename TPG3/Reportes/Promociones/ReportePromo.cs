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

namespace ProbandoMigrar.Reportes.Promociones
{
    public partial class ReportePromo : Form
    {
        public ReportePromo()
        {
            InitializeComponent();
        }

        private void ReportePromo_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void rdbTodasPromociones_CheckedChanged(object sender, EventArgs e)
        {
            rdbMayorQue.Visible = false;
            rdbMenorQue.Visible = false;
            rdbEntre.Visible = false;
            mtbDesde.Visible = false;
            mtbHasta.Visible = false;
            txtNombre.Visible = false;
            mtbDesdeVigencia.Visible = false;
            mtbHastaVigencia.Visible = false;
        }

        private void rdbPrecio_CheckedChanged(object sender, EventArgs e)
        {
            rdbMayorQue.Visible = true;
            rdbMenorQue.Visible = true;
            rdbEntre.Visible = true;
            mtbDesde.Visible = true;
            mtbHasta.Visible = false;
            txtNombre.Visible = false;
            mtbDesdeVigencia.Visible = false;
            mtbHastaVigencia.Visible = false;
        }

        private void rdbNombre_CheckedChanged(object sender, EventArgs e)
        {
            rdbMayorQue.Visible = false;
            rdbMenorQue.Visible = false;
            rdbEntre.Visible = false;
            mtbDesde.Visible = false;
            mtbHasta.Visible = false;
            txtNombre.Visible = true;
            mtbDesdeVigencia.Visible = false;
            mtbHastaVigencia.Visible = false;
        }

        private void rdbVigencia_CheckedChanged(object sender, EventArgs e)
        {
            rdbMayorQue.Visible = false;
            rdbMenorQue.Visible = false;
            rdbEntre.Visible = false;
            mtbDesde.Visible = false;
            mtbHasta.Visible = false;
            txtNombre.Visible = false;
            mtbDesdeVigencia.Visible = true;
            mtbHastaVigencia.Visible = true;
        }

        private void rdbMayorQue_CheckedChanged(object sender, EventArgs e)
        {
            mtbHasta.Visible = false;
        }

        private void rdbEntre_CheckedChanged(object sender, EventArgs e)
        {
            mtbHasta.Visible = true;
        }

        private void rdbMenorQue_CheckedChanged(object sender, EventArgs e)
        {
            mtbHasta.Visible = false;
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            if (rdbTodasPromociones.Checked)
            {
                table = AD_Promocion.ObtenerPromocion();
                lblHistoriaPromocion.Text = "Listado de todas las promociones";
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
                        table = AD_Promocion.GetPromocionPrecioMayorQue(desde);
                        lblHistoriaPromocion.Text = "Listado de todas las promociones con precio mayor a " + desde.ToString();

                    }
                    else
                    {
                        if (rdbMenorQue.Checked)
                        {
                            table = AD_Promocion.GetPromocionPrecioMenorQue(desde);
                            lblHistoriaPromocion.Text = "Listado de todas las promociones con precio menor a " + desde.ToString();
                        }
                        else
                        {
                            hasta = float.Parse(mtbHasta.Text);
                            table = AD_Promocion.GetPromocionPrecioEntre(desde, hasta);
                            lblHistoriaPromocion.Text = "Listado de todas las promociones con precio entre " + desde.ToString() + " y " + hasta.ToString();
                        }
                    }

                }
                else
                {
                    if (rdbNombre.Checked)
                    {
                        string nombre = txtNombre.Text;
                        table = AD_Promocion.GetPromocionNombre(nombre);
                        lblHistoriaPromocion.Text = "Listado de todas las promociones con el nombre " + nombre;
                    }
                    else
                    {
                        DateTime desdeV = DateTime.Parse(mtbDesdeVigencia.Text);
                        DateTime hastaV = DateTime.Parse(mtbHastaVigencia.Text);
                        table = AD_Promocion.GetPromocionVigencia(desdeV, hastaV);
                        lblHistoriaPromocion.Text = "Listado de todas las promociones vigentes entre " + desdeV.ToString() + " hasta " + hastaV.ToString();
                    }
                }
                

            }

            ReportDataSource ds = new ReportDataSource("DataSetPromocion", table);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(ds);
            reportViewer1.RefreshReport();
        }
    }
}

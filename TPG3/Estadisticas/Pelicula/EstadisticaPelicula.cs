using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using TPG3.AccesoADatos;

namespace ProbandoMigrar.Estadisticas.Pelicula
{
    public partial class EstadisticaPelicula : Form
    {
        public EstadisticaPelicula()
        {
            InitializeComponent();
        }

        private void EstadisticaPelicula_Load(object sender, EventArgs e)
        {

            this.rpvPeliculas.RefreshReport();
            ReportParameter rp = new ReportParameter("ReportParameter1", " ");
            rpvPeliculas.LocalReport.SetParameters(rp);
            rpvPeliculas.RefreshReport();
        }

        private void btnBuscarPelicula_Click(object sender, EventArgs e)
        {
            string alcance = "Alcance: ";
            DataTable table = new DataTable();
            if (rdbTodasPeliculas.Checked)
            {
                table = AD_Pelicula.ObtenerTablaReporteEstreno();
                alcance += " Películas estrenadas por año";
            }
            else
            {
                if (rbDistribuidora.Checked)
                {
                    table = AD_Pelicula.ObtenerTablaReporteDistribuidora();
                    alcance += " Cantidad de Películas por Distribuidora.";
                }
                else
                {
                    if (rbCalificacion.Checked)
                    {

                        table = AD_Pelicula.ObtenerTablaReporteCalificacion();
                        alcance += " Calificaciones de todas las películas.";
                    }
                    else
                    {
                        table = AD_Pelicula.ObtenerTablaReporteOrigen();
                        alcance += " Cantidad de películas por origen.";
                    }
                }

            }


            ReportDataSource ds = new ReportDataSource("DataSetEstadisticaPelicula", table);
            rpvPeliculas.LocalReport.DataSources.Clear();
            rpvPeliculas.LocalReport.DataSources.Add(ds);
            ReportParameter rp = new ReportParameter("ReportParameter1", alcance);
            rpvPeliculas.LocalReport.SetParameters(rp);
            rpvPeliculas.RefreshReport();
        }
    }
}

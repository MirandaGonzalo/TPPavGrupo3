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

namespace ProbandoMigrar.Reportes.Funcion
{
    public partial class ReporteFuncion : Form
    {
        public ReporteFuncion()
        {
            InitializeComponent();
        }

        private void ReporteFuncion_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSetListadoPeliculas.Pelicula' Puede moverla o quitarla según sea necesario.
            this.peliculaTableAdapter.Fill(this.dataSetListadoPeliculas.Pelicula);
            // TODO: esta línea de código carga datos en la tabla 'dataSetListadoSala.Sala' Puede moverla o quitarla según sea necesario.
            this.salaTableAdapter.Fill(this.dataSetListadoSala.Sala);

            this.reportViewer1.RefreshReport();
        }

        private void btnBuscarCombo_Click(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            if (rdbTodasFunciones.Checked)
            {
                table = AD_Funcion.ObtenerTablaFuncion();
                lblAlcanceFuncion.Text = "Listado de todas las funciones";
            }
            else
            {
                if (rdnSala.Checked)
                {
                    int sala = (int)cmbSala.SelectedValue;
                    table = AD_Funcion.ObtenerTablaFuncionesSala(sala);
                    lblAlcanceFuncion.Text = "Listado de todas las funciones de la sala " + sala.ToString();
                }
                else
                {
                    if (rdbPelicula.Checked)
                    {
                        int codPelicula = (int)cmbPelicula.SelectedValue;
                        string pelicula = cmbPelicula.SelectedText;
                        table = AD_Funcion.ObtenerTablaFuncionesPelicula(codPelicula);
                        lblAlcanceFuncion.Text = "Listado de todas las funciones donde se proyecta " + pelicula;
                    }
                    else
                    {
                        var fechaD = mtbDesde.Text;
                        var fechaH = mtbHasta.Text;
                        var desde = DateTime.Parse(fechaD);
                        var hasta = DateTime.Parse(fechaH);
                        table = AD_Funcion.ObtenerTablaFuncionesFecha(desde, hasta);
                        lblAlcanceFuncion.Text = "Listado de todas las funciones entre " + desde.ToString() + " y " + hasta.ToString();
                    }
                }
            }
            
            
            ReportDataSource ds = new ReportDataSource("DataSetFuncion", table);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(ds);
            reportViewer1.RefreshReport();
        }

        private void rdbTodasFunciones_CheckedChanged(object sender, EventArgs e)
        {
            labelSala.Visible = false;
            labelPelicula.Visible = false;
            cmbSala.Visible = false;
            cmbPelicula.Visible = false;
            mtbDesde.Visible = false;
            mtbHasta.Visible = false;
        }

        private void rdnSala_CheckedChanged(object sender, EventArgs e)
        {
            labelSala.Visible = true;
            labelPelicula.Visible = false;
            cmbSala.Visible = true;
            cmbPelicula.Visible = false;
            mtbDesde.Visible = false;
            mtbHasta.Visible = false;
        }

        private void rdbRangoFecha_CheckedChanged(object sender, EventArgs e)
        {
            labelSala.Visible = false;
            labelPelicula.Visible = false;
            cmbSala.Visible = false;
            cmbPelicula.Visible = false;
            mtbDesde.Visible = true;
            mtbHasta.Visible = true;
        }

        private void rdbPelicula_CheckedChanged(object sender, EventArgs e)
        {
            labelSala.Visible = false;
            labelPelicula.Visible = true;
            cmbSala.Visible = false;
            cmbPelicula.Visible = true;
            mtbDesde.Visible = false;
            mtbHasta.Visible = false;
        }
    }
}

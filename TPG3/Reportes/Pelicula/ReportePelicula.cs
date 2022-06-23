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

namespace ProbandoMigrar.Reportes.Pelicula
{
    public partial class ReportePelicula : Form
    {
        public ReportePelicula()
        {
            InitializeComponent();            
        }

        private void ReportePelicula_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSetDistribuidora.Distribuidora' Puede moverla o quitarla según sea necesario.
            this.distribuidoraTableAdapter.Fill(this.dataSetDistribuidora.Distribuidora);
            // TODO: esta línea de código carga datos en la tabla 'dataSetIdioma.Idioma' Puede moverla o quitarla según sea necesario.
            this.idiomaTableAdapter.Fill(this.dataSetIdioma.Idioma);
            // TODO: esta línea de código carga datos en la tabla 'dataSetGenero.Genero' Puede moverla o quitarla según sea necesario.
            this.generoTableAdapter.Fill(this.dataSetGenero.Genero);
            // TODO: esta línea de código carga datos en la tabla 'dataSetFormato.Formato' Puede moverla o quitarla según sea necesario.
            this.formatoTableAdapter.Fill(this.dataSetFormato.Formato);
            // TODO: esta línea de código carga datos en la tabla 'dataSetCalificacion.Calificacion' Puede moverla o quitarla según sea necesario.
            this.calificacionTableAdapter.Fill(this.dataSetCalificacion.Calificacion);
            // TODO: esta línea de código carga datos en la tabla 'dataSetOrigen.Origen' Puede moverla o quitarla según sea necesario.
            this.origenTableAdapter.Fill(this.dataSetOrigen.Origen);

            this.reportViewer1.RefreshReport();
        }

        private void rdbTodasPeliculas_CheckedChanged(object sender, EventArgs e)
        {
            txtTitulo.Visible = false;
            cbOrigen.Visible = false;
            cbCalificacion.Visible = false;
            cbFormato.Visible = false;
            cbGenero.Visible = false;
            cbDistribuidora.Visible = false;
            cbIdioma.Visible = false;
            lblHelp.Visible = false;
        }

        private void rdbTitulo_CheckedChanged(object sender, EventArgs e)
        {
            txtTitulo.Visible = true;
            cbOrigen.Visible = false;
            cbCalificacion.Visible = false;
            cbFormato.Visible = false;
            cbGenero.Visible = false;
            cbDistribuidora.Visible = false;
            cbIdioma.Visible = false;
            lblHelp.Text = "Título: ";
            lblHelp.Visible = true;
        }

        private void rdborigen_CheckedChanged(object sender, EventArgs e)
        {
            txtTitulo.Visible = false;
            cbOrigen.Visible = true;
            cbCalificacion.Visible = false;
            cbFormato.Visible = false;
            cbGenero.Visible = false;
            cbDistribuidora.Visible = false;
            cbIdioma.Visible = false;
            lblHelp.Text = "Origen: ";
            lblHelp.Visible = true;
        }

        private void rdbCalificacion_CheckedChanged(object sender, EventArgs e)
        {
            txtTitulo.Visible = false;
            cbOrigen.Visible = false;
            cbCalificacion.Visible = true;
            cbFormato.Visible = false;
            cbGenero.Visible = false;
            cbDistribuidora.Visible = false;
            cbIdioma.Visible = false;
            lblHelp.Text = "Calificación: ";
            lblHelp.Visible = true;
        }

        private void rdbFormato_CheckedChanged(object sender, EventArgs e)
        {
            txtTitulo.Visible = false;
            cbOrigen.Visible = false;
            cbCalificacion.Visible = false;
            cbFormato.Visible = true;
            cbGenero.Visible = false;
            cbDistribuidora.Visible = false;
            cbIdioma.Visible = false;
            lblHelp.Text = "Formato: ";
            lblHelp.Visible = true;
        }

        private void rdbGenero_CheckedChanged(object sender, EventArgs e)
        {
            txtTitulo.Visible = false;
            cbOrigen.Visible = false;
            cbCalificacion.Visible = false;
            cbFormato.Visible = false;
            cbGenero.Visible = true;
            cbDistribuidora.Visible = false;
            cbIdioma.Visible = false;
            lblHelp.Text = "Genero: ";
            lblHelp.Visible = true;
        }

        private void rdbDistrbuidora_CheckedChanged(object sender, EventArgs e)
        {
            txtTitulo.Visible = false;
            cbOrigen.Visible = false;
            cbCalificacion.Visible = false;
            cbFormato.Visible = false;
            cbGenero.Visible = false;
            cbDistribuidora.Visible = true;
            cbIdioma.Visible = false;
            lblHelp.Text = "Distribuidora: ";
            lblHelp.Visible = true;
        }

        private void rdbIdioma_CheckedChanged(object sender, EventArgs e)
        {
            txtTitulo.Visible = false;
            cbOrigen.Visible = false;
            cbCalificacion.Visible = false;
            cbFormato.Visible = false;
            cbGenero.Visible = false;
            cbDistribuidora.Visible = false;
            cbIdioma.Visible = true;
            lblHelp.Text = "Idioma: ";
            lblHelp.Visible = true;
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            if (rdbTodasPeliculas.Checked)
            {
                table = AD_Pelicula.ObtenerTablaReportePelicula();
                txtLeyendaPelicula.Text = "Listado de todas las películas";
            }
            else
            {
                if (rdbTitulo.Checked)
                {
                    string titulo = txtTitulo.Text;
                    table = AD_Pelicula.ObtenerTablaReportePeliculaTitulo(titulo);
                    txtLeyendaPelicula.Text = "Listado de todas las películas con título " + titulo;
                }
                else
                {
                    if (rdborigen.Checked)
                    {
                        int origen = (int)cbOrigen.SelectedValue;
                        string norigen = cbOrigen.SelectedText;
                        table = AD_Pelicula.ObtenerTablaReportePeliculaOrigen(origen);
                        txtLeyendaPelicula.Text = "Listado de todas las películas con origen " + norigen;
                    }
                    else
                    {
                        if (rdbCalificacion.Checked)
                        {
                            int calificacion = (int)cbCalificacion.SelectedValue;
                            string ncalif = cbCalificacion.SelectedText;
                            table = AD_Pelicula.ObtenerTablaReportePeliculaCalificacion(calificacion);
                            txtLeyendaPelicula.Text = "Listado de todas las películas con calificación " + ncalif;
                        }
                        else
                        {
                            if (rdbFormato.Checked)
                            {
                                int formato = (int)cbFormato.SelectedValue;
                                string nformat = cbFormato.SelectedText;
                                table = AD_Pelicula.ObtenerTablaReportePeliculaFormato(formato);
                                txtLeyendaPelicula.Text = "Listado de todas las películas con formato " + nformat;
                            }
                            else
                            {
                                if (rdbGenero.Checked)
                                {
                                    int genero = (int)cbGenero.SelectedValue;
                                    string ngenero = cbGenero.SelectedText;
                                    table = AD_Pelicula.ObtenerTablaReportePeliculaGenero(genero);
                                    txtLeyendaPelicula.Text = "Listado de todas las películas con formato " + ngenero;
                                }
                                else
                                {
                                    if (rdbDistrbuidora.Checked)
                                    {
                                        int distribuidora = (int)cbDistribuidora.SelectedValue;
                                        string ndistri = cbDistribuidora.SelectedText;
                                        table = AD_Pelicula.ObtenerTablaReportePeliculaDistribuidora(distribuidora);
                                        txtLeyendaPelicula.Text = "Listado de todas las películas con formato " + ndistri;
                                    }
                                    else
                                    {
                                        int idioma = (int)cbIdioma.SelectedValue;
                                        string descriI = cbIdioma.SelectedText;
                                        table = AD_Pelicula.ObtenerTablaReportePeliculaGenero(idioma);
                                        txtLeyendaPelicula.Text = "Listado de todas las películas con idioma " + descriI;
                                    }
                                }
                            }
                        }
                    }
                }
            }


            ReportDataSource ds = new ReportDataSource("DataSetPeliculas", table);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(ds);
            reportViewer1.RefreshReport();
        }
    }
}

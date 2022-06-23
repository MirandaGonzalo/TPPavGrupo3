using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using TPG3.AccesoADatos;

namespace ProbandoMigrar.Estadisticas.Funcion
{
    public partial class EstadisticaFuncion : Form
    {
        public EstadisticaFuncion()
        {
            InitializeComponent();
        }

        private void EstadisticaFuncion_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSetListadoPeliculas.Pelicula' Puede moverla o quitarla según sea necesario.
            this.peliculaTableAdapter.Fill(this.dataSetListadoPeliculas.Pelicula);
            // TODO: esta línea de código carga datos en la tabla 'dataSetListadoSala.Sala' Puede moverla o quitarla según sea necesario.
            this.salaTableAdapter.Fill(this.dataSetListadoSala.Sala);

            this.rpvFuncion.RefreshReport();
            ReportParameter rp = new ReportParameter("ReportParameter1", "");
            rpvFuncion.LocalReport.SetParameters(rp);
            rpvFuncion.RefreshReport();
        }

        private void rdbTodasFunciones_CheckedChanged(object sender, EventArgs e)
        {
            rdbMayorQue.Visible = false;
            rdbEntre.Visible = false;
            rdbMenorQue.Visible = false;
            mtbDesde.Visible = false;
            mtbHasta.Visible = false;
            cbSala.Visible = false;
            cbPelicula.Visible = false;
        }

        private void rdbFechaFuncion_CheckedChanged(object sender, EventArgs e)
        {
            rdbMayorQue.Visible = true;
            rdbEntre.Visible = true;
            rdbMenorQue.Visible = true;
            mtbDesde.Visible = true;            
            cbSala.Visible = false;
            cbPelicula.Visible = false;
        }

        private void rbSala_CheckedChanged(object sender, EventArgs e)
        {
            rdbMayorQue.Visible = false;
            rdbEntre.Visible = false;
            rdbMenorQue.Visible = false;
            mtbDesde.Visible = false;
            cbSala.Visible = true;
            cbPelicula.Visible = false;
        }

        private void rdbPelicula_CheckedChanged(object sender, EventArgs e)
        {
            rdbMayorQue.Visible = false;
            rdbEntre.Visible = false;
            rdbMenorQue.Visible = false;
            mtbDesde.Visible = false;
            mtbHasta.Visible = false;
            cbSala.Visible = false;
            cbPelicula.Visible = true;
        }

        private void btnBuscarFuncion_Click(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            string alcance = "Alcance: ";
            if (rdbTodasFunciones.Checked)
            {
                table = AD_Funcion.ObtenerTablaFuncionesReporte();
                alcance += " Porcentaje de ocupación de funciones en base al género de la película.";
            }
            else
            {
                if (rbSala.Checked)
                {
                    int sala = (int)cbSala.SelectedValue;
                    table = AD_Funcion.ObtenerTablaFuncionesReporteSala(sala);
                    alcance += " Porcentaje de ocupación de la sala " + sala.ToString() + "en base a los géneros de las películas que serán proyectadas.";
                }
                else
                {
                    if (rdbPelicula.Checked)
                    {
                        int codPelicula = (int)cbPelicula.SelectedValue;
                        string pelicula = cbPelicula.SelectedText;
                        table = AD_Funcion.ObtenerTablaFuncionesReportePelicula(codPelicula);
                        alcance += " Porcentaje de salas en las que de distribuyen las funciones de la película " + pelicula + ".";
                    }
                    else
                    {
                        var fechaD = mtbDesde.Text;
                        
                        var desde = DateTime.Parse(fechaD);
                        
                        if (rdbMayorQue.Checked)
                        {
                            table = AD_Funcion.ObtenerTablaFuncionesReporteFechaDespues(desde);
                            alcance += " Asignación de funciones dependiendo del genero a partir del " + fechaD + "."; 
                        }
                        else
                        {
                            if (rdbMenorQue.Checked)
                            {
                                table = AD_Funcion.ObtenerTablaFuncionesReporteFechaAntes(desde);
                                alcance += " Asignación de funciones dependiendo del genero antes del " + fechaD + ".";
                            }
                            else
                            {
                                var fechaH = mtbHasta.Text;
                                var hasta = DateTime.Parse(fechaH);
                                table = AD_Funcion.ObtenerTablaFuncionesReporteFechaEntre(desde, hasta);
                                alcance += " Asignación de funciones dependiendo del genero entre el " + fechaD + " y " + hasta;
                            }
                            
                        }
                    }
                }

            }


            ReportDataSource ds = new ReportDataSource("DataSetEstadisticaFuncion", table);
            rpvFuncion.LocalReport.DataSources.Clear();
            rpvFuncion.LocalReport.DataSources.Add(ds);
            ReportParameter rp = new ReportParameter("ReportParameter1", alcance);
            rpvFuncion.LocalReport.SetParameters(rp);
            rpvFuncion.RefreshReport();
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
    }
}

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
    public partial class ReporteListadoCliente : Form
    {
        public ReporteListadoCliente()
        {
            InitializeComponent();
        }

        private void ReporteListadoCliente_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bD3K7G03_2022DataSet.Cliente' Puede moverla o quitarla según sea necesario.

            this.reportViewer1.RefreshReport();            
        }

        private void rpvClientes_Load(object sender, EventArgs e)
        {

            DataTable tabla = new DataTable();
            tabla = AD_Cliente.ObtenerTablaCliente();

            ReportDataSource ds = new ReportDataSource("DataSetCliente", tabla);

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(ds);
            reportViewer1.LocalReport.Refresh();
        }



        private void rdbTodosClientes_CheckedChanged(object sender, EventArgs e)
        {
            rdbDsp.Visible = false;
            rdbEntre.Visible = false;
            rdbAntes.Visible = false;
            mtbDni.Visible = false;
            mtbFechaDesde.Visible = false;
            mtbfechaHasta.Visible = false; 
            txtNA.Visible = false;
            rdbDni.Checked = false;
            rdbFechaNac.Checked = false;
            rdbNombre.Checked = false;
            rdbApellido.Checked = false;
        }

        private void rdbDni_CheckedChanged(object sender, EventArgs e)
        {
            rdbDsp.Visible = false;
            rdbEntre.Visible = false;
            rdbAntes.Visible = false;
            mtbDni.Visible = true;
            mtbFechaDesde.Visible = false;
            mtbfechaHasta.Visible = false;
            txtNA.Visible = false;
        }

        private void rdbFechaNac_CheckedChanged(object sender, EventArgs e)
        {
            rdbDsp.Visible = true;
            rdbEntre.Visible = true;
            rdbAntes.Visible = true;
            mtbDni.Visible = false;
            mtbFechaDesde.Visible = true;
            mtbfechaHasta.Visible = true;
            txtNA.Visible = false;
        }

        private void rdbNombre_CheckedChanged(object sender, EventArgs e)
        {
            rdbDsp.Visible = false;
            rdbEntre.Visible = false;
            rdbAntes.Visible = false;
            mtbDni.Visible = false;
            mtbFechaDesde.Visible = false;
            mtbfechaHasta.Visible = false;
            txtNA.Visible = true;
        }

        private void rdbApellido_CheckedChanged(object sender, EventArgs e)
        {
            rdbDsp.Visible = false;
            rdbEntre.Visible = false;
            rdbAntes.Visible = false;
            mtbDni.Visible = false;
            mtbFechaDesde.Visible = false;
            mtbfechaHasta.Visible = false;
            txtNA.Visible = true;
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            if (rdbTodosClientes.Checked)
            {
                table = AD_Cliente.ObtenerTablaCliente();
                txtLeyendaCliente.Text = "Listado de todos los clientes";
            }
            else
            {
                if (rdbDni.Checked)
                {
                    int dni = int.Parse(mtbDni.Text);
                    table = AD_Cliente.ObtenerListadoClientesDNI(dni);
                    txtLeyendaCliente.Text = "Listado de todos los clientes con el dni " + dni.ToString();
                }
                else
                {
                    if (rdbFechaNac.Checked)
                    {
                        DateTime desde = DateTime.Parse(mtbFechaDesde.Text);
                        if (rdbEntre.Checked)
                        {
                            DateTime hasta = DateTime.Parse(mtbfechaHasta.Text);
                            table = AD_Cliente.ObtenerListadoClientesNacimientoEntre(desde,hasta);
                            txtLeyendaCliente.Text = "Listado de todos los clientes nacidos entre " + desde.ToString() + " y " + hasta.ToString();
                        }
                        else
                        {
                            if (rdbDsp.Checked)
                            {
                                table = AD_Cliente.ObtenerListadoClientesNacimientoDsp(desde);
                                txtLeyendaCliente.Text = "Listado de todos los clientes nacidos después del " + desde.ToString();
                            }
                            else
                            {
                                table = AD_Cliente.ObtenerListadoClientesNacimientoAntes(desde);
                                txtLeyendaCliente.Text = "Listado de todos los clientes nacidos antes del " + desde.ToString();
                            }
                        }
                    }
                    else
                    {
                        string nombre = txtNA.Text;
                        if (rdbNombre.Checked)
                        {
                            table = AD_Cliente.ObtenerListadoClientesNombre(nombre);
                            txtLeyendaCliente.Text = "Listado de todos los clientes cuyo nombre comienza con " + nombre;
                        }
                        else
                        {
                            table = AD_Cliente.ObtenerListadoClientesApellido(nombre);
                            txtLeyendaCliente.Text = "Listado de todos los clientes cuyo apellido comienza con " + nombre;
                        }
                    }
                }
            }
            ReportDataSource ds = new ReportDataSource("DataSetCliente", table);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(ds);
            reportViewer1.RefreshReport();
        }

        private void rdbEntre_CheckedChanged(object sender, EventArgs e)
        {
            mtbfechaHasta.Visible = true;
        }

        private void rdbDsp_CheckedChanged(object sender, EventArgs e)
        {
            mtbfechaHasta.Visible = false;
        }

        private void rdbAntes_CheckedChanged(object sender, EventArgs e)
        {
            mtbfechaHasta.Visible = false;
        }
    }
}

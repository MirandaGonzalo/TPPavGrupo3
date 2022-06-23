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

namespace ProbandoMigrar.Reportes.Empleado
{
    public partial class ReporteEmpleado : Form
    {
        public ReporteEmpleado()
        {
            InitializeComponent();
        }

        private void ReporteEmpleado_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            if (rdbTodosEmpleados.Checked)
            {
                table = AD_Empleado.ObtenerTablaEmpleado();
                txtLeyendaCliente.Text = "Listado de todos los empleados";
            }
            else
            {
                if (rdbDni.Checked)
                {
                    int dni = int.Parse(mtbDni.Text);
                    table = AD_Empleado.ObtenerListadoEmpleadosDNI(dni);
                    txtLeyendaCliente.Text = "Listado de todos los empleados con el dni " + dni.ToString();
                }
                else
                {
                    string nombre = txtNA.Text;
                    if (rdbNombre.Checked)
                    {
                        table = AD_Empleado.ObtenerListadoEmpleadosNombre(nombre);
                        txtLeyendaCliente.Text = "Listado de todos los empleados cuyo nombre comienza con " + nombre;
                    }
                    else
                    {
                        table = AD_Empleado.ObtenerListadoEmpleadosApellido(nombre);
                        txtLeyendaCliente.Text = "Listado de todos los empleados cuyo apellido comienza con " + nombre;
                    }
                    
                }
            }
            ReportDataSource ds = new ReportDataSource("DataSetEmpleado", table);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(ds);
            reportViewer1.RefreshReport();
        }

        private void rdbTodosClientes_CheckedChanged(object sender, EventArgs e)
        {
            mtbDni.Visible = false;
            txtNA.Visible = false;
            rdbDni.Checked = false;
            rdbNombre.Checked = false;
            rdbApellido.Checked = false;
        }

        private void rdbDni_CheckedChanged(object sender, EventArgs e)
        {
            mtbDni.Visible = true;
            txtNA.Visible = false;
            rdbTodosEmpleados.Checked = false;
            rdbNombre.Checked = false;
            rdbApellido.Checked = false;
        }

        private void rdbNombre_CheckedChanged(object sender, EventArgs e)
        {
            mtbDni.Visible = false;
            txtNA.Visible = true;
            rdbTodosEmpleados.Checked = false;
            rdbDni.Checked = false;
            rdbApellido.Checked = false;
        }

        private void rdbApellido_CheckedChanged(object sender, EventArgs e)
        {
            mtbDni.Visible = false;
            txtNA.Visible = true;
            rdbTodosEmpleados.Checked = false;
            rdbDni.Checked = false;
            rdbNombre.Checked = false;
        }
    }
}

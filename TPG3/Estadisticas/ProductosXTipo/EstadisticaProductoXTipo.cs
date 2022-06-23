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

namespace ProbandoMigrar.Estadisticas.ProductosXTipo
{
    public partial class EstadisticaProductoXTipo : Form
    {
        public EstadisticaProductoXTipo()
        {
            InitializeComponent();
        }

        private void EstadisticaProductoXTipo_Load(object sender, EventArgs e)
        {
            this.rpV.RefreshReport();
            ReportParameter rp = new ReportParameter("ReportParameter1", " ");
            rpV.LocalReport.SetParameters(rp);
            rpV.RefreshReport();
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            string alcance = "Alcance: ";
            if (rdbTodosProductos.Checked)
            {
                table = AD_Producto.ObtenerProductoTipoCantidad();
                alcance += "Todos los productos ordenados por tipo";
            }
            else
            {
                float desde = -1;
                float hasta = -1;
                desde = float.Parse(mtbDesde.Text);
                if (rdbMayorQue.Checked)
                {
                    table = AD_Producto.ObtenerProductoTipoCantidadPrecioMayorQue(desde);
                    alcance += " Todos los productos con un precio mayor que " + desde.ToString();

                }
                else
                    {
                    if (rdbMenorQue.Checked)
                    {
                        table = AD_Producto.ObtenerProductoTipoCantidadPrecioMenorQue(desde);
                        alcance += " Todos los productos con un precio menor que " + desde.ToString();
                    }
                    else
                    {
                        hasta = float.Parse(mtbHasta.Text);
                        table = AD_Producto.ObtenerProductoTipoCantidadPrecioEntre(desde, hasta);
                        alcance += " Todos los productos con un precio entre " + desde.ToString() + " y " + hasta.ToString();
                    }
                }
            }
            ReportDataSource ds = new ReportDataSource("DataSetEstadisticaProductoXTipo", table);
            rpV.LocalReport.DataSources.Clear();
            rpV.LocalReport.DataSources.Add(ds);
            ReportParameter rp = new ReportParameter("ReportParameter1", alcance);
            rpV.LocalReport.SetParameters(rp);
            rpV.RefreshReport();
        }

        private void visibleComponentesPrecio(bool visible)
        {
            rdbMenorQue.Visible = visible;
            rdbEntre.Visible = visible;
            rdbMayorQue.Visible = visible;
            mtbDesde.Visible = visible;
        }

        private void rdbPrecio_CheckedChanged(object sender, EventArgs e)
        {
            visibleComponentesPrecio(true);
            mtbHasta.Visible = false;
        }

        private void rdbTodosProductos_CheckedChanged(object sender, EventArgs e)
        {
            visibleComponentesPrecio(false);
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
    }
}

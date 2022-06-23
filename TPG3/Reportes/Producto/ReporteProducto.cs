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

namespace ProbandoMigrar.Reportes.Producto
{
    public partial class ReporteProducto : Form
    {
        public ReporteProducto()
        {
            InitializeComponent();
        }

        private void ReporteProducto_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSetTipoProducto.TipoProducto' Puede moverla o quitarla según sea necesario.
            this.tipoProductoTableAdapter.Fill(this.dataSetTipoProducto.TipoProducto);
            // TODO: esta línea de código carga datos en la tabla 'bD3K7G03_2022DataSet.Producto' Puede moverla o quitarla según sea necesario.
            //this.productoTableAdapter.Fill(this.bD3K7G03_2022DataSet.Producto);

            //this.rvProducto.RefreshReport();
            this.rpvProducto.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            if (rdbTodosProductos.Checked)
            {
                table = AD_Producto.ObtenerTablaProductos();
                txtLeyendaProducto.Text = "Listado de todos los productos";
                ReportDataSource Datos = new ReportDataSource("DataSetProducto", table);
                rpvProducto.LocalReport.ReportEmbeddedResource = "ProbandoMigrar.Reportes.Producto.ReporteProducto.rdlc";
                rpvProducto.LocalReport.DataSources.Clear();
                rpvProducto.LocalReport.DataSources.Add(Datos);
                rpvProducto.RefreshReport();
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
                        table = AD_Producto.ObtenerProductoPrecioMayorQue(desde);
                        txtLeyendaProducto.Text = "Listado de todos los productos con precio mayor a " + desde.ToString();
                        
                    }
                    else
                    {
                        if (rdbMenorQue.Checked)
                        {
                            table = AD_Producto.ObtenerProductoPrecioMenorQue(desde);
                            txtLeyendaProducto.Text = "Listado de todos los productos con precio menor a " + desde.ToString();
                        }
                        else
                        {
                            hasta = float.Parse(mtbHasta.Text);
                            table = AD_Producto.ObtenerProductoPrecioEntre(desde, hasta);
                            txtLeyendaProducto.Text = "Listado de todos los productos con precio entre " + desde.ToString() + " y " + hasta.ToString();
                        }
                    }

                }
                else
                {
                    int tipoProd = (int)cmbTipoProducto.SelectedValue;
                    table = AD_Producto.ObtenerProductoPorTipoProducto(tipoProd);
                    string tipoP = cmbTipoProducto.SelectedText;
                    txtLeyendaProducto.Text = "Listado de todos los productos de tipo " + tipoP;
                }
                
            }
            

            ReportDataSource ds = new ReportDataSource("DataSetProducto", table);
            rpvProducto.LocalReport.DataSources.Clear();
            rpvProducto.LocalReport.DataSources.Add(ds);
            rpvProducto.RefreshReport();
        }

        private void rdbPrecio_CheckedChanged(object sender, EventArgs e)
        {
            rdbMayorQue.Visible = true;
            rdbEntre.Visible = true;
            rdbMenorQue.Visible = true;
            mtbDesde.Visible = true;
            mtbHasta.Visible = false;
            cmbTipoProducto.Visible = false;
        }

        private void rdbTodosProductos_CheckedChanged(object sender, EventArgs e)
        {
            rdbMayorQue.Visible = false;
            rdbEntre.Visible = false;
            rdbMenorQue.Visible = false;
            mtbDesde.Visible = false;
            mtbHasta.Visible = false;
            cmbTipoProducto.Visible = false;
        }

        private void rdbTipoProducto_CheckedChanged(object sender, EventArgs e)
        {
            rdbMayorQue.Visible = false;
            rdbEntre.Visible = false;
            rdbMenorQue.Visible = false;
            mtbDesde.Visible = false;
            mtbHasta.Visible = false;
            cmbTipoProducto.Visible = true;
        }

        private void rdbMayorQue_CheckedChanged(object sender, EventArgs e)
        {
            mtbHasta.Visible = false;
        }

        private void CargarComboTipoProducto()
        {
            try
            {
                cmbTipoProducto.DataSource = AD_TipoProducto.ObtenerTipoProducto();
                cmbTipoProducto.DisplayMember = "nombreTipoProd";
                cmbTipoProducto.ValueMember = "idTipoProducto";
                cmbTipoProducto.SelectedIndex = 0;
            }

            catch (Exception)
            {
                MessageBox.Show("Error al cargar combo tipo producto");
            }
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

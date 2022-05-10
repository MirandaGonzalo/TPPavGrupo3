using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPG3.Entidades;

namespace TPG3.Formularios.Producto
{
    public partial class ListaProducto : Form
    {
        public ListaProducto()
        {
            InitializeComponent();
        }

        private void ListaProducto_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main.main1.btnSubComboAltaProducto(sender, e);
        }

        private void CargarGrilla()
        {
            try
            {
                gdrConsultarProd.DataSource = AD_Producto.ObtenerTablaProducto();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener productos");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Main.main1.btnSubComboAltaProducto(sender, e);
        }

        private void txtNombreProducto_TextChanged(object sender, EventArgs e)
        {
            (gdrConsultarProd.DataSource as DataTable).DefaultView.RowFilter = "Convert(nombre, 'System.String') LIKE '" + txtNombreProducto.Text + "%' and Convert(nombreTipoProd, 'System.String') LIKE '" + txtBuscadorTipoProd.Text + "%'";
        }

        private void txtBuscadorTipoProd_TextChanged(object sender, EventArgs e)
        {
            (gdrConsultarProd.DataSource as DataTable).DefaultView.RowFilter = "Convert(nombre, 'System.String') LIKE '" + txtNombreProducto.Text + "%' and Convert(nombreTipoProd, 'System.String') LIKE '" + txtBuscadorTipoProd.Text + "%'";
        }
    }
}

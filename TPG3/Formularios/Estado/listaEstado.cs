using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPG3.AccesoADatos;

namespace TPG3.Formularios.Estado
{
    public partial class listaEstado : Form
    {
        public listaEstado()
        {
            InitializeComponent();
        }

        private void listaEstado_Load(object sender, EventArgs e)
        {
            cargarGrilla();
        }
        private void cargarGrilla()
        {
            try
            {
                grdEstado.DataSource = AD_Estado.ObtenerTablaEstado();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al obtener los estados.");
            }
        }
        

        private void txtBuscadorEstado_TextChanged(object sender, EventArgs e)
        {
            (grdEstado.DataSource as DataTable).DefaultView.RowFilter = "Convert(nombre, 'System.String') LIKE '" + txtBuscadorEstado.Text + "%'";
        }
    }
}

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
using TPG3.Entidades;

namespace TPG3.Formularios.Genero
{
    public partial class ListadoGenero : Form
    {
        public ListadoGenero()
        {
            InitializeComponent();
        }

        private void grdBuscadorGenero_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ListadoGenero_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void CargarGrilla()
        {
            try
            {
                grdBuscadorGenero.DataSource = AD_Genero.ObtenerTablaGenero();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al obtener el listado géneros.");
            }
        }
        private void txtBuscadorGenero_TextChanged(object sender, EventArgs e)
        {
            (grdBuscadorGenero.DataSource as DataTable).DefaultView.RowFilter = "Convert(descripcion, 'System.String') LIKE '" + txtBuscadorGenero.Text + "%'";
        }
    }
}

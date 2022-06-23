using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using TPG3.Entidades;
using TPG3.AccesoADatos;

namespace TPG3.Formularios.Origen
{
    public partial class ListadoOrigen : Form
    {
        public ListadoOrigen()
        {
            InitializeComponent();
        }

        private void ListadoOrigen_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void CargarGrilla()
        {
            try
            {
                AD_Origen origen = new AD_Origen();
                grdBuscadororigen.DataSource = origen.ObtenerTablaOrigen();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al obtener los listados de origenes.");
            }
        }
        

        private void txtBuscadororigen_TextChanged(object sender, EventArgs e)
        {
            (grdBuscadororigen.DataSource as DataTable).DefaultView.RowFilter = "Convert(nombre, 'System.String') LIKE '" + txtBuscadororigen.Text + "%'";
        }
    }
}

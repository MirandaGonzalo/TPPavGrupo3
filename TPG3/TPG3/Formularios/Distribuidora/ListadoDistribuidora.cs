using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using TPG3.AccesoADatos;

namespace TPG3.Formularios.Distribuidora
{
    public partial class ListadoDistribuidora : Form
    {
        public ListadoDistribuidora()
        {
            InitializeComponent();
        }

        private void ListadoDistribuidora_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void CargarGrilla()
        {
            try
            {
                grdBuscadordistribuidora.DataSource = AD_Distribuidora.ObtenerTablaDistribuidora();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al obtener distribuidora");
            }
        }
        

        private void txtBuscadorDistribuidora_TextChanged(object sender, EventArgs e)
        {
            (grdBuscadordistribuidora.DataSource as DataTable).DefaultView.RowFilter = "Convert(NombreDistribuidora, 'System.String') LIKE '" + txtBuscadorDistribuidora.Text + "%'";
        }
    }
}

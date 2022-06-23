using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using TPG3.Entidades;
using TPG3.AccesoADatos;

namespace TPG3.Formularios.Tarifa
{
    public partial class listaTarifa : Form
    {
        public listaTarifa()
        {
            InitializeComponent();
        }

        private void listaTarifa_Load(object sender, EventArgs e)
        {
            cargarGrilla();
        }

        private void cargarGrilla()
        {
            try
            {
                grdTarifa.DataSource = AD_Tarifa.ObtenerTablaTarifa();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al obtener tarifas");
            }
        }

        private void txtBuscadororigen_TextChanged(object sender, EventArgs e)
        {
            (grdTarifa.DataSource as DataTable).DefaultView.RowFilter = "Convert(descripcion, 'System.String') LIKE '" + txtBuscadorTarifa.Text + "%'";
        }
    }
}

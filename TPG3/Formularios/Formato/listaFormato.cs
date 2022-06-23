using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using TPG3.Entidades;
using TPG3.AccesoADatos;
namespace TPG3.Formularios.Formato
{
    public partial class listaFormato : Form
    {
        public listaFormato()
        {
            InitializeComponent();
        }
        private void listaFormato_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }
        private void CargarGrilla()
        {
            try
            {
                grdBuscadorFormato.DataSource = AD_Formato.ObtenerTablaFormato();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al obtener tipos de formato.");
            }
        }
        
        private void txtBuscadorFormatos_TextChanged(object sender, EventArgs e)
        {
            (grdBuscadorFormato.DataSource as DataTable).DefaultView.RowFilter = "Convert(descripcion, 'System.String') LIKE '" + txtBuscadorFormatos.Text + "%'";
        }

       
    }
}

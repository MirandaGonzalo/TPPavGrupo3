using System;
using System.Data;
using System.Windows.Forms;
using TPG3.AccesoADatos;

namespace TPG3.Formularios.Banco
{
    public partial class listaBanco : Form
    {
        public listaBanco()
        {
            InitializeComponent();
        }

        private void listaBanco_Load(object sender, EventArgs e)
        {
            cargarGrilla();
        }

        private void cargarGrilla()
        {
            try
            {
                grdBuscadorBanco.DataSource = AD_Banco.ObtenerNombreBanco();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener bancos.");
            }
        }
        private void txtBuscadorGenero_TextChanged(object sender, EventArgs e)
        {
            (grdBuscadorBanco.DataSource as DataTable).DefaultView.RowFilter = "Convert(nombreBanco, 'System.String') LIKE '" + txtBuscadorGenero.Text + "%'";
        }
    }
}

using System;
using System.Data;
using System.Windows.Forms;
using TPG3.AccesoADatos;

namespace TPG3.Formularios.Calificacion
{
    public partial class ListadoCalificacion : Form
    {
        public ListadoCalificacion()
        {
            InitializeComponent();
        }

        private void ListadoCalificacion_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void CargarGrilla()
        {
            try
            {
                grdBuscadorcalificacion.DataSource = AD_Calificacion.ObtenerTablaCalificacion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener calificación");
            }
        }
        
        private void txtBuscadorCalificacion_TextChanged(object sender, EventArgs e)
        {
            (grdBuscadorcalificacion.DataSource as DataTable).DefaultView.RowFilter = "Convert(descripcion, 'System.String') LIKE '" + txtBuscadorCalificacion.Text + "%'";

        }
    }
}

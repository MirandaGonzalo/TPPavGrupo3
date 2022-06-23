using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using TPG3.Entidades;
using TPG3.AccesoADatos;
namespace TPG3.Formularios.TipoDocumento
{
    public partial class ListadoTipoDocumento : Form
    {
        public ListadoTipoDocumento()
        {
            InitializeComponent();
        }

        private void ListadoTipoDocumento_Load(object sender, EventArgs e)
        {
            cargarGrilla();
        }

        private void cargarGrilla()
        {
            
            try
            {
                dgvPromocion.DataSource = AD_TipoDocumento.ObtenerNombreTiposDocumentos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener el listado de tipos de documento.");
            }

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            (dgvPromocion.DataSource as DataTable).DefaultView.RowFilter = string.Format("Nombre LIKE '%{0}%' or Nombre LIKE '% {0}%'", txtBuscar.Text);
        }
    }
}

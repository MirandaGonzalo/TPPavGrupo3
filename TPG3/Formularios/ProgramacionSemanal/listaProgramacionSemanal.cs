using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using TPG3.Entidades;
using TPG3.AccesoADatos;

namespace TPG3.Formularios.ProgramacionSemanal
{
    public partial class listaProgramacionSemanal : Form
    {
        public listaProgramacionSemanal()
        {
            InitializeComponent();
        }

        private void lsitaProgramacionSemanal_Load(object sender, EventArgs e)
        {
            cargarGrilla();
        }
        private void cargarGrilla()
        {
            try
            {
                grdProgSem.DataSource = AD_ProgramacionSemanal.ObtenerTablaProgSem();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al obtener las programaciones semanales.");
            }
        }
        private void txtBuscadorProg_TextChanged(object sender, EventArgs e)
        {
            (grdProgSem.DataSource as DataTable).DefaultView.RowFilter = "Convert(nroSemana, 'System.String') LIKE '" + txtBuscadorProg.Text + "%'";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using TPG3.Entidades;
using TPG3.AccesoADatos;

namespace TPG3.Formularios.Rol
{
    public partial class ListadoRol : Form
    {
        public ListadoRol()
        {
            InitializeComponent();
        }

        private void ListadoRol_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void CargarGrilla()
        {
            try
            {
                grdBuscadorrol.DataSource = AD_Rol.ObtenerTablaRol();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al obtener el listado de roles.");
            }
        }
        
        private void txtBuscadorRoles_TextChanged(object sender, EventArgs e)
        {
            (grdBuscadorrol.DataSource as DataTable).DefaultView.RowFilter = "Convert(NombreRol, 'System.String') LIKE '" + txtBuscadorRoles.Text + "%' ";
        }
    }
}

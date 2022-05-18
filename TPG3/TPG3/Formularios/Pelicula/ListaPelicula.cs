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

namespace TPG3.Formularios.Pelicula
{
    public partial class ListaPelicula : Form
    {
        public ListaPelicula()
        {
            InitializeComponent();
        }

        private void btnRegistrarPelícula_Click(object sender, EventArgs e)
        {
            Main.main1.btnSubPeliculaAltaPelicula(sender, e);
        }

        private void ListaPelicula_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void CargarGrilla()
        {
            try
            {
                gdrActualizarPeli.DataSource = AltaPelicula.ObtenerTablaPelicula();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener la película");
            }
        }

        private void txtBuscadorTitulo_TextChanged(object sender, EventArgs e)
        {
            (gdrActualizarPeli.DataSource as DataTable).DefaultView.RowFilter = "Convert(titulo, 'System.String') LIKE '" + txtBuscadorTitulo.Text + "%' and Convert(genero, 'System.String') LIKE '" + txtBuscadorGenero.Text + "%'";

        }

        private void txtBuscadorGenero_TextChanged(object sender, EventArgs e)
        {
            (gdrActualizarPeli.DataSource as DataTable).DefaultView.RowFilter = "Convert(titulo, 'System.String') LIKE '" + txtBuscadorTitulo.Text + "%' and Convert(genero, 'System.String') LIKE '" + txtBuscadorGenero.Text + "%'";
        }


    }
}

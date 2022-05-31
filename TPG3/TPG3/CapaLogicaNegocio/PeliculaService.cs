using System.Data;
using System.Data.SqlClient;
using TPG3.AccesoADatos;
using TPG3.Entidades;

namespace TPG3.CapaLogicaNegocio
{
    public partial class PeliculaService : Form
    {
        public PeliculaService()
        {
            InitializeComponent();
        }

        private void PeliculaService_Load(object sender, EventArgs e)
        {
            btnContinuar.Enabled = false;
            CargarGrilla();
        }

        private void CargarGrilla()
        {
            try
            {
                gdrSeleccionPelicula.DataSource = AD_Pelicula.ObtenerTablaPeliculasDisponibles();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener la película");
            }
        }
        private void gdrSeleccionPelicula_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnContinuar.Enabled = true;
            int indice = e.RowIndex;
            DataGridViewRow filaSeleccionada = gdrSeleccionPelicula.Rows[indice];
            int codPelicula = (int)filaSeleccionada.Cells["codPeliculaItem"].Value;
            int formato = (int)filaSeleccionada.Cells["formato"].Value;
            try
            {
                grdSeleccionFuncion.DataSource = AD_Funcion.ObtenerTablaFuncionesDisponibles(codPelicula);
                txtCodPelicula.Text = codPelicula.ToString();
                txtFormatoSel.Text = formato.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener las funciones.");
            }
        }





        private void btnContinuar_Click(object sender, EventArgs e)
        {
            if (grdFuncionSel.Rows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar una función.");
            }
            else
            {
                var confirmResult = MessageBox.Show("Desea comprar entradas para esta función ??",
                "Confirmación!!", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    var fechaHora = DateTime.Parse(grdFuncionSel.Rows[0].Cells[0].Value.ToString());                    
                    var sala = int.Parse(grdFuncionSel.Rows[0].Cells[1].Value.ToString());
                    int codFormato = int.Parse(txtFormatoSel.Text);
                    Main.main1.formTarifa(fechaHora, sala, codFormato);
                }
            }
        }

        private void eliminarFila(DateTime fechaHora, int sala)
        {
            DateTime fechaActual;
            int salaActual = -1;
            int eliminar = -1;
            for (int rows = 0; rows < grdSeleccionFuncion.Rows.Count; rows++)
            {
                fechaActual = DateTime.Parse(grdSeleccionFuncion.Rows[rows].Cells[0].Value.ToString());
                salaActual = int.Parse(grdSeleccionFuncion.Rows[rows].Cells[1].Value.ToString());
                if (fechaActual == fechaHora && salaActual == sala)
                {
                    eliminar = rows;
                    break;
                }
            }
            grdSeleccionFuncion.Rows.RemoveAt(eliminar);
        }

        private void grdSeleccionFuncion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var currentRow = grdSeleccionFuncion.CurrentCell.RowIndex;
            DataGridViewRow selectedRow = grdSeleccionFuncion.Rows[currentRow];
            DateTime fechaHora = DateTime.Parse(grdSeleccionFuncion.Rows[currentRow].Cells[0].Value.ToString());
            int sala = int.Parse(grdSeleccionFuncion.Rows[currentRow].Cells[1].Value.ToString());
            string estado = grdSeleccionFuncion.Rows[currentRow].Cells[2].Value.ToString();
            grdFuncionSel.Rows.Clear();
            grdFuncionSel.Rows.Add(fechaHora, sala, estado);
            try
            {
                var codPelicula = int.Parse(txtCodPelicula.Text);
                grdSeleccionFuncion.DataSource = AD_Funcion.ObtenerTablaFuncionesDisponibles(codPelicula);
                eliminarFila(fechaHora, sala);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al seleccionar la función.");
            }
            
        }

        private void grdFuncionSel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            grdFuncionSel.Rows.Clear();
            try
            {
                var codPelicula = int.Parse(txtCodPelicula.Text);
                grdSeleccionFuncion.DataSource = AD_Funcion.ObtenerTablaFuncionesDisponibles(codPelicula);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al quitar la función.");
            }
        }
    }
}

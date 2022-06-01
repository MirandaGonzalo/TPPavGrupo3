using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using TPG3.AccesoADatos;

namespace TPG3.Formularios.Funcion
{
    public partial class ListaFuncion : Form
    {
        public ListaFuncion()
        {
            InitializeComponent();
        }

        private void ListaFuncion_Load(object sender, EventArgs e)
        {
            cargarGrilla();
        }

        private void cargarGrilla()
        {
            try
            {
                dgvFuncion.DataSource = AD_Funcion.ObtenerTablaFuncion();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al obtener los estados.");
            }

            
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void dgvFuncion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCargarFuncion_Click(object sender, EventArgs e)
        {
            Entidades.Funcion funcion = new Entidades.Funcion(DateTime.Today, 0, 0,"", "", DateTime.Today, DateTime.Today, 3);
            Main.main1.btnSubFuncionAltaFuncion(funcion);
        }

        private void btnEditarFuncion_Click(object sender, EventArgs e)
        {

            var currentRow = dgvFuncion.CurrentCell.RowIndex;
            DataGridViewRow selectedRow = dgvFuncion.Rows[currentRow];
            DateTime fechaHora = DateTime.Parse(dgvFuncion.Rows[currentRow].Cells[0].Value.ToString());
            int pelicula = int.Parse(dgvFuncion.Rows[currentRow].Cells[1].Value.ToString());
            string nombrePelicula = dgvFuncion.Rows[currentRow].Cells[2].Value.ToString();
            int sala = int.Parse(dgvFuncion.Rows[currentRow].Cells[3].Value.ToString());
            string estado = dgvFuncion.Rows[currentRow].Cells[4].Value.ToString();
            DateTime fechaInicio = DateTime.Parse(dgvFuncion.Rows[currentRow].Cells[5].Value.ToString());
            DateTime fechaFin = DateTime.Parse(dgvFuncion.Rows[currentRow].Cells[6].Value.ToString());
            Entidades.Funcion funcion = new Entidades.Funcion(fechaHora, sala, pelicula, nombrePelicula, estado, fechaInicio, fechaFin, 2);
            Main.main1.btnSubFuncionAltaFuncion(funcion);
        }

        private void btnEliminarFuncion_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Desea eliminar este Función ??",
                                     "Confirmación!!",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                var currentRow = dgvFuncion.CurrentCell.RowIndex;
                DataGridViewRow selectedRow = dgvFuncion.Rows[currentRow];
                DateTime fechaHora = DateTime.Parse(dgvFuncion.Rows[currentRow].Cells[0].Value.ToString());
                Entidades.Funcion func = new Entidades.Funcion(fechaHora, 0, 0,"", "", DateTime.Today, DateTime.Today, 1);
                AltaFuncion altaFuncion = new AltaFuncion(func);
                var result = altaFuncion.cargarFunc(func);
                if (result)
                {
                    MessageBox.Show("Función eliminada con éxito!");
                    cargarGrilla();
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAsientos_Click(object sender, EventArgs e)
        {
            var currentRow = dgvFuncion.CurrentCell.RowIndex;
            DataGridViewRow selectedRow = dgvFuncion.Rows[currentRow];
            DateTime fechaHora = DateTime.Parse(dgvFuncion.Rows[currentRow].Cells[0].Value.ToString());
            int pelicula = int.Parse(dgvFuncion.Rows[currentRow].Cells[1].Value.ToString());
            int sala = int.Parse(dgvFuncion.Rows[currentRow].Cells[3].Value.ToString());
            int formato = AD_Funcion.GetFormatoPelicula(pelicula);
            Main.main1.btnEstadoFuncion(fechaHora, sala, formato);
        }
    }
}

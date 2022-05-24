using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using TPG3.AccesoADatos;


namespace TPG3.Formularios.Actores
{
    public partial class ListaActor : Form
    {
        public ListaActor()
        {
            InitializeComponent();
        }

        private void btnRegistrarActualizarActor_Click(object sender, EventArgs e)
        {
            Main.main1.btnSubParticipantesAltaParticipante(sender, e);
        }

        private void ListaActor_Load(object sender, EventArgs e)
        {
            LimpiarCampos();
            CargarGrilla();
        }

        private void LimpiarCampos()
        {
            txtBuscadorNombre.Text = "";
            txtBuscadorApellido.Text = "";
        }

        private void CargarGrilla()
        {
            try
            {
                dtgListadoActor.DataSource = AD_Actor.ObtenerTablaActor();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al obtener productos");
            }
        }

        

        private void txtBuscadorNombre_TextChanged(object sender, EventArgs e)
        {
            (dtgListadoActor.DataSource as DataTable).DefaultView.RowFilter = "Convert(nombre, 'System.String') LIKE '" + txtBuscadorNombre.Text + "%' and Convert(apellido, 'System.String') LIKE '" + txtBuscadorApellido.Text + "%'";

        }

        private void txtBuscadorApellido_TextChanged(object sender, EventArgs e)
        {
            (dtgListadoActor.DataSource as DataTable).DefaultView.RowFilter = "Convert(nombre, 'System.String') LIKE '" + txtBuscadorNombre.Text + "%' and Convert(apellido, 'System.String') LIKE '" + txtBuscadorApellido.Text + "%'";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Desea eliminar este Actor ??",
                                     "Confirmación!!",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                var currentRow = dtgListadoActor.CurrentCell.RowIndex;
                DataGridViewRow selectedRow = dtgListadoActor.Rows[currentRow];
                int codActor = int.Parse(dtgListadoActor.Rows[currentRow].Cells[0].Value.ToString());
                Entidades.Actor actor = new Entidades.Actor(codActor, "", ""); 
                var result = AD_Actor.EliminarActor(actor);
                if (result)
                {
                    MessageBox.Show("Actor eliminado con éxito!");
                    CargarGrilla();
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

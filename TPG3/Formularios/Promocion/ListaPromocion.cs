using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using TPG3.Entidades;
using TPG3.AccesoADatos;

namespace TPG3.Formularios.Promocion
{
    public partial class ListaPromocion : Form
    {
     
        public ListaPromocion()
        {
            InitializeComponent();
        }

        private void ListaPromocion_Load(object sender, EventArgs e)
        {
            cargarGrilla();
        }

        private void cargarGrilla()
        {
            try
            {
                dgvPromocion.DataSource = AD_Promocion.ObtenerPromocion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener las promociones.");
            }
        }

        private void btnCargarPromo_Click(object sender, EventArgs e)
        {
            //3 - Nuevo
            //2 - Editar
            //1 - Eliminar
            Entidades.Promocion promo = new Entidades.Promocion("","",0,DateTime.Parse(DateTime.Now.ToString("d")), DateTime.Parse(DateTime.Today.ToString("d")),3);
            Main.main1.btnSubPromocionAltaPromocion(promo);
        }

        private void btnEditarPromo_Click(object sender, EventArgs e)
        {
            var currentRow = dgvPromocion.CurrentCell.RowIndex;            
            DataGridViewRow selectedRow = dgvPromocion.Rows[currentRow];
            string nombre = Convert.ToString(selectedRow.Cells["Nombre"].Value);
            string descripcion = Convert.ToString(selectedRow.Cells["Descripcion"].Value);
            string valorAux = Convert.ToString(selectedRow.Cells["Valor"].Value);
            var valor = float.Parse(valorAux);
            string fechaInicioAux = Convert.ToString(selectedRow.Cells["FechaInicio"].Value);
            var fechaInicio = DateTime.Parse(fechaInicioAux);
            string fechaFinAux = Convert.ToString(selectedRow.Cells["FechaFin"].Value);
            var fechaFin = DateTime.Parse(fechaFinAux);
            Entidades.Promocion promo = new Entidades.Promocion(nombre, descripcion, valor, fechaInicio, fechaFin, 2);
            Main.main1.btnSubPromocionAltaPromocion(promo);
        }

        private void btnEliminarPromo_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Desea eliminar esta Promoción ??",
                                     "Confirmación!!",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                var currentRow = dgvPromocion.CurrentCell.RowIndex;
                DataGridViewRow selectedRow = dgvPromocion.Rows[currentRow];
                string nombre = Convert.ToString(selectedRow.Cells["Nombre"].Value);
                Entidades.Promocion promo = new Entidades.Promocion(nombre, "", 0, DateTime.Today, DateTime.Today, 1);
                
                var result = AD_Promocion.cargarPromocion(promo);
                if (result)
                {
                    MessageBox.Show("Promoción eliminada con éxito!");
                    cargarGrilla();
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                ;
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            (dgvPromocion.DataSource as DataTable).DefaultView.RowFilter = string.Format("Nombre LIKE '%{0}%' or Nombre LIKE '% {0}%'", txtBuscar.Text);
        }
    }
}

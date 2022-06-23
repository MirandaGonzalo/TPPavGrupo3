using System;
using System.Data;
using System.Windows.Forms;
using TPG3.AccesoADatos;

namespace TPG3.Formularios.Combo
{
    public partial class ListaCombo : Form
    {
        public ListaCombo()
        {
            InitializeComponent();
        }

        private void ListaCombo_Load(object sender, EventArgs e)
        {
            cargarGrilla();
        }

        private void cargarGrilla()
        {
            try
            {
                gdrConsultarProd.DataSource = AD_Combo.ObtenerCombo();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener tipos de productos.");
            }
        }

        private void btnRegistrarCombo_Click(object sender, EventArgs e)
        {
            Entidades.Producto combo = new Entidades.Producto(-1, "", "", 1, 0, 0, 3);
            Main.main1.btnSubComboAltaCombo(combo);

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            (gdrConsultarProd.DataSource as DataTable).DefaultView.RowFilter = "Convert(nombre, 'System.String') LIKE '" + txtNombre.Text + "%'";
        }

        private void btnActualizarCombo_Click(object sender, EventArgs e)
        {
            var currentRow = gdrConsultarProd.CurrentCell.RowIndex;
            DataGridViewRow selectedRow = gdrConsultarProd.Rows[currentRow];
            string nombreCombo = (gdrConsultarProd.Rows[currentRow].Cells[0].Value.ToString());
            int idProducto = int.Parse(gdrConsultarProd.Rows[currentRow].Cells[1].Value.ToString());
            string descripcion =(gdrConsultarProd.Rows[currentRow].Cells[2].Value.ToString());
            float precio = float.Parse(gdrConsultarProd.Rows[currentRow].Cells[3].Value.ToString());
            int cantidadItems = int.Parse(gdrConsultarProd.Rows[currentRow].Cells[4].Value.ToString());

            Entidades.Producto producto = new Entidades.Producto(idProducto,nombreCombo,descripcion,1,precio,cantidadItems,2);
            Main.main1.btnSubComboAltaCombo(producto);
        }

        private void btnEliminarCombo_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Desea eliminar este Combo ??",
                                     "Confirmación!!",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                var currentRow = gdrConsultarProd.CurrentCell.RowIndex;
                DataGridViewRow selectedRow = gdrConsultarProd.Rows[currentRow];
                int idProducto = int.Parse(gdrConsultarProd.Rows[currentRow].Cells[1].Value.ToString());
                Entidades.Producto producto = new Entidades.Producto(idProducto, "", "", 1, 0, 0, 1);
                AltaCombo altaCmb = new AltaCombo(producto);
                var result = altaCmb.cargarCombo(producto);
                if (result)
                {
                    MessageBox.Show("Combo eliminado con éxito!");
                    cargarGrilla();
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

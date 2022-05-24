using System.Data;
using TPG3.AccesoADatos;

namespace TPG3.Formularios.MedioPago
{
    public partial class ListaMedioPago : Form
    {
        public ListaMedioPago()
        {
            InitializeComponent();
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void dgvMedioPago_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ListaMedioPago_Load(object sender, EventArgs e)
        {
            cargarTabla();
        }

        private void cargarTabla()
        {
            try
            {
                dgvMedioPago.DataSource = AD_MedioPago.ObtenerTablaMediosPagos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener medios de pago.");
            }
            
        }

        private void btnCargarMP_Click(object sender, EventArgs e)
        {
            Entidades.MedioPago medio = new Entidades.MedioPago(-1,"", "",-1,"",3);

            Main.main1.btnSubMedioPagoAltaMedioPago(medio);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            var currentRow = dgvMedioPago.CurrentCell.RowIndex;
            DataGridViewRow selectedRow = dgvMedioPago.Rows[currentRow];
            int codigoMedioPago = int.Parse(dgvMedioPago.Rows[currentRow].Cells[0].Value.ToString());
            string nombre = dgvMedioPago.Rows[currentRow].Cells[1].Value.ToString();
            string descripcion = dgvMedioPago.Rows[currentRow].Cells[2].Value.ToString();
            int tarjeta = int.Parse(dgvMedioPago.Rows[currentRow].Cells[3].Value.ToString());
            string nombreTarjeta = dgvMedioPago.Rows[currentRow].Cells[4].Value.ToString();

            Entidades.MedioPago medio = new Entidades.MedioPago(codigoMedioPago,nombre,descripcion,tarjeta,nombreTarjeta,2);
            Main.main1.btnSubMedioPagoAltaMedioPago(medio);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Desea eliminar este Medio de Pago ??",
                                     "Confirmación!!",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                var currentRow = dgvMedioPago.CurrentCell.RowIndex;
                DataGridViewRow selectedRow = dgvMedioPago.Rows[currentRow];
                int codigoMedioPago = int.Parse(dgvMedioPago.Rows[currentRow].Cells[0].Value.ToString());
                Entidades.MedioPago medio = new Entidades.MedioPago(codigoMedioPago, "", "", 0, "", 1);
                AltaMedioPago altaMedioPago = new AltaMedioPago(medio);
                var result = altaMedioPago.cargarMP(medio);
                if (result)
                {
                    MessageBox.Show("Medio de Pago eliminado con éxito!");
                    cargarTabla();
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

using System.Data;
using TPG3.AccesoADatos;
using TPG3.Entidades;
using System.Data.SqlClient;

namespace TPG3.CapaLogicaNegocio
{
    public partial class PagoCombo : Form
    {
        float precioFinal;
        private List<EditItemCombo> listaCombos;
        public PagoCombo(List<EditItemCombo> combos)
        {
            this.listaCombos = combos;
            InitializeComponent();
            this.AutoScroll = true;
        }

        private void PagoCombo_Load(object sender, EventArgs e)
        {
            cargarCombos();
            cargarMediosDePago();
            this.precioFinal = precioTotalCombos();
            lblPrecioFinal.Text = "$" +  precioFinal.ToString();
            lblPrecioDescuento.Text = "$" + precioFinal.ToString();
            CargarGrillaPromo();
        }

        private void cargarCombos()
        {
            for (int i = 0; i < listaCombos.Count; i++)
            {
                dgvDetalleCombo.Rows.Add(listaCombos[i].nombre, listaCombos[i].cantidad.ToString(), listaCombos[i].precio.ToString(), (listaCombos[i].cantidad * listaCombos[i].precio).ToString());
            }
            
        }

        private void CargarGrillaPromo()
        {
            try
            {
                gridSeleccionPromo.DataSource = AD_Promocion.GetDetallePromocion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener el listado de promociones.");
            }
        }

        private float precioTotalCombos()
        {
            float total = 0;
            for (int rows = 0; rows < dgvDetalleCombo.Rows.Count; rows++)
            {
                total += int.Parse(dgvDetalleCombo.Rows[rows].Cells[3].Value.ToString());
            }
            return total;
        }

        private void cargarMediosDePago()
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

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (dgvMedioPagoSel.Rows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar un Medio de Pago.");
            }
            else
            {
                string msg = "Desea realizar esta venta ?";
                string npromocion = "Sin promoción";
                float promocion = 0;
                var cantR = gridPromoSel.Rows.Count;
                if (cantR == 0)
                {
                    msg = "Desea realizar esta venta sin Promoción ??";
                }
                else
                {
                    npromocion = gridPromoSel.Rows[0].Cells[0].Value.ToString();
                    promocion = float.Parse(gridPromoSel.Rows[0].Cells[2].Value.ToString());
                }
                var confirmResult = MessageBox.Show(msg,"Confirmación!!", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    var fechaHora = DateTime.Now;
                    var medioPago = int.Parse(dgvMedioPagoSel.Rows[0].Cells[0].Value.ToString());
                    int ultimoNroTicket = AD_Ticket.GetUltimoNumeroTicket();
                    Ticket tick = new Ticket(ultimoNroTicket + 1, fechaHora, medioPago, Main.main1.usuario.dni, Main.main1.usuario.tipoDocumento, npromocion, promocion);
                    var result = AD_Ticket.RegistrarTicket(tick, listaCombos);
                    if (result)
                    {
                        MessageBox.Show("Ticket creado con éxito.");
                    }
                    else
                    {
                        MessageBox.Show("Error al generar el ticket.");
                    }
                }                    
                Main.main1.formPagoCombo(listaCombos);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            (dgvMedioPago.DataSource as DataTable).DefaultView.RowFilter = "Convert(Nombre, 'System.String') LIKE '" + txtNombre.Text + "%'";
        }

        private void eliminarFila(int codigo)
        {
            int fila = -1;
            int eliminar = -1;
            for (int rows = 0; rows < dgvMedioPago.Rows.Count; rows++)
            {
                fila = int.Parse(dgvMedioPago.Rows[rows].Cells[0].Value.ToString());
                if (fila == codigo)
                {
                    eliminar = rows;
                    break;
                }
            }
            dgvMedioPago.Rows.RemoveAt(eliminar);
        }

        private void dgvMedioPago_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var currentRow = dgvMedioPago.CurrentCell.RowIndex;
            DataGridViewRow selectedRow = dgvMedioPago.Rows[currentRow];
            int codigo = int.Parse(dgvMedioPago.Rows[currentRow].Cells[0].Value.ToString());
            string nombre = dgvMedioPago.Rows[currentRow].Cells[1].Value.ToString();
            string descripcion = (dgvMedioPago.Rows[currentRow].Cells[2].Value.ToString());
            int tarjeta = int.Parse(dgvMedioPago.Rows[currentRow].Cells[3].Value.ToString());
            string nombreTarjeta = dgvMedioPago.Rows[currentRow].Cells[4].Value.ToString();
            dgvMedioPagoSel.Rows.Clear();
            dgvMedioPagoSel.Rows.Add(codigo,nombre,descripcion,tarjeta,nombreTarjeta);
            cargarMediosDePago();
            eliminarFila(codigo);
        }

        private void dgvMedioPagoSel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvMedioPagoSel.Rows.Clear();
            cargarMediosDePago();
        }

        private void eliminarFilaPromo(string nombre)
        {
            string nombrePromo = "";
            int eliminar = -1;
            for (int rows = 0; rows < gridSeleccionPromo.Rows.Count; rows++)
            {
                nombrePromo = gridSeleccionPromo.Rows[rows].Cells[0].Value.ToString();
                if (nombrePromo == nombre)
                {
                    eliminar = rows;
                    break;
                }
            }
            gridSeleccionPromo.Rows.RemoveAt(eliminar);
        }


        private void gridSeleccionPromo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var currentRow = gridSeleccionPromo.CurrentCell.RowIndex;
            DataGridViewRow selectedRow = gridSeleccionPromo.Rows[currentRow];
            string nombre = (gridSeleccionPromo.Rows[currentRow].Cells[0].Value.ToString());
            string descripcion = (gridSeleccionPromo.Rows[currentRow].Cells[1].Value.ToString());
            float valor = float.Parse(gridSeleccionPromo.Rows[currentRow].Cells[2].Value.ToString());
            gridPromoSel.Rows.Clear();
            gridPromoSel.Rows.Add(nombre, descripcion, valor);
            CargarGrillaPromo();
            eliminarFilaPromo(nombre);
            var precioConDescuento = precioFinal - valor;
            lblPrecioDescuento.Text = "$" + precioConDescuento.ToString();
        }

        private void gridPromoSel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            gridPromoSel.Rows.Clear();
            CargarGrillaPromo();
        }
    }
}

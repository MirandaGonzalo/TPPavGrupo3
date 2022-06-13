using System.Data;
using System.Data.SqlClient;
using TPG3.AccesoADatos;
using TPG3.Entidades;

namespace TPG3.CapaLogicaNegocio
{
    public partial class TarifaService : Form
    {
        private DateTime fechaHora;
        private int sala;
        private int codFormato;
        List<int> listaTarifasSel;        
        public int asientosDisp;
        public TarifaService(DateTime fechaH, int salaS, int formato)
        {
            listaTarifasSel = new List<int>();            
            listaTarifasSel.Add(-1);
            this.fechaHora = fechaH;
            this.sala = salaS;
            this.codFormato = formato;
            var asOc = AD_AsientoXSala.GetAsientos(fechaHora, sala);
            this.asientosDisp = 34 - asOc.Count;
            InitializeComponent();
            lblAsientosDis.Text = "Asientos Disponibles: " + asientosDisp.ToString();
            this.AutoScroll = true;
        }

        private void TarifaService_Load(object sender, EventArgs e)
        {
            CargarGrillaTarifa();
            CargarGrillaPromo();
            cargarMediosDePago();
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

        private void CargarGrillaTarifa()
        {
            try
            {                
                gdrSeleccionTarifa.DataSource = AD_Tarifa.ObtenerTablaTarifasFormato(codFormato);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener el listado de tarifas.");
            }
        }
        private void CargarGrillaPromo()
        {
            try
            {
                gridSeleccionPromo.DataSource = AD_Promocion.GetDetallePromocion();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al obtener el listado de promociones.");
            }
        }
        private void gdrSeleccionTarifa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnContinuar.Enabled = true;
            int indice = e.RowIndex;
            DataGridViewRow filaSeleccionada = gdrSeleccionTarifa.Rows[indice];

        }


        private void gridSeleccionPromo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            DataGridViewRow filaSeleccionada = gridSeleccionPromo.Rows[indice];

            string nombrePromo = filaSeleccionada.Cells["Nombre"].Value.ToString();            
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {

        }

        private void mostrarTarifasDisponibles()
        {
            string cadenaConexion = System.Configuration.ConfigurationSettings.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = (String.Format("SELECT t.idTarifa AS 'idTarifa',t.descripcion AS 'descripcion', " +
                "f.descripcion AS 'formato',t.valor AS 'valor'FROM Tarifa AS t JOIN Formato AS f " +
                "ON(t.codFormato = f.codFormato) WHERE t.codFormato = @codFormato and " +
                "t.idTarifa NOT IN ({0}) ", String.Join(",", listaTarifasSel)));

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@codFormato", codFormato);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;
                cn.Open();
                cmd.Connection = cn;
                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);
                gdrSeleccionTarifa.DataSource = tabla;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                cn.Close();
            }
        }

        private void calcularTotal()
        {
            float total = 0;
            float valor = 0;
            int cantidad = 0;
            for (int rows = 0; rows < grdTarifasSel.Rows.Count; rows++)
            {
                valor = float.Parse(grdTarifasSel.Rows[rows].Cells[3].Value.ToString());
                cantidad = int.Parse(grdTarifasSel.Rows[rows].Cells[4].Value.ToString());
                total += valor * cantidad;
            }
            lblPrecioFinal.Text = total.ToString();
        }

        private void calcularPrecioConPromocion()
        {
            float total = 0;
            for (int rows = 0; rows < gridPromoSel.Rows.Count; rows++)
            {
                total = float.Parse(gridPromoSel.Rows[rows].Cells[2].Value.ToString());
            }
            var precioFinal = int.Parse(lblPrecioFinal.Text);
            float precioConPromocion = precioFinal - total;
            if (precioConPromocion < 0)
            {
                lblPrecioFinalDescuento.Text = "0";
            }
            else
            {
                lblPrecioFinalDescuento.Text = precioConPromocion.ToString();
            }
        }

        private void gdrSeleccionTarifa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var currentRow = gdrSeleccionTarifa.CurrentCell.RowIndex;
            DataGridViewRow selectedRow = gdrSeleccionTarifa.Rows[currentRow];
            int idTarifa = int.Parse(gdrSeleccionTarifa.Rows[currentRow].Cells[0].Value.ToString());
            listaTarifasSel.Add(idTarifa);
            string descripcion = (gdrSeleccionTarifa.Rows[currentRow].Cells[1].Value.ToString());
            string formato = gdrSeleccionTarifa.Rows[currentRow].Cells[2].Value.ToString();
            float valor = float.Parse(gdrSeleccionTarifa.Rows[currentRow].Cells[3].Value.ToString());
            grdTarifasSel.Rows.Add(idTarifa, descripcion, formato, valor, 1);
            mostrarTarifasDisponibles();
            calcularTotal();
        }

        private void grdTarifasSel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var currentRow = grdTarifasSel.CurrentCell.RowIndex;
            DataGridViewRow selectedRow = grdTarifasSel.Rows[currentRow];
            int idTarifa = int.Parse(grdTarifasSel.Rows[currentRow].Cells[0].Value.ToString());
            listaTarifasSel.Remove(idTarifa);
            mostrarTarifasDisponibles();
            grdTarifasSel.Rows.RemoveAt(currentRow);
        }

        private void eliminarFila(string nombre)
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

        private int cantidadEntradas()
        {
            int cantidad = 0;
            for (int rows = 0; rows < grdTarifasSel.Rows.Count; rows++)
            {
                cantidad += int.Parse(grdTarifasSel.Rows[rows].Cells[4].Value.ToString());
            }
            return cantidad;
        }

        private void gridSeleccionPromo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var currentRow = gridSeleccionPromo.CurrentCell.RowIndex;
            DataGridViewRow selectedRow = gridSeleccionPromo.Rows[currentRow];
            string nombre = (gridSeleccionPromo.Rows[currentRow].Cells[0].Value.ToString());
            string descripcion = (gridSeleccionPromo.Rows[currentRow].Cells[1].Value.ToString());
            float valor = float.Parse(gridSeleccionPromo.Rows[currentRow].Cells[2].Value.ToString());
            gridPromoSel.Rows.Clear();
            gridPromoSel.Rows.Add(nombre,descripcion,valor);
            CargarGrillaPromo();
            eliminarFila(nombre);
            calcularTotal();
            calcularPrecioConPromocion();
        }

        private void gridPromoSel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            gridPromoSel.Rows.Clear();
            CargarGrillaPromo();
        }
        private List<int> obtenerCantidadXTarifa()
        {
            List<int> listaCantTarifas = new List<int>();
            int cantidad = -1;
            int id = -1;
            for (int rows = 0; rows < grdTarifasSel.Rows.Count; rows++)
            {
                id = int.Parse(grdTarifasSel.Rows[rows].Cells[0].Value.ToString());
                cantidad = int.Parse(grdTarifasSel.Rows[rows].Cells[4].Value.ToString());
                for (int j = 0; j < cantidad; j++)
                {
                    listaCantTarifas.Add(id);
                }
            }
            return listaCantTarifas;
        }

        private List<float> obtenerPrecioXTarifa()
        {
            List<float> listaPrecio = new List<float>();
            int cantidad = -1;
            float precio = -1;
            for (int rows = 0; rows < grdTarifasSel.Rows.Count; rows++)
            {
                precio = float.Parse(grdTarifasSel.Rows[rows].Cells[3].Value.ToString());
                cantidad = int.Parse(grdTarifasSel.Rows[rows].Cells[4].Value.ToString());
                for (int j = 0; j < cantidad; j++)
                {
                    listaPrecio.Add(precio);
                }
            }
            return listaPrecio;
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            if (grdTarifasSel.Rows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar una tarifa.");
            }
            else
            {
                if (dgvMedioPagoSel.Rows.Count == 0){
                    MessageBox.Show("Debe seleccionar un medio de pago.");
                }
                else
                {
                    if (gridPromoSel.Rows.Count == 0)
                    {
                        MessageBox.Show("Debe seleccionar una promoción.");
                    }
                    else
                    {
                        string promocion = (gridPromoSel.Rows[0].Cells[0].Value.ToString());
                        float descPromo = float.Parse(gridPromoSel.Rows[0].Cells[2].Value.ToString());
                        int cantEntradas = cantidadEntradas();
                        if (cantEntradas > asientosDisp)
                        {
                            MessageBox.Show("La cantidad de asientos ingresada no es válida.");
                        }
                        else
                        {
                            var medioPago = int.Parse(dgvMedioPagoSel.Rows[0].Cells[0].Value.ToString());
                            Main.main1.formSeleccionarAsientos(fechaHora, sala, obtenerCantidadXTarifa(),obtenerPrecioXTarifa() ,cantidadEntradas(), promocion, descPromo, codFormato, medioPago);
                        }
                    }
                }
                
            }
        }

        private void eliminarFilaMedioPago(int codigo)
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
            dgvMedioPagoSel.Rows.Add(codigo, nombre, descripcion, tarjeta, nombreTarjeta);
            cargarMediosDePago();
            eliminarFilaMedioPago(codigo);
        }

        private void dgvMedioPagoSel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvMedioPagoSel.Rows.Clear();
            cargarMediosDePago();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}

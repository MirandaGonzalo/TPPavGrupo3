using TPG3.AccesoADatos;

namespace TPG3.Formularios.Producto
{
    public partial class AltaProducto : Form
    {
        private Entidades.Producto producto;
        public AltaProducto(Entidades.Producto prod)
        {
            this.producto = prod;
            InitializeComponent();
        }
        private void AltaProducto_Load(object sender, EventArgs e)
        {
            LimpiarCampos();
            btnActualizar.Enabled = false;
            CargarComboTipoProducto();
            CargarGrilla();
            lblError.Visible = false;
        }

        private void LimpiarCampos()
        {
            txtPrecio1.Text = "";
            txtNombreProducto.Text = "";
            txtDescripcion1.Text = "";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            bool camposCorrectos = validarCamposNoVacios();
                
            if (camposCorrectos)
            {
                Entidades.Producto p = ObtenerDatosProducto();
                bool resultado = AD_Producto.AgregarProductoABD(p);

                if (resultado)
                {
                    MessageBox.Show("Producto agregado con éxito");
                    LimpiarCampos();
                    CargarComboTipoProducto();
                    CargarGrilla();
                }
                else
                {
                    MessageBox.Show("Error al cargar el producto");
                }
            }
            else
            {
                MessageBox.Show("Datos Incorrectos, Ingrese nuevamente los Datos");
            }
            
        }

        private Entidades.Producto ObtenerDatosProducto()
        {
            Entidades.Producto prod = new Entidades.Producto(-1,"","",-1,0,0,-1);

            prod.TipoProducto = (int)cmbTipoProducto1.SelectedValue;
            prod.Nombre = txtNombreProducto.Text.Trim();
            prod.Descripcion = txtDescripcion1.Text.Trim();
            prod.Precio = float.Parse(txtPrecio1.Text);
            

            return prod;
        }

        private void CargarComboTipoProducto()
        {
            try
            {
                cmbTipoProducto1.DataSource = AD_TipoProducto.ObtenerTipoProducto();
                cmbTipoProducto1.DisplayMember = "nombreTipoProd";
                cmbTipoProducto1.ValueMember = "idTipoProducto";
                cmbTipoProducto1.SelectedIndex = 0;
            }

            catch (Exception)
            {
                MessageBox.Show("Error al cargar combo tipo producto");
            }
        }
        private void CargarGrilla()
        {
            try
            {
                gdrActualizarProd.DataSource = AD_Producto.ObtenerTablaProducto();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al obtener productos");
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Entidades.Producto p = ObtenerDatosProducto();
            bool camposCorrectos = validarCamposNoVacios();

            if (camposCorrectos)
            {
                bool resultado = AD_Producto.ActualizarProducto(p);
                if (resultado)
                {
                    MessageBox.Show("Producto actualizado con éxito");
                    LimpiarCampos();
                    CargarGrilla();
                    CargarComboTipoProducto();
                }
                else
                {
                    MessageBox.Show("Error al actualizar producto");
                };
            }
            else
            {
                MessageBox.Show("Datos Incorrectos, Ingrese nuevamente los Datos");
            }
        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void gdrActualizarProd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnActualizar.Enabled = true;
            int indice = e.RowIndex;
            btnActualizar.Enabled = true;
            DataGridViewRow filaSeleccionada = gdrActualizarProd.Rows[indice];

            int idProducto = (int)filaSeleccionada.Cells["IdProducto"].Value;
            Entidades.Producto p = AD_Producto.ObtenerProducto(idProducto);
            LimpiarCampos();
            CargarCampos(p);
        }
        private void CargarCampos(Entidades.Producto p)
        {
            cmbTipoProducto1.SelectedValue = p.TipoProducto;
            txtNombreProducto.Text = p.Nombre;
            txtDescripcion1.Text = p.Descripcion;
            txtPrecio1.Text = p.Precio.ToString();
        }

        private bool validarCamposNoVacios()
        {
            if (txtNombreProducto.Text.Trim().Equals(""))
            {
                lblError.Visible = true;
                lblError.Text = " El campo Nombre Producto no puede estar vacío.";
                txtNombreProducto.Focus();
                return false;
            }
            int parsedValue;
            if (!int.TryParse(txtPrecio1.Text, out parsedValue))
            {
                lblError.Visible = true;
                lblError.Text = "El campo Precio solo debe contener números.";
                txtPrecio1.Focus();
            }
            if (txtPrecio1.Text.Trim().Equals(""))
            {
                lblError.Visible = true;
                lblError.Text = "El campo Precio no puede estar vacío o tener un valor menor a cero.";
                txtPrecio1.Focus();
                return false;
            }
            if (txtDescripcion1.Text.Trim().Equals(""))
            {
                lblError.Visible = true;
                lblError.Text = "El campo Descripción no puede estar vacío.";
                txtDescripcion1.Focus();
                return false;
            }
            return true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPG3.Entidades;

namespace TPG3.Formularios.Combo
{
    public partial class AltaCombo : Form
    {
        public AltaCombo()
        {
            InitializeComponent();
        }

        private void AltaCombo_Load(object sender, EventArgs e)
        {
            LimpiarCampo();
            CargarGrillaListadoProducto();
        }

        private void LimpiarCampo()
        {
            txtNombreCombro.Text = "";
            txtPrecioCombo.Text = "";
            txtDescripcionCombo.Text = "";
            txtCantidad.Text = "";
        }

        private void CargarGrillaListadoProducto()
        {
            try
            {
                gdrActualizarProd.DataSource = AD_Producto.ObtenerTablaProducto();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener productos");
            }
        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            LimpiarCampo();
        }

        private void btnAgregarCombo_Click(object sender, EventArgs e)
        {
            Productos nombreCombo = ObtenerDatosNombreCombo();
            //List<Productos> productosCombo = ObtenerProductosCombo();
        }
        private Productos ObtenerDatosNombreCombo()
        {
            Productos nombreCombo = new Productos();

            nombreCombo.TipoProducto = 1;
            nombreCombo.Nombre = txtNombreCombro.Text.Trim();
            nombreCombo.Descripcion = txtDescripcionCombo.Text.Trim();
            nombreCombo.Precio = float.Parse(txtPrecioCombo.Text);


            return nombreCombo;
        }

        //private List<Productos> ObtenerProductosCombo()
        //{

        //}

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        }

        private void btnRegistrarCombo_Click(object sender, EventArgs e)
        {
            Main.main1.btnSubComboAltaCombo(sender, e);

        }

        //private void CargarCombo()
        //{
        //    try
        //    {
        //        cmbCombo.DataSource = AD_Producto.ObtenerTipoProducto();
        //        cmbCombo.DisplayMember = "nombreTipoProd";
        //        cmbCombo.ValueMember = "idTipoProducto";
        //        cmbCombo.SelectedIndex = -1;
        //    }

        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error al cargar combo tipo producto");
        //    }
        //}









    }
}

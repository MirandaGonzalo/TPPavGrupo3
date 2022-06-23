using System;
using ProbandoMigrar.Estadisticas.ProductosXTipo;
using System.Windows.Forms;
using ProbandoMigrar.Estadisticas.Funcion;
using ProbandoMigrar.Estadisticas.Pelicula;
using ProbandoMigrar.Estadisticas.TicketEntrada;
using ProbandoMigrar.Estadisticas.Promocion;
using ProbandoMigrar.Estadisticas.Descuentos;
using ProbandoMigrar.Estadisticas.Empleado;
using ProbandoMigrar.Estadisticas.Combo;
using ProbandoMigrar.Estadisticas.Formato;
using ProbandoMigrar.Estadisticas.PrecioDescuento;

namespace TPG3.Formularios.Estadisticas
{
    public partial class Estadisticas : Form
    {
        public Estadisticas()
        {
            InitializeComponent();
        }

        private void btnProdXTipo_Click(object sender, EventArgs e)
        {
            EstadisticaProductoXTipo formulario = new EstadisticaProductoXTipo();
            formulario.ShowDialog();
        }

        private void btnFunciones_Click(object sender, EventArgs e)
        {
            EstadisticaFuncion formulario = new EstadisticaFuncion();
            formulario.ShowDialog();
        }

        private void btnEstadisticaPeliculas_Click(object sender, EventArgs e)
        {
            EstadisticaPelicula formulario = new EstadisticaPelicula();
            formulario.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            EstadisticaTicketEntrada formulario = new EstadisticaTicketEntrada();
            formulario.ShowDialog();
        }

        private void btnPromocion_Click(object sender, EventArgs e)
        {
            EstadisticaPromocion formulario = new EstadisticaPromocion();
            formulario.ShowDialog();
        }

        private void btnDescuentos_Click(object sender, EventArgs e)
        {
            EstadisticaDescuento formulario = new EstadisticaDescuento();
            formulario.ShowDialog();
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            EstadisticaEmpleado formulario = new EstadisticaEmpleado();
            formulario.ShowDialog();
        }

        private void btnCombos_Click(object sender, EventArgs e)
        {
            EstadisticaCombo formulario = new EstadisticaCombo();
            formulario.ShowDialog();
        }

        private void btnEstadisticaFormato_Click(object sender, EventArgs e)
        {
            EstadisticaFormato formulario = new EstadisticaFormato();
            formulario.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            EstadisticaPrecioDescuento formulario = new EstadisticaPrecioDescuento();
            formulario.ShowDialog();
        }
    }
}

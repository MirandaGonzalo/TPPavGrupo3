using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using TPG3.Entidades;
using TPG3.AccesoADatos;
using ProbandoMigrar.Reportes;
using ProbandoMigrar.Reportes.Funcion;
using ProbandoMigrar.Reportes.Empleado;
using ProbandoMigrar.Reportes.Producto;
using ProbandoMigrar.Reportes.Pelicula;
using ProbandoMigrar.Reportes.Tarifa;
using ProbandoMigrar.Reportes.Promociones;
using ProbandoMigrar.Reportes.Entrada;

namespace TPG3.Formularios.Reportes
{
    public partial class Reportes : Form
    {
        public Reportes()
        {
            InitializeComponent();
        }

        private void btnReporteListCliente_Click(object sender, EventArgs e)
        {
            ReporteListadoCliente formulario = new ReporteListadoCliente();
            formulario.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ReporteFuncion formulario = new ReporteFuncion();
            formulario.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ReporteCombo formulario = new ReporteCombo();
            formulario.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ReporteEmpleado formulario = new ReporteEmpleado();
            formulario.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReporteProducto formulario = new ReporteProducto();
            formulario.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ReportePelicula formulario = new ReportePelicula();
            formulario.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ReporteTarifa formulario = new ReporteTarifa();
            formulario.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ReportePromo formulario = new ReportePromo();
            formulario.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //ReporteTarjeta formulario = new ReporteTarjeta();
            //formulario.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ReporteEntrada formulario = new ReporteEntrada();
            formulario.ShowDialog();
        }
    }
}

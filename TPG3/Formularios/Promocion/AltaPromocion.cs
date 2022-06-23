using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using TPG3.Entidades;
using TPG3.AccesoADatos;

namespace TPG3.Formularios.Promocion
{
    public partial class AltaPromocion : Form
    {
        private Entidades.Promocion promo;
        public AltaPromocion(Entidades.Promocion editPromo)
        {
            promo = editPromo;
            InitializeComponent();
            cargarFormulario(promo);
        }

        private void limpiarEspacios()
        {
            mtbValor.Text = mtbValor.Text.Replace("_", "");
            mtbInicio.Text = mtbInicio.Text.Replace(" ", "0");
            mtbInicio.Text = mtbInicio.Text.Replace("_", "0");
            mtbFin.Text = mtbFin.Text.Replace(" ", "0");
            mtbFin.Text = mtbFin.Text.Replace("_", "0");
        }

        private void cargarFormulario(Entidades.Promocion editPromo)
        {
            if (editPromo.TipoEdicion > 1)
            {
                if (editPromo.TipoEdicion == 2)
                {
                    txtNombre.Text = editPromo.nombre;
                    txtNombre.Enabled = false;
                    txtDescripcion.Text = editPromo.descripcion;
                    mtbValor.Text = editPromo.valor.ToString();
                    mtbInicio.Text = completarFecha(editPromo.fechaInicio);
                    mtbFin.Text = completarFecha(editPromo.fechaFin);
                    lblTitulo.Text = "Modificar Promoción";
                    btnCargarPromocion.Text = "Modificar";
                    limpiarEspacios();
                }
                else
                {
                    DateTime inicio = DateTime.Today;
                    DateTime fin = inicio.AddDays(7);
                    mtbInicio.Text = completarFecha(inicio);
                    mtbFin.Text = completarFecha(fin);
                }
            }
        }

        private string completarFecha(DateTime fechaInicial)
        {
            string fecha = fechaInicial.ToString();
            int charLocation = fecha.IndexOf("/", StringComparison.Ordinal);
            string resto = "";
            string dia = fecha.Substring(0, charLocation);
            if (dia.Length == 1) dia = "0" + dia;
            resto = fecha.Substring(charLocation + 1);
            int charLocation2 = resto.IndexOf("/", StringComparison.Ordinal);
            string mes = resto.Substring(0, charLocation2);
            if (mes.Length == 1) mes = "0" + mes;
            string año = resto.Substring(charLocation2 + 1);
            string fechaFinal = dia + "/" + mes + "/" + año;
            return fechaFinal;
        }

        private void btnCargarPromocion_Click(object sender, EventArgs e)
        {
            limpiarEspacios();
            //validamos los datos
            bool valido = validarCampos();
            if (valido)
            {
                promo.nombre = txtNombre.Text;
                promo.descripcion = txtDescripcion.Text;
                promo.valor = float.Parse(mtbValor.Text.Trim());
                promo.fechaInicio = DateTime.Parse(mtbInicio.Text);
                promo.fechaFin = DateTime.Parse(mtbFin.Text);
                bool result = AD_Promocion.cargarPromocion(promo);
                if (result)
                {   
                    if (promo.TipoEdicion == 3)
                    {
                        MessageBox.Show("Promoción cargada con éxito!");
                    }
                    else
                    {
                        MessageBox.Show("Promoción actualizada con éxito!");
                    }
                    lblError.Text = "";
                    btnListado_Click(sender, e);                    
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool validarFormatoDate(String fecha)
        {
            string inputString = fecha;
            DateTime dDateInicio;

            if (DateTime.TryParse(inputString, out dDateInicio))
            {
                String.Format("{0:dd/MM/yyyy}", dDateInicio);
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool validarCampos()
        {
            if (txtNombre.Text.Trim().Equals(""))
            {
                lblError.Text = "El campo Nombre no puede estar vacío.";
                txtNombre.Focus();
                return false;
            }
            if (mtbValor.Text.Trim().Equals(""))
            {
                lblError.Text = "El campo Valor no puede estar vacío.";
                mtbValor.Focus();
                return false;
            }
            
            if (mtbInicio.Text.Trim().Equals(""))
            {
                lblError.Text = "El campo Fecha Inicio no puede estar vacío.";
                mtbInicio.Focus();
                return false;
            }
            if (mtbFin.Text.Trim().Equals(""))
            {
                lblError.Text = "El campo Fecha Fin no puede estar vacío.";
                mtbFin.Focus();
                return false;
            }
            int count = 0;
            foreach (char c in mtbInicio.Text)
            {    
                count++;   
            }
            if (count < 10)
            {
                lblError.Text = "La Fecha Inicio no está completa (dd/mm/yyyy).";
                mtbInicio.Focus();
                return false;
            }
            count = 0;
            foreach (char c in mtbFin.Text)
            {
                count++;
            }
            if (count < 10)
            {
                lblError.Text = "La Fecha Fin no está completa (dd/mm/yyyy).";
                mtbFin.Focus();
                return false;
            }
            if (!validarFormatoDate(mtbInicio.Text))
            {
                lblError.Text = "La Fecha Inicio no está en el formato correcto (dd/mm/yyyy).";
                mtbInicio.Focus();
                return false;
            }
            if (!validarFormatoDate(mtbFin.Text))
            {
                lblError.Text = "La Fecha Fin no está en el formato correcto (dd/mm/yyyy).";
                mtbFin.Focus();
                return false;
            }
            var date = new DateTime(1800, 1, 1);
            DateTime fechaInicio = DateTime.ParseExact(mtbInicio.Text, "dd/MM/yyyy", null);
            if (fechaInicio <= date)
            {
                lblError.Text = "La Fecha Inicio no es válida.";
                mtbInicio.Focus();
                return false;
            }
            DateTime fechaFin = DateTime.ParseExact(mtbFin.Text, "dd/MM/yyyy", null);
            if (fechaFin <= date)
            {
                lblError.Text = "La Fecha Fin no es válida.";
                mtbFin.Focus();
                return false;
            }
            if (fechaFin <= fechaInicio)
            {
                lblError.Text = "La Fecha Inicio debe ser menor que la Fecha Fin.";
                mtbInicio.Focus();
                return false;
            }
            return true;
        }

        private void btnListado_Click(object sender, EventArgs e)
        {
            Main.main1.btnSubPromocion_Click(sender, e);
        }
    }
}

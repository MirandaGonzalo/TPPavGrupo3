using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPG3.AccesoADatos;

namespace TPG3.Formularios.Cliente
{
    public partial class AltaCliente : Form
    {
        private Entidades.Cliente cliente;
        public AltaCliente(Entidades.Cliente cli)
        {
            cliente = cli;
            InitializeComponent();
            cargarFormulario(cli);
        }
        private void limpiarEspacios()
        {
            mtbDni.Text = mtbDni.Text.Replace("_", "");
            mtbTelefono.Text = mtbTelefono.Text.Replace("_", "");
        }

        private string completarFecha(DateTime fechaInicial)
        {
            string fecha = fechaInicial.ToString();
            int charLocation = fecha.IndexOf("/", StringComparison.Ordinal);
            string resto = "";
            string dia = fecha.Substring(0, charLocation);
            if (dia.Count() == 1) dia = "0" + dia;
            resto = fecha.Substring(charLocation + 1);
            int charLocation2 = resto.IndexOf("/", StringComparison.Ordinal);
            string mes = resto.Substring(0, charLocation2);
            if (mes.Count() == 1) mes = "0" + mes;
            string año = resto.Substring(charLocation2 + 1);
            string fechaFinal = dia + "/" + mes + "/" + año;
            return fechaFinal;
        }

        private void cargarFormulario(Entidades.Cliente editCliente)
        {
            if (editCliente.TipoEdicion > 1)
            {
                if (editCliente.TipoEdicion == 2)
                {
                    mtbDni.Text = editCliente.dni.ToString().Trim();
                    Componentes.ComboboxItem item = new Componentes.ComboboxItem();
                    item.Text = editCliente.nombreTipoDocumento;
                    item.Value = editCliente.tipoDocumento;
                    cbTipoDoc.Items.Add(item);
                    mtbDni.Enabled = false;
                    cbTipoDoc.Enabled = false;
                    cbTipoDoc.SelectedIndex = cbTipoDoc.FindString(editCliente.nombreTipoDocumento);
                    cbTipoDoc.SelectedValue = editCliente.tipoDocumento;
                    txtNombre.Text = editCliente.nombre;
                    txtApellido.Text = editCliente.apellido;
                    mtbNacimiento.Text = completarFecha(editCliente.fechaNacimiento);
                    mtbTelefono.Text = editCliente.telefono.Trim();
                    txtEmail.Text = editCliente.email;
                    lblTitulo.Text = "Actualizar Cliente";
                    btnCargarCliente.Text = "Actualizar";
                    limpiarEspacios();
                }
                else
                {
                    cargarComboTiposDescuentos();
                }
            }
        }

        private void btnCargarPromocion_Click(object sender, EventArgs e)
        {
            //validamos los datos
            limpiarEspacios();
            bool valido = validarCampos();
            if (valido)
            {
                bool result = cargarCliente(cliente);
                if (result)
                {
                    if (cliente.TipoEdicion == 3)
                    {
                        MessageBox.Show("Cliente cargado con éxito!");
                    }
                    else
                    {
                        MessageBox.Show("Cliente actualizado con éxito!");
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
        private void cargarComboTiposDescuentos()
        {
            try
            {
                cbTipoDoc.DataSource = AD_TipoDocumento.ObtenerTablaTiposDocumentos();
                cbTipoDoc.DisplayMember = "Nombre";
                cbTipoDoc.ValueMember = "idTipoDocumento";
            }
            catch (Exception)
            {
                MessageBox.Show("Error al obtener los tipos de documentos.");
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
            if (mtbDni.Text.Trim().Equals(""))
            {
                lblError.Text = "El campo Dni no puede estar vacío.";
                mtbDni.Focus();
                return false;
            }
            if (txtNombre.Text.Trim().Equals(""))
            {
                lblError.Text = "El campo Nombre no puede estar vacío.";
                txtNombre.Focus();
                return false;
            }
            if (txtApellido.Text.Trim().Equals(""))
            {
                lblError.Text = "El campo Apellido no puede estar vacío.";
                txtApellido.Focus();
                return false;
            }
            int count = 0;
            foreach (char c in mtbNacimiento.Text)
            {
                count++;
            }
            if (count < 10)
            {
                lblError.Text = "La Fecha no está completa (dd/mm/yyyy).";
                mtbNacimiento.Focus();
                return false;
            }
            if (!validarFormatoDate(mtbNacimiento.Text))
            {
                lblError.Text = "La Fecha de Nacimiento no está en el formato correcto (dd/mm/yyyy).";
                mtbNacimiento.Focus();
                return false;
            }
            var date = new DateTime(1800, 1, 1);
            DateTime fechaInicio = DateTime.ParseExact(mtbNacimiento.Text.Trim(), "dd/MM/yyyy", null);
            if (fechaInicio <= date)
            {
                lblError.Text = "La Fecha de Nacimiento no es válida.";
                mtbNacimiento.Focus();
                return false;
            }
            return true;
        }

        public bool cargarCliente(Entidades.Cliente cliente)
        {
            if (cliente.TipoEdicion > 1)
            {
                cliente.dni = int.Parse(mtbDni.Text);
                cliente.nombre = txtNombre.Text.Trim();
                cliente.apellido = txtApellido.Text.Trim();
                cliente.email = txtEmail.Text.Trim();
                var fechaN = mtbNacimiento.Text;
                cliente.fechaNacimiento = DateTime.Parse(fechaN);
                cliente.telefono = mtbTelefono.Text.Trim();
                //Crear
                if (cliente.TipoEdicion == 3)
                {
                    
                    try
                    {
                        cliente.tipoDocumento = (int)cbTipoDoc.SelectedValue;
                        AD_Cliente.AgregarCliente(cliente);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Error al insertar el cliente.");
                        return false;
                    }
                    
                }
                //Modificar
                else
                {
                    try
                    {
                        AD_Cliente.ActualizarCliente(cliente);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Error al actualizar el cliente.");
                        return false;
                    }
                }
            }
            else
            {
                try
                {
                    AD_Cliente.EliminarCliente(cliente);
                }
                catch (Exception)
                {
                    return false;
                }
                
            }
            return true;

        }

        private void btnListado_Click(object sender, EventArgs e)
        {
            Main.main1.btnSubCliente_Click(sender, e);
        }

        private void AltaCliente_Load(object sender, EventArgs e)
        {

        }
    }
}

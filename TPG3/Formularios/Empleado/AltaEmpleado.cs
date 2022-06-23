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

namespace TPG3.Formularios.Empleado
{
    public partial class AltaEmpleado : Form
    {
        private Entidades.Empleado empleado;
        public AltaEmpleado(Entidades.Empleado emp)
        {
            empleado = emp;
            InitializeComponent();
            cargarFormulario(emp);
        }
        private void limpiarEspacios()
        {
            mtbDni.Text = mtbDni.Text.Replace("_","");
            mtbTelefono.Text = mtbTelefono.Text.Replace("_", "");            
        }
        private void cargarFormulario(Entidades.Empleado editEmpleado)
        {            
            if (editEmpleado.TipoEdicion > 1)
            {
                if (editEmpleado.TipoEdicion == 2)
                {
                    mtbDni.Text = editEmpleado.dni.ToString().Trim();
                    Componentes.ComboboxItem item = new Componentes.ComboboxItem();
                    item.Text = editEmpleado.nombreTipoDocumento;
                    item.Value = editEmpleado.tipoDocumento;
                    cbTipoDoc.Items.Add(item);
                    mtbDni.Enabled = false;
                    cbTipoDoc.Enabled = false;
                    cbTipoDoc.SelectedIndex = cbTipoDoc.FindString(editEmpleado.nombreTipoDocumento);
                    cbTipoDoc.SelectedValue = editEmpleado.tipoDocumento;
                    txtNombre.Text = editEmpleado.nombre;
                    txtApellido.Text = editEmpleado.apellido;
                    mtbTelefono.Text = editEmpleado.telefono.Trim();
                    txtEmail.Text = editEmpleado.email;
                    lblTitulo.Text = "Modificar Empleado";
                    limpiarEspacios();
                }
                else
                {
                    cargarComboTiposDocumentos();
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
                bool result = cargarEmpleado(empleado);
                if (result)
                {
                    if (empleado.TipoEdicion == 3)
                    {
                        MessageBox.Show("Empleado cargado con éxito!");
                    }
                    else
                    {
                        MessageBox.Show("Empleado actualizado con éxito!");
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

        private void cargarComboTiposDocumentos()
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
            return true;
        }

        public bool cargarEmpleado(Entidades.Empleado empleado)
        {
            if (empleado.TipoEdicion > 1)
            {
                try
                {
                    empleado.nombre = txtNombre.Text;
                    empleado.apellido = txtApellido.Text;
                    empleado.email = txtEmail.Text;
                    empleado.telefono = mtbTelefono.Text;
                    empleado.dni = int.Parse(mtbDni.Text);
                    //Crear
                    if (empleado.TipoEdicion == 3)
                    {
                        empleado.tipoDocumento = (int)cbTipoDoc.SelectedValue;
                        AD_Empleado.CargarEmpleado(empleado);
                    }
                    //Modificar
                    else
                    {
                        AD_Empleado.ActualizarEmpleado(empleado);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Error.");
                    return false;
                }
            }
            else
            {
                try
                {
                    AD_Usuario.EliminarUsuario(empleado.dni, empleado.tipoDocumento);
                    try
                    {
                        AD_Empleado.EliminarEmpleado(empleado);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Error al eliminar el empleado.");
                        return false;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Error al eliminar el usuario del empleado.");
                    return false;
                }
            }
            return true;
        }

        private void btnListado_Click(object sender, EventArgs e)
        {
            Main.main1.btnSubEmpleado_Click(sender, e);
        }
    }
}


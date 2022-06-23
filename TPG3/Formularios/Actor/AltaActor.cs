using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using TPG3.AccesoADatos;
using TPG3.Entidades;

namespace TPG3.Formularios.Actores
{
    public partial class AltaActor : Form
    {
        public AltaActor(Entidades.Actor actor)
        {
            InitializeComponent();
            CargarGrilla();
        }

        private void AltaActor_Load(object sender, EventArgs e)
        {
            btnActualizarActor.Enabled = false;
            lblError.Visible = false;
            LimpiarCampos();
            CargarGrilla();
        }

        private void LimpiarCampos()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
        }
        private void CargarGrilla()
        {
            try
            {
                dtgActualizarActor.DataSource = AD_Actor.ObtenerTablaActor();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al obtener listado de actores.");
            }
        }

       
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            bool camposCorrectos = validarCamposNoVacios();

            if (camposCorrectos)
            {
                Actor r = ObtenerDatosActor();

                bool resultado = AD_Actor.AgregarActorABD(r);

                if (resultado)
                {
                    MessageBox.Show("Actor agregado con éxito");
                    LimpiarCampos();
                    CargarGrilla();
                }
                else
                {
                    MessageBox.Show("Error al cargar el actor");
                }
            }
            else
            {
                MessageBox.Show("Datos Incorrectos, Ingrese nuevamente los Datos");
            }

        }

        private Actor ObtenerDatosActor()
        {
            Actor actor = new Actor();

            actor.Nombre = txtNombre.Text.Trim();
            actor.Apellido = txtApellido.Text.Trim();
            actor.CodActor = int.Parse(txtCodActor.Text.Trim());
            return actor;
        }

        private void btnActualizarActor_Click(object sender, EventArgs e)
        {
            Actor r = ObtenerDatosActor();
            bool resultado = AD_Actor.ActualizarActor(r);
            if (resultado)
            {
                MessageBox.Show("Actor actualizado con éxito");
                LimpiarCampos();
                CargarGrilla();
            }
            else
            {
                MessageBox.Show("Error al actualizar actor");
            }
        }

        

        private void dtgActualizarActor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnActualizarActor.Enabled = true;
            int indice = e.RowIndex;
            if (indice >= 0)
            {
                DataGridViewRow filaSeleccionada = dtgActualizarActor.Rows[indice];

                int codActor = (int)filaSeleccionada.Cells[0].Value;
                txtCodActor.Text = codActor.ToString();
                Actor r = AD_Actor.ObtenerActor(codActor);
                LimpiarCampos();
                CargarCampos(r);
            };
           
        }
        private void CargarCampos(Actor r)
        {
            txtNombre.Text = r.Nombre;
            txtApellido.Text = r.Apellido;
        }

        private void btnLimpiarCamposActores_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private bool validarCamposNoVacios()
        {
            if (txtNombre.Text.Trim().Equals(""))
            {
                lblError.Visible = true;
                lblError.Text = " El campo Nombre del Actor no puede estar vacío.";
                txtNombre.Focus();
                return false;
            }
            if (txtApellido.Text.Trim().Equals(""))
            {
                lblError.Visible = true;
                lblError.Text = "El campo Precio no puede estar vacío o tener un valor menor a cero.";
                txtApellido.Focus();
                return false;
            }
            return true;
        }
    }
}

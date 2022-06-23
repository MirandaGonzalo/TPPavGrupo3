using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using TPG3.AccesoADatos;

namespace TPG3.Formularios.Empleado
{
    public partial class ListadoEmpelado : Form
    {
        public ListadoEmpelado()
        {
            InitializeComponent();
        }

        private void ListadoEmpelado_Load(object sender, EventArgs e)
        {
            cargarGrilla();
        }

        private void cargarGrilla()
        {
            try
            {
                dgvEmpleados.DataSource = AD_Empleado.ObtenerTablaEmpleado();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al obtener los empleados.");
            }
        }

        private void btnCargarEmpleado_Click(object sender, EventArgs e)
        {
            //3 - Nuevo
            //2 - Editar
            //1 - Eliminar
            Entidades.Empleado empleado = new Entidades.Empleado(0, 0,"","","","","", 3);
            Main.main1.btnSubTicketAltaEmpleado(empleado);            
        }

        private void txtBuscarDni_TextChanged(object sender, EventArgs e)
        {
            //(dgvEmpleados.DataSource as DataTable).DefaultView.RowFilter = "Convert(dni, 'System.String') LIKE '" + txtBuscarDni.Text + "%' and Convert(tipoDocumento, 'System.String') LIKE '" + txtBuscarTipoDoc.Text + "%'";
        }

        private void txtBuscarTipoDoc_TextChanged(object sender, EventArgs e)
        {
            //(dgvEmpleados.DataSource as DataTable).DefaultView.RowFilter = "Convert(dni, 'System.String') LIKE '" + txtBuscarDni.Text + "%' and Convert(tipoDocumento, 'System.String') LIKE '" + txtBuscarTipoDoc.Text + "%'";
        }

        private void btnEditarEmpleado_Click(object sender, EventArgs e)
        {
            var currentRow = dgvEmpleados.CurrentCell.RowIndex;
            string nombreTipoDocumento = (dgvEmpleados.Rows[currentRow].Cells[0].Value.ToString());
            int dni = int.Parse(dgvEmpleados.Rows[currentRow].Cells[1].Value.ToString());
            int idTipoDocumento = int.Parse(dgvEmpleados.Rows[currentRow].Cells[2].Value.ToString());
            string nombre = dgvEmpleados.Rows[currentRow].Cells[3].Value.ToString();
            string apellido = dgvEmpleados.Rows[currentRow].Cells[4].Value.ToString();
            string email = dgvEmpleados.Rows[currentRow].Cells[5].Value.ToString();
            string telefono = dgvEmpleados.Rows[currentRow].Cells[6].Value.ToString();
            
            Entidades.Empleado empleado = new Entidades.Empleado(dni, idTipoDocumento, nombreTipoDocumento, nombre,apellido,email,telefono, 2);
            Main.main1.btnSubTicketAltaEmpleado(empleado);
        }

        private void btnEliminarEmpleado_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Desea eliminar este Empleado ??",
                                     "Confirmación!!",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                var currentRow = dgvEmpleados.CurrentCell.RowIndex;
                DataGridViewRow selectedRow = dgvEmpleados.Rows[currentRow];
                int dni = int.Parse(dgvEmpleados.Rows[currentRow].Cells[1].Value.ToString());
                int idTipoDocumento = int.Parse(dgvEmpleados.Rows[currentRow].Cells[2].Value.ToString());
                Entidades.Empleado empleado = new Entidades.Empleado(dni, idTipoDocumento, "", "", "", "", "", 1);                
                AltaEmpleado altaEmp = new AltaEmpleado(empleado);
                var result = altaEmp.cargarEmpleado(empleado);
                if (result)
                {
                    MessageBox.Show("Empleado eliminado con éxito!");
                    cargarGrilla();
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}

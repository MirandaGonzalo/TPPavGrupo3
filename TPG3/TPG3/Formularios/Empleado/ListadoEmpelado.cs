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
            string cadenaConexion = "Data Source=200.69.137.167,11333;Initial Catalog=BD3K7G03_2022;Persist Security Info=True;User ID=BD3K7G03_2022;Password=PSW03_98074";
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT dni,TipoDocumento.idTipoDocumento as 'idTipoDocumento',TipoDocumento.nombre as 'tipoDocumento', Empleado.nombre, apellido, email, telefono  FROM Empleado " +
                "INNER JOIN TipoDocumento ON Empleado.tipoDocumento = TipoDocumento.idTipoDocumento";

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;
                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);
                dgvEmpleados.DataSource = tabla;

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                cn.Close();
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
            (dgvEmpleados.DataSource as DataTable).DefaultView.RowFilter = "Convert(dni, 'System.String') LIKE '" + txtBuscarDni.Text + "%' and Convert(tipoDocumento, 'System.String') LIKE '" + txtBuscarTipoDoc.Text + "%'";
        }

        private void txtBuscarTipoDoc_TextChanged(object sender, EventArgs e)
        {
            (dgvEmpleados.DataSource as DataTable).DefaultView.RowFilter = "Convert(dni, 'System.String') LIKE '" + txtBuscarDni.Text + "%' and Convert(tipoDocumento, 'System.String') LIKE '" + txtBuscarTipoDoc.Text + "%'";
        }

        private void btnEditarEmpleado_Click(object sender, EventArgs e)
        {
            var currentRow = dgvEmpleados.CurrentCell.RowIndex;
            DataGridViewRow selectedRow = dgvEmpleados.Rows[currentRow];
            int dni = int.Parse(dgvEmpleados.Rows[currentRow].Cells[0].Value.ToString());
            int tipoDocumento = int.Parse(dgvEmpleados.Rows[currentRow].Cells[1].Value.ToString());
            string nombreTipoDocumento = (dgvEmpleados.Rows[currentRow].Cells[2].Value.ToString());
            string nombre = dgvEmpleados.Rows[currentRow].Cells[3].Value.ToString();
            string apellido = dgvEmpleados.Rows[currentRow].Cells[4].Value.ToString();
            string email = dgvEmpleados.Rows[currentRow].Cells[5].Value.ToString();
            string telefono = dgvEmpleados.Rows[currentRow].Cells[6].Value.ToString();
            
            Entidades.Empleado empleado = new Entidades.Empleado(dni,tipoDocumento, nombreTipoDocumento, nombre,apellido,email,telefono, 2);
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
                int dni = int.Parse(dgvEmpleados.Rows[currentRow].Cells[0].Value.ToString());
                int tipoDocumento = int.Parse(dgvEmpleados.Rows[currentRow].Cells[1].Value.ToString());
                Entidades.Empleado empleado = new Entidades.Empleado(dni, tipoDocumento, "", "", "", "", "", 1);                
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

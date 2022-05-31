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

namespace TPG3
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }


        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Trim().Equals("") || txtContraseña.Text.Trim().Equals(""))
            {
                lblError.Text = "Error el usuario/contraseña ingresado no es válido."; 
            }
            else
            {
                var usuario = txtUsuario.Text.Trim();
                var contraseña = txtContraseña.Text.Trim();
                try
                {
                    var user = AD_Usuario.validarUsuario(usuario, contraseña);
                    if (user.idUsuario != -1)
                    {                        
                        this.Hide();
                        Main main = new Main(user);
                        main.ShowDialog();
                        this.Close();

                    }
                    else
                    {
                        lblError.Text = "Error el usuario/contraseña no es correcto.";
                    }
                }
                catch (Exception Ex)
                {

                    MessageBox.Show("Error!" + Ex.ToString());
                }
                
                
            }
            
        }
    }
}

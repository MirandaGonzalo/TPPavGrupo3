﻿using System;
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

namespace TPG3.Formularios.Tarjeta
{
    public partial class AltaTarjeta : Form
    {
        private Entidades.Tarjeta tarjeta;
        public AltaTarjeta(Entidades.Tarjeta tarj)
        {
            tarjeta = tarj;
            InitializeComponent();
            cargarFormulario(tarjeta);
        }


            private void cargarFormulario(Entidades.Tarjeta editTarjeta)
            {
                if (editTarjeta.TipoEdicion > 1)
                {
                    if (editTarjeta.TipoEdicion == 2)
                    {
                        txtNombre.Text = editTarjeta.nombre.ToString();
                        txtDescripcion.Text = editTarjeta.descripcion.ToString();
                        //Componentes.ComboboxItem item = new Componentes.ComboboxItem();
                        //item.Text = editMedioPago.nombreTarjeta;
                        //item.Value = editMedioPago.tarjeta;
                        //cbTipoDoc.Items.Add(item);
                        //cbTipoDoc.SelectedIndex = 0;

                        lblTitulo.Text = "Modificar Tarjeta";
                    }
                    cargarComboBanco(editTarjeta);
                }
            }

        private void cargarComboBanco(Entidades.Tarjeta editTarjeta)
        {
            string cadenaConexion = "Data Source=200.69.137.167,11333;Initial Catalog=BD3K7G03_2022;Persist Security Info=True;User ID=BD3K7G03_2022;Password=PSW03_98074";
            SqlConnection cn = new SqlConnection(cadenaConexion);
            string consulta = "";
            try
            {
                SqlCommand cmd = new SqlCommand();
                if (tarjeta.TipoEdicion == 2)
                {
                    consulta = "SELECT * FROM Banco where idBanco <> @banco";
                }
                else
                {
                    consulta = "SELECT * FROM Banco";
                }

                cmd.Parameters.Clear();
                if (tarjeta.TipoEdicion == 2) cmd.Parameters.AddWithValue("@banco", tarjeta.banco);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;
                cn.Open();
                cmd.Connection = cn;

                DataTable listaBanco = new DataTable();

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(listaBanco);
                cmbBanco.DataSource = listaBanco;
                cmbBanco.DisplayMember = "nombreBanco";
                cmbBanco.ValueMember = "idBanco";
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

        private void btnRegistrarTarjeta_Click(object sender, EventArgs e)
        {
            //validamos los datos
            bool valido = validarCampos();
            if (valido)
            {
                bool result = cargarTarjeta(tarjeta);
                if (result)
                {
                    if (tarjeta.TipoEdicion == 3)
                    {
                        MessageBox.Show("Tarjeta cargada con éxito!");
                    }
                    else
                    {
                        MessageBox.Show("Tarjeta actualizada con éxito.");
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

        public bool cargarTarjeta(Entidades.Tarjeta tarjeta)
        {
            if (tarjeta.TipoEdicion > 1)
            {
                try
                {
                    tarjeta.nombre = txtNombre.Text;
                    tarjeta.descripcion = txtDescripcion.Text;
                    tarjeta.banco = (int)cmbBanco.SelectedValue;
                    if (tarjeta.TipoEdicion == 3)
                    {
                        AD_Tarjeta.CargarTarjeta(tarjeta);
                    }
                    else
                    {
                        AD_Tarjeta.ActualizarTarjeta(tarjeta);
                    };
                }
                catch (Exception)
                {
                    MessageBox.Show("Error.");
                }
            }
            else
            {
                try
                {
                    AD_Tarjeta.EliminarTarjeta(tarjeta);
                }
                catch (Exception)
                {
                    MessageBox.Show("Error al eliminar la tarjeta.");
                }
            }
            return true;
        }

        private bool validarCampos()
        {
            if (txtNombre.Text.Trim().Equals(""))
            {
                lblError.Text = "El campo Nombre no puede estar vacío.";
                txtNombre.Focus();
                return false;
            }
            return true;
        }

        private void btnListado_Click(object sender, EventArgs e)
        {
            Main.main1.btnSubTarjeta_Click(sender, e);
        }
    }
}

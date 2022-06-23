using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using TPG3.Entidades;
using TPG3.AccesoADatos;
using System.Linq;
using System.Drawing;

namespace TPG3.Formularios.Funcion
{
    public partial class EstadoFuncion : Form
    {
        private List<string> asientosOcupados = new List<string>();
        private DateTime fechaHora;
        private int salaFuncion;
        private int codFormato;
        public EstadoFuncion(DateTime fechaHoraFuncion, int sala, int formato)
        {
            this.fechaHora = fechaHoraFuncion;
            this.salaFuncion = sala;
            this.codFormato = formato;
            InitializeComponent();
            this.asientosOcupados = AD_AsientoXSala.GetAsientos(fechaHoraFuncion, sala);
            if (asientosOcupados == null)
            {
                asientosOcupados.Add("-1");
            }
            else
            {
                lblAsientosOcupados.Text = asientosOcupados.Count.ToString();
            }
            lblAsientosLibres.Text = (34 - int.Parse(lblAsientosOcupados.Text)).ToString();
            marcarAsientos();
        }

        private void marcarAsientos()
        {
            List<Control> ListOfButtons = new List<Control>
            {
                A1,A2,A3,A4,A5,A6,A7,A8,A9,A10,B1,B2,B3,B4,B5,B6,B7,B8,B9,B10,C1,C2,C3,C4,C5,C6,C7,C8,D1,D2,D3,D4,D5,D6
            };
            string nombre = "";
            for (int i = 0; i < 34; i++)
            {
                if (i < ListOfButtons.Count)
                {                    
                    nombre = ListOfButtons.ElementAt(i).Name;
                    if (asientosOcupados.Contains(nombre))
                    {
                        ListOfButtons.ElementAt(i).BackColor = Color.Red;
                    }
                    else
                    {
                        ListOfButtons.ElementAt(i).BackColor = Color.Green;
                    }
                    ListOfButtons.ElementAt(i).ForeColor = Color.White;
                    ListOfButtons.ElementAt(i).Enabled = false;
                }
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Main.main1.btnFuncion_Click(sender, e);
        }

        private void btnReservar_Click(object sender, EventArgs e)
        {
            Main.main1.formTarifa(fechaHora, salaFuncion, codFormato);
        }
    }
}



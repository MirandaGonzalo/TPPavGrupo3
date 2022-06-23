using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using TPG3.Entidades;
using TPG3.AccesoADatos;
using System.Linq;
using System.Drawing;

namespace TPG3.CapaLogicaNegocio
{
    public partial class SeleccionAsientoFuncion : Form
    {
        private List<string> asientosOcupados = new List<string>();
        private List<string> asientosOcupadosNuevos = new List<string>();        
        private List<int> listaCantidadXTarifaSeleccionadas = new List<int>();
        private List<float> listaPrecioXTarifaSeleccionadas = new List<float>();
        public DateTime fechaHoraFuncion;
        public int sala;
        public int cantidadEntradasSolicitadas;
        public int cantidadEntradasPosibles = 34;
        public int codFormato;
        public string npromo;
        public float descPromo;
        public int medioPago;
        public SeleccionAsientoFuncion(DateTime fechaHoraS, int salaS,List<int> listaCantxTarifa,List<float> listaPrecio,int cantS, string npromo, float promocion, int formato, int medio)
        {
            this.fechaHoraFuncion = fechaHoraS;
            this.sala = salaS;            
            this.listaCantidadXTarifaSeleccionadas = listaCantxTarifa;
            this.listaPrecioXTarifaSeleccionadas = listaPrecio;
            this.cantidadEntradasSolicitadas = cantS;
            this.npromo = npromo;
            this.descPromo = promocion;
            this.codFormato = formato;
            this.medioPago = medio;
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
            lblAsientosLibres.Text = (cantidadEntradasPosibles - int.Parse(lblAsientosOcupados.Text)).ToString();
            lblAsientosDisponibles.Text = cantidadEntradasSolicitadas.ToString();
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
                        ListOfButtons.ElementAt(i).Enabled = false;
                        ListOfButtons.ElementAt(i).BackColor = Color.Red;                        
                    }
                    else
                    {
                        ListOfButtons.ElementAt(i).BackColor = Color.Green;
                    }
                    ListOfButtons.ElementAt(i).ForeColor = Color.White;
                }
            }
        }

        private void ocuparAsiento(Button btn)
        {
            if (asientosOcupadosNuevos.Contains(btn.Name))
            {
                btn.BackColor = Color.Green;
                btn.ForeColor = Color.White;
                asientosOcupadosNuevos.Remove(btn.Name);
            }
            else
            {
                if (asientosOcupadosNuevos.Count < cantidadEntradasSolicitadas)
                {
                    asientosOcupadosNuevos.Add(btn.Name);
                    btn.BackColor = Color.LightBlue;
                    btn.ForeColor = Color.Black;
                }
                else
                {
                    MessageBox.Show("Ya se encuentran todos los asientos solicitados ocupados.");
                }
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (asientosOcupadosNuevos.Count < cantidadEntradasSolicitadas)
            {
                MessageBox.Show("No se ocuparon todos los asientos solicitiados.", "Atención!!");
            }
            else
            {
                var confirmResult = MessageBox.Show("Desea reservar estos asientos ??",
                                     "Atención!!",
                                     MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    int ultimoNroTicket = AD_Ticket.GetUltimoNumeroTicket();
                    int ultimoNroEntrada = AD_Entrada.GetUltimoNumeroEntrada();
                    var fechaHoraVenta = DateTime.Now;                    
                    Ticket ticket = new Ticket(ultimoNroTicket + 1, fechaHoraVenta, medioPago, Main.main1.usuario.dni, Main.main1.usuario.tipoDocumento, npromo, descPromo);
                    var result = AD_Entrada.RegistrarEntrada(ticket, fechaHoraFuncion, sala, asientosOcupadosNuevos, listaCantidadXTarifaSeleccionadas, listaPrecioXTarifaSeleccionadas, ultimoNroEntrada+1);
                    if (result)
                    {
                        MessageBox.Show("Reserva realizada con éxito.");
                        Main.main1.btnEstadoFuncion(fechaHoraFuncion, sala, codFormato);
                    }
                    else
                    {
                        MessageBox.Show("Error al reservar los asientos!");
                    }
                }
            }
        }

        private void A1_Click(object sender, EventArgs e)
        {
            Button btn = (sender as Button);
            ocuparAsiento(btn);
        }

        private void A2_Click(object sender, EventArgs e)
        {
            Button btn = (sender as Button);
            ocuparAsiento(btn);
        }

        private void A3_Click(object sender, EventArgs e)
        {
            Button btn = (sender as Button);
            ocuparAsiento(btn);
        }

        private void A4_Click(object sender, EventArgs e)
        {
            Button btn = (sender as Button);
            ocuparAsiento(btn);
        }

        private void A5_Click(object sender, EventArgs e)
        {
            Button btn = (sender as Button);
            ocuparAsiento(btn);
        }

        private void A6_Click(object sender, EventArgs e)
        {
            Button btn = (sender as Button);
            ocuparAsiento(btn);
        }

        private void A7_Click(object sender, EventArgs e)
        {
            Button btn = (sender as Button);
            ocuparAsiento(btn);
        }

        private void A8_Click(object sender, EventArgs e)
        {
            Button btn = (sender as Button);
            ocuparAsiento(btn);
        }

        private void A9_Click(object sender, EventArgs e)
        {
            Button btn = (sender as Button);
            ocuparAsiento(btn);
        }

        private void A10_Click(object sender, EventArgs e)
        {
            Button btn = (sender as Button);
            ocuparAsiento(btn);
        }

        private void B1_Click(object sender, EventArgs e)
        {
            Button btn = (sender as Button);
            ocuparAsiento(btn);
        }

        private void B2_Click(object sender, EventArgs e)
        {
            Button btn = (sender as Button);
            ocuparAsiento(btn);
        }

        private void B3_Click(object sender, EventArgs e)
        {
            Button btn = (sender as Button);
            ocuparAsiento(btn);
        }

        private void B4_Click(object sender, EventArgs e)
        {
            Button btn = (sender as Button);
            ocuparAsiento(btn);
        }

        private void B5_Click(object sender, EventArgs e)
        {
            Button btn = (sender as Button);
            ocuparAsiento(btn);
        }

        private void B6_Click(object sender, EventArgs e)
        {
            Button btn = (sender as Button);
            ocuparAsiento(btn);
        }

        private void B7_Click(object sender, EventArgs e)
        {
            Button btn = (sender as Button);
            ocuparAsiento(btn);
        }

        private void B8_Click(object sender, EventArgs e)
        {
            Button btn = (sender as Button);
            ocuparAsiento(btn);
        }

        private void B9_Click(object sender, EventArgs e)
        {
            Button btn = (sender as Button);
            ocuparAsiento(btn);
        }

        private void B10_Click(object sender, EventArgs e)
        {
            Button btn = (sender as Button);
            ocuparAsiento(btn);
        }

        private void C1_Click(object sender, EventArgs e)
        {
            Button btn = (sender as Button);
            ocuparAsiento(btn);
        }

        private void C2_Click(object sender, EventArgs e)
        {
            Button btn = (sender as Button);
            ocuparAsiento(btn);
        }

        private void C3_Click(object sender, EventArgs e)
        {
            Button btn = (sender as Button);
            ocuparAsiento(btn);
        }

        private void C4_Click(object sender, EventArgs e)
        {
            Button btn = (sender as Button);
            ocuparAsiento(btn);
        }

        private void C5_Click(object sender, EventArgs e)
        {
            Button btn = (sender as Button);
            ocuparAsiento(btn);
        }

        private void C6_Click(object sender, EventArgs e)
        {
            Button btn = (sender as Button);
            ocuparAsiento(btn);
        }

        private void C7_Click(object sender, EventArgs e)
        {
            Button btn = (sender as Button);
            ocuparAsiento(btn);
        }

        private void C8_Click(object sender, EventArgs e)
        {
            Button btn = (sender as Button);
            ocuparAsiento(btn);
        }

        private void D1_Click(object sender, EventArgs e)
        {
            Button btn = (sender as Button);
            ocuparAsiento(btn);
        }

        private void D2_Click(object sender, EventArgs e)
        {
            Button btn = (sender as Button);
            ocuparAsiento(btn);
        }

        private void D3_Click(object sender, EventArgs e)
        {
            Button btn = (sender as Button);
            ocuparAsiento(btn);
        }

        private void D4_Click(object sender, EventArgs e)
        {
            Button btn = (sender as Button);
            ocuparAsiento(btn);
        }

        private void D5_Click(object sender, EventArgs e)
        {
            Button btn = (sender as Button);
            ocuparAsiento(btn);
        }

        private void D6_Click(object sender, EventArgs e)
        {
            Button btn = (sender as Button);
            ocuparAsiento(btn);
        }

    }
}

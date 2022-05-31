using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPG3.Entidades
{
    public class DetalleTicketCombo
    {
        public int orden { get; set; }
        public int nroTicket { get; set; }
        public int nroCombo { get; set; }
        public int cantidad { get; set; }

        public DetalleTicketCombo(int orden, int nroTicket, int nroCombo, int cantidad)
        {
            this.orden = orden;
            this.nroTicket = nroTicket;
            this.nroCombo = nroCombo;
            this.cantidad = cantidad;
        }
    }
}

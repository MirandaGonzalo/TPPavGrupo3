using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPG3.Entidades
{
    public class Ticket
    {
        public int nroTicket { get; set; }
        public DateTime fechaHoraVenta { get; set; }
        public int medioPago { get; set; }
        public int dniEmpelado { get; set; }
        public int tipoDocEmpleado { get; set; }

        public Ticket(int nroTicket, DateTime fechahoraVenta, int medioPago, int dniEmpleado, int tipoDocEmpleado)
        {
            this.nroTicket = nroTicket;
            this.fechaHoraVenta = fechahoraVenta;
            this.medioPago = medioPago;
            this.dniEmpelado = dniEmpleado;
            this.tipoDocEmpleado = tipoDocEmpleado;
        }
    }
}

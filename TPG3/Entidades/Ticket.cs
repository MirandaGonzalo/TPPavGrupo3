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
        public string npromocion { get; set; }
        public float promocion { get; set; }

        public Ticket()
        {

        }
        public Ticket(int nroTicket, DateTime fechahoraVenta, int medioPago, int dniEmpleado, int tipoDocEmpleado,string npromocion, float promocion)
        {
            this.nroTicket = nroTicket;
            this.fechaHoraVenta = fechahoraVenta;
            this.medioPago = medioPago;
            this.dniEmpelado = dniEmpleado;
            this.tipoDocEmpleado = tipoDocEmpleado;
            this.npromocion = npromocion;
            this.promocion = promocion;
        }
    }
}

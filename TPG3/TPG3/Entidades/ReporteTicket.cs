using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPG3.Entidades
{
    public class ReporteTicket
    {
        public string medioPago { get; set; }
        public float precio { get; set; }
        public string empleado { get; set; }
    

        public ReporteTicket() { }

        public ReporteTicket(String medioPago, float precio, string empleado)
        {
            this.medioPago = medioPago;
            this.precio = precio;
            this.empleado = empleado;
        }

    }
}

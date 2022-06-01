using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPG3.Entidades
{
    public class Entrada
    {
        public int nroEntrada { get; set; }
        public DateTime fechaHoraVenta { get; set; }
        public DateTime fechaHoraFuncion { get; set; }
        public int sala { get; set; }
        public int numeroFila { get; set; }
        public string letraColumna { get; set; }
        public int tarifa { get; set; }
        public string promocion { get; set; }

        public Entrada(int nroEntrada, DateTime fechaHoraVenta, DateTime fechaHoraFuncion, int sala, int numeroFila, string letraColumna, int tarifa, string promocion)
        {
            this.nroEntrada = nroEntrada;
            this.fechaHoraVenta = fechaHoraVenta;
            this.fechaHoraFuncion = fechaHoraFuncion;
            this.sala = sala;
            this.numeroFila = numeroFila;
            this.letraColumna = letraColumna;
            this.tarifa = tarifa;
            this.promocion = promocion;
        }
    }
}

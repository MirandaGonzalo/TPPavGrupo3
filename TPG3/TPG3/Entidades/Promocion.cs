using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPG3.Entidades
{
    public class Promocion
    {
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public float valor { get; set; }
        public DateTime fechaInicio { get; set; }
        public DateTime fechaFin { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPG3.Entidades
{
    public class EditItemCombo
    {
        public int idProducto { get; set; }
        public string nombre { get; set; }
        public int cantidad { get; set; }
        public float precio { get; set; }

        public EditItemCombo(int idProducto,string nombre, int cantidad, float precio)
        {
            this.idProducto = idProducto;
            this.nombre = nombre;
            this.cantidad = cantidad;
            this.precio = precio;
        }
    }
}

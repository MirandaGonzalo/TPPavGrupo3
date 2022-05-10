using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPG3.Entidades
{
    public class Productos
    {
        private string idProducto;
        private string nombre;
        private string descripcion;
        private int tipoProducto;
        private float precio;

        public Productos(string nombre, string descripcion, int tipoProducto, float precio)
        {
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.tipoProducto = tipoProducto;
            this.precio = precio;
        }

        public Productos()
        {

        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int TipoProducto { get => tipoProducto; set => tipoProducto = value; }
        public float Precio { get => precio; set => precio = value; }
        public string IdProducto { get => idProducto; set => idProducto = value; }
    }
}

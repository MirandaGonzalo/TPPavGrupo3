using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPG3.Entidades
{
    public class Tarifa
    {
        private int idTarifa;
        private string descripcion;
        private float valor;
        private int codFormato;

        public Tarifa(int idTarifa, string descripcion, float valor, int codFormato)
        {
            this.idTarifa = idTarifa;
            this.descripcion = descripcion;
            this.valor = valor;
            this.codFormato = codFormato;
        }

        public Tarifa()
        {

        }

        public int IdTarifa { get => idTarifa; set => idTarifa = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public float Valor { get => valor; set => valor = value; }
        public int CodFormato { get => codFormato; set => codFormato = value; }
    }
}

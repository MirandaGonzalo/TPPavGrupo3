using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPG3.Entidades
{
    public class Usuario
    {
        public int idUsuario { get; set; }
        public string nombreUsuario { get; set; }
        public int dni { get; set; }
        public int tipoDocumento { get; set; }
        public DateTime fechaAlta { get; set; }
        public string contraseña { get; set; }

        public Usuario(int idUsuario, string nombreUsuario, int dni, int tipoDocumento, DateTime fechaAlta, string contraseña)
        {
            this.idUsuario = idUsuario;
            this.nombreUsuario = nombreUsuario;
            this.dni = dni;
            this.tipoDocumento = tipoDocumento;
            this.fechaAlta = fechaAlta;
            this.contraseña = contraseña;
        }
    }
}

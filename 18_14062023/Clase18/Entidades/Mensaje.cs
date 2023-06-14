using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   
    public class Mensaje
    {
        private int id;
        private string mensaje;

        public Mensaje(int id, string mensaje)
        {
            this.id = id;
            this.mensaje = mensaje;
        }

        public int Id { get => id; set => id = value; }
        public string MiMensaje { get => mensaje; set => mensaje = value; }
    }
}

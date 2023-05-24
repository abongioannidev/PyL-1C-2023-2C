using Entidades.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Modelos
{
    public class Email : IMensaje
    {
        private bool estado;

        public bool Estado => this.estado;

        public string EnviarMensaje()
        {
            this.estado = !this.estado;
            return "El Email envia un mensaje";
        }
    }
}

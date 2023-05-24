using Entidades.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Modelos
{
    public abstract class Persona : IMensaje
    {
        public virtual bool Estado { get => true; }

        public abstract string EnviarMensaje();
     
    }
}

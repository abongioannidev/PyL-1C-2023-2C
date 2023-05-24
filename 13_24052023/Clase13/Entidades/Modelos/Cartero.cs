using Entidades.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Modelos
{
    public class Cartero :Persona, IGenerica<string>
    {
        private bool estado;

        public string Nombre { get; set; }  
        public override bool Estado => this.estado;

        public override string EnviarMensaje()
        {
            this.estado = !this.estado;
            return "El cartero envia un mensaje para ambas";
        }
        //string IMensaje.EnviarMensaje()
        //{
        //    this.estado = !this.estado;
        //    return "El cartero envia un mensaje de forma explicita";
        //}

        //string IGenerica<string>.EnviarMensaje()
        //{
        //    this.estado = !this.estado;
        //    return "El cartero envia un mensaje desde la interfaz generica";
        //}

        //int IGenerica<int>.EnviarMensaje()
        //{
        //    throw new NotImplementedException();
        //}
    }
}

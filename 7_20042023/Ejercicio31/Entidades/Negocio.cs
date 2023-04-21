using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Negocio
    {

        private PuestoAtencion caja;
        private Queue<Cliente> clientes;
        private string nombre;
        
        private Negocio() 
        {
            this.clientes = new Queue<Cliente>();   
        }   
        public Negocio(string nombre)
            : this()    
        {
            this.nombre = nombre;
        }

        public Cliente? Cliente
        {
            get
            {
                if(this.ClientesPendientes > 0)
                {
                    return this.clientes.Dequeue();
                }
                return null;
                
            }

            set
            {
               bool result =  this + value;
            }
        }

        public int ClientesPendientes
        {
            get { return this.clientes.Count; }
        }


        public static bool operator ==(Negocio n, Cliente cliente)
        {
            foreach (Cliente item in n.clientes)
            {
                if(cliente == item)
                {
                    return true;
                }
            }

            return false;
        }
        public static bool operator !=(Negocio n, Cliente cliente)
        {
            return !(n == cliente); 
        }

        public static bool operator ~(Negocio n)
        {
            return n.caja.Atender(n.Cliente);
        }
        public static bool operator + (Negocio n, Cliente cliente)
        {
            if (n != cliente)
            {
                n.clientes.Enqueue(cliente); 
                return true;
            }
            return false;
        }
    }
}

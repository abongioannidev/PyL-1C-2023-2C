using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente
    {
        private string nombre;
        private int numero;

        public Cliente(int numero) 
        {
            this.numero = numero;   
        }
        public Cliente(int numero, string nombre)
            :this(numero)
        {
            this.nombre = nombre;   
        }

        public static bool operator == (Cliente a, Cliente b)
        {
            return a.numero == b.numero;
        }
        public static bool operator !=(Cliente a, Cliente b)
        {
            return (a==b);
        }




    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entidades
{
    public class Perro
    {

        public Persona duenio;
        public int edad;
        public string nombre;


        public string Saludar()
        {
            string algo = "algo";
            return $"Soy un perrito y mi nombre es {this.nombre}";
        }
    }
}

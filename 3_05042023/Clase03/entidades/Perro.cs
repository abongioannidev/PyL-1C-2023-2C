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
        private string raza;
    

        public string Saludar()
        {
            string algo = "algo";
            return $"Soy un perrito y mi nombre es {this.nombre}";
        }

        public static void Mostrar(Perro perro)
        {
            Console.WriteLine(perro.Saludar());
        }

        public string GetRaza()
        {
            return this.raza;
        }

        public void SetRaza(string value)
        {
            this.raza = value;
        }



    }
}

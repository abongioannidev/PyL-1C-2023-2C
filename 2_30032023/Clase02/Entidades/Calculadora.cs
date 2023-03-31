using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Calculadora
    {
        private static int valor = 100;
        public static void SoyUnaCalculadora()
        {
            Console.WriteLine($"Soy una calculadora y mi atributo valor es {Calculadora.valor}");
            Calculadora.valor = 87;
            Console.WriteLine($"Soy una calculadora y mi atributo valor es {Calculadora.valor}");
        }

    }
}

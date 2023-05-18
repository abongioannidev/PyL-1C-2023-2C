using Entidades.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.MetodoDeExtension
{
    public static class MisMetodosDeExtension
    {
        public static double ElevarAlCuadrado(this int numero)
        {
            return Math.Pow(numero, 2);
        }
        public static int CantidadDeLetras(this string palabra)
        {
            return palabra.Length;
        }

        public static string ExtenderConversor(this Conversor conversor)
        {
            return "Extendiendo la instancia de conversor";
        }

        public static string Concatenar(this string palabra, params string[] palabras)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(palabra);
            foreach (var item in palabras)
            {
                sb.Append(",");
                sb.Append(item);
            }
            return sb.ToString();
        }
    }
}

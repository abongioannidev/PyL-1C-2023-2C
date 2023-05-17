using Entidades.Excepciones;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Modelo
{
    public class Conversor
    {
        
        public static string ConvertirANumeroRomaro(int numero)
        {
            
            return Conversor.convertirUnidades(numero);
        }

        private static string convertirUnidades(int numero)
        {
            StringBuilder stringBuilder = new StringBuilder();
            if (numero > 0 && numero <= 3)
            {
                stringBuilder.Append('I', numero);
                return stringBuilder.ToString();
            }

            if (numero == 4)
            {

                return "IV";
            }

            if (numero > 4 && numero < 9)
            {
                stringBuilder.Append("V");
                stringBuilder.Append('I', numero - 5);
                return stringBuilder.ToString();
            }

            if (numero == 9)
            {

                return "IX";
            }
            if( numero == 10)
            {
                return "X";
            }

            throw new NumeroInvalidoException("Numero Invalido");

        }
    }
}

using Entidades.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Models
{
    public class Calculadora
    {
        private int numeroA;
        private int numeroB;
        public Calculadora(string numeroA, string numeroB)
        {
            this.ConvierteNumero(numeroA, out this.numeroA);
            this.ConvierteNumero(numeroB, out this.numeroB);

        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        /// <exception cref="ArgumentoInvalidoException"></exception>
        public double Dividir()
        {
            try
            {
                return this.numeroA / this.numeroB;
            }
            catch (DivideByZeroException ex)
            {

                throw new ArgumentoInvalidoException("El divisor no puede ser cero", ex);
            }

        }
        public double Multiplicar()
        {
            return this.numeroA * this.numeroB;
        }
        public double Sumar()
        {
            return this.numeroA + this.numeroB;
        }

        public double Restar()
        {
            return this.numeroA - this.numeroB;
        }

        private void ConvierteNumero(string numero, out int resultado)
        {
            resultado = int.Parse(numero);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Excepciones
{
    public class NumeroInvalidoException : Exception
    {
        public NumeroInvalidoException(string? message) : base(message)
        {
        }

        public NumeroInvalidoException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}

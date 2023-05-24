using Entidades.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Modelos
{
    public class GestorDeArchivos<T> : IArchivos<T>
    {
        public void Guardar(T dato)
        {
            throw new NotImplementedException();
        }


        public T Leer()
        {
            throw new NotImplementedException();
        }

  
    }
}

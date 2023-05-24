using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Interfaces
{
    public interface IArchivos<T>
    {
        T Leer();

        void Guardar(T dato);

    }
}

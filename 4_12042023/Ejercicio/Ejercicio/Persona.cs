using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio
{
    public class Persona
    {
        private int dni;
        private static Persona persona;
        private Persona(int dni)
        {
            this.dni = dni;
        }

        public static Persona GetPersona(int dni)
        {
            if(Persona.persona is null)
            {
                Persona.persona = new Persona(dni);
            }

            return Persona.persona;
        }
        public int GetDni()
        {
            return this.dni;
        }

        public static implicit operator Persona(int dni)
        {
            return new Persona(dni);
        }

        //Lucas
        public static implicit operator int(Persona p)
        {
            return p.dni;
        }
    }
}

using Entidades;
using System.Runtime.CompilerServices;

namespace Clase07
{
 
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona p = new Persona("1234567", "Perez", ETipo.ALUMNO);
            p.Nombre = "Jose";
            //p.SetDni(-90000);


            p[1] = "HOLA";
            string value = p[0];
            Console.WriteLine(value);
            //Console.WriteLine(p.TipoDePersona);
            //Console.WriteLine(p.TipoDeNumero);

            //Console.WriteLine((int)ETipo.ALUMNO == 1);

   
  
        }
    }
}
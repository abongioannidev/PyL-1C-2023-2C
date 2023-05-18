using System.Text;

using Entidades.MetodoDeExtension;
using Entidades.Modelo;

namespace Clase11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = 10;
            Conversor c = new Conversor();

            //ASI NO SE USAAAAAA 
            Console.WriteLine(MisMetodosDeExtension.CantidadDeLetras("lalalallala"));


            Console.WriteLine(numero.ElevarAlCuadrado());
            Console.WriteLine(c.ExtenderConversor());
            Console.WriteLine("Hello, World!".CantidadDeLetras());

            Console.WriteLine("Hola".Concatenar("Mundo","Como","Estas").Concatenar("Otra Cosa"));
        }
    }


}
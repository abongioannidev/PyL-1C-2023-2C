using Entidades;

namespace Clase09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Figura tr = new Triangulo(2,3,ConsoleColor.Red);
            Figura rt = new Rectangulo(2,3,ConsoleColor.Magenta);

            
            

            Console.WriteLine($"El area dela triangulo es {tr.Area}");
            Console.WriteLine($"El area dela rectangulo es {rt.Area}");

            Console.WriteLine(tr.ToString());
            
            
        }
    }
}
using Entidades;
namespace Ejercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dibujo;
            Boligrafo bic = new Boligrafo(ConsoleColor.Red,10);
            ConsoleColor colorIncialDeConsola = Console.ForegroundColor;


            bic.Pintar(3, out dibujo);
            Console.ForegroundColor = bic.GetColor();
            
            Console.WriteLine(dibujo);

            Console.ForegroundColor = colorIncialDeConsola;
            Console.WriteLine($"cantidad de caracteres del primer retorno es {dibujo.Length}");


            bic.Pintar(100,out dibujo);
            Console.ForegroundColor = bic.GetColor();
            Console.WriteLine(dibujo);
            Console.ForegroundColor = colorIncialDeConsola;
            Console.WriteLine($"cantidad de caracteres del segundo retorno es {dibujo.Length}");

            Console.ForegroundColor = colorIncialDeConsola;

        }
    }
}
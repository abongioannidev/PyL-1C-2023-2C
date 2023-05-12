using Entidades.Models;
using Entidades.Exceptions;
namespace Clase10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numeroA;
            string numeroB;
            Calculadora calculadora;
            Console.WriteLine("Ingrese el primer numero");
            numeroA = Console.ReadLine();
            Console.WriteLine("Ingrese el Segundo numero");
            numeroB = Console.ReadLine();

            

            try
            {
                calculadora = new Calculadora(numeroA, numeroB);
                Console.WriteLine($"El resultado es {calculadora.Dividir()}");
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                
                Console.WriteLine(ex.Message);
                Exception bucle = ex.InnerException;
                while (bucle != null)
                {
                    Console.WriteLine(bucle.Message);
                    bucle = bucle.InnerException;
                }
            }
       
          

            Console.ReadKey();


            //Exception e = new Exception("Primer excepcion");

            //ArgumentoInvalidoException a = new ArgumentoInvalidoException("mensaje A", e);
            //ArgumentoInvalidoException b = new ArgumentoInvalidoException("mensaje B", a);
            //ArgumentoInvalidoException c = new ArgumentoInvalidoException("mensaje C", b);


            //Console.WriteLine(c.Message);
            //Exception bucle = c.InnerException;
            //while (bucle != null)
            //{
            //    Console.WriteLine(bucle.Message);
            //    bucle = bucle.InnerException;
            //}


        }
    }
}
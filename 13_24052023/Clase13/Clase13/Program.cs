using Entidades.Interfaces;
using Entidades.Modelos;
namespace Clase13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IMensaje> carteros = new List<IMensaje>();
            IMensaje cartero = new Cartero();
            IMensaje paloma = new Paloma();

            IMensaje mensajeador = new Paloma();
            IMensaje mensajeador2 = new Whatsapp();
            IMensaje mensajeador3 = new Cartero();
            IMensaje mensajeador4 = new Email();


            ((Cartero)cartero).Nombre = "El Cartero";

            cartero.EnviarMensaje();
            ((IMensaje)paloma).EnviarMensaje();


            carteros.Add(paloma);
            carteros.Add(cartero);

            foreach (IMensaje item in carteros)
            {
                Console.WriteLine(item.EnviarMensaje());
            }


            IGenerica<string> cartero2 = new Cartero();


            Console.WriteLine(cartero.EnviarMensaje());
            Console.WriteLine(cartero2.EnviarMensaje());


        }
    }
}
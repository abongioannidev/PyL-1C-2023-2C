using Entidades;

namespace EjemploBdEHilos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task t = GestorDataBase.IniciarLectura((p) => Console.WriteLine($"{p.Apellido }, {p.Nombre}"));
            t.Wait();
            //Console.ReadKey();
        }
    }
}
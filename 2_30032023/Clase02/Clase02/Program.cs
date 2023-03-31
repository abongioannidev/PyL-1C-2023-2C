using System.ComponentModel.DataAnnotations;
using System.Text;
using Entidades;
using Entidades.DataBase;




namespace Clase02
{
    internal class Program
    {
        
        //Nombre de la mascota
        //Edad(Validar 1 - 12)
        //Tipo: (Validar “gato”, “perro”, “hamster”)
        //Peso: (Validar 0 - 50)
        //Diagnostico: (Validar  “otitis”, “alergias”,)

        //Informes:

        //Nombre de la mascota más vieja
        //Cantidad de mascotas con parásitos
        //Nombre, edad y diagnóstico de la mascota más joven ingresada.

        static void Main(string[] args)
        {

       
            //string nombreMascota;
            //int edadMascota;
            //string tipoMascota;
            //int pesoMascota;
            //string diagnostico;
            string cadena = "Hola " + "Mundo";

            DateTime dateTime = DateTime.Now;

            Console.WriteLine(dateTime.Year);

            
         
            Console.WriteLine(dateTime);

            //Console.WriteLine(sb);
            /*Console.WriteLine(cadena)*/;
            //string cadena = string.Empty;
        
            //Calculadora.SoyUnaCalculadora();
            ////Calculadora.valor = 900;
            //Calculadora.SoyUnaCalculadora();

            //Perro.SoyUnPerro();
            //FileName.SoyUnFileName();
            //Console.WriteLine("Ingrese el nombre de la mascota");
            //nombreMascota = Console.ReadLine();



            //Validador.ValidarNumero("Ingrese la edad de la mascota", out edadMascota, 1, 12);

            //ValidarNumero("Ingrese la edad de la mascota", out edadMascota, 1, 12);

            //ValidaTexto("Ingrese el tipo de mascota (“gato”, “perro”, “hamster”)", out tipoMascota, "perro", "gato", "hamster");

            //Console.WriteLine("Ingrese el tipo de mascota (“gato”, “perro”, “hamster”)");
            //tipoMascota = Console.ReadLine();

            //while (tipoMascota != "gato" && tipoMascota != "perro" && tipoMascota != "hamster")
            //{
            //    Console.WriteLine("Error tipo invalido (“gato”, “perro”, “hamster”)");
            //    tipoMascota = Console.ReadLine();
            //}


            //ValidarNumero("Ingrese el peso de la mascota", out pesoMascota, 0, 50);

            //ValidaTexto("Ingrese el diagnostico (“otitis”, “alergias”, “parasitos”)", out diagnostico, "otitis", "alergias"); 

            //Console.WriteLine("Ingrese el diagnostico (“otitis”, “alergias”, “parasitos”)");
            //diagnostico = Console.ReadLine();

            //while (diagnostico != "otitis" && diagnostico != "alergias" && diagnostico != "parasitos")
            //{
            //    Console.WriteLine("Error Ingrese el diagnostico (“otitis”, “alergias”, “parasitos”)");
            //    diagnostico = Console.ReadLine();
            //}

            //Console.WriteLine(edadMascota);
            //Console.WriteLine(diagnostico);
            //Console.WriteLine(pesoMascota);
            //Console.WriteLine(tipoMascota);



            //void ValidarNumero(string mensaje,out int valor , int min, int max)
            //{
            //    Console.WriteLine(mensaje);

            //    int.TryParse(Console.ReadLine(), out valor);
            //    while (valor < min || valor > max)
            //    {
            //        Console.WriteLine($"Error valor invalido, ingrese un valor entre {min}-{max}");
            //        Console.WriteLine(mensaje);
            //        int.TryParse(Console.ReadLine(), out valor);
            //    }

            //}

            //void ValidaTexto(string mensaje, out string valor, params string[] valores)
            //{
            //    Console.WriteLine(mensaje);
            //    valor = Console.ReadLine();

            //    while (!valores.Contains(valor))
            //    {
            //        Console.WriteLine($"Error valor invalido, ingrese valido");
            //        valor = Console.ReadLine();
            //    }
            //}


            Console.ReadKey();
        }
    }
}
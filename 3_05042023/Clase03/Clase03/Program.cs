using entidades;

namespace Clase03
{
    internal class Program
    {
        static void Main(string[] args)
        {
                       
            
            

            Persona personaUno = new Persona();

            Persona.ModificarNombre(personaUno);


            Persona personaDos = new Persona("Franco", "Perrota");

     

            Console.WriteLine(personaUno.nombre);
  


            //Perro miPerro = new Perro();
            //miPerro.duenio = personaUno;
            //miPerro.edad = 3;
            //miPerro.nombre = "boby";

            //Perro miPerroDos = new Perro();
            //miPerroDos.duenio = personaDos;
            //miPerroDos.edad = 1;
            //miPerroDos.nombre = "Pucchi";

            //Console.WriteLine(miPerroDos.Saludar());


            //Perro perroReferencia = miPerroDos;

            //perroReferencia.nombre = "Lalal";

            //Console.WriteLine(Persona.familia);
            //Persona.CambiarFamilia("LALAL");


            //Console.WriteLine(Persona.familia);
            //Console.WriteLine(Persona.familia);



            





        }
    }


}
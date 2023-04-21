using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using Entidades;

namespace Clase06
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //ArrayList lista = new ArrayList();


            Persona p1 = new Persona(34, "Pepe", "Argento");
            Persona p2 = new Persona(36, "Colo", "Barco");
            Persona p3 = new Persona(39, "Cristian", "Pavon");

            //lista.Add(p1);
            //lista.Add("Hola Mundo");
            //lista.Add(2);


            //foreach (var p in lista)
            //{
            //    if (p is Persona)
            //    {
            //        Console.WriteLine(((Persona)p).Saludar());
            //    }
            //    else
            //    {
            //        Console.WriteLine(p);

            //    }
            //}

            List<Persona> jugadores = new List<Persona>() { p1, p2, p3 };

            //foreach (Persona item in jugadores)
            //{
            //    Console.WriteLine(item.Saludar());
            //}

            //jugadores.Clear();

            //Console.WriteLine("Segunda impresion");


            //jugadores.Add(p1);
            //jugadores.Add(p2);
            //jugadores.Add(p3);



            //foreach (Persona item in jugadores)
            //{
            //    Console.WriteLine(item.Saludar());
            //}


            //jugadores.Remove(p1);

            //Console.WriteLine("Tercera impresion");
            //foreach (Persona item in jugadores)
            //{
            //    Console.WriteLine(item.Saludar());
            //}


            //List<int> numeros = new List<int>() { 5, 6, 3, 4,10, 1, 1, 1, 1, 1, 1 };

            //numeros.Sort();
            //numeros.Sort(FuncionCriterio);

            //foreach (var item in numeros)
            //{
            //    Console.WriteLine(item);

            //}
            //Console.WriteLine("Hello, World!");


            //int FuncionCriterio(int num1, int num2)
            //{
            //  return num1- num2;
            //}

            //jugadores.Sort(FuncionCriterioPersonaNombre);

            //foreach (Persona item in jugadores)
            //{
            //    Console.WriteLine(item.Saludar());
            //}

            //int FuncionCriterioPersonaEdad(Persona p1, Persona p2)
            //{
            //    return p2.getEdad() - p1.getEdad();
            //}

            //int FuncionCriterioPersonaNombre(Persona p1, Persona p2)
            //{
            //    return String.Compare(p2.getNombre(), p1.getNombre());

            //}


            //Dictionary<string, List<Persona>> dic = new Dictionary<string, List<Persona>>();

            //dic.Add("Argentinos",jugadores);

            //if(dic.ContainsKey("Argentinos"))
            //{
            //    List<Persona> personas = dic["Argentinos"];
            //    personas.Add(new Persona(45, "nueva", "persona"));
            //}

            //foreach (KeyValuePair<string,List<Persona>> item in dic)
            //{
            //    Console.WriteLine(item.Key);
            //    foreach (Persona persona in item.Value)
            //    {
            //        Console.WriteLine(persona.Saludar());
            //    }
            //}

            //List<KeyValuePair<string, List<Persona>>> algo = dic.ToList();

            //dic.Clear();


            //Queue<int> cola = new Queue<int>(); 

            //cola.Enqueue(1);
            //cola.Enqueue(2);
            //cola.Enqueue(3);
            //cola.Enqueue(4);
            //cola.Enqueue(5);





            //Console.WriteLine("cantidad {0}",cola.Count);

            //Console.WriteLine("recupero pero no elimino {0}", cola.Peek());

            //Console.WriteLine("cantidad {0}", cola.Count);
            //Console.WriteLine("ïtem {0}",cola.Dequeue());

            //Console.WriteLine("cantidad {0}", cola.Count);

            //cola.Clear();

            //cola.ToList();

            //Stack<int> pila = new Stack<int>();

            //pila.Push(1);
            //pila.Push(2);
            //pila.Push(3);

            //Console.WriteLine(pila.Pop());
            //Console.WriteLine("+++++++++++");

            //Console.WriteLine(pila.Peek());

            //Console.WriteLine("+++++++++++");
            //foreach (var p in pila)
            //{
            //    Console.WriteLine(p);
            //}

            //SortedList<int, string> sortedList = new SortedList<int, string>();

            //sortedList.Add(90, "Hola");
            //sortedList.Add(1, "Mundo");


            //foreach (var item in sortedList)
            //{
            //    Console.WriteLine(item.Key);
            //    Console.WriteLine(item.Value);
            //}

            //SortedList<string, int> sortedList = new SortedList<string, int>();


            //sortedList.Add("Hola", 90);
            //sortedList.Add("Mundo",1);
            //sortedList.Add("Alejandro", 1090);

            //foreach (var item in sortedList)
            //{
            //    Console.WriteLine(item.Key);
            //    Console.WriteLine(item.Value);
            //}

            //SortedList<Persona, int> personas = new SortedList<Persona, int>(); 

            //personas.Add(p3,1 );
            //personas.Add(p1,2 );
            //personas.Add(p2,5 );


        }

    }


}
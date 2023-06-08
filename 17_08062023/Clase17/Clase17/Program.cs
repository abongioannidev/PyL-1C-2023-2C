namespace Clase17
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Task tarea = Task.Run(MiMetodo);

            Console.WriteLine($"En el main {Thread.CurrentThread.ManagedThreadId}");
            Task tarea2 = Task.Run(MiMetodo);
            Task tarea3 = Task.Run(MiMetodo);
            Console.WriteLine("La tarea esta iniciada e impirmo en paralelo 1");

            Console.WriteLine("La tarea esta iniciada e impirmo en paralelo 2");

            Console.WriteLine("La tarea esta iniciada e impirmo en paralelo 3");
            Console.WriteLine("La tarea esta iniciada e impirmo en paralelo 4");

            tarea.Wait();

            Console.WriteLine("Termino mis tareas");
          
            //CancellationTokenSource cancellation = new CancellationTokenSource();
            //CancellationToken token = cancellation.Token;
            //ConsoleKey teclaPresionada;
            //Action delegado = () => ImpirmirHora(cancellation);
            //Task task = Task.Run(delegado, token);
            

            
            //do
            //{
            //    teclaPresionada = Console.ReadKey().Key;
            //    Console.WriteLine($"Presiono {teclaPresionada}");
            //    if(teclaPresionada == ConsoleKey.Spacebar)
            //    {
            //        cancellation.Cancel();
            //    }
                
            //}
            //while( teclaPresionada != ConsoleKey.Escape );
            
             

           
            //Console.WriteLine("Presiono escape sali del primer do while");
            
        }



        //static void ImpirmirHora(CancellationTokenSource cancellation)
        //{
        //    do
        //    {
        //        Console.WriteLine($"{DateTime.Now}");
        //        Thread.Sleep(1000);
       
        //    }while(true && !cancellation.IsCancellationRequested);
            
        //}
        static void MiMetodo()
        {
            Console.WriteLine($"El id del task en mi metodo {Task.CurrentId}");
            Console.WriteLine($"En mi metodo {Thread.CurrentThread.ManagedThreadId}");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"iteracion numero {i}");
                Thread.Sleep( 1000 );
            }
        }

    }
}
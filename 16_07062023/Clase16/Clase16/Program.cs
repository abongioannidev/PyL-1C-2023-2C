using Entidades;

namespace Clase16
{
    internal class Program
    {
        public delegate void MiDelegado();
        public delegate string MiDelegado2();
        public delegate string MiDelegado3(string value1, string value2);
        public delegate double DelegagoGerman(int numero);
        static void Main(string[] args)
        {



            //List<Persona> lista = new List<Persona>()
            //{ new Persona("Pepe", 50),
            //    new Persona("Raul", 44),
            //    new Persona("Lucas", 52),
            //};
            //Action action = ()=> { Console.WriteLine("HOla Mudno desde mi action"); };


            //action.Invoke();
            //Comparison<Persona> comparison = (p1, p2) => p1.Edad - p1.Edad;
            //lista.Sort((p1,p2)=>p1.Edad-p2.Edad);
            //Persona p = lista.Find(p=> p.Edad == 50);

            //bool result = lista.Exists(p => p.Nombre == "Lucas");

            //Action a = () => { };
            //Action<int,int> b = (a,b) => { Console.WriteLine(b); };
            //Console.WriteLine(result);

            //Func<int, double> CalcularPotenciaAlCuadrado = (numero) => numero * numero;
            //DelegagoGerman delegagoGerman = (numero) => numero * numero;
            //delegagoGerman += (numero) => numero * 10;

            //foreach (DelegagoGerman func in delegagoGerman.GetInvocationList())
            //{ 
            //    Console.WriteLine(func(5)); 
            //}

            //Func<string, string, bool> ejemplo = (val1, val2) => val1 == val2;


            //Console.WriteLine(CalcularPotenciaAlCuadrado(10));
            //Console.WriteLine(delegagoGerman(5));



            //Console.WriteLine(p.ToString());
            //foreach (Persona persona in lista)
            //{
            //    Console.WriteLine(persona.ToString());
            //}


            //MiDelegado3 miDelegado3 = MiMetodoParticular;
            //Func<string, string, string> miDelegado = MiMetodoParticular;

            //string resultado = miDelegado("Pepe", "Diaz");

            //Console.WriteLine(resultado);

            //Action Van a ser delagados que no retornan valores
            //Func Van a ser delegados que retornar un tipo generico y puede recibir paramatros
            //Predicate Van a ser delegados que recibe un parametro y retorna bool
            //Comparison Van a ser delegados que recibe 2 genericos y retorna INT



            //Action delegado = HacerAlgo;
            //Func<int,string> delegadoFunc = Saludar;
            //Predicate<string> delegadoPredicate = Saludar2;
            //Comparison<Persona> comparison = FuncionCriterio;

            //MiDelegado miDelegado = MetodoParaMiDelegado;
            //miDelegado += MetodoParaMiDelegado2;

            //MiDelegado2 miDelegado2 = MetodoParaMiNuevoDelegado;
            // miDelegado2 += MetodoParaMiNuevoDelegado2;
            //string resultado = miDelegado2();


            //Console.WriteLine(resultado);
            //foreach (MiDelegado2 d in miDelegado2.GetInvocationList())
            //{
            //    string algo = d.Invoke();
            //    Console.WriteLine(algo);

            //}



            //miDelegado();


            Func<string, string, string> login = Ejecutar(3);
            Console.WriteLine(login("Pepe", "1234"));
            Console.WriteLine(login("Pepe", "1234"));
            Console.WriteLine(login("Pepe", "1234"));
            Console.WriteLine(login("Pepe", "1234"));

            Console.ReadKey();
        }

        static Func<string,string,string> Ejecutar(int cantidad)
        {
            Console.WriteLine("Me inicializo");
            string usuarioValido = "Admin";
            string passwordValido = "12345";
            int intentos = 0;
            return (usuario, password) =>
            {
                Console.WriteLine("Me Ejecuto");
                if (intentos < cantidad)
                {
                    if (usuario == usuarioValido && password == passwordValido)
                    {
                        return "Bienvenido admin";
                    }
                    intentos++;
                    return "Usuario o password invalido";

                }
                Console.WriteLine("Ya no me ejecuto mas");
                return "Usuario bloqueado";
        
            };
        }

        //static void HacerAlgo()
        //{
        //    Console.WriteLine("Hola Mundo");
        //}
        //static string Saludar(int numero)
        //{
        //    return "Hola Mundo";
        //}

        //static bool Saludar2(string value)
        //{
        //    return value == "Hola Mundo";
        //}

        //static int FuncionCriterio(Persona personaA, Persona personaB)
        //{

        //    return personaA.Edad - personaB.Edad;
        //}
        //static void MetodoParaMiDelegado()
        //{
        //    Console.WriteLine("Hola Mundo Desde mi MetodoParaMiDelegado");
        //}
        //static void MetodoParaMiDelegado2()
        //{
        //    Console.WriteLine("Hola Mundo Desde mi MetodoParaMiDelegado2 LALALALLLLAL");
        //}

        //static void MetodoParaMiDelegado3()
        //{
        //    Console.WriteLine("Hola Mundo Desde mi MetodoParaMiDelegado3 LALALALLLLAL");
        //}

        //static string MetodoParaMiNuevoDelegado()
        //{
        //    return "Hola Mundo Desde mi MetodoParaMiDelegado";
        //}
        //static string MetodoParaMiNuevoDelegado2()
        //{
        //    return "Hola Mundo Desde mi MetodoParaMiDelegado 222222";
        //}

        //static string MiMetodoParticular(string value, string value2)
        //{
        //    return $"Hola como estas {value},{value2}";
        //}

    }
}
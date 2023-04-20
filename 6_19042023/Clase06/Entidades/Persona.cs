namespace Entidades
{
    public class Persona
    {
        private int edad;
        private string nombre;
        private string apellido;



        public Persona(int edad, string nombre, string apellido)
        {
            this.edad = edad;
            this.nombre = nombre;
            this.apellido = apellido;
        }


        public int getEdad()
        {
            return this.edad;    
        }
        public string getNombre()
        {
            return this.nombre;
        }
        public string getApellido()
        {
            return this.apellido;
        }

        public string Saludar()
        {
            return $"Soy {this.nombre}, {this.apellido} y tengo {this.edad} años";
        }

        public static int FuncionCriterioPersonaNombre(Persona p1, Persona p2)
        {
            return String.Compare(p2.getNombre(), p1.getNombre());

        }

        public static int FuncionCriterioPersonaEdad(Persona p1, Persona p2)
        {
            return p2.getEdad() - p1.getEdad();
        }
    }
}
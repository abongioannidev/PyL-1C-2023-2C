namespace entidades
{
    public class Persona
    {
        public static string familia;
        public int edad;
        public string nombre;
        public string apellido;


        static Persona()
        {
            Persona.familia = "Mono";
        }

        public Persona()
        {

        }

        public Persona(string nombre,string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = 56;
        }


        public string Saludar()
        {
            return $"Soy una persona y mi nombre es {this.nombre}";
        }

        public static void CambiarFamilia(string familia)
        {
            
            Persona.familia = familia;
        }

        public static void ModificarNombre(Persona p)
        {
            p.nombre = "Nombre modificado desde el metodo";
        }

    }
}
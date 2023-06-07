namespace Entidades
{
    public class Persona
    {

        private string nombre;
        private int edad;

        public Persona(string nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Edad { get => edad; set => edad = value; }

        public override string ToString()
        {
            return $"{this.Nombre},{this.Edad}";
        }
    }
}
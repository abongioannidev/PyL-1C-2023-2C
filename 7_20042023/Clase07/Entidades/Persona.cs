using System.Text.RegularExpressions;
using System.Linq;

namespace Entidades
{

    public class Persona
    {
        private List<int> notas;
        public const int PROFESOR = 0;
        public const int ALUMNO = 1;
        private ETipo tipo;
        private string nombre;
        private string apellido;
        private DateTime fechaDeNacimiento;
        private int dni;


        public Persona(string dni, string apellido, ETipo tipo)
        {
            this.tipo = tipo;
            this.Dni = dni;
            this.Apellido = apellido;
            this.notas = new List<int>();
        }

        public string Dni
        {
            get
            {
                return this.dni.ToString();
            }
            private set
            {
                Regex regex = new Regex("^[0-9]{8}$");
                if (regex.IsMatch(value))
                {
                    int.TryParse(value, out this.dni);
                }
            }
        }

        /// <summary>
        /// Si el indice es 0 retorna el nombre, si es otro el apellido
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public string this[string index]
        {
            get
            {
                if (index == "nombre")
                {
                    return this.nombre;

                }
                else if (index == "apellido")
                {
                    return this.apellido;

                }
                return "indice invalida";
               

            }
        }

        /// <summary>
        /// indexa las notas
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public string this[int index]
        {
            get
            {
                if(index >-1 &&  index <= this.notas.Count-1 )
                {
                    return this.notas[index].ToString();
                }
                return "No hay notas o indice invalido";


            }
            set
            {
                this.notas.Add(index);
            
            }
        }
        public ETipo TipoDePersona { get { return this.tipo; } }


        public int TipoDeNumero { get { return (int)this.tipo; } }
        public string Apellido
        {
            private get { return this.apellido; }
            set
            {
                if (this.ValidaNombreYApellido(value))
                {
                    this.apellido = value;
                }

            }
        }




        public int Edad
        {
            get { return DateTime.Now.Year - this.fechaDeNacimiento.Year; }
        }

        public DateTime FechaDeNacimiento
        {
            set
            {
                if (this.ValidaFecha(value, DateTime.Now))
                {
                    this.fechaDeNacimiento = value;
                }
            }
        }

        public string Nombre { get => nombre; set => nombre = value; }


        private bool ValidaNombreYApellido(string value)
        {
            return !string.IsNullOrWhiteSpace(value);
        }

        private bool ValidaFecha(DateTime fechaInicio, DateTime fechaFin)
        {
            return fechaInicio < fechaFin;
        }



    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Entidades
{
    public class Triangulo:Figura
    {

        private ConsoleColor color;
        public Triangulo(double yAltura, double xBase, ConsoleColor color) : base(yAltura, xBase)
        {
            this.color = color;
        }
        
       
        public ConsoleColor Color { get => color; }

        public override double Area { get { return this.CalcularArea(); } }

        protected override double CalcularArea()
        {

            return base.CalcularArea()/2;

        }

        protected override string MostrarDatos()
        {
            return $"Soy un triangulo, y mis datos son {base.MostrarDatos()}";
        }
        public override string ToString()
        {
            return this.MostrarDatos();
        }

        public static bool operator == (Triangulo a, Triangulo b)
        {
            return a.xBase == b.xBase && a.yAltura == b.yAltura;
        }
        public static bool operator !=(Triangulo a, Triangulo b)
        {
            return !(a==b);
        }

        public override bool Equals(object? obj)
        {
            return obj is not null && obj is Triangulo && ((Triangulo)obj) == this;
        }
        public override int GetHashCode()
        {
            return this.xBase.GetHashCode();
        }

        public override string Imprimir(double x, double y)
        {
            return $"{x},{y}";
          }
    }
}

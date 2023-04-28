using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Rectangulo : Figura
    {

        private ConsoleColor color;
        public Rectangulo(double yAltura, double xBase, ConsoleColor color) : base(yAltura, xBase)
        {
            this.color = color;
        }

        public ConsoleColor Color { get => color; }

        public override double Area => this.CalcularArea();

        public override string Imprimir(double x, double y)
        {
            return $"{x},{y}";
        }
    }
}

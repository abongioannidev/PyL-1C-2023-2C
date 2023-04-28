namespace Entidades
{
    public abstract class Figura
    {
        protected double yAltura;
        protected double xBase;
     

  

        protected Figura(double yAltura, double xBase)
        {
            this.yAltura = yAltura;
            this.xBase = xBase; 
        }

        public abstract double Area { get; }

        public abstract string Imprimir(double x, double y);


        protected virtual double CalcularArea()
        {
       
          return this.xBase * this.yAltura;
      
        }

        protected virtual string MostrarDatos()
        {
            return $"altura: {this.yAltura}, base: {this.xBase}";
        }

    }
}
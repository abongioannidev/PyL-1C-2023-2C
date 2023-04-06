using System.Text;

namespace Entidades
{
    public class Boligrafo
    {
        public const short cantidadTintaMaxima = 100;
        private ConsoleColor color;
        private short tinta;

        public Boligrafo(ConsoleColor color, short tinta)
        {
            this.color = color;
            this.tinta = tinta;
        }


        public ConsoleColor GetColor()
        {
            return this.color;
        }
        public short GetTinta() { return this.tinta; }


        private void SetTinta(short tinta)
        {
            if(tinta > 0)
            {
                this.Cargar(tinta);
            }
            else if(tinta < 0)
            {
                this.GastarTinta(tinta);
            }
        }

        private void GastarTinta(short tinta)
        {
            int tintaAux = this.tinta - tinta;
            if(tintaAux <= 0)
            {
                this.tinta = 0;
            }
            else
            {
                this.tinta = (short)tintaAux;

            }

        }

        private void Cargar(short tinta)
        {
           int tintaAux =  this.tinta + tinta;
            if(tintaAux >= Boligrafo.cantidadTintaMaxima)
            {
                this.tinta = Boligrafo.cantidadTintaMaxima;
            }
            else
            {
                this.tinta = (short)tintaAux;
            }
        }

        public void Recargar()
        {
            this.SetTinta(Boligrafo.cantidadTintaMaxima);
        }


        public bool Pintar(short gasto, out string dibujo)
        {
            if(this.tinta <= 0) 
            {
                dibujo = "Sin tinta para pintar";
            
                return false;
            }


            StringBuilder sb = new StringBuilder();   
            sb.Append('*', gasto > this.tinta ? this.tinta :gasto);
         
 

            dibujo = sb.ToString();
            return true;
        }
    }
}
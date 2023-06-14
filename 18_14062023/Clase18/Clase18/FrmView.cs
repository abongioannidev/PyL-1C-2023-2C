using Entidades;
namespace Clase18
{
    public partial class FrmView : Form
    {

        public FrmView()
        {
            InitializeComponent();
            GestorDataBase.OnMensaje += ManejarMensaje;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GestorDataBase.IniciarLectura = !GestorDataBase.IniciarLectura;

        }

        EnviarMensaje callback;
        private void ManejarMensaje(Mensaje mensaje)
        {
            if(this.InvokeRequired)
            {
                callback = new EnviarMensaje(ManejarMensaje);
                object[] args = { mensaje };
                this.BeginInvoke(callback,args);
            }
            else
            {
                this.lblMensaje.Text = mensaje.MiMensaje;
            }
           
        }

        private void FrmView_FormClosing(object sender, FormClosingEventArgs e)
        {
            GestorDataBase.IniciarLectura = false;
        }
    }
}
namespace FrmView
{
    public partial class FrmView : Form
    {
        CancellationTokenSource cancellationTokenSource;
        Task tarea;
        public FrmView()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            this.cancellationTokenSource = new CancellationTokenSource();
            CancellationToken token = cancellationTokenSource.Token;
            this.tarea = Task.Run(this.IniciarReloj, token);
        }

        public delegate void Callback(int hora, string saludo);
        private void ActualizarHora(int hora, string saludo)
        {
            if (this.InvokeRequired)
            {
                Callback callback = new Callback(this.ActualizarHora);
                object[] args = {  hora, saludo };
                this.BeginInvoke(callback, args);
                //Es lo mismo que lo de arriba
                //this.BeginInvoke(()=>this.ActualizarHora(hora, saludo));
            }
            else
            {
                this.lblHora.Text = $"{hora}";
                this.txtIngreso.Text = saludo;
            }

        }

        private void IniciarReloj()
        {
            int numero = 60;
            do
            {
                this.ActualizarHora(numero, $"Hola Mundo{numero}");
                Thread.Sleep(1000);
                numero--;
            } while (numero > 0 && !this.cancellationTokenSource.IsCancellationRequested);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.cancellationTokenSource.Cancel();
        }
    }
}
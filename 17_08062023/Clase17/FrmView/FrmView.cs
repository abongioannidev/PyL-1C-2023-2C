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
            int valor = int.Parse(this.txtIngreso.Text);
            this.cancellationTokenSource = new CancellationTokenSource();
            CancellationToken token = cancellationTokenSource.Token;
            this.tarea = Task.Run(() => this.IniciarReloj(valor), token);
        }

        public delegate void Callback(int hora);
        private void ActualizarHora(int hora)
        {
            if (this.InvokeRequired)
            {
                Callback callback = new Callback(this.ActualizarHora);
                object[] args = { hora };
                this.BeginInvoke(callback, args);
                //Es lo mismo que lo de arriba
                //this.BeginInvoke(()=>this.ActualizarHora(hora, saludo));
            }
            else
            {
                this.lblHora.Text = $"{hora}";
            }

        }

        private void IniciarReloj(int numero)
        {

            do
            {
                this.ActualizarHora(numero);
                Thread.Sleep(1000);
                numero--;
            } while (numero >= 0 && !this.cancellationTokenSource.IsCancellationRequested);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.cancellationTokenSource.Cancel();
        }
    }
}
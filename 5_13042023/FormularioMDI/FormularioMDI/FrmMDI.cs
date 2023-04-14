namespace FormularioMDI
{
    public partial class FrmMDI : Form
    {
        public FrmMDI()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmHijo frm = new FrmHijo();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
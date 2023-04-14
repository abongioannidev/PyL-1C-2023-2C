using Entidades;
namespace Clase05
{
    public partial class FrmClase05 : Form
    {
        Persona p;
        public FrmClase05()
        {
            InitializeComponent();
            this.lstNombres.Items.Add("ALejandro");
            this.lstNombres.Items.Add("Pepe");
            this.lstNombres.Items.Add("Luis");
            this.lstNombres.Items.Add("Jose");

            p = new Persona();

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            MessageBox.Show($"{this.txtApellido.Text},{this.txtNombre.Text}", "Caja de Texto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            SegundoForm frmSegundo = new SegundoForm(56);


            DialogResult result = frmSegundo.ShowDialog();



            if (result == DialogResult.OK)
            {
                MessageBox.Show("Todo OK");
            }

            foreach (Control item in this.grpDatos.Controls)
            {
                if (item is TextBox)
                {
                    if (item.Name == "txtNombre")
                    {
                        item.Text = "lalala";
                    }

                }
            }

        }

        private void FrmClase05_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult resultado = MessageBox.Show("Desea cerrar la ventana?", "Cierre", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
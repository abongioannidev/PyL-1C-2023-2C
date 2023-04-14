using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase05
{
    public partial class SegundoForm : Form
    {
        private int edad;
        public SegundoForm(int edad)
        {
            InitializeComponent();
            this.edad = edad;
        }


        private void SegundoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {

                this.DialogResult = DialogResult.No;
            }

        }

     
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Numeros
{
    public partial class Cheque : Form
    {
        public Cheque()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = Int32.Parse(this.txtcan.Text);
            this.txtResultado.Text = Numeros.NumerosLetras.getmillar(num);
        }
    }
}

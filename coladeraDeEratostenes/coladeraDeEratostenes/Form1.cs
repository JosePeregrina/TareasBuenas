using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coladeraDeEratostenes
{
    public partial class Form1 : Form
    {
        Coladera eratostenes;
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdCalcularPrimo_Click(object sender, EventArgs e)
        {
            string r;

            r = Coladera.Buscar(20);

            txtSalida.Text = r.ToString();
            
            //txtSalida.Text = "" + (10 % 2);
        }
    }
}

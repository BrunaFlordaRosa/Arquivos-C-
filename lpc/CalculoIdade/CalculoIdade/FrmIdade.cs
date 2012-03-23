using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CalculoIdade
{
    public partial class FrmIdade : Form
    {
        public FrmIdade()
        {
            InitializeComponent();
        }

        private void txtIdade_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int idade = Convert.ToInt32(txtIdade.Text);
            int diasVida = idade * 365;
            int horasVida = diasVida * 24;

            MessageBox.Show(" Você tem " + diasVida + " dias de vida e " + horasVida + " horas de vida");


        }
    }
}

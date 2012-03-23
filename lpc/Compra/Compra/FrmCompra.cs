using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Compra
{
    public partial class FrmCompra : Form
    {
        public FrmCompra()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int ValorCompra= Convert.ToInt32(txtCompra.Text);
            int Desconto= Convert.ToInt32(txtDesconto.Text);
            ValorCompra = ValorCompra - (ValorCompra * Desconto) / 100;
            MessageBox.Show("O Valor total a ser pago é: R$ " + ValorCompra);
        }
    }
}

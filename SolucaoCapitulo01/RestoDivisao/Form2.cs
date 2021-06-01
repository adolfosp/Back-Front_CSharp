using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RestoDivisao
{
    public partial class frmRestoDeDivisao : Form
    {
        public frmRestoDeDivisao()
        {
            InitializeComponent();
        }



        private void btnOperacao_Click_1(object sender, EventArgs e)
        {
         
            int dividendo = Convert.ToInt32(txtDividendo.Text);
            int divisor = Convert.ToInt32(txtDivisor.Text);

            int resultado = dividendo % divisor;

            txtResto.Text = Convert.ToString(resultado);

            MessageBox.Show("Cáclulo realizado", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

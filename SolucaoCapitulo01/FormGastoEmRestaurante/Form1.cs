using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormGastoEmRestaurante
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            txtValorTotal.Text = (Convert.ToDouble(txtDespesa.Text) * 1.10).ToString("N");
            //Formata a STRING para um valor numérico

        }
    }
}

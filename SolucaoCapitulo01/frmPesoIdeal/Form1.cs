using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmPesoIdeal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(cmbGenero.Text == String.Empty || txtAltura.Text == String.Empty)
            {
                MessageBox.Show("Por favor preencha os campos solicitados", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }else
            {
                double altura = Convert.ToDouble(txtAltura.Text);
                if (cmbGenero.Text == "Masculino")
                {
                    lblResultado.Text = ((72.7 * altura) - 58).ToString("N");
                }
                else
                {
                    lblResultado.Text = ((62.1 * altura) - 44.7).ToString("N");
                }
            }
        }
    }
}

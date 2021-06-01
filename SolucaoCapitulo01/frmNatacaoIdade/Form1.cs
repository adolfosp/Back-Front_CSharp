using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmNatacaoIdade
{
    public partial class frmNatacao : Form
    {
        public frmNatacao()
        {
            InitializeComponent();
        }

        private void bntVerificarCategoria_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == String.Empty || dtpAnoNascimento.Text == String.Empty)
            {
                MessageBox.Show("Por favor preencha os campos solicitados", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {

                TimeSpan tsQuantidadeDeDias = DateTime.Now.Date - dtpAnoNascimento.Value;
                int idade = (tsQuantidadeDeDias.Days / 365);
                if (idade > 17)
                {
                    lblCategoria.Text = "Adulto";
                }
                else if (idade > 13)
                {
                    lblCategoria.Text = "Juvenil B";

                }
                else if (idade > 10)
                {
                    lblCategoria.Text = "Juvenil A";

                }
                else if (idade > 7)
                {
                    lblCategoria.Text = "Infantil B";

                }
                else if (idade >= 5)
                {
                    lblCategoria.Text = "Infantil A";

                }
                else
                {
                    lblCategoria.Text = "Não Existe categoria";
                }
            }
        }

        private void txtAnoNascimento_Enter(object sender, EventArgs e)
        {
            if (dtpAnoNascimento.Text.Trim().Length < 4)
            {
                MessageBox.Show("É preciso informar o ANO DE" + " NASCIMENTO com 4 digitos", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtpAnoNascimento.Focus();
            }
        }

       

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

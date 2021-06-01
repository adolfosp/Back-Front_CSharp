using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeituraDadosTxt
{
    public partial class frmFuncionarioEmpresa : Form
    {
        public frmFuncionarioEmpresa()
        {
            InitializeComponent();
            dgvFuncionarios.ColumnCount = 2;
            dgvFuncionarios.Columns[0].HeaderText = "Nome";
            dgvFuncionarios.Columns[0].Width = 230;
            dgvFuncionarios.Columns[1].HeaderText = "Salário";
            dgvFuncionarios.Columns[1].Width = 67;
            
        }

        private void btnCriarLinhaRegistro_Click(object sender, EventArgs e)
        {
            int numeroFuncionarios = Convert.ToInt16(txtNumFuncionario.Text);
            if (numeroFuncionarios < 1)
                numeroFuncionarios = 1;
            int i = 0;
            do {
                var linhaTabela = new DataGridViewRow();
                linhaTabela.Cells.Add(new DataGridViewTextBoxCell { Value = "" });
                linhaTabela.Cells.Add(new DataGridViewTextBoxCell { Value = 0 });
                dgvFuncionarios.Rows.Add(linhaTabela);
            } while (++i < numeroFuncionarios);
            txtNumFuncionario.Enabled = false;
            btnCriarArquivo.Enabled = true;
            btnReiniciar.Enabled = true;
            btnCriarLinhaRegistro.Enabled = false;
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            dgvFuncionarios.Rows.Clear();
            txtNumFuncionario.Text = string.Empty;
            txtNumFuncionario.Enabled = true;
            btnCriarArquivo.Enabled = false;
            btnReiniciar.Enabled = false;
            btnCriarLinhaRegistro.Enabled = true;

        }

        private void btnCriarArquivo_Click(object sender, EventArgs e)
        {
            if (!ValidaDados())
            {
                MessageBox.Show("Os dados possuem problemas. Verifique se não deixou nenhum nome em branco ou se existe um valor correto para os salários de cada um");
            }else if(sfdGravarArquivo.ShowDialog() == DialogResult.OK)
            {
                GerarArquivo();
                MessageBox.Show("Arquivo gerado com Sucesso");
            }
        }

        private void GerarArquivo()
        {
            StreamWriter wr = new StreamWriter(sfdGravarArquivo.FileName, true);        
            for(int j = 0; j< (dgvFuncionarios.Rows.Count - 1); ++j)
            {
                wr.WriteLine(dgvFuncionarios.Rows[j].Cells[0].Value.ToString() + ";" + dgvFuncionarios.Rows[j].Cells[1].Value.ToString());
            }
            wr.Close();
        }

        private bool ValidaDados()
        {
            int i = 0;
            bool dadosValidados = true;
            double stringToDouble = 0.0;

            do
            {
                Console.WriteLine("valor de i: " + i);
                Console.WriteLine("valor de funcionarios: " + (dgvFuncionarios.Rows.Count - 1));
                if (string.IsNullOrWhiteSpace(dgvFuncionarios.Rows[i].Cells[0].Value.ToString()))
                   dadosValidados = false;
                if (!Double.TryParse(dgvFuncionarios.Rows[i].Cells[1].Value.ToString(), out stringToDouble))
                    dadosValidados = false;
            } while (++i < (dgvFuncionarios.Rows.Count - 1));
            return dadosValidados;
        }
    }
}

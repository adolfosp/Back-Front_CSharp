using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReajusteSalarial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolTip2_Popup(object sender, PopupEventArgs e)
        {

        }

        private void btnProcessar_Click(object sender, EventArgs e)
        {
            RealizarProcessamento(Convert.ToDouble(txtSalario.Text), cmbCategoria.Text,cmbTurno.Text,Convert.ToDouble(txtHorasTrabalhada.Text));
        }

        private void RealizarProcessamento(double salario, string categoria, string turno, double horasTrabalhadas)
        {
            double valorCoeficiente = GetCoeficiente(turno);
            double valorGratificacao = GetGratificacao(turno, horasTrabalhadas);
            double valorSalarioBruto = horasTrabalhadas * valorCoeficiente;
            double valorImposto = GetValorImposto(categoria, valorSalarioBruto);
            double valorAuxilioAlimentacao = GetValorAuxilioAlimentacao(categoria, valorSalarioBruto, salario);
            double valorSalarioLiquido = (valorSalarioBruto + (valorGratificacao + valorAuxilioAlimentacao)) + valorImposto;
            ApresentarResultados(valorCoeficiente, valorSalarioBruto, valorImposto, valorGratificacao, valorAuxilioAlimentacao, valorSalarioLiquido);
        }

        private double GetCoeficiente(string turno)
        {
            double valorCoeficiente = 0;
            switch (turno)
            {
                case "Matutino":
                    valorCoeficiente = Convert.ToDouble(txtSalario.Text) * 0.01;
                    break;
                case "Vespertino":
                    valorCoeficiente = Convert.ToDouble(txtSalario.Text)*0.02;
                    break;
                case "Noturno":
                    valorCoeficiente = Convert.ToDouble(txtSalario.Text) * 0.03;
                    break;
            }

            return valorCoeficiente;
        }

        private double GetGratificacao(string turno, double horasTrabalhadas)
        {
            double valorGratificacao = 30;
            if (turno.Equals("Noturno") && horasTrabalhadas > 80)
                valorGratificacao = 50;
            return valorGratificacao;
        }

        private static double GetValorImposto(string categoria, double valorSalarioBruto)
        {
            double valorImposto = 0;
            switch (categoria)
            {
                case "Calouro":
                    if (valorSalarioBruto < 300)
                        valorImposto = valorSalarioBruto * 0.01;
                    else
                        valorImposto = valorSalarioBruto * 0.04;
                    break;
            }
            return valorImposto;
        }

        private double GetValorAuxilioAlimentacao(string categoria, double valorSalarioBruto, double salario)
        {
            double valorAuxilioAlimentacao = (valorSalarioBruto / 3) / 2;
            if (categoria.Equals("Calouro") && (valorSalarioBruto < (salario / 2)))
                valorAuxilioAlimentacao = (valorSalarioBruto / 3);
            return valorAuxilioAlimentacao;
        }

        private void ApresentarResultados(double valorCoeficiente, double valorSalarioBruto, double valorImposto, double valorGratificacao, double valorAuxilioAlimentacao, double salarioLiquido)
        {
            lblSituacao.Text = GetSituacaoEstagiario(salarioLiquido);

            lbxResumo.Items.Add(String.Format("{0,-29}{1,12:C}", "Valor do coeficiente:", valorCoeficiente));
            lbxResumo.Items.Add(String.Format("{0,-29}{1,12:C}", "Salário Bruto:", valorSalarioBruto));
            lbxResumo.Items.Add(String.Format("{0,-29}{1,12:C}", "Valor do imposto:", valorImposto));
            lbxResumo.Items.Add(String.Format("{0,-29}{1,12:C}", "Valor da Gratificacao:", valorGratificacao));
            lbxResumo.Items.Add(String.Format("{0,-29}{1,12:C}", "Valor do Auxilio Alimentacao:", valorAuxilioAlimentacao));
            lbxResumo.Items.Add(String.Format("{0,-29}{1,12:C}", "Valor do Salario liquido:", salarioLiquido));

        }

        private string GetSituacaoEstagiario(double salarioLiquido)
        {
            if (salarioLiquido < 350)
                return "Mal Remunerado";
            else if (salarioLiquido < 600)
                return "Normal";
            else
                return "Bem Remunerado";
        }
    }
}
                                                                                                                                                                                                                                                                                                                              
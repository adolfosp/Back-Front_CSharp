using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioInterface.Entities
{
    class Parcela
    {

        public DateTime DataVencimento { get; set; }
        public double ValorVencimento { get; set; }

        public Parcela(DateTime dataVencimento, double valorVencimento)
        {
            DataVencimento = dataVencimento;
            ValorVencimento = valorVencimento;
        }

        public Parcela()
        {
        }
    }
}

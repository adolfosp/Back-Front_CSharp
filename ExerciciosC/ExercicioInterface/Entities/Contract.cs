using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioInterface.Entities
{
    class Contract
    {

        public int Number { get; set; }
        public DateTime Data { get; set; }

        public double TotalValue { get; set; }
        public List<Parcela> Parcelas { get; set; }

        public Contract(int number, DateTime data, double totalValue)
        {
            Number = number;
            Data = data;
            TotalValue = totalValue;
            Parcelas = new List<Parcela>();
        }

        public void AddInstallment(Parcela parcela)
        {
            Parcelas.Add(parcela);
        }

        public override string ToString()
        {
            return " \n Numero contrato:"
                + Number
                + "\n Data: "
                + Data
                + "\n Total: "
                + TotalValue;
        }
    }
}

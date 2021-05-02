using ExercicioInterface.Entities;
using System;

namespace ExercicioInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("number");
            int numeroContrato = int.Parse(Console.ReadLine());
            Console.WriteLine("Data");
            DateTime data = DateTime.Parse(Console.ReadLine());
            Console.WriteLine(data.ToString("dd/MM/yyyy"));
            Console.WriteLine("Valor do contrato");
            double valorContrato = double.Parse(Console.ReadLine());
            Console.WriteLine("Número de parcelas");
            int numeroParcelas = int.Parse(Console.ReadLine());


            Contract contrato = new Contract
            {
                Data = data,
                totalValue = valorContrato,
                Number = numeroContrato
            };

            Console.WriteLine(contrato);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriz
{
    class Program
    {
        static void Main(string[] args)
        {

            double[,] matriz = new double[2, 3];

            Console.WriteLine(matriz.Length);

            //primeira dimensão da matriz - linha
            Console.WriteLine(matriz.Rank);

            //a dimensao 0 da matriz tem tamanho 2
            Console.WriteLine(matriz.GetLength(0));

            Console.ReadKey();
        }
    }
}

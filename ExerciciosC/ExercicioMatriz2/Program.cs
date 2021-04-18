using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioMatriz2
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] valores = Console.ReadLine().Split(' ');

            int[,] matriz = new int[int.Parse(valores[0]), int.Parse(valores[1])];


            for(int i =0; i < int.Parse(valores[0]); i++)
            {

                string[] valoresInserirMatriz = Console.ReadLine().Split(' ');

                for (int j = 0; j < int.Parse(valores[1]); j++)
                {
                    matriz[i,j] = int.Parse(valoresInserirMatriz[j]);
                }
            }
            int valorUnicoMatriz = int.Parse(Console.ReadLine());

            for (int i = 0; i < int.Parse(valores[0]); i++)
            {
                for (int j = 0; j < int.Parse(valores[1]); j++)
                {
                   if(matriz[i,j] == valorUnicoMatriz)
                    {
                        Console.WriteLine("Position :" + i + ", " + j);
                        Console.WriteLine("Top : " + matriz[i - 1, j]);
                        Console.WriteLine("Left : " + matriz[i, j-1]);
                        Console.WriteLine("Right : " + matriz[i, j + 1]);
                        Console.WriteLine("Bottom : " + matriz[i +1 , j ]);


                    }

                }
                Console.WriteLine();
            }





            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {

            int x = int.Parse(Console.ReadLine());


            switch(x){
                case 1:
                    Console.WriteLine("SEGUNDA");
                    break;
                case 2:
                    Console.WriteLine("TERÇA");
                    break;
                case 3:
                    Console.WriteLine("QUARTA");
                    break;
                case 4:
                    Console.WriteLine("QUINTA");
                    break;
                case 5:
                    Console.WriteLine("SEXTA");
                    break;
                case 6:
                    Console.WriteLine("SÁBADO");
                    break;
                case 7:
                    Console.WriteLine("DOMINGO");
                    break;
                default:
                    Console.WriteLine("Valor não corresponde à nenhum dia");
                    break;
            }
            Console.ReadKey();
        }
    }
}

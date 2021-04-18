using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncoesString
{
    class Program
    {
        static void Main(string[] args)
        {

            string original = "abcde FHIJK ABC abc DEFG  ";
            //conteúdo imutável

            bool b1 = String.IsNullOrEmpty(original);
            bool b2 = String.IsNullOrWhiteSpace(original);

            string S1 = original.ToLower();
            string S2 = original.ToUpper();
            string S3 = original.Trim();
            int n1 = original.IndexOf("bc");
            //mostrar o indice de onde comeca o valor passado
            int n2 = original.LastIndexOf("bc");
            //mostra a última ocorrência do valor passado

            string S4 = original.Substring(3);
            string S5 = original.Substring(3,5);
            //5 caracteres a partir da posição 3


            string S6 = original.Replace('a', 'x');
            Console.WriteLine(b2);

            Console.ReadKey();
        }
    }
}

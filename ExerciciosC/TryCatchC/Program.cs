using System;

namespace TryCatchC
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());

                int result = n1 / n2;

                Console.WriteLine(result);

            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Não foi possível realizar a operação pois existe números 0 e não pode realizar a divisão" + e.Message);    
            }
            catch(FormatException e)
            {
                Console.WriteLine("Formato do valor inserido incorreto");
            }
            finally
            {
                //fecha tudo meu parça
            }


        }
    }
}

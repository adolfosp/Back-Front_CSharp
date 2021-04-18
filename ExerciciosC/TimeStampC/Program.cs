using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeStampC
{
    class Program
    {
        static void Main(string[] args)
        {

            TimeSpan t1 = new TimeSpan(0, 1, 30);
                                        //hora, minuto, segunda

            TimeSpan t2 = new TimeSpan(900000000L);
            TimeSpan t3 = new TimeSpan(2, 11, 32);
            TimeSpan t4 = new TimeSpan(4,2, 11, 32);
            TimeSpan t5 = new TimeSpan(1,2,11,21,321);
            TimeSpan t6 = TimeSpan.FromDays(1.5);
            Console.WriteLine(t5);

            Console.ReadKey();
        }
    }
}

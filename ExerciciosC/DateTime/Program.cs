using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace DateTimeC
{
    class Program
    {
        static void Main(string[] args)
        {
            //DateTime d1 = DateTime.Now;
            DateTime d1 = new DateTime(2018,11,25);
            DateTime d2 = new DateTime(2018, 12, 12, 23, 52, 3);
            DateTime d3 = new DateTime(2018, 12, 12, 23, 52, 00,500);

            Console.WriteLine(d3.Day);
            Console.WriteLine(d3.Year);
            Console.WriteLine(d3.ToLongDateString());
            //CONVERTENDO PARA STRING

            DateTime d4 = DateTime.Now;
            DateTime d5 = DateTime.Today;
            DateTime d6 = DateTime.UtcNow;

            DateTime d7 = DateTime.Parse("2000-08-15");
            DateTime d8 = DateTime.Parse("15/08/2000");

            DateTime d9 = DateTime.ParseExact("2000-08-15","yyyy-MM-dd",CultureInfo.InvariantCulture);

            Console.WriteLine(d9);
         

            Console.ReadKey();
        }
    }
}

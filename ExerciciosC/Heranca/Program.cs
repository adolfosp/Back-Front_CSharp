using Heranca.Entities;
using System;

namespace Heranca
{
    class Program
    {
        static void Main(string[] args)
        {

            Account acc = new Account(1001, "Alex", 0.0);
            BusinessAccount bacc = new BusinessAccount(1002, "Maria,", 0.00, 500);

            //UPCASTING
            Account acc1 = bacc;
            Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 200.0);
            Account acc3 = new SavingsAccount(1004, "Ana", 0.0, 0.1);


            //DOWNCASTING


            BusinessAccount acc4 = (BusinessAccount)acc2;
            //BusinessAccount acc5 = (BusinessAccount)acc3;

            //acc3 for uma instância de businessAccount
            if(acc3 is BusinessAccount)
            {
                BusinessAccount acc5 = (BusinessAccount)acc3;
                                        //acc3 as BusinessAccount
            }
        }
    }
}
